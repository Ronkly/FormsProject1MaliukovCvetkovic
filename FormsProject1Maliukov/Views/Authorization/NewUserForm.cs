using FormsProject1MaliukovCvetkovic.Classes;

namespace FormsProject1MaliukovCvetkovic.Views.Authorization
{
    public partial class NewUserForm : Form
    {
        private bool backToLogin = false;
        public NewUserForm()
        {
            InitializeComponent();
        }
        private void NewUserForm_Load(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }
        private void TextBoxesCheck()
        {
            buttonSignUp.Enabled = !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text);
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            if (Classes.DataBase.simples.Any(u => u.Username == username) || Classes.DataBase.admin.Username == username)
            {
                _ = MessageBox.Show("User with this username already exists.");
                return;
            }
            if (Helper.IsValidPassword(password) == false)
            {
                _ = MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter and one digit.");
                return;
            }

            Classes.SimpleUser newUser = new(name, username, password);
            Classes.DataBase.simples.Add(newUser);
            Classes.DataBase.SaveUsers();

            _ = MessageBox.Show("Registration successful! Now log in.");
            BackToLogin();
        }
        private void BackToLogin()
        {
            LoginForm login = new();
            backToLogin = true;
            login.Show();
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }

        private void NewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!backToLogin)
            {
                Application.Exit();
            }
        }
    }
}
