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

        private void LoadProfileData()
        {
            
        }

        private void SaveChanges(string name, string username, string pass)
        {
DataBase.CurrentUser.UpdateProfile(name, username, pass);

                if (DataBase.CurrentUser is SimpleUser)
                {
                    DataBase.SaveUsers();
}
                _ = MessageBox.Show("Profile data updated.");
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
    }
}