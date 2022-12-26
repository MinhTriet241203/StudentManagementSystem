namespace StudentManagementSystem
{
    partial class SubjectsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label subjectIDLabel1;
            System.Windows.Forms.Label subjectNameLabel1;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManageDataSet = new StudentManagementSystem.StudentManageDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.subjectsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDTextBox1 = new System.Windows.Forms.TextBox();
            this.subjectNameTextBox1 = new System.Windows.Forms.TextBox();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.subjectsTableAdapter = new StudentManagementSystem.StudentManageDataSetTableAdapters.SubjectsTableAdapter();
            this.tableAdapterManager = new StudentManagementSystem.StudentManageDataSetTableAdapters.TableAdapterManager();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            subjectIDLabel1 = new System.Windows.Forms.Label();
            subjectNameLabel1 = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingNavigator)).BeginInit();
            this.subjectsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectIDLabel1
            // 
            subjectIDLabel1.AutoSize = true;
            subjectIDLabel1.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectIDLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            subjectIDLabel1.Location = new System.Drawing.Point(181, 164);
            subjectIDLabel1.Name = "subjectIDLabel1";
            subjectIDLabel1.Size = new System.Drawing.Size(48, 26);
            subjectIDLabel1.TabIndex = 8;
            subjectIDLabel1.Text = "ID:";
            // 
            // subjectNameLabel1
            // 
            subjectNameLabel1.AutoSize = true;
            subjectNameLabel1.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectNameLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            subjectNameLabel1.Location = new System.Drawing.Point(56, 228);
            subjectNameLabel1.Name = "subjectNameLabel1";
            subjectNameLabel1.Size = new System.Drawing.Size(108, 26);
            subjectNameLabel1.TabIndex = 10;
            subjectNameLabel1.Text = "Môn học:";
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            semesterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            semesterLabel.Location = new System.Drawing.Point(56, 290);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(96, 26);
            semesterLabel.TabIndex = 12;
            semesterLabel.Text = "Học kì:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1237, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin môn học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1237, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\n";
            // 
            // subjectsBindingNavigator
            // 
            this.subjectsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjectsBindingNavigator.AllowMerge = false;
            this.subjectsBindingNavigator.AutoSize = false;
            this.subjectsBindingNavigator.BackColor = System.Drawing.Color.Teal;
            this.subjectsBindingNavigator.BindingSource = this.subjectsBindingSource;
            this.subjectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjectsBindingNavigator.CountItemFormat = "trong {0}";
            this.subjectsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjectsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subjectsBindingNavigator.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.subjectsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subjectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.subjectsBindingNavigatorSaveItem});
            this.subjectsBindingNavigator.Location = new System.Drawing.Point(0, 630);
            this.subjectsBindingNavigator.MoveFirstItem = null;
            this.subjectsBindingNavigator.MoveLastItem = null;
            this.subjectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjectsBindingNavigator.Name = "subjectsBindingNavigator";
            this.subjectsBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.subjectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjectsBindingNavigator.Size = new System.Drawing.Size(1276, 47);
            this.subjectsBindingNavigator.TabIndex = 2;
            this.subjectsBindingNavigator.Text = "bindingNavigator1";
            this.subjectsBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigatorAddNewItem.Image = global::StudentManagementSystem.Properties.Resources.plus_4_64;
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(84, 44);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.studentManageDataSet;
            // 
            // studentManageDataSet
            // 
            this.studentManageDataSet.DataSetName = "StudentManageDataSet";
            this.studentManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(120, 44);
            this.bindingNavigatorCountItem.Text = "trong {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigatorDeleteItem.Image = global::StudentManagementSystem.Properties.Resources.trash_10_64;
            this.bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(72, 44);
            this.bindingNavigatorDeleteItem.Text = "Xoá";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigatorMovePreviousItem.Image = global::StudentManagementSystem.Properties.Resources.arrow_88_64;
            this.bindingNavigatorMovePreviousItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(96, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigatorPositionItem.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 34);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigatorMoveNextItem.Image = global::StudentManagementSystem.Properties.Resources.arrow_24_64;
            this.bindingNavigatorMoveNextItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(72, 44);
            this.bindingNavigatorMoveNextItem.Text = "Sau";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // subjectsBindingNavigatorSaveItem
            // 
            this.subjectsBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.subjectsBindingNavigatorSaveItem.Image = global::StudentManagementSystem.Properties.Resources.save_64;
            this.subjectsBindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.subjectsBindingNavigatorSaveItem.Name = "subjectsBindingNavigatorSaveItem";
            this.subjectsBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subjectsBindingNavigatorSaveItem.Size = new System.Drawing.Size(190, 44);
            this.subjectsBindingNavigatorSaveItem.Text = "Lưu thay đổi";
            this.subjectsBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjectsBindingNavigatorSaveItem_Click);
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.AllowUserToAddRows = false;
            this.subjectsDataGridView.AllowUserToDeleteRows = false;
            this.subjectsDataGridView.AutoGenerateColumns = false;
            this.subjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectsDataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIDDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.subjectsDataGridView.DataSource = this.subjectsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.subjectsDataGridView.Location = new System.Drawing.Point(555, 161);
            this.subjectsDataGridView.MultiSelect = false;
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.ReadOnly = true;
            this.subjectsDataGridView.RowHeadersVisible = false;
            this.subjectsDataGridView.RowHeadersWidth = 51;
            this.subjectsDataGridView.RowTemplate.Height = 24;
            this.subjectsDataGridView.RowTemplate.ReadOnly = true;
            this.subjectsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsDataGridView.Size = new System.Drawing.Size(698, 491);
            this.subjectsDataGridView.TabIndex = 3;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.subjectIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.subjectIDDataGridViewTextBoxColumn.FillWeight = 106.9519F;
            this.subjectIDDataGridViewTextBoxColumn.Frozen = true;
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.subjectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.FillWeight = 97.68271F;
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "Môn học";
            this.subjectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.FillWeight = 97.68271F;
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Kì";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectIDTextBox1
            // 
            this.subjectIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "SubjectID", true));
            this.subjectIDTextBox1.Enabled = false;
            this.subjectIDTextBox1.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectIDTextBox1.Location = new System.Drawing.Point(245, 161);
            this.subjectIDTextBox1.Name = "subjectIDTextBox1";
            this.subjectIDTextBox1.Size = new System.Drawing.Size(83, 34);
            this.subjectIDTextBox1.TabIndex = 9;
            // 
            // subjectNameTextBox1
            // 
            this.subjectNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "SubjectName", true));
            this.subjectNameTextBox1.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameTextBox1.Location = new System.Drawing.Point(186, 225);
            this.subjectNameTextBox1.Name = "subjectNameTextBox1";
            this.subjectNameTextBox1.Size = new System.Drawing.Size(346, 34);
            this.subjectNameTextBox1.TabIndex = 11;
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "Semester", true));
            this.semesterTextBox.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterTextBox.Location = new System.Drawing.Point(186, 287);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(346, 34);
            this.semesterTextBox.TabIndex = 13;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.ScoresTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentManagementSystem.StudentManageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveButton.Image = global::StudentManagementSystem.Properties.Resources.save_32;
            this.SaveButton.Location = new System.Drawing.Point(273, 480);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(259, 62);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseMnemonic = false;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.Image = global::StudentManagementSystem.Properties.Resources.delete_32;
            this.DeleteButton.Location = new System.Drawing.Point(273, 590);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(259, 62);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Xoá";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseMnemonic = false;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.SeaGreen;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NextButton.Image = global::StudentManagementSystem.Properties.Resources.arrow_24_32;
            this.NextButton.Location = new System.Drawing.Point(351, 157);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(40, 40);
            this.NextButton.TabIndex = 15;
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NextButton.UseMnemonic = false;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.SeaGreen;
            this.PreviousButton.FlatAppearance.BorderSize = 0;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousButton.Image = global::StudentManagementSystem.Properties.Resources.arrow_88_32;
            this.PreviousButton.Location = new System.Drawing.Point(124, 157);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(40, 40);
            this.PreviousButton.TabIndex = 15;
            this.PreviousButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PreviousButton.UseMnemonic = false;
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.Image = global::StudentManagementSystem.Properties.Resources.plus_4_32;
            this.AddButton.Location = new System.Drawing.Point(273, 362);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(259, 62);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Tạo mới";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseMnemonic = false;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1276, 677);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(subjectIDLabel1);
            this.Controls.Add(this.subjectIDTextBox1);
            this.Controls.Add(subjectNameLabel1);
            this.Controls.Add(this.subjectNameTextBox1);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(this.subjectsBindingNavigator);
            this.Controls.Add(this.subjectsDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SubjectsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin môn học ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectsForm_FormClosing);
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingNavigator)).EndInit();
            this.subjectsBindingNavigator.ResumeLayout(false);
            this.subjectsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private StudentManageDataSet studentManageDataSet;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private StudentManageDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private StudentManageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjectsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton subjectsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView subjectsDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox subjectIDTextBox1;
        private System.Windows.Forms.TextBox subjectNameTextBox1;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
    }
}

