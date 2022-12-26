using System;
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

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            subjectsDataGridView.Enabled = false;
            DeleteButton.Text = "Huỷ";
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            //đưa ra lựa chọn confirm lưu cho người dùng
            var result = MessageBox.Show("Xác nhận lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            try
            {
                //gọi navigator save item và gọi lệnh nhấn vào, thay thế cho nhấn trực tiếp vào nút
                subjectsBindingNavigatorSaveItem.PerformClick();
                this.subjectsDataGridView.Enabled = true;
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

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            //đưa ra 2 trường hợp huỷ hoặc xoá, nếu người dùng nhấn tạo mới trước đó thì nút xoá đổi thành nút huỷ
            //và thông báo cũng thay đổi tương tự

            string confirmMessage = "Xác nhận xoá lựa chọn";
            string successMessage = "Xoá lựa chọn thành công";
            if (DeleteButton.Text == "Huỷ")
            { confirmMessage = "Xác nhận huỷ?"; successMessage = "Đã huỷ tạo mới"; }
            var result = MessageBox.Show(confirmMessage, "Thông báo", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return; //huỷ nếu không chọn yes
            bindingNavigatorDeleteItem.PerformClick();
            MessageBox.Show(successMessage, "Thông báo");

        }

        private void PreviousButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                bindingNavigatorMovePreviousItem.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đổi lựa chọn lúc này");
                return;
            }
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                bindingNavigatorMoveNextItem.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đổi lựa chọn lúc này");
                return;
            }
        }

        private void HomeButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
