using FormsProject1MaliukovCvetkovic.Classes;
using System.Data;

namespace FormsProject1MaliukovCvetkovic.Views
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (DataBase.CurrentUser != null)
                labelWelcome.Text = $"Hello, {DataBase.CurrentUser.Name}";

            // Настройка ComboBox сортировки
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Default");
            comboBox1.Items.Add("Date (Oldest first)");
            comboBox1.Items.Add("Date (Newest first)");
            comboBox1.Items.Add("Title (A-Z)");
            comboBox1.SelectedIndex = 0; // Выбираем Default

            RefreshTaskLists();
        }

        private void RefreshTaskLists()
        {
            // 1. Получаем списки
            var myTasksQuery = DataBase.tasks.Where(t => t.owner_ID == DataBase.CurrentUser?.Id);
            var allTasksQuery = DataBase.tasks.AsEnumerable(); // Берем всех

            // 2. Фильтрация (Поиск по названию - textBox1)
            string searchText = textBox1.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                allTasksQuery = allTasksQuery.Where(t => t.Title.ToLower().Contains(searchText) || t.Description.ToLower().Contains(searchText));
            }

            // 3. Сортировка (comboBox1)
            switch (comboBox1.SelectedIndex)
            {
                case 1: // Date Oldest
                    myTasksQuery = myTasksQuery.OrderBy(t => t.DueDate);
                    allTasksQuery = allTasksQuery.OrderBy(t => t.DueDate);
                    break;
                case 2: // Date Newest
                    myTasksQuery = myTasksQuery.OrderByDescending(t => t.DueDate);
                    allTasksQuery = allTasksQuery.OrderByDescending(t => t.DueDate);
                    break;
                case 3: // Title A-Z
                    myTasksQuery = myTasksQuery.OrderBy(t => t.Title);
                    allTasksQuery = allTasksQuery.OrderBy(t => t.Title);
                    break;
            }

            // 4. Привязка к таблицам
            BindGrid(dataGridView1, myTasksQuery.ToList()); // Личные
            BindGrid(dataGridView2, allTasksQuery.ToList()); // Все
        }

        // Вспомогательный метод для настройки GridView, чтобы было красиво
        private void BindGrid(DataGridView dgv, List<Classes.Task> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data;

            // Скрываем колонку с ID, она пользователю не нужна
            if (dgv.Columns["owner_ID"] != null) dgv.Columns["owner_ID"].Visible = false;
        }

        private void AddNewTask(string title, string desc, DateTime date)
        {
            if (DataBase.CurrentUser == null || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введите название задачи!");
                return;
            }

            Classes.Task newTask = new Classes.Task(title, desc, date, DataBase.CurrentUser.Id);
            DataBase.tasks.Add(newTask);
            DataBase.SaveTasks();

            // Очистка полей
            textBoxTaskName.Text = "";
            textBoxTaskDesc.Text = "";

            RefreshTaskLists();
            MessageBox.Show("Task added successfully!");
        }

        private void DeleteSelectedTask(Classes.Task taskToDelete)
        {
            bool isAdmin = DataBase.CurrentUser is AdminUser;
            bool isOwner = taskToDelete.owner_ID == DataBase.CurrentUser?.Id;

            if (isAdmin || isOwner)
            {
                DataBase.tasks.Remove(taskToDelete);
                DataBase.SaveTasks();
                RefreshTaskLists();
                MessageBox.Show("Task deleted.");
            }
            else
            {
                MessageBox.Show("You cannot delete someone else's task.");
            }
        }

        // --- Обработчики событий ---

        private void buttonTask_Click(object sender, EventArgs e)
        {
            AddNewTask(textBoxTaskName.Text, textBoxTaskDesc.Text, dateTimePicker1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Живой поиск при вводе текста
            RefreshTaskLists();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сортировка при выборе
            RefreshTaskLists();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработка клика по кнопке внутри таблицы (если ты добавил кнопку удаления в саму таблицу)
            // Но пока просто оставляю, чтобы удалять через выделение строки, если нужно.
            // Для удаления можно добавить кнопку "Delete Selected" на форму.
        }

        // Удаление по двойному клику (как опция)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var task = (Classes.Task)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (MessageBox.Show("Delete this task?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteSelectedTask(task);
                }
            }
        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            OpenUserManagement();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            PerformLogout();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm();
            profileForm.ShowDialog(); // ShowDialog блокирует текущее окно, пока профиль не закроют

            // Если профиль удалили, CurrentUser станет null
            if (DataBase.CurrentUser == null)
            {
                PerformLogout();
            }
            else
            {
                // Обновляем приветствие на случай, если имя сменили
                labelWelcome.Text = $"Hello, {DataBase.CurrentUser.Name}";
            }
        }

        // Методы переходов
        private void PerformLogout()
        {
            DataBase.CurrentUser = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void OpenUserManagement()
        {
            if (DataBase.CurrentUser is AdminUser)
            {
                Views.Admin.UserManagement adminForm = new Views.Admin.UserManagement();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("This feature is only available to the Administrator.");
            }
        }

        // Пустые заглушки
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBoxTaskName_TextChanged(object sender, EventArgs e) { }
        private void textBoxTaskDesc_TextChanged(object sender, EventArgs e) { }
    }
}