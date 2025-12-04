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
            buttonNewUser = new Button();
            buttonLogIn = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14F);
            textBox2.Location = new Point(78, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 34);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14F);
            textBox1.Location = new Point(78, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 34);
            textBox1.TabIndex = 8;
            // 
            // buttonNewUser
            // 
            buttonNewUser.Location = new Point(306, 12);
            buttonNewUser.Name = "buttonNewUser";
            buttonNewUser.Size = new Size(94, 29);
            buttonNewUser.TabIndex = 7;
            buttonNewUser.Text = "Log In";
            buttonNewUser.UseVisualStyleBackColor = true;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(99, 354);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(197, 66);
            buttonLogIn.TabIndex = 6;
            buttonLogIn.Text = "Create profile";
            buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 64);
            label1.Name = "label1";
            label1.Size = new Size(135, 33);
            label1.TabIndex = 5;
            label1.Text = "Team-Do";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 14F);
            textBox3.Location = new Point(78, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 34);
            textBox3.TabIndex = 10;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonNewUser);
            Controls.Add(buttonLogIn);
            Controls.Add(label1);
            Name = "NewUserForm";
            Text = "NewUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonNewUser;
        private Button buttonLogIn;
        private Label label1;
        private TextBox textBox3;
    }
}