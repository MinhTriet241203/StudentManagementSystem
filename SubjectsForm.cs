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

        private void subjectsBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManageDataSet);
        }

        private void SubjectsForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.studentManageDataSet.Subjects);

        }
    }
}
