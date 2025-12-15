namespace FormsProject1MaliukovCvetkovic.Views
{
    partial class TasksForm
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            buttonProfile = new Button();
            buttonLogOut = new Button();
            buttonUserList = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            buttonTask = new Button();
            textBoxTaskName = new TextBox();
            textBoxTaskDesc = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            labelWelcome = new Label();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 90);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 141);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(376, 90);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(262, 141);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // buttonProfile
            // 
            buttonProfile.Location = new Point(40, 26);
            buttonProfile.Margin = new Padding(3, 2, 3, 2);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(82, 48);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "Profile";
            buttonProfile.UseVisualStyleBackColor = true;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(589, 26);
            buttonLogOut.Margin = new Padding(3, 2, 3, 2);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(82, 32);
            buttonLogOut.TabIndex = 3;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonUserList
            // 
            buttonUserList.Location = new Point(128, 26);
            buttonUserList.Margin = new Padding(3, 2, 3, 2);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(82, 48);
            buttonUserList.TabIndex = 4;
            buttonUserList.Text = "User list";
            buttonUserList.UseVisualStyleBackColor = true;
            buttonUserList.Click += buttonUserList_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 63);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(507, 62);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(497, 281);
            buttonTask.Margin = new Padding(3, 2, 3, 2);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(71, 34);
            buttonTask.TabIndex = 8;
            buttonTask.Text = "New task";
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTask_Click;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(46, 288);
            textBoxTaskName.Margin = new Padding(3, 2, 3, 2);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.PlaceholderText = "Name";
            textBoxTaskName.Size = new Size(110, 23);
            textBoxTaskName.TabIndex = 9;
            textBoxTaskName.TextChanged += textBoxTaskName_TextChanged;
            // 
            // textBoxTaskDesc
            // 
            textBoxTaskDesc.Location = new Point(162, 288);
            textBoxTaskDesc.Margin = new Padding(3, 2, 3, 2);
            textBoxTaskDesc.Name = "textBoxTaskDesc";
            textBoxTaskDesc.PlaceholderText = "Description";
            textBoxTaskDesc.Size = new Size(154, 23);
            textBoxTaskDesc.TabIndex = 10;
            textBoxTaskDesc.TextChanged += textBoxTaskDesc_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(322, 288);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(169, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(135, 236);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(574, 281);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(64, 34);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.ButtonHighlight;
            labelWelcome.Location = new Point(258, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(40, 26);
            labelWelcome.TabIndex = 7;
            labelWelcome.Text = "Hi!";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(228, 51);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 14;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxTaskDesc);
            Controls.Add(textBoxTaskName);
            Controls.Add(buttonTask);
            Controls.Add(labelWelcome);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(buttonUserList);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonProfile);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TasksForm";
            Text = "TasksForm";
            FormClosed += TasksForm_FormClosed;
            Load += TasksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button buttonProfile;
        private Button buttonLogOut;
        private Button buttonUserList;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button buttonTask;
        private TextBox textBoxTaskName;
        private TextBox textBoxTaskDesc;
        private DateTimePicker dateTimePicker1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label labelWelcome;
        private Button buttonRefresh;
    }
}