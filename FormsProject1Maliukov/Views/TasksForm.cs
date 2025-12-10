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
            labelWelcome.Text = $"Hello, {Classes.DataBase.CurrentUser.Name}";

            RefreshTaskLists();
        }

        private void RefreshTaskLists()
        {
            List<Classes.Task> myTasks = Classes.DataBase.tasks.Where(t => t.owner_ID == Classes.DataBase.CurrentUser.Id).ToList();
            List<Classes.Task> allTasks = Classes.DataBase.tasks.ToList();
        }
        private void AddNewTask(string title, string desc, DateTime date)
        {
            if (Classes.DataBase.CurrentUser == null)
            {
                return;
            }

            Classes.Task newTask = new(title, desc, date, Classes.DataBase.CurrentUser.Id);
            Classes.DataBase.tasks.Add(newTask);
            Classes.DataBase.SaveTasks();

            RefreshTaskLists();
        }
        private void DeleteSelectedTask(Classes.Task taskToDelete)
        {
            bool isAdmin = Classes.DataBase.CurrentUser is Classes.AdminUser;
            bool isOwner = taskToDelete.owner_ID == Classes.DataBase.CurrentUser.Id;

            if (isAdmin || isOwner)
            {
                _ = Classes.DataBase.tasks.Remove(taskToDelete);
                Classes.DataBase.SaveTasks();
                RefreshTaskLists();
                _ = MessageBox.Show("Task deleted.");
            }
            else
            {
                _ = MessageBox.Show("You cannot delete someone else's task.");
            }
        }
        {
            Classes.DataBase.CurrentUser = null;
            LoginForm login = new();
            login.Show();
            Close();
        }
        private void OpenUserManagement()
        {
            if (Classes.DataBase.CurrentUser is Classes.AdminUser)
            {
                Views.Admin.UserManagement adminForm = new();
                adminForm.Show();
            }
            else
            {
                _ = MessageBox.Show("This feature is only available to the Administrator.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            AddNewTask(textBoxTaskName.Text, textBoxTaskDesc.Text, dateTimePicker1.Value);
        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTaskDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
