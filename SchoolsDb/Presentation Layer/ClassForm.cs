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
    public partial class ClassForm : Form
    {
        private DbManager<Class, string> dbManager = new DbManager<Class, string>(ContextGenerator.GetClassContext());
        private Class selectedClass;
        private Student selectedStudent;
        private School selectedSchool;
        private DbManager<School, string> schoolManager = new DbManager<School, string>(ContextGenerator.GetSchoolsContext());
        private DbManager<Student, string> studentManager = new DbManager<Student, string>(ContextGenerator.GetStudentsContext());

        public ClassForm()
        {
            InitializeComponent();
            LoadClasses();
            LoadStudents();
            LoadSchools();
            classGridView.ReadOnly = true;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(teacherTxtBox.Text)
                    && ValidationManager.IsValidString(majorTxtBox.Text)
                    && selectedClass != null)
                {
                    string name = nameTxtBox.Text;
                    string teacher = teacherTxtBox.Text;
                    string major = majorTxtBox.Text;
                    double grade = Convert.ToDouble(gradeNUD.Value);
                    School school = schoolComboBox.SelectedItem as School;

                    Class @class = new Class(name, teacher, school, major, grade);
                    dbManager.Create(@class);

                    MessageBox.Show("Class created successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadClasses();

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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(teacherTxtBox.Text)
                    && ValidationManager.IsValidString(majorTxtBox.Text)
                    && selectedClass != null)
                {
                    selectedClass.Name = nameTxtBox.Text;
                    selectedClass.ClassTeacher = teacherTxtBox.Text;
                    selectedClass.Major = majorTxtBox.Text;
                    selectedClass.AverageGrade = Convert.ToDouble(gradeNUD.Value);
                    selectedClass.School = schoolComboBox.SelectedItem as School;
                    selectedClass.SchoolId = selectedClass.School.Id;

                    dbManager.Update(selectedClass);

                    MessageBox.Show("Class updated successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadClasses();
                }
                else
                {
                    MessageBox.Show("Choose class from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedClass != null)
                {
                    dbManager.Delete(selectedClass.Id);
                    MessageBox.Show("Class ☠️ successfully!", "💀", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedClass = null;
                    LoadClasses();
                }
                else
                {
                    MessageBox.Show("Choose class from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            selectedClass = null;
            ClearTextBoxes();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void classGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("🔥");
                return;
            }
            selectedClass = classGridView.Rows[e.RowIndex].DataBoundItem as Class;
            FillTextBoxes();
        }

        private void studentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsBox.SelectedIndex >= 0 && studentsBox.SelectedIndex < studentsBox.Items.Count)
            {
                selectedStudent = studentsBox.Items[studentsBox.SelectedIndex] as Student;
            }
        }
        private void ClearTextBoxes()
        {
            nameTxtBox.Text = string.Empty;
            teacherTxtBox.Text = string.Empty;
            majorLbl.Text = string.Empty;
            gradeNUD.Value = 0;
            schoolComboBox.SelectedIndex = -1;
            studentsBox.SelectedIndex = -1;
        }
        private void FillTextBoxes()
        {
            if (selectedClass != null)
            {
                nameTxtBox.Text = selectedClass.Name;
                teacherTxtBox.Text = selectedClass.ClassTeacher;
                majorLbl.Text = selectedClass.Major;
                gradeNUD.Value = (decimal)selectedClass.AverageGrade;
                schoolComboBox.SelectedItem = selectedClass.School;
                studentsBox.SelectedItem = selectedClass.Students;           
            }
        }
        private void LoadClasses()
        {
            classGridView.DataSource = dbManager.ReadAll();
        }

        public void LoadStudents()
        {
            studentsBox.DataSource = studentManager.ReadAll();
            studentsBox.DisplayMember = "Name";
        }

        public void LoadSchools()
        {
            schoolComboBox.DataSource = schoolManager.ReadAll();
            schoolComboBox.DisplayMember = "Name";
        }
    }
}
