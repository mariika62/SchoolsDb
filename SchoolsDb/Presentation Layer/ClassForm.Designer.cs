namespace Presentation_Layer
{
    partial class ClassForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.majorLbl = new System.Windows.Forms.Label();
            this.majorTxtBox = new System.Windows.Forms.TextBox();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.teacherTxtBox = new System.Windows.Forms.TextBox();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.schoolLbl = new System.Windows.Forms.Label();
            this.classLbl = new System.Windows.Forms.Label();
            this.classGridView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.gradeNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(40, 19);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 25);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(40, 57);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(228, 31);
            this.nameTxtBox.TabIndex = 1;
            // 
            // majorLbl
            // 
            this.majorLbl.AutoSize = true;
            this.majorLbl.Location = new System.Drawing.Point(325, 19);
            this.majorLbl.Name = "majorLbl";
            this.majorLbl.Size = new System.Drawing.Size(58, 25);
            this.majorLbl.TabIndex = 2;
            this.majorLbl.Text = "Major";
            // 
            // majorTxtBox
            // 
            this.majorTxtBox.Location = new System.Drawing.Point(325, 57);
            this.majorTxtBox.Name = "majorTxtBox";
            this.majorTxtBox.Size = new System.Drawing.Size(228, 31);
            this.majorTxtBox.TabIndex = 3;
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Location = new System.Drawing.Point(40, 116);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(115, 25);
            this.teacherLbl.TabIndex = 4;
            this.teacherLbl.Text = "Class Teacher";
            // 
            // teacherTxtBox
            // 
            this.teacherTxtBox.Location = new System.Drawing.Point(40, 161);
            this.teacherTxtBox.Name = "teacherTxtBox";
            this.teacherTxtBox.Size = new System.Drawing.Size(228, 31);
            this.teacherTxtBox.TabIndex = 5;
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Location = new System.Drawing.Point(325, 116);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(129, 25);
            this.gradeLbl.TabIndex = 6;
            this.gradeLbl.Text = "Average Grade";
            // 
            // schoolLbl
            // 
            this.schoolLbl.AutoSize = true;
            this.schoolLbl.Location = new System.Drawing.Point(607, 9);
            this.schoolLbl.Name = "schoolLbl";
            this.schoolLbl.Size = new System.Drawing.Size(66, 25);
            this.schoolLbl.TabIndex = 8;
            this.schoolLbl.Text = "School";
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.Location = new System.Drawing.Point(40, 230);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(69, 25);
            this.classLbl.TabIndex = 10;
            this.classLbl.Text = "Classes";
            // 
            // classGridView
            // 
            this.classGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGridView.Location = new System.Drawing.Point(40, 267);
            this.classGridView.Name = "classGridView";
            this.classGridView.RowHeadersWidth = 62;
            this.classGridView.RowTemplate.Height = 33;
            this.classGridView.Size = new System.Drawing.Size(505, 263);
            this.classGridView.TabIndex = 11;
            this.classGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classGridView_CellClick);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(591, 324);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(108, 47);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(732, 324);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 47);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(665, 377);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(108, 47);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(591, 430);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(108, 47);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(732, 430);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(108, 47);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(607, 55);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(228, 33);
            this.schoolComboBox.TabIndex = 17;
            // 
            // studentsLbl
            // 
            this.studentsLbl.AutoSize = true;
            this.studentsLbl.Location = new System.Drawing.Point(607, 116);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(81, 25);
            this.studentsLbl.TabIndex = 18;
            this.studentsLbl.Text = "Students";
            // 
            // studentsBox
            // 
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.ItemHeight = 25;
            this.studentsBox.Location = new System.Drawing.Point(607, 161);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(243, 104);
            this.studentsBox.TabIndex = 19;
            this.studentsBox.SelectedIndexChanged += new System.EventHandler(this.studentsBox_SelectedIndexChanged);
            // 
            // gradeNUD
            // 
            this.gradeNUD.Location = new System.Drawing.Point(325, 161);
            this.gradeNUD.Name = "gradeNUD";
            this.gradeNUD.Size = new System.Drawing.Size(228, 31);
            this.gradeNUD.TabIndex = 20;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 613);
            this.Controls.Add(this.gradeNUD);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.studentsLbl);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.classGridView);
            this.Controls.Add(this.classLbl);
            this.Controls.Add(this.schoolLbl);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.teacherTxtBox);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.majorTxtBox);
            this.Controls.Add(this.majorLbl);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLbl);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLbl;
        private TextBox nameTxtBox;
        private Label majorLbl;
        private TextBox majorTxtBox;
        private Label teacherLbl;
        private TextBox teacherTxtBox;
        private Label gradeLbl;
        private Label schoolLbl;
        private Label classLbl;
        private DataGridView classGridView;
        private Button createBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearBtn;
        private Button closeBtn;
        private ComboBox schoolComboBox;
        private Label studentsLbl;
        private ListBox studentsBox;
        private NumericUpDown gradeNUD;
    }
}