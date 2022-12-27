using System;
using System.Data.SqlClient;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'studentManageDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.studentManageDataSet.Classes);
            // TODO: This line of code loads data into the 'studentManageDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentManageDataSet.Students);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            studentsDataGridView.Enabled = false;
            DeleteButton.Text = "Huỷ";
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) { return; }
            try
            {
                //gọi navigator save item và gọi lệnh nhấn vào, thay thế cho nhấn trực tiếp vào nút
                studentsBindingNavigatorSaveItem.PerformClick();
                studentsDataGridView.Enabled = true;
                DeleteButton.Text = "Xoá";
                MessageBox.Show("Lưu thay đổi thành công", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lưu, hãy hoàn tất điền thông tin", "Thông báo");
                return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //đưa ra 2 trường hợp huỷ hoặc xoá, nếu người dùng nhấn tạo mới trước đó thì nút xoá đổi thành nút huỷ
            //và thông báo cũng thay đổi tương tự.

            string confirmMessage = "Xác nhận xóa học sinh?";
            string successMessage = "Xóa học sinh thành công";

            if (DeleteButton.Text == "Huỷ")
            {
                confirmMessage = "Xác nhận huỷ tạo mới?";
                successMessage = "Đã huỷ tạo mới";
            }

            var result = MessageBox.Show(confirmMessage, "Thông báo", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return; //huỷ nếu không chọn yes
            bindingNavigatorDeleteItem.PerformClick();
            MessageBox.Show(successMessage, "Thông báo");
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
            try
            {
                bindingNavigatorMovePreviousItem.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thay đổi lựa chọn lúc này", "Thông báo");
                return;
            }

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.classIDTextBox.Text = comboBox1.SelectedValue.ToString();
        }

        private void classIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.comboBox1.SelectedValue = classIDTextBox.Text;
        }
    }
}
