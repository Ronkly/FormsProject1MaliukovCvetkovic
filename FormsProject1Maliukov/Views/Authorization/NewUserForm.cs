namespace FormsProject1MaliukovCvetkovic.Views.Authorization
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }
        private void PerformRegistration(string name, string username, string password)
        {
            if (Classes.DataBase.simples.Any(u => u.Username == username) || Classes.DataBase.admin.Username == username)
            {
                _ = MessageBox.Show("User with this username already exists.");
                return;
            }

            Classes.SimpleUser newUser = new(name, username, password);
            Classes.DataBase.simples.Add(newUser);
            Classes.DataBase.SaveUsers();

            _ = MessageBox.Show("Registration successful! Now log in.");
            LoginForm login = new();
            login.Show();
            Close();
        }
        private void BackToLogin()
        {
            LoginForm login = new();

            login.Show();
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            PerformRegistration(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }
    }
}
