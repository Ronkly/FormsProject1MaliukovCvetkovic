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

        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBoxesCheck();
        }
    }
}
