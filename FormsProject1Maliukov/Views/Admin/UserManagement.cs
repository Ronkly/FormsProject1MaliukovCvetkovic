using FormsProject1MaliukovCvetkovic.Classes;

namespace FormsProject1MaliukovCvetkovic.Views.Admin
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new()
            {
                Name = "IDColumn",
                HeaderText = "ID",
                Visible = false
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

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;

            DataGridViewRefresh();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
        }

        private void DataGridViewRefresh()
        {
            dataGridView1.Rows.Clear();
            foreach (Classes.SimpleUser user in Classes.DataBase.simples.Where(u => u != Classes.DataBase.CurrentUser))
            {
                _ = dataGridView1.Rows.Add(user.Id, user.Username, user.Password);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DischargeColumn"].Index && e.RowIndex >= 0)
            {
                PerformUserDischarge(e.RowIndex);
            }
        }

        private void PerformUserDischarge(int rowIndex)
        {
            string idToDischarge = dataGridView1.Rows[rowIndex].Cells["IDColumn"].Value.ToString();
            string usernameToDischarge = dataGridView1.Rows[rowIndex].Cells["NameColumn"].Value.ToString();

            int tasksCount = DataBase.tasks.Count(t => t.owner_ID == idToDischarge);

            if (MessageBox.Show($"Are you sure you want to delete all the data about {usernameToDischarge}, including their {tasksCount} tasks?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _ = DataBase.tasks.RemoveAll(t => t.owner_ID == idToDischarge);
                DataBase.SaveTasks();

                SimpleUser? userToRemove = DataBase.simples.FirstOrDefault(u => u.Username == usernameToDischarge);
                if (userToRemove != null)
                {
                    _ = DataBase.simples.Remove(userToRemove);
                    DataBase.SaveUsers();
                }

                DataGridViewRefresh();
                _ = MessageBox.Show($"User {usernameToDischarge} has been fired.");
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (sender is DataGridView dgv && dgv.IsCurrentCellDirty)
            {
                _ = dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            object? idObj = row.Cells["IDColumn"].Value;
            if (idObj == null)
            {
                return;
            }

            string id = idObj.ToString() ?? string.Empty;
            SimpleUser? user = DataBase.simples.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return;
            }

            DataGridViewColumn? col = dataGridView1.Columns[e.ColumnIndex];
            if (col == null)
            {
                return;
            }

            if (col.Name == "NameColumn")
            {
                string newName = row.Cells["NameColumn"].Value?.ToString() ?? string.Empty;
                if (user.Username != newName)
                {
                    user.Username = newName;
                    DataBase.SaveUsers();
                }
            }
            else if (col.Name == "PasswordColumn")
            {
                string newPass = row.Cells["PasswordColumn"].Value?.ToString() ?? string.Empty;
                if (user.Password != newPass)
                {
                    user.Password = newPass;
                    DataBase.SaveUsers();
                }
            }
        }
    }
}
