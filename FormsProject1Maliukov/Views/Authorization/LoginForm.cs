namespace FormsProject1MaliukovCvetkovic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TextBoxesCheck()
        {
            buttonLogIn.Enabled = !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text);
        }
        private void CleanData()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            buttonLogIn.Enabled = false;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            CleanData();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            GoToSignUp();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }

        // Actual login logic
        private void PerformLogin()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (Classes.DataBase.Authenticate(username, password))
            {
                Views.TasksForm tasksForm = new Views.TasksForm();
                tasksForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
            }
        }

        private void GoToSignUp()
        {
            Views.Authorization.NewUserForm regForm = new Views.Authorization.NewUserForm();
            regForm.Show();
            this.Hide();
        }
    }
}
