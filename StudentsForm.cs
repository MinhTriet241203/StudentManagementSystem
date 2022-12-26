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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManageDataSet);
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentManageDataSet.Students);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) { return; }
            studentsBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("Lưu thay đổi thành công", "Thông báo");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận xóa học sinh?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { return; }
            bindingNavigatorDeleteItem.PerformClick();
            MessageBox.Show("Xóa học sinh thành công", "Thông báo");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
