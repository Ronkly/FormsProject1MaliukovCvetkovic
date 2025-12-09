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
            labelWelcome = new Label();
            buttonTask = new Button();
            textBoxTaskName = new TextBox();
            textBoxTaskDesc = new TextBox();
            dateTimePicker1 = new DateTimePicker();
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
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(430, 120);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // buttonProfile
            // 
            buttonProfile.Location = new Point(46, 35);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(94, 29);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "button1";
            buttonProfile.UseVisualStyleBackColor = true;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(146, 35);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(94, 29);
            buttonLogOut.TabIndex = 3;
            buttonLogOut.Text = "button2";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonUserList
            // 
            buttonUserList.Location = new Point(669, 35);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(94, 29);
            buttonUserList.TabIndex = 4;
            buttonUserList.Text = "button3";
            buttonUserList.UseVisualStyleBackColor = true;
            buttonUserList.Click += buttonUserList_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 84);
            textBox1.Name = "textBox1";
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
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(360, 29);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(50, 20);
            labelWelcome.TabIndex = 7;
            labelWelcome.Text = "label1";
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(636, 379);
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
            textBoxTaskName.Size = new Size(125, 27);
            textBoxTaskName.TabIndex = 9;
            textBoxTaskName.TextChanged += textBoxTaskName_TextChanged;
            // 
            // textBoxTaskDesc
            // 
            textBoxTaskDesc.Location = new Point(222, 383);
            textBoxTaskDesc.Name = "textBoxTaskDesc";
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
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Label labelWelcome;
        private Button buttonTask;
        private TextBox textBoxTaskName;
        private TextBox textBoxTaskDesc;
        private DateTimePicker dateTimePicker1;
    }
}