namespace FormsProject1MaliukovCvetkovic.Views.Authorization
{
    partial class NewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonToLogIn = new Button();
            buttonSignUp = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14F);
            textBox2.Location = new Point(108, 164);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Username";
            textBox2.Size = new Size(200, 29);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14F);
            textBox1.Location = new Point(108, 116);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(200, 29);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonToLogIn
            // 
            buttonToLogIn.Location = new Point(333, 35);
            buttonToLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonToLogIn.Name = "buttonToLogIn";
            buttonToLogIn.Size = new Size(82, 22);
            buttonToLogIn.TabIndex = 7;
            buttonToLogIn.Text = "Log In";
            buttonToLogIn.UseVisualStyleBackColor = true;
            buttonToLogIn.Click += buttonNewUser_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(123, 293);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(172, 50);
            buttonSignUp.TabIndex = 6;
            buttonSignUp.Text = "Create profile";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 52);
            label1.Name = "label1";
            label1.Size = new Size(104, 26);
            label1.TabIndex = 5;
            label1.Text = "Team-Do";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 14F);
            textBox3.Location = new Point(108, 219);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Password";
            textBox3.Size = new Size(200, 29);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 439);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonToLogIn);
            Controls.Add(buttonSignUp);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewUserForm";
            Text = "NewUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonToLogIn;
        private Button buttonSignUp;
        private Label label1;
        private TextBox textBox3;
    }
}