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

        private void HocSinh_Click(object sender, EventArgs e)
        {
            StudentsForm stsForm = new StudentsForm();
            this.Hide();
            stsForm.Show();
        }

        private void LopHoc_Click(object sender, EventArgs e)
        {
            ClassesForm clForm = new ClassesForm();
            this.Hide();
            clForm.Show();
        }

        private void MonHoc_Click(object sender, EventArgs e)
        {
            SubjectsForm sjForm = new SubjectsForm();
            this.Hide();
            sjForm.Show();
        }

        private void DiemSo_Click(object sender, EventArgs e)
        {
            ScoresForm scForm = new ScoresForm();
            this.Hide();
            scForm.Show();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            StatisticsForm stForm = new StatisticsForm();
            this.Hide();
            stForm.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
