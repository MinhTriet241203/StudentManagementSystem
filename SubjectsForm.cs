using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void SubjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
