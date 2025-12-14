using FormsProject1MaliukovCvetkovic.Classes;
using System.Data;
using System.Linq;

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

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Default");
            comboBox1.Items.Add("Date (Oldest first)");
            comboBox1.Items.Add("Date (Newest first)");
            comboBox1.Items.Add("Title (A-Z)");
            comboBox1.SelectedIndex = 0;

            RefreshTaskLists();
        }

        private void RefreshTaskLists()
        {
            // --- ЛОГИКА ОТОБРАЖЕНИЯ ИМЕН ---

            // 1. Собираем всех пользователей (обычных + админа) в один список для поиска имен
            List<User> allUsers = DataBase.simples.Cast<User>().ToList();
            if (DataBase.admin != null) allUsers.Add(DataBase.admin);

            // 2. Объединяем Задачи с Юзерами, чтобы получить Имена
            var query = DataBase.tasks.Join(allUsers,
                task => task.owner_ID,    // ID из задачи
                user => user.Id,          // ID юзера
                (task, user) => new TaskDisplay(task, user.Name) // Создаем красивый объект
            ).AsEnumerable();

            // 3. Фильтрация
            string searchText = textBox1.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(t => t.Title.ToLower().Contains(searchText)
                                      || t.Description.ToLower().Contains(searchText)
                                      || t.OwnerName.ToLower().Contains(searchText));
            }

            // 4. Сортировка
            switch (comboBox1.SelectedIndex)
            {
                case 1: query = query.OrderBy(t => t.DueDate); break;
                case 2: query = query.OrderByDescending(t => t.DueDate); break;
                case 3: query = query.OrderBy(t => t.Title); break;
            }

            var resultList = query.ToList();

            // 5. Разделяем на "Мои" и "Все"
            var myTasks = resultList.Where(t => t.owner_ID == DataBase.CurrentUser?.Id).ToList();

            BindGrid(dataGridView1, myTasks);
            BindGrid(dataGridView2, resultList);
        }

        private void BindGrid(DataGridView dgv, List<TaskDisplay> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data;

            // Прячем ID, показываем Имя
            if (dgv.Columns["owner_ID"] != null) dgv.Columns["owner_ID"].Visible = false;
            if (dgv.Columns["OwnerName"] != null)
            {
                dgv.Columns["OwnerName"].HeaderText = "Author";
                dgv.Columns["OwnerName"].DisplayIndex = 0; // Ставим имя первым
            }
        }

        // --- ЛОГИКА ДОБАВЛЕНИЯ И УДАЛЕНИЯ ---

        private void AddNewTask(string title, string desc, DateTime date)
        {
            if (DataBase.CurrentUser == null || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введите название задачи!");
                return;
            }

            // Создаем задачу
            Classes.Task newTask = new Classes.Task(title, desc, date, DataBase.CurrentUser.Id);
            DataBase.tasks.Add(newTask);
            DataBase.SaveTasks();

            textBoxTaskName.Text = "";
            textBoxTaskDesc.Text = "";
            RefreshTaskLists();
            MessageBox.Show("Task added successfully!");
        }

        private void DeleteSelectedTask(string taskId)
        {
            // Ищем задачу по ID владельца и параметрам (или лучше добавить ID самой задаче в будущем)
            // Но пока удаляем по ссылке на объект из списка
            var taskToDelete = DataBase.tasks.FirstOrDefault(t => t.owner_ID == taskId);
            // Это упрощение. В идеале у Task должен быть свой уникальный TaskId.
            // Но используем логику удаления через TaskDisplay
        }

        // Правильный метод удаления через интерфейс
        private void TryDeleteFromGrid(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0) return;

            // Получаем красивый объект из строки
            TaskDisplay displayItem = (TaskDisplay)dgv.SelectedRows[0].DataBoundItem;

            // Находим ОРИГИНАЛЬНУЮ задачу в базе данных
            // (Сравниваем всё, так как у задачи нет уникального ID, это слабое место, но пока сойдет)
            var originalTask = DataBase.tasks.FirstOrDefault(t =>
                t.owner_ID == displayItem.owner_ID &&
                t.Title == displayItem.Title &&
                t.DueDate == displayItem.DueDate);

            if (originalTask == null) return;

            // Проверка прав
            bool isAdmin = DataBase.CurrentUser is AdminUser;
            bool isOwner = originalTask.owner_ID == DataBase.CurrentUser?.Id;

            if (isAdmin || isOwner)
            {
                if (MessageBox.Show("Delete task?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataBase.tasks.Remove(originalTask);
                    DataBase.SaveTasks();
                    RefreshTaskLists();
                }
            }
            else
            {
                MessageBox.Show("You can only delete your own tasks.");
            }
        }

        // --- СОБЫТИЯ ---

        private void buttonTask_Click(object sender, EventArgs e)
        {
            AddNewTask(textBoxTaskName.Text, textBoxTaskDesc.Text, dateTimePicker1.Value);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, какая таблица активна
            if (dataGridView1.Focused || dataGridView1.SelectedRows.Count > 0)
                TryDeleteFromGrid(dataGridView1);
            else if (dataGridView2.Focused || dataGridView2.SelectedRows.Count > 0)
                TryDeleteFromGrid(dataGridView2);
            else
                MessageBox.Show("Select a row to delete.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => RefreshTaskLists();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => RefreshTaskLists();

        private void buttonUserList_Click(object sender, EventArgs e) => OpenUserManagement();

        private void buttonLogOut_Click(object sender, EventArgs e) => PerformLogout();

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm();
            profileForm.ShowDialog();

            if (DataBase.CurrentUser == null) PerformLogout();
            else labelWelcome.Text = $"Hello, {DataBase.CurrentUser.Name}";
        }

        private void PerformLogout()
        {
            DataBase.CurrentUser = null;
            new LoginForm().Show();
            Close();
        }

        private void OpenUserManagement()
        {
            if (DataBase.CurrentUser is AdminUser) new Views.Admin.UserManagement().Show();
            else MessageBox.Show("Admin only.");
        }

        // Пустые методы, чтобы дизайнер не ругался
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void buttonUpdate_Click(object sender, EventArgs e) 
        {
            RefreshTaskLists();
        }
        private void textBoxTaskName_TextChanged(object sender, EventArgs e) { }
        private void textBoxTaskDesc_TextChanged(object sender, EventArgs e) { }
    }

    // --- ВСПОМОГАТЕЛЬНЫЙ КЛАСС ДЛЯ ОТОБРАЖЕНИЯ (Вставь его в конец файла TasksForm.cs) ---
    public class TaskDisplay
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string OwnerName { get; set; } // ИМЯ!
        public string owner_ID { get; set; }  // Скрытый ID для логики

        public TaskDisplay(Classes.Task task, string ownerName)
        {
            Title = task.Title;
            Description = task.Description;
            DueDate = task.DueDate;
            IsCompleted = task.IsCompleted;
            owner_ID = task.owner_ID;
            OwnerName = ownerName;
        }
    }
}