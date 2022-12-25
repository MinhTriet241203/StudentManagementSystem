namespace StudentManagementSystem
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ThongKe = new System.Windows.Forms.Button();
            this.DiemSo = new System.Windows.Forms.Button();
            this.MonHoc = new System.Windows.Forms.Button();
            this.LopHoc = new System.Windows.Forms.Button();
            this.HocSinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1238, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1238, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ThongKe
            // 
            this.ThongKe.BackColor = System.Drawing.Color.Teal;
            this.ThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ThongKe.FlatAppearance.BorderSize = 0;
            this.ThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKe.Font = new System.Drawing.Font("JetBrains Mono NL", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKe.ForeColor = System.Drawing.Color.Transparent;
            this.ThongKe.Image = global::StudentManagementSystem.Properties.Resources.pie_chart_128;
            this.ThongKe.Location = new System.Drawing.Point(1031, 209);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.ThongKe.Size = new System.Drawing.Size(219, 337);
            this.ThongKe.TabIndex = 2;
            this.ThongKe.Text = "Thống kê";
            this.ThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ThongKe.UseVisualStyleBackColor = false;
            // 
            // DiemSo
            // 
            this.DiemSo.BackColor = System.Drawing.Color.Teal;
            this.DiemSo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DiemSo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DiemSo.FlatAppearance.BorderSize = 0;
            this.DiemSo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.DiemSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiemSo.Font = new System.Drawing.Font("JetBrains Mono NL", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemSo.ForeColor = System.Drawing.Color.Transparent;
            this.DiemSo.Image = global::StudentManagementSystem.Properties.Resources.feather_128;
            this.DiemSo.Location = new System.Drawing.Point(773, 209);
            this.DiemSo.Name = "DiemSo";
            this.DiemSo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.DiemSo.Size = new System.Drawing.Size(219, 337);
            this.DiemSo.TabIndex = 2;
            this.DiemSo.Text = "Điểm số";
            this.DiemSo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DiemSo.UseVisualStyleBackColor = false;
            // 
            // MonHoc
            // 
            this.MonHoc.BackColor = System.Drawing.Color.Teal;
            this.MonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MonHoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MonHoc.FlatAppearance.BorderSize = 0;
            this.MonHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.MonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonHoc.Font = new System.Drawing.Font("JetBrains Mono NL", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHoc.ForeColor = System.Drawing.Color.Transparent;
            this.MonHoc.Image = global::StudentManagementSystem.Properties.Resources.book_stack_128;
            this.MonHoc.Location = new System.Drawing.Point(521, 209);
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.MonHoc.Size = new System.Drawing.Size(219, 337);
            this.MonHoc.TabIndex = 2;
            this.MonHoc.Text = "Môn học";
            this.MonHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MonHoc.UseVisualStyleBackColor = false;
            // 
            // LopHoc
            // 
            this.LopHoc.BackColor = System.Drawing.Color.Teal;
            this.LopHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LopHoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LopHoc.FlatAppearance.BorderSize = 0;
            this.LopHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.LopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LopHoc.Font = new System.Drawing.Font("JetBrains Mono NL", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopHoc.ForeColor = System.Drawing.Color.Transparent;
            this.LopHoc.Image = global::StudentManagementSystem.Properties.Resources.classroom_2_128;
            this.LopHoc.Location = new System.Drawing.Point(269, 209);
            this.LopHoc.Name = "LopHoc";
            this.LopHoc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.LopHoc.Size = new System.Drawing.Size(219, 337);
            this.LopHoc.TabIndex = 2;
            this.LopHoc.Text = "Lớp học";
            this.LopHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LopHoc.UseVisualStyleBackColor = false;
            // 
            // HocSinh
            // 
            this.HocSinh.BackColor = System.Drawing.Color.Teal;
            this.HocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HocSinh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HocSinh.FlatAppearance.BorderSize = 0;
            this.HocSinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.HocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HocSinh.Font = new System.Drawing.Font("JetBrains Mono NL", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HocSinh.ForeColor = System.Drawing.Color.Transparent;
            this.HocSinh.Image = global::StudentManagementSystem.Properties.Resources.student_128;
            this.HocSinh.Location = new System.Drawing.Point(12, 209);
            this.HocSinh.Name = "HocSinh";
            this.HocSinh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.HocSinh.Size = new System.Drawing.Size(219, 337);
            this.HocSinh.TabIndex = 2;
            this.HocSinh.Text = "Học sinh";
            this.HocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HocSinh.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ThongKe);
            this.Controls.Add(this.DiemSo);
            this.Controls.Add(this.MonHoc);
            this.Controls.Add(this.LopHoc);
            this.Controls.Add(this.HocSinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Quản lí học sinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HocSinh;
        private System.Windows.Forms.Button LopHoc;
        private System.Windows.Forms.Button DiemSo;
        private System.Windows.Forms.Button MonHoc;
        private System.Windows.Forms.Button ThongKe;
    }
}

