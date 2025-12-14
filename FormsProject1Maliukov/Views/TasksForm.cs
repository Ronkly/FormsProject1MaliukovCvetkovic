using FormsProject1MaliukovCvetkovic.Classes;
using System.Data;

namespace FormsProject1MaliukovCvetkovic.Views
{
    public partial class TasksForm : Form
    {
        private Classes.Task? _selectedTask = null;

        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            LoadData();
            buttonUserList.Enabled = DataBase.CurrentUser is AdminUser;
        }

        private void LoadData()
        {
            if (DataBase.CurrentUser != null)
            {
                labelWelcome.Text = $"Hello, {DataBase.CurrentUser.Name}";
            }

            comboBox1.Items.Clear();
            _ = comboBox1.Items.Add("Default");
            _ = comboBox1.Items.Add("Date (Oldest first)");
            _ = comboBox1.Items.Add("Date (Newest first)");
            _ = comboBox1.Items.Add("Title (A-Z)");
            comboBox1.SelectedIndex = 0;

            RefreshTaskLists();
        }

        private void RefreshTaskLists()
        {
            List<User> allUsers = DataBase.simples.Cast<User>().ToList();
            if (DataBase.admin != null)
            {
                allUsers.Add(DataBase.admin);
            }

            IEnumerable<TaskDisplay> query = DataBase.tasks.Join(allUsers,
                task => task.owner_ID,
                user => user.Id,
                (task, user) => new TaskDisplay(task, user.Name)
            ).AsEnumerable();

            string searchText = textBox1.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(t => t.Title.ToLower().Contains(searchText)
                                      || t.Description.ToLower().Contains(searchText)
                                      || t.OwnerName.ToLower().Contains(searchText));
            }

            switch (comboBox1.SelectedIndex)
            {
                case 1: query = query.OrderBy(t => t.DueDate); break;
                case 2: query = query.OrderByDescending(t => t.DueDate); break;
                case 3: query = query.OrderBy(t => t.Title); break;
            }

            List<TaskDisplay> resultList = query.ToList();
            List<TaskDisplay> myTasks = resultList.Where(t => t.owner_ID == DataBase.CurrentUser?.Id).ToList();

            BindGrid(dataGridView1, myTasks);
            BindGrid(dataGridView2, resultList);
        }

        private void BindGrid(DataGridView dgv, List<TaskDisplay> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data;

            if (dgv.Columns["owner_ID"] != null)
            {
                dgv.Columns["owner_ID"].Visible = false;
            }

            if (dgv.Columns["OwnerName"] != null)
            {
                dgv.Columns["OwnerName"].HeaderText = "Author";
                dgv.Columns["OwnerName"].DisplayIndex = 0;
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is DataGridView dgv && e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
            {
                if (dgv.Rows[e.RowIndex].DataBoundItem is TaskDisplay item && item.IsCompleted)
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.SelectionBackColor = Color.Green;
                }
            }
        }

        // The method below finds the original task in the database by matching owner ID, title, and due date.
        // This is not ideal without a unique task ID, but it's acceptable for this learning project.
        private void HandleCellClick(DataGridView dgv, int rowIndex)
        {
            if (rowIndex < 0)
            {
                return;
            }

            TaskDisplay displayItem = (TaskDisplay)dgv.Rows[rowIndex].DataBoundItem;

            _selectedTask = DataBase.tasks.FirstOrDefault(t =>
                t.owner_ID == displayItem.owner_ID &&
                t.Title == displayItem.Title &&
                t.DueDate == displayItem.DueDate);

            if (_selectedTask != null)
            {
                textBoxTaskName.Text = _selectedTask.Title;
                textBoxTaskDesc.Text = _selectedTask.Description;
                dateTimePicker1.Value = _selectedTask.DueDate;

                bool isOwner = _selectedTask.owner_ID == DataBase.CurrentUser?.Id;
                bool isAdmin = DataBase.CurrentUser is AdminUser;
                buttonUpdate.Enabled = isOwner || isAdmin;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(dataGridView1, e.RowIndex);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(dataGridView2, e.RowIndex);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedTask == null)
            {
                _ = MessageBox.Show("Please select a task from the list first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTaskName.Text))
            {
                _ = MessageBox.Show("Name cannot be empty.");
                return;
            }

            _selectedTask.Title = textBoxTaskName.Text;
            _selectedTask.Description = textBoxTaskDesc.Text;
            _selectedTask.DueDate = dateTimePicker1.Value;

            DataBase.SaveTasks();

            _selectedTask = null;
            textBoxTaskName.Text = "";
            textBoxTaskDesc.Text = "";
            RefreshTaskLists();

            _ = MessageBox.Show("Task updated!");
        }

        private void buttonMarkDone_Click(object sender, EventArgs e)
        {
            if (_selectedTask == null)
            {
                if (dataGridView1.Focused && dataGridView1.SelectedRows.Count > 0)
                {
                    HandleCellClick(dataGridView1, dataGridView1.SelectedRows[0].Index);
                }
                else if (dataGridView2.Focused && dataGridView2.SelectedRows.Count > 0)
                {
                    HandleCellClick(dataGridView2, dataGridView2.SelectedRows[0].Index);
                }
            }

            if (_selectedTask != null)
            {
                _selectedTask.IsCompleted = true;

                DataBase.SaveTasks();
                RefreshTaskLists();
                _selectedTask = null;
            }
            else
            {
                _ = MessageBox.Show("Please select a task to mark as completed.");
            }
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            AddNewTask(textBoxTaskName.Text, textBoxTaskDesc.Text, dateTimePicker1.Value);
        }

        private void AddNewTask(string title, string desc, DateTime date)
        {
            if (DataBase.CurrentUser == null || string.IsNullOrWhiteSpace(title))
            {
                _ = MessageBox.Show("Введите название задачи!");
                return;
            }

            Classes.Task newTask = new(title, desc, date, DataBase.CurrentUser.Id);
            DataBase.tasks.Add(newTask);
            DataBase.SaveTasks();

            textBoxTaskName.Text = "";
            textBoxTaskDesc.Text = "";
            RefreshTaskLists();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Focused || dataGridView1.SelectedRows.Count > 0)
            {
                TryDeleteFromGrid(dataGridView1);
            }
            else if (dataGridView2.Focused || dataGridView2.SelectedRows.Count > 0)
            {
                TryDeleteFromGrid(dataGridView2);
            }
            else
            {
                _ = MessageBox.Show("Select a row to delete.");
            }
        }

        private void TryDeleteFromGrid(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                return;
            }

            TaskDisplay displayItem = (TaskDisplay)dgv.SelectedRows[0].DataBoundItem;
            Classes.Task? originalTask = DataBase.tasks.FirstOrDefault(t =>
                t.owner_ID == displayItem.owner_ID &&
                t.Title == displayItem.Title &&
                t.DueDate == displayItem.DueDate);

            if (originalTask == null)
            {
                return;
            }

            bool isAdmin = DataBase.CurrentUser is AdminUser;
            bool isOwner = originalTask.owner_ID == DataBase.CurrentUser?.Id;

            if (isAdmin || isOwner)
            {
                if (MessageBox.Show("Delete task?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _ = DataBase.tasks.Remove(originalTask);
                    DataBase.SaveTasks();
                    _selectedTask = null;
                    RefreshTaskLists();
                }
            }
            else
            {
                _ = MessageBox.Show("You can only delete your own tasks.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshTaskLists();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTaskLists();
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
            UserProfileForm profileForm = new();
            _ = profileForm.ShowDialog();
            if (DataBase.CurrentUser == null)
            {
                PerformLogout();
            }
            else
            {
                labelWelcome.Text = $"Hello, {DataBase.CurrentUser.Name}";
            }
        }

        private void PerformLogout()
        {
            DataBase.CurrentUser = null;
            new LoginForm().Show();
            Close();
        }

        private void OpenUserManagement()
        {
            if (DataBase.CurrentUser is AdminUser)
            {
                new Views.Admin.UserManagement().Show();
            }
            else
            {
                _ = MessageBox.Show("Admin only.");
            }
        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheckTask();
        }

        private void textBoxTaskDesc_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheckTask();
        }

        private void TextBoxesCheckTask()
        {
            buttonTask.Enabled = !string.IsNullOrEmpty(textBoxTaskName.Text) && !string.IsNullOrEmpty(textBoxTaskDesc.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }

    public class TaskDisplay
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string OwnerName { get; set; }
        public string owner_ID { get; set; }

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