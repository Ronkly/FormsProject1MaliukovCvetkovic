namespace FormsProject1MaliukovCvetkovic
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonLogIn = new Button();
            buttonNewUser = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(104, 26);
            label1.TabIndex = 0;
            label1.Text = "Team-Do";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(117, 292);
            buttonLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(172, 50);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonNewUser
            // 
            buttonNewUser.Location = new Point(298, 36);
            buttonNewUser.Margin = new Padding(3, 2, 3, 2);
            buttonNewUser.Name = "buttonNewUser";
            buttonNewUser.Size = new Size(82, 22);
            buttonNewUser.TabIndex = 2;
            buttonNewUser.Text = "New user";
            buttonNewUser.UseVisualStyleBackColor = true;
            buttonNewUser.Click += buttonNewUser_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14F);
            textBox1.Location = new Point(99, 125);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(200, 29);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14F);
            textBox2.Location = new Point(99, 186);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(200, 29);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 77);
            label2.Name = "label2";
            label2.Size = new Size(75, 26);
            label2.TabIndex = 5;
            label2.Text = "Log In";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 370);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonNewUser);
            Controls.Add(buttonLogIn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Tasks - Log in";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonLogIn;
        private Button buttonNewUser;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}
