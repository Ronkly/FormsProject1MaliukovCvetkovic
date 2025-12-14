using FormsProject1MaliukovCvetkovic.Classes;

namespace FormsProject1MaliukovCvetkovic.Views
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
            LoadProfileData();
        }
        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadProfileData()
        {
            textBoxName.Text = DataBase.CurrentUser.Name;
            textBoxLogin.Text = DataBase.CurrentUser.Username;
            textBoxName.Text = DataBase.CurrentUser.Name;
        }

        private void SaveChanges(string name, string username)
        {
            DataBase.CurrentUser.UpdateProfile(name, username);

            if (DataBase.CurrentUser is SimpleUser)
            {
                DataBase.SaveUsers();
            }
            _ = MessageBox.Show("Profile data updated.");
        }

        private bool CheckPassword()
        {
            if (textBoxCurrent.Text != DataBase.CurrentUser.Password)
            {
                _ = MessageBox.Show("Current password is incorrect.");
                return false;
            }
            if (textBoxNewPass.Text.Length < 6)
            {
                _ = MessageBox.Show("New password must be at least 6 characters long.");
                return false;
            }
            return true;
        }

        private void DeleteAccount()
        {
            if (DataBase.CurrentUser is AdminUser)
            {
                _ = MessageBox.Show("The Administrator cannot delete their own account.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete your account and all associated tasks?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ = DataBase.tasks.RemoveAll(t => t.owner_ID == DataBase.CurrentUser.Id);
                DataBase.SaveTasks();

                // Remove the user from the list
                if (DataBase.CurrentUser is SimpleUser simple)
                {
                    _ = DataBase.simples.Remove(simple);
                    DataBase.SaveUsers();
                }

                DataBase.CurrentUser = null;
                _ = MessageBox.Show("Account successfully deleted.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteAccount();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges(textBoxName.Text, textBoxLogin.Text);
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                DataBase.CurrentUser.UpdatePassword(textBoxNewPass.Text);
                if (DataBase.CurrentUser is SimpleUser)
                {
                    DataBase.SaveUsers();
                }
                _ = MessageBox.Show("Password successfully changed.");
            }
        }
    }
}