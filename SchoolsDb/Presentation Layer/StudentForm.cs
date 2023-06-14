using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class StudentForm : Form
    {
        private DbManager<Student, string> dbManager = new DbManager<Student, string>(ContextGenerator.GetBrandsContext());
        private Student selectedStudent;

        public StudentForm()
        {
            InitializeComponent();
            LoadBrands();
            brandsDataGridView.ReadOnly = true;
        }

        #region Events


        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(emailTxtBox.Text)
                    && ValidationManager.IsValidString(phoneTxtBox.Text)
                    && selectedStudent != null)
                {
                    selectedStudent.Name = nameTxtBox.Text;
                    selectedStudent.Email = emailTxtBox.Text;
                    selectedStudent.Phone = phoneTxtBox.Text;
                    selectedStudent.Address = addressTxtBox.Text;

                    dbManager.Update(selectedStudent);

                    MessageBox.Show("Student updated successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Choose student from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void createBtn_Click(object sender, EventArgs e)
        {

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudent != null)
                {
                    dbManager.Delete(selectedStudent.Id);
                    MessageBox.Show("Student ☠️ successfully!", "💀", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedStudent = null;
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Choose student from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            selectedStudent = null;
            ClearTextBoxes();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
