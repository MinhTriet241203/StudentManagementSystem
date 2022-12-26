﻿using System;
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
            this.classesTableAdapter.Fill(this.studentManageDataSet.Classes);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận lưu thay đổi", "Thông báo", MessageBoxButtons.YesNo);
            if(result== DialogResult.Yes) { return; }
            classesBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("Đã lưu thay đổi", "Thông báo");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận xóa lớp học", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { return; }
            bindingNavigatorDeleteItem.PerformClick();
            MessageBox.Show("Xóa lớp học thành công", "Thông báo");
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
