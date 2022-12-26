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
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            //đưa ra lựa chọn confirm lưu cho người dùng
            var result = MessageBox.Show("Lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            //gọi navigator save item và gọi lệnh nhấn vào, thay thế cho nhấn trực tiếp vào nút
            subjectsBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("Lưu thay đổi thành công", "Thông báo");
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            
            var result = MessageBox.Show("Xoá lựa chọn?", "Thông báo", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            bindingNavigatorDeleteItem.PerformClick();
            MessageBox.Show("Xoá thành công", "Thông báo");
        }

        private void PreviousButton_Click(object sender, System.EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }
    }
}
