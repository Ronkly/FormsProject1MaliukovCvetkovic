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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 100);
            label1.Name = "label1";
            label1.Size = new Size(135, 33);
            label1.TabIndex = 0;
            label1.Text = "Team-Do";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(134, 390);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(197, 66);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonNewUser
            // 
            buttonNewUser.Location = new Point(341, 48);
            buttonNewUser.Name = "buttonNewUser";
            buttonNewUser.Size = new Size(94, 29);
            buttonNewUser.TabIndex = 2;
            buttonNewUser.Text = "New user";
            buttonNewUser.UseVisualStyleBackColor = true;
            buttonNewUser.Click += buttonNewUser_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14F);
            textBox1.Location = new Point(113, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14F);
            textBox2.Location = new Point(113, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 34);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 494);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonNewUser);
            Controls.Add(buttonLogIn);
            Controls.Add(label1);
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
    }
}
