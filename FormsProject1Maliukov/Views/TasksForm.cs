using System;
using System.Linq;
using System.Windows.Forms;

namespace FormsProject1MaliukovCvetkovic.Views
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }
        
        // I'll call this in TasksForm_Load
        private void LoadData()
        {
            // I'll set the welcome label text here
            // labelWelcome.Text = $"Hello, {Classes.DataBase.CurrentUser.Name}"; 

            RefreshTaskLists();
            
            // I'll populate the ComboBox with authors for filtering here
        }

        // I'll call this after adding/deleting a task or on the Refresh button click
        private void RefreshTaskLists()
        {
            // 1. Personal tasks (owner_ID == CurrentUser.Id)
            var myTasks = Classes.DataBase.tasks.Where(t => t.owner_ID == Classes.DataBase.CurrentUser.Id).ToList();
            // I'll bind the data to dataGridViewMyTasks here
            
            // 2. All company tasks (filtered/sorted as needed)
            var allTasks = Classes.DataBase.tasks.ToList();
            // I'll bind the data to dataGridViewAllTasks here
        }

        // I'll call this when the "Create Task" button is confirmed
        private void AddNewTask(string title, string desc, DateTime date)
        {
            if (Classes.DataBase.CurrentUser == null) return;

            Classes.Task newTask = new Classes.Task(title, desc, date, Classes.DataBase.CurrentUser.Id);
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
                Classes.DataBase.tasks.Remove(taskToDelete);
                Classes.DataBase.SaveTasks();
                RefreshTaskLists();
                MessageBox.Show("Task deleted.");
            }
            else
            {
                MessageBox.Show("You cannot delete someone else's task.");
            }
        }
        
        // I'll call this from the Log Out button
        private void PerformLogout()
        {
            Classes.DataBase.CurrentUser = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // I'll call this from the "View All Workers" button
        private void OpenUserManagement()
        {
            if (Classes.DataBase.CurrentUser is Classes.AdminUser)
            {
                Views.Admin.UserManagement adminForm = new Views.Admin.UserManagement();
                adminForm.Show();
                // I might need to manage form visibility here
            }
            else
            {
                MessageBox.Show("This feature is only available to the Administrator.");
            }
        }
    }
}
