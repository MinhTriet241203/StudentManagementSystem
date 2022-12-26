using System;
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
            if(result != DialogResult.Yes) { return; }
            try
            {
                //gọi navigator save item và gọi lệnh nhấn vào, thay thế cho nhấn trực tiếp vào nút
                studentsBindingNavigatorSaveItem.PerformClick();
                MessageBox.Show("Lưu thay đổi thành công", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lưu, hãy hoàn tất điền thông tin", "Thông báo");
                return;
            }
            
            MessageBox.Show("Lưu thay đổi thành công", "Thông báo");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận xóa học sinh?", "Thông báo", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) { return; }
            bindingNavigatorDeleteItem.PerformClick();
            MessageBox.Show("Xóa học sinh thành công", "Thông báo");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {

                bindingNavigatorMoveNextItem.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thay đổi lựa chọn lúc này", "Thông báo");
                return;
            }
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
