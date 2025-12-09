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
            // I'll set the welcome label text here
            labelWelcome.Text = $"Hello, {Classes.DataBase.CurrentUser.Name}";

            RefreshTaskLists();

            // I'll populate the ComboBox with authors for filtering here
        }

        // I'll call this after adding/deleting a task or on the Refresh button click
        private void RefreshTaskLists()
        {
            // 1. Personal tasks (owner_ID == CurrentUser.Id)
            List<Classes.Task> myTasks = Classes.DataBase.tasks.Where(t => t.owner_ID == Classes.DataBase.CurrentUser.Id).ToList();
            // I'll bind the data to dataGridViewMyTasks here

            // 2. All company tasks (filtered/sorted as needed)
            List<Classes.Task> allTasks = Classes.DataBase.tasks.ToList();
            // I'll bind the data to dataGridViewAllTasks here
        }

        // I'll call this when the "Create Task" button is confirmed
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

        // I'll call this from the DataGridView CellContentClick event when the Delete button is pressed
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

        // I'll call this from the Log Out button
        private void PerformLogout()
        {
            Classes.DataBase.CurrentUser = null;
            LoginForm login = new();
            login.Show();
            Close();
        }

        // I'll call this from the "View All Workers" button
        private void OpenUserManagement()
        {
            if (Classes.DataBase.CurrentUser is Classes.AdminUser)
            {
                Views.Admin.UserManagement adminForm = new();
                adminForm.Show();
                // I might need to manage form visibility here
            }
            else
            {
                _ = MessageBox.Show("This feature is only available to the Administrator.");
            }
        }

        // Search box for tasks
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Grid for all tasks
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Grid for my tasks
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Here I need to add the choice of the sorting (alphabetical, date)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Button for opening the list of all users (everyone can open it, just admins can manage it)
        private void buttonUserList_Click(object sender, EventArgs e)
        {
            OpenUserManagement();
        }

        // Log out button
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            PerformLogout();
        }

        // Profile button
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
