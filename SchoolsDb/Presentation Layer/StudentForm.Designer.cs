﻿






namespace Presentation_Layer
{
    partial class StudentForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.schoolLB = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.classLB = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ageNUAD = new System.Windows.Forms.NumericUpDown();
            this.avgNUAD = new System.Windows.Forms.NumericUpDown();
            this.nicNUAD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(198, 432);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(42, 432);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 29);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(339, 432);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(625, 432);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(775, 432);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(94, 29);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(629, 182);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RowHeadersWidth = 51;
            this.studentsDataGridView.RowTemplate.Height = 29;
            this.studentsDataGridView.Size = new System.Drawing.Size(300, 188);
            this.studentsDataGridView.TabIndex = 5;
            this.studentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellClick);
            this.studentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Students";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(42, 65);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(207, 27);
            this.nameTxtBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Avarage Grade";
            // 
            // phTxtBox
            // 
            this.phTxtBox.Location = new System.Drawing.Point(336, 138);
            this.phTxtBox.Name = "phTxtBox";
            this.phTxtBox.Size = new System.Drawing.Size(207, 27);
            this.phTxtBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number in class";
            // 
            // schoolLB
            // 
            this.schoolLB.FormattingEnabled = true;
            this.schoolLB.ItemHeight = 20;
            this.schoolLB.Location = new System.Drawing.Point(37, 242);
            this.schoolLB.Name = "schoolLB";
            this.schoolLB.Size = new System.Drawing.Size(212, 164);
            this.schoolLB.TabIndex = 17;
            this.schoolLB.SelectedIndexChanged += new System.EventHandler(this.schoolLB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "School";
            // 
            // classLB
            // 
            this.classLB.FormattingEnabled = true;
            this.classLB.ItemHeight = 20;
            this.classLB.Location = new System.Drawing.Point(336, 242);
            this.classLB.Name = "classLB";
            this.classLB.Size = new System.Drawing.Size(207, 164);
            this.classLB.TabIndex = 19;
            this.classLB.SelectedIndexChanged += new System.EventHandler(this.classLB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Class";
            // 
            // ageNUAD
            // 
            this.ageNUAD.Location = new System.Drawing.Point(42, 140);
            this.ageNUAD.Name = "ageNUAD";
            this.ageNUAD.Size = new System.Drawing.Size(207, 27);
            this.ageNUAD.TabIndex = 21;
            // 
            // avgNUAD
            // 
            this.avgNUAD.Location = new System.Drawing.Point(336, 66);
            this.avgNUAD.Name = "avgNUAD";
            this.avgNUAD.Size = new System.Drawing.Size(207, 27);
            this.avgNUAD.TabIndex = 22;
            // 
            // nicNUAD
            // 
            this.nicNUAD.Location = new System.Drawing.Point(625, 65);
            this.nicNUAD.Name = "nicNUAD";
            this.nicNUAD.Size = new System.Drawing.Size(207, 27);
            this.nicNUAD.TabIndex = 23;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 512);
            this.Controls.Add(this.nicNUAD);
            this.Controls.Add(this.avgNUAD);
            this.Controls.Add(this.ageNUAD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.classLB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.schoolLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.updateBtn);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateBtn;
        private Button createBtn;
        private Button deleteBtn;
        private Button clearBtn;
        private Button closeBtn;
        private DataGridView studentsDataGridView;
        private Label label1;
        private TextBox nameTxtBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox phTxtBox;
        private Label label5;
        private Label label6;
        private ListBox schoolLB;
        private Label label7;
        private ListBox classLB;
        private Label label8;
        private NumericUpDown ageNUAD;
        private NumericUpDown avgNUAD;
        private NumericUpDown nicNUAD;
    }
}