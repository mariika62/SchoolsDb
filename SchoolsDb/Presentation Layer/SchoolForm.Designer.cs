namespace Presentation_Layer
{
    partial class SchoolForm
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
            nameTxtBox = new TextBox();
            createBtn = new Button();
            label1 = new Label();
            adrressTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            typeTxtBox = new TextBox();
            studentsBox = new ListBox();
            label4 = new Label();
            classesBox = new ListBox();
            label5 = new Label();
            schoolGridView = new DataGridView();
            label6 = new Label();
            updateBtn = new Button();
            deleteBtn = new Button();
            ClearBtn = new Button();
            CloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)schoolGridView).BeginInit();
            SuspendLayout();
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(27, 55);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(125, 27);
            nameTxtBox.TabIndex = 0;
            nameTxtBox.TextChanged += nameTxtBox_TextChanged;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(486, 259);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(94, 29);
            createBtn.TabIndex = 1;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // adrressTxtBox
            // 
            adrressTxtBox.Location = new Point(226, 55);
            adrressTxtBox.Name = "adrressTxtBox";
            adrressTxtBox.Size = new Size(125, 27);
            adrressTxtBox.TabIndex = 3;
            adrressTxtBox.TextChanged += adrressTxtBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 20);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 20);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Type";
            // 
            // typeTxtBox
            // 
            typeTxtBox.Location = new Point(412, 55);
            typeTxtBox.Name = "typeTxtBox";
            typeTxtBox.Size = new Size(125, 27);
            typeTxtBox.TabIndex = 6;
            typeTxtBox.TextChanged += typeTxtBox_TextChanged;
            // 
            // studentsBox
            // 
            studentsBox.FormattingEnabled = true;
            studentsBox.ItemHeight = 20;
            studentsBox.Location = new Point(603, 55);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(150, 104);
            studentsBox.TabIndex = 7;
            studentsBox.SelectedIndexChanged += studentsBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(648, 20);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "Students";
            // 
            // classesBox
            // 
            classesBox.FormattingEnabled = true;
            classesBox.ItemHeight = 20;
            classesBox.Location = new Point(412, 139);
            classesBox.Name = "classesBox";
            classesBox.Size = new Size(150, 104);
            classesBox.TabIndex = 9;
            classesBox.SelectedIndexChanged += classesBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 106);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 10;
            label5.Text = "Classes";
            // 
            // schoolGridView
            // 
            schoolGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schoolGridView.Location = new Point(20, 201);
            schoolGridView.Name = "schoolGridView";
            schoolGridView.RowHeadersWidth = 51;
            schoolGridView.RowTemplate.Height = 29;
            schoolGridView.Size = new Size(300, 188);
            schoolGridView.TabIndex = 11;
            schoolGridView.CellContentClick += schoolGridView_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 161);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Schools";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(620, 259);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(551, 311);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(486, 360);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(94, 29);
            ClearBtn.TabIndex = 15;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(620, 360);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(94, 29);
            CloseBtn.TabIndex = 16;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SchoolForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseBtn);
            Controls.Add(ClearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(label6);
            Controls.Add(schoolGridView);
            Controls.Add(label5);
            Controls.Add(classesBox);
            Controls.Add(label4);
            Controls.Add(studentsBox);
            Controls.Add(typeTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(adrressTxtBox);
            Controls.Add(label1);
            Controls.Add(createBtn);
            Controls.Add(nameTxtBox);
            Name = "SchoolForm";
            Text = "SchoolForm";
            ((System.ComponentModel.ISupportInitialize)schoolGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTxtBox;
        private Button createBtn;
        private Label label1;
        private TextBox adrressTxtBox;
        private Label label2;
        private Label label3;
        private TextBox typeTxtBox;
        private ListBox studentsBox;
        private Label label4;
        private ListBox classesBox;
        private Label label5;
        private DataGridView schoolGridView;
        private Label label6;
        private Button updateBtn;
        private Button deleteBtn;
        private Button ClearBtn;
        private Button CloseBtn;
    }
}