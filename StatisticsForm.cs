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
            // TODO: This line of code loads data into the 'studentManageDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.studentManageDataSet.Classes);
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.StudentManageConnectionString))
            {
                con.Open();
                try
                {
                    using(SqlCommand command = new SqlCommand("SELECT * FROM Classes JOIN Students ON Students.ClassID = Classes.ClassID", con))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi kết nối database", "Thông báo");
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManageDataSet);

        }
    }
}
