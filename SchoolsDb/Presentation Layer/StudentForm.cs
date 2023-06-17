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
        private DbManager<Student, string> dbManager = new DbManager<Student, string>(ContextGenerator.GetStudentsContext());
        private Student selectedStudent;
        private School selectedSchool;
        private Class selectedClass;
        private DbManager<School, string> schoolManager = new DbManager<School, string>(ContextGenerator.GetSchoolsContext());
        private DbManager<Class, string> classManager = new DbManager<Class, string>(ContextGenerator.GetClassContext());

        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadClass();
            LoadSchools();
            studentsDataGridView.ReadOnly = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(phTxtBox.Text)
                    && selectedStudent != null)
                {
                    selectedStudent.Name = nameTxtBox.Text;
                    selectedStudent.AverageGrade = Convert.ToDouble(avgNUAD.Value);
                    selectedStudent.NumberInClass = Convert.ToInt32(nicNUAD.Value);
                    selectedStudent.Age = Convert.ToInt32(ageNUAD.Value);
                    selectedStudent.Telephone = phTxtBox.Text;

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
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(phTxtBox.Text))
                {
                    string name = nameTxtBox.Text;
                    double averageGrade = Convert.ToDouble(avgNUAD.Value);
                    int numberInclass = Convert.ToInt32(nicNUAD.Value);
                    int age = Convert.ToInt32(ageNUAD.Value);
                    string telephone = phTxtBox.Text;
                    School? school = schoolLB.SelectedItem as School;
                    Class? @class= classLB.SelectedItem as Class;

                    //string name, int age, double averageGrade, int numberInClass, School school, Class @class, string telephone = null
                    Student student = new Student(name, age, averageGrade, numberInclass, school, @class);
                    dbManager.Create(student);

                    MessageBox.Show("Student created successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStudents();

                    ClearTextBoxes();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("You have to enter values in the text boxes! 🤨🤨🤨", "☹", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTxtBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("🔥");
                return;
            }
            selectedStudent = studentsDataGridView.Rows[e.RowIndex].DataBoundItem as Student;
            FillTextBoxes();
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
        private void ClearTextBoxes()
        {
            nameTxtBox.Text = string.Empty;
            avgNUAD.Value = 0;
            nicNUAD.Value = 0;
            phTxtBox.Text = string.Empty;
            ageNUAD.Value = 0;
            schoolLB.SelectedIndex = -1;
            classLB.SelectedIndex = -1;
        }

        private void FillTextBoxes()
        {
            if (selectedStudent != null)
            {
                nameTxtBox.Text = selectedStudent.Name;
                ageNUAD.Value = Convert.ToInt32(selectedStudent.Age);
                avgNUAD.Value = (decimal)selectedStudent.AverageGrade;
                phTxtBox.Text = selectedStudent.Telephone;
                nicNUAD.Value = Convert.ToInt32(selectedStudent.NumberInClass);
                schoolLB.SelectedItem = selectedStudent.School;
                classLB.SelectedItem = selectedStudent.Class;
            }
        }

        private void LoadStudents()
        {
            studentsDataGridView.DataSource = dbManager.ReadAll();
        }
        public void LoadSchools()
        {
            schoolLB.DataSource = schoolManager.ReadAll();
            schoolLB.DisplayMember = "Name";
        }
        public void LoadClass()
        {
            classLB.DataSource = classManager.ReadAll();
            classLB.DisplayMember = "Name";
        }

        private void schoolLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (schoolLB.SelectedIndex >= 0 && schoolLB.SelectedIndex < schoolLB.Items.Count)
            {
                selectedSchool = schoolLB.Items[schoolLB.SelectedIndex] as School;
            }
        }

        private void classLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classLB.SelectedIndex >= 0 && classLB.SelectedIndex < classLB.Items.Count)
            {
                selectedClass = classLB.Items[classLB.SelectedIndex] as Class;
            }
        }
    }
}
