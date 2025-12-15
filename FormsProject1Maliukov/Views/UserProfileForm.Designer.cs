namespace FormsProject1MaliukovCvetkovic.Views
{
    partial class UserProfileForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonDelete = new Button();
            textBoxName = new TextBox();
            textBoxLogin = new TextBox();
            textBoxCurrent = new TextBox();
            textBoxNewPass = new TextBox();
            label5 = new Label();
            buttonSaveChanges = new Button();
            buttonChangePass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(400, 47);
            label1.Name = "label1";
            label1.Size = new Size(142, 33);
            label1.TabIndex = 1;
            label1.Text = "Your data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 168);
            label2.Name = "label2";
            label2.Size = new Size(103, 33);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 216);
            label3.Name = "label3";
            label3.Size = new Size(101, 33);
            label3.TabIndex = 3;
            label3.Text = "Login:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(443, 164);
            label4.Name = "label4";
            label4.Size = new Size(265, 33);
            label4.TabIndex = 4;
            label4.Text = "Current password:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(798, 31);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 76);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete account";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.Location = new Point(209, 164);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(182, 39);
            textBoxName.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(209, 212);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(182, 39);
            textBoxLogin.TabIndex = 7;
            // 
            // textBoxCurrent
            // 
            textBoxCurrent.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCurrent.Location = new Point(724, 158);
            textBoxCurrent.Margin = new Padding(3, 4, 3, 4);
            textBoxCurrent.Name = "textBoxCurrent";
            textBoxCurrent.Size = new Size(182, 39);
            textBoxCurrent.TabIndex = 8;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNewPass.Location = new Point(724, 208);
            textBoxNewPass.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(182, 39);
            textBoxNewPass.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(478, 208);
            label5.Name = "label5";
            label5.Size = new Size(223, 33);
            label5.TabIndex = 10;
            label5.Text = "New password:";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(209, 304);
            buttonSaveChanges.Margin = new Padding(3, 4, 3, 4);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(183, 47);
            buttonSaveChanges.TabIndex = 11;
            buttonSaveChanges.Text = "Save";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonChangePass
            // 
            buttonChangePass.Location = new Point(683, 304);
            buttonChangePass.Margin = new Padding(3, 4, 3, 4);
            buttonChangePass.Name = "buttonChangePass";
            buttonChangePass.Size = new Size(183, 47);
            buttonChangePass.TabIndex = 12;
            buttonChangePass.Text = "Save";
            buttonChangePass.UseVisualStyleBackColor = true;
            buttonChangePass.Click += buttonChangePass_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 432);
            Controls.Add(buttonChangePass);
            Controls.Add(buttonSaveChanges);
            Controls.Add(label5);
            Controls.Add(textBoxNewPass);
            Controls.Add(textBoxCurrent);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonDelete;
        private TextBox textBoxName;
        private TextBox textBoxLogin;
        private TextBox textBoxCurrent;
        private TextBox textBoxNewPass;
        private Label label5;
        private Button buttonSaveChanges;
        private Button buttonChangePass;
    }
}