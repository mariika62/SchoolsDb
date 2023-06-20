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
    public partial class SchoolForm : Form
    {
        private DbManager<School, string> dbManager = new DbManager<School, string>(ContextGenerator.GetSchoolsContext());
        private Class selectedClass;
        private Student selectedStudent;
        private School selectedSchool;
        private DbManager<Class, string> classManager = new DbManager<Class, string>(ContextGenerator.GetClassContext());
        private DbManager<Student, string> studentManager = new DbManager<Student, string>(ContextGenerator.GetStudentsContext());
        public SchoolForm()
        {
            InitializeComponent();
            LoadSchools();
            LoadClasses();
            LoadStudents();
            schoolGridView.ReadOnly = true;
        }
        private void createBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(adrressTxtBox.Text)
                    && ValidationManager.IsValidString(typeTxtBox.Text)
                    && selectedSchool != null)
                {
                    string name = nameTxtBox.Text;
                    string address = adrressTxtBox.Text;
                    string type = typeTxtBox.Text;

                    School @school = new School(name, address, type);
                    dbManager.Create(@school);

                    MessageBox.Show("School created successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSchools();

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
                    && ValidationManager.IsValidString(adrressTxtBox.Text)
                    && ValidationManager.IsValidString(typeTxtBox.Text)
                    && selectedSchool != null)
                {
                    selectedSchool.Name = nameTxtBox.Text;
                    selectedSchool.Address = adrressTxtBox.Text;
                    selectedSchool.Type = typeTxtBox.Text;

                    dbManager.Update(selectedSchool);

                    MessageBox.Show("School updated successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadClasses();
                }
                else
                {
                    MessageBox.Show("Choose school from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedSchool != null)
                {
                    dbManager.Delete(selectedSchool.Id);
                    MessageBox.Show("School ☠️ successfully!", "💀", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedSchool = null;
                    LoadClasses();
                }
                else
                {
                    MessageBox.Show("Choose school from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            selectedSchool = null;
            ClearTextBoxes();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adrressTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsBox.SelectedIndex >= 0 && studentsBox.SelectedIndex < studentsBox.Items.Count)
            {
                selectedSchool = studentsBox.Items[studentsBox.SelectedIndex] as School;
            }
        }

        private void classesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classesBox.SelectedIndex >= 0 && classesBox.SelectedIndex < classesBox.Items.Count)
            {
                selectedSchool = classesBox.Items[classesBox.SelectedIndex] as School;
            }
        }

        private void schoolGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("🔥");
                return;
            }
            selectedSchool = schoolGridView.Rows[e.RowIndex].DataBoundItem as School;
            FillTextBoxes();
        }
        private void ClearTextBoxes()
        {
            nameTxtBox.Text = string.Empty;
            adrressTxtBox.Text = string.Empty;
            typeTxtBox.Text = string.Empty;
            studentsBox.SelectedIndex = -1;
            classesBox.SelectedIndex = -1;
        }
        private void FillTextBoxes()
        {
            if (selectedSchool != null)
            {
                nameTxtBox.Text = selectedSchool.Name;
                adrressTxtBox.Text = selectedSchool.Address;
                typeTxtBox.Text = selectedSchool.Type;
                studentsBox.SelectedItem = selectedSchool.Students;
                classesBox.SelectedItem = selectedSchool.Classes;
            }
        }
        private void LoadClasses()
        {
            classesBox.DataSource = classManager.ReadAll();
            classesBox.DisplayMember = "Name";
        }

        public void LoadStudents()
        {
            studentsBox.DataSource = studentManager.ReadAll();
            studentsBox.DisplayMember = "Name";
        }

        public void LoadSchools()
        {
            schoolGridView.DataSource = dbManager.ReadAll();
        }
    }
}
