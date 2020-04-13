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
            this.openFileButton = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.healthDataFilterFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hasAbnormalSymptomFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.visitHubeiFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeHealthDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.fileOperationGroupBox = new System.Windows.Forms.GroupBox();
            this.editHealthDataGroupBox = new System.Windows.Forms.GroupBox();
            this.baseSplitContainer = new System.Windows.Forms.SplitContainer();
            this.openFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.healthDataFilterFlowLayoutPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.fileOperationGroupBox.SuspendLayout();
            this.editHealthDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).BeginInit();
            this.baseSplitContainer.Panel1.SuspendLayout();
            this.baseSplitContainer.Panel2.SuspendLayout();
            this.baseSplitContainer.SuspendLayout();
            this.mainMenuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addButton.Location = new System.Drawing.Point(25, 299);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(426, 60);
            this.addButton.TabIndex = 7;
            this.addButton.TabStop = false;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.openFileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openFileButton.Location = new System.Drawing.Point(25, 80);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(426, 60);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.TabStop = false;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveToFileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveToFileButton.Location = new System.Drawing.Point(25, 170);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(426, 60);
            this.saveToFileButton.TabIndex = 9;
            this.saveToFileButton.TabStop = false;
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
            this.viewSuspectedCaseCheckBox.TabIndex = 1;
            this.viewSuspectedCaseCheckBox.Text = "View Suspected Cases";
            this.viewSuspectedCaseCheckBox.UseVisualStyleBackColor = true;
            this.viewSuspectedCaseCheckBox.CheckedChanged += new System.EventHandler(this.ViewSuspectedCaseCheckBox_CheckedChanged);
            // 
            // employeeHealthDataLabel
            // 
            this.employeeHealthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeHealthDataLabel.AutoSize = true;
            this.employeeHealthDataLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employeeHealthDataLabel.Location = new System.Drawing.Point(5, 23);
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
            this.editButton.TabIndex = 5;
            this.editButton.TabStop = false;
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
            this.deleteButton.TabIndex = 6;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Delete ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ginNumberTextBox
            // 
            this.ginNumberTextBox.Location = new System.Drawing.Point(25, 119);
            this.ginNumberTextBox.Name = "ginNumberTextBox";
            this.ginNumberTextBox.Size = new System.Drawing.Size(426, 45);
            this.ginNumberTextBox.TabIndex = 4;
            this.ginNumberTextBox.TabStop = false;
            this.ginNumberTextBox.Enter += new System.EventHandler(this.EditButton_Click);
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
            this.healthDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.healthDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthDataGridView.Location = new System.Drawing.Point(5, 67);
            this.healthDataGridView.MultiSelect = false;
            this.healthDataGridView.Name = "healthDataGridView";
            this.healthDataGridView.ReadOnly = true;
            this.healthDataGridView.RowHeadersWidth = 10;
            this.healthDataGridView.RowTemplate.Height = 44;
            this.healthDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.healthDataGridView.Size = new System.Drawing.Size(1664, 1091);
            this.healthDataGridView.StandardTab = true;
            this.healthDataGridView.TabIndex = 0;
            this.healthDataGridView.SelectionChanged += new System.EventHandler(this.SelectRowChange);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItemEdit,
            this.deleteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(374, 148);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+Shift+A";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(373, 48);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripMenuItemEdit
            // 
            this.editToolStripMenuItemEdit.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItemEdit.Image")));
            this.editToolStripMenuItemEdit.Name = "editToolStripMenuItemEdit";
            this.editToolStripMenuItemEdit.ShortcutKeyDisplayString = "Ctrl+E";
            this.editToolStripMenuItemEdit.Size = new System.Drawing.Size(373, 48);
            this.editToolStripMenuItemEdit.Text = "Edit";
            this.editToolStripMenuItemEdit.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(373, 48);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(1674, 1227);
            this.tableLayoutPanel.TabIndex = 19;
            // 
            // healthDataFilterFlowLayoutPanel
            // 
            this.healthDataFilterFlowLayoutPanel.Controls.Add(this.viewSuspectedCaseCheckBox);
            this.healthDataFilterFlowLayoutPanel.Controls.Add(this.hasAbnormalSymptomFilterCheckBox);
            this.healthDataFilterFlowLayoutPanel.Controls.Add(this.visitHubeiFilterCheckBox);
            this.healthDataFilterFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthDataFilterFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.healthDataFilterFlowLayoutPanel.Location = new System.Drawing.Point(5, 1166);
            this.healthDataFilterFlowLayoutPanel.Name = "healthDataFilterFlowLayoutPanel";
            this.healthDataFilterFlowLayoutPanel.Size = new System.Drawing.Size(1664, 56);
            this.healthDataFilterFlowLayoutPanel.TabIndex = 1;
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
            this.hasAbnormalSymptomFilterCheckBox.TabIndex = 2;
            this.hasAbnormalSymptomFilterCheckBox.TabStop = false;
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
            this.visitHubeiFilterCheckBox.TabIndex = 3;
            this.visitHubeiFilterCheckBox.TabStop = false;
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
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.TabStop = true;
            this.mainMenuStrip.Text = "Add";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(90, 43);
            this.addToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(458, 54);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToFileToolStripMenuItem.Image")));
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(458, 54);
            this.saveToFileToolStripMenuItem.Text = "Save To File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(96, 43);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem1.Image")));
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(437, 54);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem2.Image")));
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(437, 54);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(437, 54);
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
            this.viewEmployeeHealthDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.viewEmployeeHealthDataToolStripMenuItem.Size = new System.Drawing.Size(701, 54);
            this.viewEmployeeHealthDataToolStripMenuItem.Text = "View Employee Health Data";
            this.viewEmployeeHealthDataToolStripMenuItem.Click += new System.EventHandler(this.ViewEmployeeHealthDataToolStripMenuItem_Click);
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
            this.splitContainer.Size = new System.Drawing.Size(2266, 1227);
            this.splitContainer.SplitterDistance = 1674;
            this.splitContainer.TabIndex = 21;
            this.splitContainer.TabStop = false;
            // 
            // fileOperationGroupBox
            // 
            this.fileOperationGroupBox.Controls.Add(this.saveToFileButton);
            this.fileOperationGroupBox.Controls.Add(this.openFileButton);
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
            this.baseSplitContainer.SplitterDistance = 61;
            this.baseSplitContainer.TabIndex = 23;
            this.baseSplitContainer.TabStop = false;
            // 
            // openFileToolStripButton
            // 
            this.openFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripButton.Image")));
            this.openFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripButton.Name = "openFileToolStripButton";
            this.openFileToolStripButton.Size = new System.Drawing.Size(197, 56);
            this.openFileToolStripButton.Text = "Open File";
            this.openFileToolStripButton.ToolTipText = "Open File (Ctrl+O)";
            this.openFileToolStripButton.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(231, 56);
            this.saveToolStripButton.Text = "Save To File";
            this.saveToolStripButton.ToolTipText = "Save To File (Ctrl+S)";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.AutoSize = false;
            this.searchToolStripTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.searchToolStripTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(470, 63);
            this.searchToolStripTextBox.Text = "Search By Gin Number (Ctrl+Q)";
            this.searchToolStripTextBox.Enter += new System.EventHandler(this.SearchToolStripTextBox_MouseEnter);
            this.searchToolStripTextBox.LostFocus += new System.EventHandler(this.SearchToolStripTextBox_MouseLeave);
            this.searchToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchToolStripTextBox_KeyDownEnter);
            this.searchToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerCheck_WithMessageBoxWarning);
            this.searchToolStripTextBox.MouseEnter += new System.EventHandler(this.SearchToolStripTextBox_MouseEnter);
            this.searchToolStripTextBox.MouseLeave += new System.EventHandler(this.SearchToolStripTextBox_MouseLeave);
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(120, 56);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.ToolTipText = "Add (Ctrl+Shift+A)";
            this.addToolStripButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(116, 56);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.ToolTipText = "Edit (Ctrl+E)";
            this.editToolStripButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(154, 56);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.ToolTipText = "Delete (Del)";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.AutoSize = false;
            this.mainMenuToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripButton,
            this.saveToolStripButton,
            this.searchToolStripTextBox,
            this.addToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.toolStripButton1});
            this.mainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            this.mainMenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenuToolStrip.Size = new System.Drawing.Size(2250, 63);
            this.mainMenuToolStrip.TabIndex = 3;
            this.mainMenuToolStrip.TabStop = true;
            this.mainMenuToolStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchToolStripTextBox_KeyDownEnter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1316, 107);
            this.monthCalendar1.MaxDate = new System.DateTime(2020, 4, 13, 19, 59, 45, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 63);
            this.toolStripButton1.Text = "Filter Date";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2266, 1339);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.baseSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.KeyPreview = true;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenuForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
            this.baseSplitContainer.Panel1.ResumeLayout(false);
            this.baseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).EndInit();
            this.baseSplitContainer.ResumeLayout(false);
            this.mainMenuToolStrip.ResumeLayout(false);
            this.mainMenuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button openFileButton;
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
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeHealthDataToolStripMenuItem;
        private System.Windows.Forms.CheckBox hasAbnormalSymptomFilterCheckBox;
        private System.Windows.Forms.SplitContainer baseSplitContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip mainMenuToolStrip;
        private System.Windows.Forms.ToolStripButton openFileToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripTextBox toolStripButton1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}