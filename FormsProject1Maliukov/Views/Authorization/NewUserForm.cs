using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject1MaliukovCvetkovic.Views.Authorization
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }
// I'll call this from the Register button click event
        private void PerformRegistration(string name, string username, string password)
        {
            // I need to check for unique username
            if (Classes.DataBase.simples.Any(u => u.Username == username) || Classes.DataBase.admin.Username == username)
            {
                MessageBox.Show("User with this username already exists.");
                return;
            }

            Classes.SimpleUser newUser = new Classes.SimpleUser(name, username, password);
            Classes.DataBase.simples.Add(newUser);
            Classes.DataBase.SaveUsers();
            
            MessageBox.Show("Registration successful! Now log in.");
            
            // I'll go back to login
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // I'll call this from the Back to Login button click event
        private void BackToLogin()
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
