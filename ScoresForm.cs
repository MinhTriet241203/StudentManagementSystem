using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ScoresForm : Form
    {
        public ScoresForm()
        {
            InitializeComponent();
        }

        private void ScoresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void ScoresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentManageDataSet.Students);
            // TODO: This line of code loads data into the 'studentManageDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.studentManageDataSet.Subjects);
            // TODO: This line of code loads data into the 'studentManageDataSet.Scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.studentManageDataSet.Scores);
            // TODO: This line of code loads data into the 'studentManageDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.studentManageDataSet.Subjects);
            // TODO: This line of code loads data into the 'studentManageDataSet.Scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.studentManageDataSet.Scores);
            // TODO: This line of code loads data into the 'studentManageDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentManageDataSet.Students);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManageDataSet);

        }

        private void studentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.studentIDComboBox.SelectedIndex != -1)
            studentIDTextBox.Text = this.studentIDComboBox.SelectedItem.ToString();
        }
    }
}
