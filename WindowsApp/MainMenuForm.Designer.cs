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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.viewSuspectedCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeHealthDataLabel = new System.Windows.Forms.Label();
            this.healthDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelEmployeeHealthData = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hasAbnormalSymptomFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.visitHubeiFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.treeViewComboBox = new System.Windows.Forms.ComboBox();
            this.treeView = new System.Windows.Forms.TreeView();
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
            this.viewCurrentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.clearFilterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHide = new System.Windows.Forms.ToolStripStatusLabel();
            this.hideStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.warningToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.sizeToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus2LabelAppName = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.healthDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanelEmployeeHealthData.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainMenuToolStrip.SuspendLayout();
            this.tableLayoutPanelBase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
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
            this.viewSuspectedCaseCheckBox.Location = new System.Drawing.Point(832, 3);
            this.viewSuspectedCaseCheckBox.Name = "viewSuspectedCaseCheckBox";
            this.viewSuspectedCaseCheckBox.Size = new System.Drawing.Size(371, 46);
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
            this.employeeHealthDataLabel.Location = new System.Drawing.Point(366, 13);
            this.employeeHealthDataLabel.Name = "employeeHealthDataLabel";
            this.employeeHealthDataLabel.Size = new System.Drawing.Size(338, 39);
            this.employeeHealthDataLabel.TabIndex = 2;
            this.employeeHealthDataLabel.Text = "Employee Health Data";
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
            this.healthDataGridView.Location = new System.Drawing.Point(366, 120);
            this.healthDataGridView.MultiSelect = false;
            this.healthDataGridView.Name = "healthDataGridView";
            this.healthDataGridView.ReadOnly = true;
            this.healthDataGridView.RowHeadersWidth = 10;
            this.healthDataGridView.RowTemplate.Height = 44;
            this.healthDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.healthDataGridView.Size = new System.Drawing.Size(1626, 890);
            this.healthDataGridView.StandardTab = true;
            this.healthDataGridView.TabIndex = 0;
            this.healthDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateRowSelected);
            this.healthDataGridView.SelectionChanged += new System.EventHandler(this.UpdateRowSelected);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItemEdit,
            this.deleteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(360, 148);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+Shift+A";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(359, 48);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripMenuItemEdit
            // 
            this.editToolStripMenuItemEdit.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItemEdit.Image")));
            this.editToolStripMenuItemEdit.Name = "editToolStripMenuItemEdit";
            this.editToolStripMenuItemEdit.ShortcutKeyDisplayString = "Ctrl+E";
            this.editToolStripMenuItemEdit.Size = new System.Drawing.Size(359, 48);
            this.editToolStripMenuItemEdit.Text = "Edit";
            this.editToolStripMenuItemEdit.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(359, 48);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tableLayoutPanelEmployeeHealthData
            // 
            this.tableLayoutPanelEmployeeHealthData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelEmployeeHealthData.ColumnCount = 2;
            this.tableLayoutPanelEmployeeHealthData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEmployeeHealthData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1632F));
            this.tableLayoutPanelEmployeeHealthData.Controls.Add(this.treeViewLabel, 0, 0);
            this.tableLayoutPanelEmployeeHealthData.Controls.Add(this.employeeHealthDataLabel, 1, 0);
            this.tableLayoutPanelEmployeeHealthData.Controls.Add(this.healthDataGridView, 1, 2);
            this.tableLayoutPanelEmployeeHealthData.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanelEmployeeHealthData.Controls.Add(this.treeViewComboBox, 0, 1);
            this.tableLayoutPanelEmployeeHealthData.Controls.Add(this.treeView, 0, 2);
            this.tableLayoutPanelEmployeeHealthData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEmployeeHealthData.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanelEmployeeHealthData.Name = "tableLayoutPanelEmployeeHealthData";
            this.tableLayoutPanelEmployeeHealthData.RowCount = 3;
            this.tableLayoutPanelEmployeeHealthData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelEmployeeHealthData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.120434F));
            this.tableLayoutPanelEmployeeHealthData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.7463F));
            this.tableLayoutPanelEmployeeHealthData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelEmployeeHealthData.Size = new System.Drawing.Size(1997, 1015);
            this.tableLayoutPanelEmployeeHealthData.TabIndex = 19;
            // 
            // treeViewLabel
            // 
            this.treeViewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewLabel.AutoSize = true;
            this.treeViewLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewLabel.Location = new System.Drawing.Point(5, 13);
            this.treeViewLabel.Name = "treeViewLabel";
            this.treeViewLabel.Size = new System.Drawing.Size(157, 39);
            this.treeViewLabel.TabIndex = 28;
            this.treeViewLabel.Text = "Tree View";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hasAbnormalSymptomFilterCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.visitHubeiFilterCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.viewSuspectedCaseCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(366, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1626, 55);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // hasAbnormalSymptomFilterCheckBox
            // 
            this.hasAbnormalSymptomFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hasAbnormalSymptomFilterCheckBox.AutoSize = true;
            this.hasAbnormalSymptomFilterCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hasAbnormalSymptomFilterCheckBox.ForeColor = System.Drawing.Color.Black;
            this.hasAbnormalSymptomFilterCheckBox.Location = new System.Drawing.Point(3, 3);
            this.hasAbnormalSymptomFilterCheckBox.Name = "hasAbnormalSymptomFilterCheckBox";
            this.hasAbnormalSymptomFilterCheckBox.Size = new System.Drawing.Size(484, 46);
            this.hasAbnormalSymptomFilterCheckBox.TabIndex = 3;
            this.hasAbnormalSymptomFilterCheckBox.TabStop = false;
            this.hasAbnormalSymptomFilterCheckBox.Text = "View Has Abnormal Symptom";
            this.hasAbnormalSymptomFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // visitHubeiFilterCheckBox
            // 
            this.visitHubeiFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitHubeiFilterCheckBox.AutoSize = true;
            this.visitHubeiFilterCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitHubeiFilterCheckBox.ForeColor = System.Drawing.Color.Black;
            this.visitHubeiFilterCheckBox.Location = new System.Drawing.Point(493, 3);
            this.visitHubeiFilterCheckBox.Name = "visitHubeiFilterCheckBox";
            this.visitHubeiFilterCheckBox.Size = new System.Drawing.Size(333, 46);
            this.visitHubeiFilterCheckBox.TabIndex = 3;
            this.visitHubeiFilterCheckBox.TabStop = false;
            this.visitHubeiFilterCheckBox.Text = "View Visited Hubei ";
            this.visitHubeiFilterCheckBox.UseVisualStyleBackColor = true;
            this.visitHubeiFilterCheckBox.CheckedChanged += new System.EventHandler(this.VisitHubeiFilterCheckBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(1209, 3);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(276, 46);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // treeViewComboBox
            // 
            this.treeViewComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewComboBox.FormattingEnabled = true;
            this.treeViewComboBox.Items.AddRange(new object[] {
            "Date TreeView",
            "Name & Gin Number TreeView"});
            this.treeViewComboBox.Location = new System.Drawing.Point(5, 57);
            this.treeViewComboBox.Name = "treeViewComboBox";
            this.treeViewComboBox.Size = new System.Drawing.Size(353, 43);
            this.treeViewComboBox.TabIndex = 27;
            this.treeViewComboBox.Text = "Choose TreeView ";
            this.treeViewComboBox.SelectedIndexChanged += new System.EventHandler(this.TreeViewComboBox_SelectedIndexChanged);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(5, 120);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(353, 890);
            this.treeView.TabIndex = 3;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
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
            this.mainMenuStrip.Size = new System.Drawing.Size(2003, 49);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.TabStop = true;
            this.mainMenuStrip.Text = "Add";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.AccessibleName = "";
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.addToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(438, 54);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToFileToolStripMenuItem.Image")));
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(438, 54);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(92, 45);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem1.Image")));
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(423, 54);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem2.Image")));
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(423, 54);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(423, 54);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckOnClick = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeHealthDataToolStripMenuItem,
            this.viewCurrentStatusToolStripMenuItem,
            this.viewToolBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(106, 45);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // viewEmployeeHealthDataToolStripMenuItem
            // 
            this.viewEmployeeHealthDataToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewEmployeeHealthDataToolStripMenuItem.Name = "viewEmployeeHealthDataToolStripMenuItem";
            this.viewEmployeeHealthDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.viewEmployeeHealthDataToolStripMenuItem.Size = new System.Drawing.Size(663, 54);
            this.viewEmployeeHealthDataToolStripMenuItem.Text = "View Employee Health Data";
            this.viewEmployeeHealthDataToolStripMenuItem.Click += new System.EventHandler(this.ViewEmployeeHealthDataToolStripMenuItem_Click);
            // 
            // viewCurrentStatusToolStripMenuItem
            // 
            this.viewCurrentStatusToolStripMenuItem.Checked = true;
            this.viewCurrentStatusToolStripMenuItem.CheckOnClick = true;
            this.viewCurrentStatusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewCurrentStatusToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewCurrentStatusToolStripMenuItem.Name = "viewCurrentStatusToolStripMenuItem";
            this.viewCurrentStatusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.viewCurrentStatusToolStripMenuItem.Size = new System.Drawing.Size(663, 54);
            this.viewCurrentStatusToolStripMenuItem.Text = "View Status Bar";
            this.viewCurrentStatusToolStripMenuItem.Click += new System.EventHandler(this.ViewCurrentStatusToolStripMenuItem_Click);
            // 
            // viewToolBarToolStripMenuItem
            // 
            this.viewToolBarToolStripMenuItem.Checked = true;
            this.viewToolBarToolStripMenuItem.CheckOnClick = true;
            this.viewToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolBarToolStripMenuItem.Name = "viewToolBarToolStripMenuItem";
            this.viewToolBarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.viewToolBarToolStripMenuItem.Size = new System.Drawing.Size(663, 54);
            this.viewToolBarToolStripMenuItem.Text = "View Tool Bar";
            this.viewToolBarToolStripMenuItem.Click += new System.EventHandler(this.ViewToolBarToolStripMenuItem_Click);
            // 
            // openFileToolStripButton
            // 
            this.openFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripButton.Image")));
            this.openFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripButton.Name = "openFileToolStripButton";
            this.openFileToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.openFileToolStripButton.Size = new System.Drawing.Size(189, 56);
            this.openFileToolStripButton.Text = "Open File";
            this.openFileToolStripButton.ToolTipText = "Open File (Ctrl+O)";
            this.openFileToolStripButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.saveToolStripButton.Size = new System.Drawing.Size(215, 56);
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
            this.searchToolStripTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.searchToolStripTextBox.Size = new System.Drawing.Size(470, 63);
            this.searchToolStripTextBox.Text = "Search By Gin Number (Ctrl+Q)";
            this.searchToolStripTextBox.Enter += new System.EventHandler(this.SearchToolStripTextBox_Enter);
            this.searchToolStripTextBox.Leave += new System.EventHandler(this.SearchToolStripTextBox_Leave);
            this.searchToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchToolStripTextBox_KeyDownEnter);
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.addToolStripButton.Size = new System.Drawing.Size(117, 56);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.ToolTipText = "Add (Ctrl+Shift+A)";
            this.addToolStripButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.editToolStripButton.Size = new System.Drawing.Size(112, 56);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.ToolTipText = "Edit (Ctrl+E)";
            this.editToolStripButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.deleteToolStripButton.Size = new System.Drawing.Size(148, 56);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.ToolTipText = "Delete (Del)";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.AutoSize = false;
            this.mainMenuToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripButton,
            this.saveToolStripButton,
            this.addToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.searchToolStripTextBox,
            this.clearFilterToolStripButton});
            this.mainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            this.mainMenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuToolStrip.Size = new System.Drawing.Size(2003, 63);
            this.mainMenuToolStrip.TabIndex = 3;
            this.mainMenuToolStrip.TabStop = true;
            this.mainMenuToolStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchToolStripTextBox_KeyDownEnter);
            // 
            // clearFilterToolStripButton
            // 
            this.clearFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearFilterToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearFilterToolStripButton.Image")));
            this.clearFilterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearFilterToolStripButton.Name = "clearFilterToolStripButton";
            this.clearFilterToolStripButton.Size = new System.Drawing.Size(162, 56);
            this.clearFilterToolStripButton.Text = "Clear Filter";
            this.clearFilterToolStripButton.Click += new System.EventHandler(this.ClearFilterToolStripButton_Click);
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.ColumnCount = 1;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBase.Controls.Add(this.mainMenuToolStrip, 0, 0);
            this.tableLayoutPanelBase.Controls.Add(this.tableLayoutPanelEmployeeHealthData, 0, 1);
            this.tableLayoutPanelBase.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            this.tableLayoutPanelBase.RowCount = 3;
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.32355F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.676443F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(2003, 1146);
            this.tableLayoutPanelBase.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 1087);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1997, 56);
            this.panel1.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09768F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1997, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHide,
            this.hideStatusBar,
            this.currentStatusToolStripStatusLabel,
            this.warningToolStripStatusLabel1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1395, 53);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHide
            // 
            this.toolStripStatusLabelHide.Name = "toolStripStatusLabelHide";
            this.toolStripStatusLabelHide.Size = new System.Drawing.Size(0, 40);
            // 
            // hideStatusBar
            // 
            this.hideStatusBar.Image = ((System.Drawing.Image)(resources.GetObject("hideStatusBar.Image")));
            this.hideStatusBar.Name = "hideStatusBar";
            this.hideStatusBar.Size = new System.Drawing.Size(66, 40);
            this.hideStatusBar.Text = " ";
            this.hideStatusBar.ToolTipText = "Hide Status Bar";
            this.hideStatusBar.Click += new System.EventHandler(this.HideStatusBar_Click);
            // 
            // currentStatusToolStripStatusLabel
            // 
            this.currentStatusToolStripStatusLabel.Name = "currentStatusToolStripStatusLabel";
            this.currentStatusToolStripStatusLabel.Size = new System.Drawing.Size(106, 40);
            this.currentStatusToolStripStatusLabel.Text = "Ready";
            this.currentStatusToolStripStatusLabel.ToolTipText = "Status";
            // 
            // warningToolStripStatusLabel1
            // 
            this.warningToolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("warningToolStripStatusLabel1.Image")));
            this.warningToolStripStatusLabel1.Name = "warningToolStripStatusLabel1";
            this.warningToolStripStatusLabel1.Size = new System.Drawing.Size(172, 40);
            this.warningToolStripStatusLabel1.Text = "warning";
            this.warningToolStripStatusLabel1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 40);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 40);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripStatusLabel2,
            this.toolStripStatus2LabelAppName});
            this.statusStrip2.Location = new System.Drawing.Point(1395, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(602, 52);
            this.statusStrip2.TabIndex = 28;
            // 
            // sizeToolStripStatusLabel2
            // 
            this.sizeToolStripStatusLabel2.Name = "sizeToolStripStatusLabel2";
            this.sizeToolStripStatusLabel2.Size = new System.Drawing.Size(250, 39);
            this.sizeToolStripStatusLabel2.Text = "Size: 1699, 1283";
            // 
            // toolStripStatus2LabelAppName
            // 
            this.toolStripStatus2LabelAppName.Name = "toolStripStatus2LabelAppName";
            this.toolStripStatus2LabelAppName.Size = new System.Drawing.Size(235, 39);
            this.toolStripStatus2LabelAppName.Text = "Health Monitor";
            // 
            // mainMenuToolStripStatusLabel2
            // 
            this.mainMenuToolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.mainMenuToolStripStatusLabel2.Name = "mainMenuToolStripStatusLabel2";
            this.mainMenuToolStripStatusLabel2.Size = new System.Drawing.Size(0, 39);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2003, 1195);
            this.Controls.Add(this.tableLayoutPanelBase);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Monitor";
            this.SizeChanged += new System.EventHandler(this.MainMenuForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenuForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanelEmployeeHealthData.ResumeLayout(false);
            this.tableLayoutPanelEmployeeHealthData.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainMenuToolStrip.ResumeLayout(false);
            this.mainMenuToolStrip.PerformLayout();
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource healthDatabaseBindingSource;
        private System.Windows.Forms.Label employeeHealthDataLabel;
        private System.Windows.Forms.CheckBox viewSuspectedCaseCheckBox;
        private System.Windows.Forms.DataGridView healthDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmployeeHealthData;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.CheckBox visitHubeiFilterCheckBox;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeHealthDataToolStripMenuItem;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel mainMenuToolStripStatusLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel sizeToolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus2LabelAppName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHide;
        private System.Windows.Forms.ToolStripStatusLabel currentStatusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel warningToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem viewToolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel hideStatusBar;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ComboBox treeViewComboBox;
        private System.Windows.Forms.Label treeViewLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolStripButton clearFilterToolStripButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox hasAbnormalSymptomFilterCheckBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
    }
}