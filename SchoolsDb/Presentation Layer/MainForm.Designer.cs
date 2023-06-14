namespace Presentation_Layer
{

    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.schoolBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolBtn
            // 
            this.schoolBtn.Location = new System.Drawing.Point(171, 196);
            this.schoolBtn.Name = "schoolBtn";
            this.schoolBtn.Size = new System.Drawing.Size(94, 29);
            this.schoolBtn.TabIndex = 0;
            this.schoolBtn.Text = "School";
            this.schoolBtn.UseVisualStyleBackColor = true;
            this.schoolBtn.Click += new System.EventHandler(this.schoolBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(346, 196);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(94, 29);
            this.studentBtn.TabIndex = 1;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // ClassBtn
            // 
            this.ClassBtn.Location = new System.Drawing.Point(529, 196);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(94, 29);
            this.ClassBtn.TabIndex = 2;
            this.ClassBtn.Text = "Class";
            this.ClassBtn.UseVisualStyleBackColor = true;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.schoolBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button schoolBtn;
        private Button studentBtn;
        private Button ClassBtn;
    }
}