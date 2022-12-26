using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
        }

        private void ClassesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManageDataSet);

        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(studentManageDataSet.Classes);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DeleteButton.Text = "Huỷ";
            classesDataGridView.Enabled = false;
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //đưa ra lựa chọn confirm lưu cho người dùng
            var result = MessageBox.Show("Xác nhận lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            try
            {
                //gọi navigator save item và gọi lệnh nhấn vào, thay thế cho nhấn trực tiếp vào nút
                classesBindingNavigatorSaveItem.PerformClick();
                this.classesDataGridView.Enabled = true;
                DeleteButton.Text = "Xoá";
                MessageBox.Show("Lưu thay đổi thành công", "Thông báo");
            }
            catch (Exception)
            {
                //bắt lỗi khi người dùng để trống thông tin trước khi lưu
                MessageBox.Show("Không thể lưu, hãy hoàn tất điền thông tin", "Thông báo");
                return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //đưa ra 2 trường hợp huỷ hoặc xoá, nếu người dùng nhấn tạo mới trước đó thì nút xoá đổi thành nút huỷ
            //và thông báo cũng thay đổi tương tự

            string confirmMessage = "Xác nhận xóa lớp học?";
            string successMessage = "Xóa lớp học thành công";

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
    }
}
