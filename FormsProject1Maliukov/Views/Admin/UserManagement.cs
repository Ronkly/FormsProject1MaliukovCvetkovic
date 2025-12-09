using FormsProject1MaliukovCvetkovic.Classes;
using System.Linq;

namespace FormsProject1MaliukovCvetkovic.Views.Admin
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();

            // I'll make sure to add the ID column here so I can use it for deletion
            DataGridViewTextBoxColumn idColumn = new()
            {
                Name = "IDColumn",
                HeaderText = "ID",
                Visible = false // I don't want to show the ID, but I need it to delete
            };
            _ = dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new()
            {
                Name = "NameColumn",
                HeaderText = "Name"
            };
            _ = dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn passwordColumn = new()
            {
                Name = "PasswordColumn",
                HeaderText = "Password"
            };
            _ = dataGridView1.Columns.Add(passwordColumn);

            DataGridViewButtonColumn dischargeColumn = new()
            {
                Name = "DischargeColumn",
                HeaderText = "Actions",
                Text = "Fire",
                UseColumnTextForButtonValue = true
          
            };
            _ = dataGridView1.Columns.Add(dischargeColumn);

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            
            DataGridViewRefresh(); // I'll load the data immediately
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // I'll do nothing here for now
        }
        private void DataGridViewRefresh()
        {
            dataGridView1.Rows.Clear();
            // I need to skip the current admin from the list
            foreach (Classes.SimpleUser user in Classes.DataBase.simples.Where(u => u != Classes.DataBase.CurrentUser))
            {
                // I need to add ID, Username, and Password
                _ = dataGridView1.Rows.Add(user.Id, user.Username, user.Password);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DischargeColumn"].Index && e.RowIndex >= 0)
            {
                PerformUserDischarge(e.RowIndex); // I'll move the logic to a separate method
            }
        }

        // Logic for firing a user
        private void PerformUserDischarge(int rowIndex)
        {
            // I'll make sure I have the ID and Username from the row cells
            string idToDischarge = dataGridView1.Rows[rowIndex].Cells["IDColumn"].Value.ToString();
            string usernameToDischarge = dataGridView1.Rows[rowIndex].Cells["NameColumn"].Value.ToString();
            
            // I'll find how many tasks this user has
            int tasksCount = DataBase.tasks.Count(t => t.owner_ID == idToDischarge);
            
            // I'll ask for confirmation before deletion
            if (MessageBox.Show($"Are you sure you want to delete all the data about {usernameToDischarge}, including their {tasksCount} tasks?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete user's tasks
                DataBase.tasks.RemoveAll(t => t.owner_ID == idToDischarge);
                DataBase.SaveTasks();

                // Delete the user
                var userToRemove = DataBase.simples.FirstOrDefault(u => u.Username == usernameToDischarge);
                if (userToRemove != null)
                {
                    DataBase.simples.Remove(userToRemove);
                    DataBase.SaveUsers();
                }

                DataGridViewRefresh(); // I need to refresh the table
                MessageBox.Show($"User {usernameToDischarge} has been fired.");
            }
        }
    }
}
