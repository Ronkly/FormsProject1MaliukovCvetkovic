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

        // I'll call this when the form loads to display current user data
        private void LoadProfileData()
        {
            if (DataBase.CurrentUser != null)
            {
                // I'll set the textboxes here
                // textBoxName.Text = DataBase.CurrentUser.Name;
                // textBoxUsername.Text = DataBase.CurrentUser.Username;
                // textBoxPassword.Text = DataBase.CurrentUser.Password; 
            }
        }

        // I'll call this from the Save Changes button
        private void SaveChanges(string name, string username, string pass)
        {
            if (DataBase.CurrentUser != null)
            {
                DataBase.CurrentUser.UpdateProfile(name, username, pass);

                // Only SimpleUsers are saved in the list, Admin is static
                if (DataBase.CurrentUser is SimpleUser)
                {
                    DataBase.SaveUsers();
                }
                _ = MessageBox.Show("Profile data updated.");
            }
        }

        // I'll call this from the Delete Account button
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
                // Remove user's tasks
                _ = DataBase.tasks.RemoveAll(t => t.owner_ID == DataBase.CurrentUser.Id);
                DataBase.SaveTasks();

                // Remove the user from the list
                if (DataBase.CurrentUser is SimpleUser simple)
                {
                    _ = DataBase.simples.Remove(simple);
                    DataBase.SaveUsers();
                }

                // Log out and return to login
                DataBase.CurrentUser = null;
                _ = MessageBox.Show("Account successfully deleted.");

                // I'll open the LoginForm and close the current form/TasksForm here
            }
        }
    }
}