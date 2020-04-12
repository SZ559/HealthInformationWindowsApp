namespace WindowsApp
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.addButton = new System.Windows.Forms.Button();
            this.importFromFileButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.viewSuspectedCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeHealthDataLabel = new System.Windows.Forms.Label();
            this.healthDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ginNumberTextBox = new System.Windows.Forms.TextBox();
            this.ginNumberLabel = new System.Windows.Forms.Label();
            this.errorGinNumberLabel = new System.Windows.Forms.Label();
            this.errorCannotFindGinNumberLabel = new System.Windows.Forms.Label();
            this.healthDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.healthDataFilterFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hasAbnormalSymptomFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.visitHubeiFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editByGinNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeHealthDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.fileOperationGroupBox = new System.Windows.Forms.GroupBox();
            this.editHealthDataGroupBox = new System.Windows.Forms.GroupBox();
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.importToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.baseSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.healthDataFilterFlowLayoutPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.fileOperationGroupBox.SuspendLayout();
            this.editHealthDataGroupBox.SuspendLayout();
            this.mainMenuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).BeginInit();
            this.baseSplitContainer.Panel1.SuspendLayout();
            this.baseSplitContainer.Panel2.SuspendLayout();
            this.baseSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addButton.Location = new System.Drawing.Point(25, 299);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(426, 60);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // importFromFileButton
            // 
            this.importFromFileButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.importFromFileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importFromFileButton.Location = new System.Drawing.Point(25, 80);
            this.importFromFileButton.Name = "importFromFileButton";
            this.importFromFileButton.Size = new System.Drawing.Size(426, 60);
            this.importFromFileButton.TabIndex = 3;
            this.importFromFileButton.Text = "Import From File";
            this.importFromFileButton.UseVisualStyleBackColor = false;
            this.importFromFileButton.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveToFileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveToFileButton.Location = new System.Drawing.Point(25, 170);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(426, 60);
            this.saveToFileButton.TabIndex = 4;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = false;
            this.saveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            // 
            // viewSuspectedCaseCheckBox
            // 
            this.viewSuspectedCaseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSuspectedCaseCheckBox.AutoSize = true;
            this.viewSuspectedCaseCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewSuspectedCaseCheckBox.ForeColor = System.Drawing.Color.Black;
            this.viewSuspectedCaseCheckBox.Location = new System.Drawing.Point(1290, 3);
            this.viewSuspectedCaseCheckBox.Name = "viewSuspectedCaseCheckBox";
            this.viewSuspectedCaseCheckBox.Size = new System.Drawing.Size(371, 43);
            this.viewSuspectedCaseCheckBox.TabIndex = 18;
            this.viewSuspectedCaseCheckBox.Text = "View Suspected Cases";
            this.viewSuspectedCaseCheckBox.UseVisualStyleBackColor = true;
            this.viewSuspectedCaseCheckBox.CheckedChanged += new System.EventHandler(this.ViewSuspectedCaseCheckBox_CheckedChanged);
            // 
            // employeeHealthDataLabel
            // 
            this.employeeHealthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeHealthDataLabel.AutoSize = true;
            this.employeeHealthDataLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employeeHealthDataLabel.Location = new System.Drawing.Point(5, 24);
            this.employeeHealthDataLabel.Name = "employeeHealthDataLabel";
            this.employeeHealthDataLabel.Size = new System.Drawing.Size(338, 39);
            this.employeeHealthDataLabel.TabIndex = 2;
            this.employeeHealthDataLabel.Text = "Employee Health Data";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editButton.Location = new System.Drawing.Point(25, 209);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(209, 60);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteButton.Location = new System.Drawing.Point(242, 209);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(209, 60);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ginNumberTextBox
            // 
            this.ginNumberTextBox.Location = new System.Drawing.Point(25, 119);
            this.ginNumberTextBox.Name = "ginNumberTextBox";
            this.ginNumberTextBox.Size = new System.Drawing.Size(426, 45);
            this.ginNumberTextBox.TabIndex = 10;
            this.ginNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerCheck);
            // 
            // ginNumberLabel
            // 
            this.ginNumberLabel.AutoSize = true;
            this.ginNumberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ginNumberLabel.Location = new System.Drawing.Point(18, 77);
            this.ginNumberLabel.Name = "ginNumberLabel";
            this.ginNumberLabel.Size = new System.Drawing.Size(346, 39);
            this.ginNumberLabel.TabIndex = 11;
            this.ginNumberLabel.Text = "Search By Gin Number:";
            // 
            // errorGinNumberLabel
            // 
            this.errorGinNumberLabel.AutoSize = true;
            this.errorGinNumberLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGinNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorGinNumberLabel.Location = new System.Drawing.Point(19, 167);
            this.errorGinNumberLabel.Name = "errorGinNumberLabel";
            this.errorGinNumberLabel.Size = new System.Drawing.Size(431, 35);
            this.errorGinNumberLabel.TabIndex = 16;
            this.errorGinNumberLabel.Text = "Gin Number must be an integer";
            this.errorGinNumberLabel.Visible = false;
            // 
            // errorCannotFindGinNumberLabel
            // 
            this.errorCannotFindGinNumberLabel.AutoSize = true;
            this.errorCannotFindGinNumberLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCannotFindGinNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCannotFindGinNumberLabel.Location = new System.Drawing.Point(19, 167);
            this.errorCannotFindGinNumberLabel.Name = "errorCannotFindGinNumberLabel";
            this.errorCannotFindGinNumberLabel.Size = new System.Drawing.Size(387, 35);
            this.errorCannotFindGinNumberLabel.TabIndex = 17;
            this.errorCannotFindGinNumberLabel.Text = "Cannot find the Gin Number";
            this.errorCannotFindGinNumberLabel.Visible = false;
            // 
            // healthDataGridView
            // 
            this.healthDataGridView.AllowUserToAddRows = false;
            this.healthDataGridView.AllowUserToDeleteRows = false;
            this.healthDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.healthDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.healthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.healthDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthDataGridView.Location = new System.Drawing.Point(5, 68);
            this.healthDataGridView.MultiSelect = false;
            this.healthDataGridView.Name = "healthDataGridView";
            this.healthDataGridView.ReadOnly = true;
            this.healthDataGridView.RowHeadersWidth = 10;
            this.healthDataGridView.RowTemplate.Height = 44;
            this.healthDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.healthDataGridView.Size = new System.Drawing.Size(1664, 1096);
            this.healthDataGridView.TabIndex = 0;
            this.healthDataGridView.SelectionChanged += new System.EventHandler(this.SelectRowChange);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.healthDataGridView, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.employeeHealthDataLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.healthDataFilterFlowLayoutPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1674, 1233);
            this.tableLayoutPanel.TabIndex = 19;
            // 
            // healthDataFilterFlowLayoutPanel
            // 
            this.healthDataFilterFlowLayoutPanel.Controls.Add(this.viewSuspectedCaseCheckBox);
            this.healthDataFilterFlowLayoutPanel.Controls.Add(this.hasAbnormalSymptomFilterCheckBox);
            this.healthDataFilterFlowLayoutPanel.Controls.Add(this.visitHubeiFilterCheckBox);
            this.healthDataFilterFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthDataFilterFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.healthDataFilterFlowLayoutPanel.Location = new System.Drawing.Point(5, 1172);
            this.healthDataFilterFlowLayoutPanel.Name = "healthDataFilterFlowLayoutPanel";
            this.healthDataFilterFlowLayoutPanel.Size = new System.Drawing.Size(1664, 56);
            this.healthDataFilterFlowLayoutPanel.TabIndex = 3;
            // 
            // hasAbnormalSymptomFilterCheckBox
            // 
            this.hasAbnormalSymptomFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hasAbnormalSymptomFilterCheckBox.AutoSize = true;
            this.hasAbnormalSymptomFilterCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hasAbnormalSymptomFilterCheckBox.ForeColor = System.Drawing.Color.Black;
            this.hasAbnormalSymptomFilterCheckBox.Location = new System.Drawing.Point(650, 3);
            this.hasAbnormalSymptomFilterCheckBox.Name = "hasAbnormalSymptomFilterCheckBox";
            this.hasAbnormalSymptomFilterCheckBox.Size = new System.Drawing.Size(634, 43);
            this.hasAbnormalSymptomFilterCheckBox.TabIndex = 20;
            this.hasAbnormalSymptomFilterCheckBox.Text = "View Employee Has Abnormal Symptom";
            this.hasAbnormalSymptomFilterCheckBox.UseVisualStyleBackColor = true;
            this.hasAbnormalSymptomFilterCheckBox.CheckedChanged += new System.EventHandler(this.HasAbnormalSymptomCheckBox_CheckedChanged);
            // 
            // visitHubeiFilterCheckBox
            // 
            this.visitHubeiFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitHubeiFilterCheckBox.AutoSize = true;
            this.visitHubeiFilterCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitHubeiFilterCheckBox.ForeColor = System.Drawing.Color.Black;
            this.visitHubeiFilterCheckBox.Location = new System.Drawing.Point(39, 3);
            this.visitHubeiFilterCheckBox.Name = "visitHubeiFilterCheckBox";
            this.visitHubeiFilterCheckBox.Size = new System.Drawing.Size(605, 43);
            this.visitHubeiFilterCheckBox.TabIndex = 19;
            this.visitHubeiFilterCheckBox.Text = "View Employee Visited Hubei Recently";
            this.visitHubeiFilterCheckBox.UseVisualStyleBackColor = true;
            this.visitHubeiFilterCheckBox.CheckedChanged += new System.EventHandler(this.VisitHubeiFilterCheckBox_CheckedChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(2266, 47);
            this.mainMenuStrip.TabIndex = 20;
            this.mainMenuStrip.Text = "Add";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(90, 43);
            this.addToolStripMenuItem.Text = "File";
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(420, 54);
            this.importFromFileToolStripMenuItem.Text = "Import From File";
            this.importFromFileToolStripMenuItem.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(420, 54);
            this.saveToFileToolStripMenuItem.Text = "Save To File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editByGinNumberToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(96, 43);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(275, 54);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editByGinNumberToolStripMenuItem
            // 
            this.editByGinNumberToolStripMenuItem.Name = "editByGinNumberToolStripMenuItem";
            this.editByGinNumberToolStripMenuItem.Size = new System.Drawing.Size(275, 54);
            this.editByGinNumberToolStripMenuItem.Text = "Edit";
            this.editByGinNumberToolStripMenuItem.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(275, 54);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeHealthDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(110, 43);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewEmployeeHealthDataToolStripMenuItem
            // 
            this.viewEmployeeHealthDataToolStripMenuItem.Name = "viewEmployeeHealthDataToolStripMenuItem";
            this.viewEmployeeHealthDataToolStripMenuItem.Size = new System.Drawing.Size(581, 54);
            this.viewEmployeeHealthDataToolStripMenuItem.Text = "View Employee Health Data";
            this.viewEmployeeHealthDataToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeHealthDataToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.fileOperationGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.editHealthDataGroupBox);
            this.splitContainer.Panel2.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.Size = new System.Drawing.Size(2266, 1233);
            this.splitContainer.SplitterDistance = 1674;
            this.splitContainer.TabIndex = 21;
            // 
            // fileOperationGroupBox
            // 
            this.fileOperationGroupBox.Controls.Add(this.saveToFileButton);
            this.fileOperationGroupBox.Controls.Add(this.importFromFileButton);
            this.fileOperationGroupBox.Location = new System.Drawing.Point(15, 536);
            this.fileOperationGroupBox.Name = "fileOperationGroupBox";
            this.fileOperationGroupBox.Size = new System.Drawing.Size(553, 302);
            this.fileOperationGroupBox.TabIndex = 1;
            this.fileOperationGroupBox.TabStop = false;
            this.fileOperationGroupBox.Text = "File Operation";
            // 
            // editHealthDataGroupBox
            // 
            this.editHealthDataGroupBox.Controls.Add(this.ginNumberLabel);
            this.editHealthDataGroupBox.Controls.Add(this.errorGinNumberLabel);
            this.editHealthDataGroupBox.Controls.Add(this.addButton);
            this.editHealthDataGroupBox.Controls.Add(this.errorCannotFindGinNumberLabel);
            this.editHealthDataGroupBox.Controls.Add(this.ginNumberTextBox);
            this.editHealthDataGroupBox.Controls.Add(this.editButton);
            this.editHealthDataGroupBox.Controls.Add(this.deleteButton);
            this.editHealthDataGroupBox.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editHealthDataGroupBox.Location = new System.Drawing.Point(15, 69);
            this.editHealthDataGroupBox.Name = "editHealthDataGroupBox";
            this.editHealthDataGroupBox.Size = new System.Drawing.Size(553, 415);
            this.editHealthDataGroupBox.TabIndex = 0;
            this.editHealthDataGroupBox.TabStop = false;
            this.editHealthDataGroupBox.Text = "Edit Employee Health Data";
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton,
            this.importToolStripButton,
            this.saveToolStripButton,
            this.searchToolStripTextBox});
            this.mainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            this.mainMenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenuToolStrip.Size = new System.Drawing.Size(2266, 55);
            this.mainMenuToolStrip.TabIndex = 22;
            this.mainMenuToolStrip.Text = "toolStrip1";
            this.mainMenuToolStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchToolStripTextBox_KeyDownEnter);
            // 
            // toolStripButton
            // 
            this.toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton.Enabled = false;
            this.toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton.Image")));
            this.toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton.Name = "toolStripButton";
            this.toolStripButton.Size = new System.Drawing.Size(58, 48);
            this.toolStripButton.Text = "toolStripButton1";
            // 
            // importToolStripButton
            // 
            this.importToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripButton.Image")));
            this.importToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripButton.Name = "importToolStripButton";
            this.importToolStripButton.Size = new System.Drawing.Size(299, 48);
            this.importToolStripButton.Text = "Import From File";
            this.importToolStripButton.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(231, 48);
            this.saveToolStripButton.Text = "Save To File";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.searchToolStripTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(380, 55);
            this.searchToolStripTextBox.Text = "Search By Gin Number";
            this.searchToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchToolStripTextBox_KeyDownEnter);
            this.searchToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerCheck_WithMessageBoxWarning);
            this.searchToolStripTextBox.MouseEnter += new System.EventHandler(this.searchToolStripTextBox_MouseEnter);
            this.searchToolStripTextBox.MouseLeave += new System.EventHandler(this.searchToolStripTextBox_MouseLeave);
            // 
            // baseSplitContainer
            // 
            this.baseSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseSplitContainer.Location = new System.Drawing.Point(0, 47);
            this.baseSplitContainer.Name = "baseSplitContainer";
            this.baseSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // baseSplitContainer.Panel1
            // 
            this.baseSplitContainer.Panel1.Controls.Add(this.mainMenuToolStrip);
            // 
            // baseSplitContainer.Panel2
            // 
            this.baseSplitContainer.Panel2.Controls.Add(this.splitContainer);
            this.baseSplitContainer.Size = new System.Drawing.Size(2266, 1292);
            this.baseSplitContainer.SplitterDistance = 55;
            this.baseSplitContainer.TabIndex = 23;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2266, 1339);
            this.Controls.Add(this.baseSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.healthDataFilterFlowLayoutPanel.ResumeLayout(false);
            this.healthDataFilterFlowLayoutPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.fileOperationGroupBox.ResumeLayout(false);
            this.editHealthDataGroupBox.ResumeLayout(false);
            this.editHealthDataGroupBox.PerformLayout();
            this.mainMenuToolStrip.ResumeLayout(false);
            this.mainMenuToolStrip.PerformLayout();
            this.baseSplitContainer.Panel1.ResumeLayout(false);
            this.baseSplitContainer.Panel1.PerformLayout();
            this.baseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).EndInit();
            this.baseSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button importFromFileButton;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource healthDatabaseBindingSource;
        private System.Windows.Forms.Label employeeHealthDataLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox ginNumberTextBox;
        private System.Windows.Forms.Label ginNumberLabel;
        private System.Windows.Forms.Label errorGinNumberLabel;
        private System.Windows.Forms.Label errorCannotFindGinNumberLabel;
        private System.Windows.Forms.CheckBox viewSuspectedCaseCheckBox;
        private System.Windows.Forms.DataGridView healthDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox fileOperationGroupBox;
        private System.Windows.Forms.GroupBox editHealthDataGroupBox;
        private System.Windows.Forms.FlowLayoutPanel healthDataFilterFlowLayoutPanel;
        private System.Windows.Forms.CheckBox visitHubeiFilterCheckBox;
        private System.Windows.Forms.ToolStripMenuItem editByGinNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeHealthDataToolStripMenuItem;
        private System.Windows.Forms.CheckBox hasAbnormalSymptomFilterCheckBox;
        private System.Windows.Forms.ToolStrip mainMenuToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.SplitContainer baseSplitContainer;
        private System.Windows.Forms.ToolStripButton importToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}