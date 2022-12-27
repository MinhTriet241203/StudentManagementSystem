using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet.Scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.studentManageDataSet.Scores);
            // TODO: This line of code loads data into the 'studentManageDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.studentManageDataSet.Classes);

        }
    }
}
