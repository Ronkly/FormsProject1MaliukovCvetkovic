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
                Name = "NameColumn",
                HeaderText = "ID"
            };
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
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }
        private void DataGridViewRefresh()
        {
            dataGridView1.Rows.Clear();
            foreach (Classes.SimpleUser user in Classes.DataBase.simples)
            {
                _ = dataGridView1.Rows.Add(user.Username, user.Password);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DischargeColumn"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                string idToDischarge = dataGridView1.Rows[rowIndex].Cells["IDColumn"].Value.ToString();
                string usernameToDischarge = dataGridView1.Rows[rowIndex].Cells["NameColumn"].Value.ToString();
                int tasksCount = DataBase.tasks.Count(t => t.owner_ID == idToDischarge);

                if (MessageBox.Show($"Are you sure you want to delete all the data about {usernameToDischarge}, including their {tasksCount} tasks?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _ = DataBase.tasks.Remove(DataBase.tasks.Where(t => t.owner_ID == idToDischarge).FirstOrDefault());
                    _ = DataBase.simples.Remove(DataBase.simples.Where(u => u.Username == usernameToDischarge).FirstOrDefault());
                    DataGridViewRefresh();

                    _ = MessageBox.Show($"Пользователь {usernameToDischarge} уволен.");
                }
            }
        }
    }
}
