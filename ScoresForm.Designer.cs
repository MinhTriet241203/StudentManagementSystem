namespace StudentManagementSystem
{
    partial class ScoresForm
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
            System.Windows.Forms.Label scoreIDLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label subjectIDLabel;
            System.Windows.Forms.Label scoreLabel;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label studentIDLabel1;
            System.Windows.Forms.Label subjectIDLabel1;
            System.Windows.Forms.Label scoreLabel1;
            System.Windows.Forms.Label semesterLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoresForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.studentManageDataSet = new StudentManagementSystem.StudentManageDataSet();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresTableAdapter = new StudentManagementSystem.StudentManageDataSetTableAdapters.ScoresTableAdapter();
            this.tableAdapterManager = new StudentManagementSystem.StudentManageDataSetTableAdapters.TableAdapterManager();
            this.studentsTableAdapter = new StudentManagementSystem.StudentManageDataSetTableAdapters.StudentsTableAdapter();
            this.subjectsTableAdapter = new StudentManagementSystem.StudentManageDataSetTableAdapters.SubjectsTableAdapter();
            this.scoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreIDTextBox = new System.Windows.Forms.TextBox();
            this.studentIDComboBox = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectIDComboBox = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.subjectIDTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox1 = new System.Windows.Forms.TextBox();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            scoreIDLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            subjectIDLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            studentIDLabel1 = new System.Windows.Forms.Label();
            subjectIDLabel1 = new System.Windows.Forms.Label();
            scoreLabel1 = new System.Windows.Forms.Label();
            semesterLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingNavigator)).BeginInit();
            this.scoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreIDLabel
            // 
            scoreIDLabel.AutoSize = true;
            scoreIDLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scoreIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            scoreIDLabel.Location = new System.Drawing.Point(166, 116);
            scoreIDLabel.Name = "scoreIDLabel";
            scoreIDLabel.Size = new System.Drawing.Size(120, 26);
            scoreIDLabel.TabIndex = 23;
            scoreIDLabel.Text = "Score ID:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            studentIDLabel.Location = new System.Drawing.Point(43, 179);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(144, 26);
            studentIDLabel.TabIndex = 25;
            studentIDLabel.Text = "Student ID:";
            // 
            // subjectIDLabel
            // 
            subjectIDLabel.AutoSize = true;
            subjectIDLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            subjectIDLabel.Location = new System.Drawing.Point(43, 233);
            subjectIDLabel.Name = "subjectIDLabel";
            subjectIDLabel.Size = new System.Drawing.Size(144, 26);
            subjectIDLabel.TabIndex = 27;
            subjectIDLabel.Text = "Subject ID:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            scoreLabel.Location = new System.Drawing.Point(43, 288);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(84, 26);
            scoreLabel.TabIndex = 29;
            scoreLabel.Text = "Score:";
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            semesterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            semesterLabel.Location = new System.Drawing.Point(43, 345);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(120, 26);
            semesterLabel.TabIndex = 31;
            semesterLabel.Text = "Semester:";
            // 
            // studentIDLabel1
            // 
            studentIDLabel1.AutoSize = true;
            studentIDLabel1.Location = new System.Drawing.Point(125, 480);
            studentIDLabel1.Name = "studentIDLabel1";
            studentIDLabel1.Size = new System.Drawing.Size(71, 16);
            studentIDLabel1.TabIndex = 34;
            studentIDLabel1.Text = "Student ID:";
            // 
            // subjectIDLabel1
            // 
            subjectIDLabel1.AutoSize = true;
            subjectIDLabel1.Location = new System.Drawing.Point(125, 508);
            subjectIDLabel1.Name = "subjectIDLabel1";
            subjectIDLabel1.Size = new System.Drawing.Size(71, 16);
            subjectIDLabel1.TabIndex = 36;
            subjectIDLabel1.Text = "Subject ID:";
            // 
            // scoreLabel1
            // 
            scoreLabel1.AutoSize = true;
            scoreLabel1.Location = new System.Drawing.Point(125, 536);
            scoreLabel1.Name = "scoreLabel1";
            scoreLabel1.Size = new System.Drawing.Size(46, 16);
            scoreLabel1.TabIndex = 38;
            scoreLabel1.Text = "Score:";
            // 
            // semesterLabel1
            // 
            semesterLabel1.AutoSize = true;
            semesterLabel1.Location = new System.Drawing.Point(125, 564);
            semesterLabel1.Name = "semesterLabel1";
            semesterLabel1.Size = new System.Drawing.Size(68, 16);
            semesterLabel1.TabIndex = 40;
            semesterLabel1.Text = "Semester:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(173, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin điểm số";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1237, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\n";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Teal;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeButton.Image = global::StudentManagementSystem.Properties.Resources.house_48;
            this.HomeButton.Location = new System.Drawing.Point(29, 21);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(60, 60);
            this.HomeButton.TabIndex = 22;
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // studentManageDataSet
            // 
            this.studentManageDataSet.DataSetName = "StudentManageDataSet";
            this.studentManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "Scores";
            this.scoresBindingSource.DataSource = this.studentManageDataSet;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.ScoresTableAdapter = this.scoresTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentManagementSystem.StudentManageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // scoresBindingNavigator
            // 
            this.scoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scoresBindingNavigator.BindingSource = this.scoresBindingSource;
            this.scoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scoresBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.scoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.scoresBindingNavigatorSaveItem});
            this.scoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scoresBindingNavigator.Name = "scoresBindingNavigator";
            this.scoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scoresBindingNavigator.Size = new System.Drawing.Size(1277, 29);
            this.scoresBindingNavigator.TabIndex = 23;
            this.scoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 29);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // scoresBindingNavigatorSaveItem
            // 
            this.scoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scoresBindingNavigatorSaveItem.Image")));
            this.scoresBindingNavigatorSaveItem.Name = "scoresBindingNavigatorSaveItem";
            this.scoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 26);
            this.scoresBindingNavigatorSaveItem.Text = "Save Data";
            this.scoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.scoresBindingNavigatorSaveItem_Click);
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.AutoGenerateColumns = false;
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.scoresDataGridView.DataSource = this.scoresBindingSource;
            this.scoresDataGridView.Location = new System.Drawing.Point(605, 113);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.RowHeadersWidth = 51;
            this.scoresDataGridView.RowTemplate.Height = 24;
            this.scoresDataGridView.Size = new System.Drawing.Size(644, 513);
            this.scoresDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ScoreID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ScoreID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubjectID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Semester";
            this.dataGridViewTextBoxColumn5.HeaderText = "Semester";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // scoreIDTextBox
            // 
            this.scoreIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "ScoreID", true));
            this.scoreIDTextBox.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.scoreIDTextBox.Location = new System.Drawing.Point(304, 113);
            this.scoreIDTextBox.Name = "scoreIDTextBox";
            this.scoreIDTextBox.Size = new System.Drawing.Size(121, 34);
            this.scoreIDTextBox.TabIndex = 24;
            // 
            // studentIDComboBox
            // 
            this.studentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "StudentID", true));
            this.studentIDComboBox.DataSource = this.studentsBindingSource;
            this.studentIDComboBox.DisplayMember = "StudentName";
            this.studentIDComboBox.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDComboBox.ForeColor = System.Drawing.Color.Black;
            this.studentIDComboBox.FormattingEnabled = true;
            this.studentIDComboBox.Location = new System.Drawing.Point(259, 179);
            this.studentIDComboBox.Name = "studentIDComboBox";
            this.studentIDComboBox.Size = new System.Drawing.Size(238, 34);
            this.studentIDComboBox.TabIndex = 26;
            this.studentIDComboBox.ValueMember = "StudentID";
            this.studentIDComboBox.SelectedIndexChanged += new System.EventHandler(this.studentIDComboBox_SelectedIndexChanged);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentManageDataSet;
            // 
            // subjectIDComboBox
            // 
            this.subjectIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "SubjectID", true));
            this.subjectIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjectsBindingSource, "SubjectID", true));
            this.subjectIDComboBox.DataSource = this.subjectsBindingSource;
            this.subjectIDComboBox.DisplayMember = "SubjectName";
            this.subjectIDComboBox.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectIDComboBox.ForeColor = System.Drawing.Color.Black;
            this.subjectIDComboBox.FormattingEnabled = true;
            this.subjectIDComboBox.Location = new System.Drawing.Point(259, 230);
            this.subjectIDComboBox.Name = "subjectIDComboBox";
            this.subjectIDComboBox.Size = new System.Drawing.Size(121, 34);
            this.subjectIDComboBox.TabIndex = 28;
            this.subjectIDComboBox.ValueMember = "SubjectID";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.studentManageDataSet;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "Score", true));
            this.scoreTextBox.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.ForeColor = System.Drawing.Color.Black;
            this.scoreTextBox.Location = new System.Drawing.Point(259, 285);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(121, 34);
            this.scoreTextBox.TabIndex = 30;
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "Semester", true));
            this.semesterComboBox.DataSource = this.subjectsBindingSource;
            this.semesterComboBox.DisplayMember = "Semester";
            this.semesterComboBox.Enabled = false;
            this.semesterComboBox.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterComboBox.ForeColor = System.Drawing.Color.Black;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(259, 342);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(121, 34);
            this.semesterComboBox.TabIndex = 32;
            this.semesterComboBox.ValueMember = "Semester";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(202, 477);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentIDTextBox.TabIndex = 35;
            // 
            // subjectIDTextBox
            // 
            this.subjectIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "SubjectID", true));
            this.subjectIDTextBox.Location = new System.Drawing.Point(202, 505);
            this.subjectIDTextBox.Name = "subjectIDTextBox";
            this.subjectIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.subjectIDTextBox.TabIndex = 37;
            // 
            // scoreTextBox1
            // 
            this.scoreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "Score", true));
            this.scoreTextBox1.Location = new System.Drawing.Point(202, 533);
            this.scoreTextBox1.Name = "scoreTextBox1";
            this.scoreTextBox1.Size = new System.Drawing.Size(100, 22);
            this.scoreTextBox1.TabIndex = 39;
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoresBindingSource, "Semester", true));
            this.semesterTextBox.Location = new System.Drawing.Point(202, 561);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(100, 22);
            this.semesterTextBox.TabIndex = 41;
            // 
            // ScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1277, 646);
            this.Controls.Add(studentIDLabel1);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(subjectIDLabel1);
            this.Controls.Add(this.subjectIDTextBox);
            this.Controls.Add(scoreLabel1);
            this.Controls.Add(this.scoreTextBox1);
            this.Controls.Add(semesterLabel1);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(scoreIDLabel);
            this.Controls.Add(this.scoreIDTextBox);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDComboBox);
            this.Controls.Add(subjectIDLabel);
            this.Controls.Add(this.subjectIDComboBox);
            this.Controls.Add(scoreLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.scoresDataGridView);
            this.Controls.Add(this.scoresBindingNavigator);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScoresForm_FormClosing);
            this.Load += new System.EventHandler(this.ScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingNavigator)).EndInit();
            this.scoresBindingNavigator.ResumeLayout(false);
            this.scoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomeButton;
        private StudentManageDataSet studentManageDataSet;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private StudentManageDataSetTableAdapters.ScoresTableAdapter scoresTableAdapter;
        private StudentManageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton scoresBindingNavigatorSaveItem;
        private StudentManageDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridView scoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox scoreIDTextBox;
        private System.Windows.Forms.ComboBox studentIDComboBox;
        private System.Windows.Forms.ComboBox subjectIDComboBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private StudentManageDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox subjectIDTextBox;
        private System.Windows.Forms.TextBox scoreTextBox1;
        private System.Windows.Forms.TextBox semesterTextBox;
    }
}

