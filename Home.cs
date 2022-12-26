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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HocSinh_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            this.Hide();
            studentsForm.Show();
        }

        private void LopHoc_Click(object sender, EventArgs e)
        {
            ClassesForm classesForm = new ClassesForm();
            this.Hide();
            classesForm.Show();
        }

        private void MonHoc_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            this.Hide();
            subjectsForm.Show();
        }

        private void DiemSo_Click(object sender, EventArgs e)
        {
            ScoresForm scoresForm = new ScoresForm();
            this.Hide();
            scoresForm.Show();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            this.Hide();
            statisticsForm.Show();
        }
    }
}
