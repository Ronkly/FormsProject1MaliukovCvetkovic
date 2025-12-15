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
            labelID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 35);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 1;
            label1.Text = "Your data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 126);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(79, 162);
            label3.Name = "label3";
            label3.Size = new Size(76, 26);
            label3.TabIndex = 3;
            label3.Text = "Login:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(388, 123);
            label4.Name = "label4";
            label4.Size = new Size(204, 26);
            label4.TabIndex = 4;
            label4.Text = "Current password:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(698, 23);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(115, 57);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete account";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.Location = new Point(183, 123);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(160, 32);
            textBoxName.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(183, 159);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(160, 32);
            textBoxLogin.TabIndex = 7;
            // 
            // textBoxCurrent
            // 
            textBoxCurrent.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCurrent.Location = new Point(634, 118);
            textBoxCurrent.Name = "textBoxCurrent";
            textBoxCurrent.Size = new Size(160, 32);
            textBoxCurrent.TabIndex = 8;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNewPass.Location = new Point(634, 156);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(160, 32);
            textBoxNewPass.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(418, 156);
            label5.Name = "label5";
            label5.Size = new Size(174, 26);
            label5.TabIndex = 10;
            label5.Text = "New password:";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(183, 228);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(160, 35);
            buttonSaveChanges.TabIndex = 11;
            buttonSaveChanges.Text = "Save";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonChangePass
            // 
            buttonChangePass.Location = new Point(598, 228);
            buttonChangePass.Name = "buttonChangePass";
            buttonChangePass.Size = new Size(160, 35);
            buttonChangePass.TabIndex = 12;
            buttonChangePass.Text = "Save";
            buttonChangePass.UseVisualStyleBackColor = true;
            buttonChangePass.Click += buttonChangePass_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(79, 82);
            labelID.Name = "labelID";
            labelID.Size = new Size(46, 26);
            labelID.TabIndex = 13;
            labelID.Text = "ID: ";
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 324);
            Controls.Add(labelID);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label labelID;
    }
}