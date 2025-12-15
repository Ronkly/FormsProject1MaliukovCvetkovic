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
            buttonMarkDone = new Button();
            labelWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(299, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(430, 120);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(299, 188);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // buttonProfile
            // 
            buttonProfile.Location = new Point(46, 35);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(94, 64);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "Profile";
            buttonProfile.UseVisualStyleBackColor = true;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(673, 35);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(94, 43);
            buttonLogOut.TabIndex = 3;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonUserList
            // 
            buttonUserList.Location = new Point(146, 35);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(94, 64);
            buttonUserList.TabIndex = 4;
            buttonUserList.Text = "User list";
            buttonUserList.UseVisualStyleBackColor = true;
            buttonUserList.Click += buttonUserList_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 84);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(579, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(635, 379);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(94, 29);
            buttonTask.TabIndex = 8;
            buttonTask.Text = "New task";
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTask_Click;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(61, 383);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.PlaceholderText = "Name";
            textBoxTaskName.Size = new Size(125, 27);
            textBoxTaskName.TabIndex = 9;
            textBoxTaskName.TextChanged += textBoxTaskName_TextChanged;
            // 
            // textBoxTaskDesc
            // 
            textBoxTaskDesc.Location = new Point(222, 383);
            textBoxTaskDesc.Name = "textBoxTaskDesc";
            textBoxTaskDesc.PlaceholderText = "Description";
            textBoxTaskDesc.Size = new Size(125, 27);
            textBoxTaskDesc.TabIndex = 10;
            textBoxTaskDesc.TextChanged += textBoxTaskDesc_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(360, 381);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(185, 335);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 31);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(353, 196);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(73, 45);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonMarkDone
            // 
            buttonMarkDone.Location = new Point(295, 331);
            buttonMarkDone.Margin = new Padding(3, 4, 3, 4);
            buttonMarkDone.Name = "buttonMarkDone";
            buttonMarkDone.Size = new Size(86, 31);
            buttonMarkDone.TabIndex = 14;
            buttonMarkDone.Text = "Mark done";
            buttonMarkDone.UseVisualStyleBackColor = true;
            buttonMarkDone.Click += buttonMarkDone_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(266, 47);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(28, 20);
            labelWelcome.TabIndex = 7;
            labelWelcome.Text = "Hi!";
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonMarkDone);
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
            Name = "TasksForm";
            Text = "TasksForm";
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
        private Button buttonMarkDone;
        private Label labelWelcome;
    }
}