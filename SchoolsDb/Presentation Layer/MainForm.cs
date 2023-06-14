using System.Security.Cryptography.Xml;

namespace Presentation_Layer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void schoolBtn_Click(object sender, EventArgs e)
        {
            SchoolForm schoolForm = new SchoolForm();
            schoolForm.ShowDialog();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void ClassBtn_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            classForm.ShowDialog();
        }
    }
}