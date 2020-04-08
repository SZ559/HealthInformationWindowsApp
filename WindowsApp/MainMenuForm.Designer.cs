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
            this.addButton = new System.Windows.Forms.Button();
            this.importFromFileButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.databasePanel = new System.Windows.Forms.Panel();
            this.dataGirdViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.displaySuspectedCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.healthDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeHealthDataLabel = new System.Windows.Forms.Label();
            this.suspectedCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ginNumberTextBox = new System.Windows.Forms.TextBox();
            this.ginNumberLabel = new System.Windows.Forms.Label();
            this.errorGinNumberLabel = new System.Windows.Forms.Label();
            this.errorCannotFindGinNumberLabel = new System.Windows.Forms.Label();
            this.databasePanel.SuspendLayout();
            this.dataGirdViewTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspectedCaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addButton.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(1961, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(412, 53);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // importFromFileButton
            // 
            this.importFromFileButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.importFromFileButton.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFromFileButton.Location = new System.Drawing.Point(1961, 489);
            this.importFromFileButton.Name = "importFromFileButton";
            this.importFromFileButton.Size = new System.Drawing.Size(412, 63);
            this.importFromFileButton.TabIndex = 3;
            this.importFromFileButton.Text = "Import From File";
            this.importFromFileButton.UseVisualStyleBackColor = false;
            this.importFromFileButton.Click += new System.EventHandler(this.InputFromFileButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveToFileButton.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToFileButton.Location = new System.Drawing.Point(1961, 601);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(412, 63);
            this.saveToFileButton.TabIndex = 4;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = false;
            this.saveToFileButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            // 
            // databasePanel
            // 
            this.databasePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.databasePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.databasePanel.Controls.Add(this.dataGirdViewTableLayoutPanel);
            this.databasePanel.Location = new System.Drawing.Point(12, 68);
            this.databasePanel.Name = "databasePanel";
            this.databasePanel.Size = new System.Drawing.Size(1876, 1262);
            this.databasePanel.TabIndex = 9;
            // 
            // dataGirdViewTableLayoutPanel
            // 
            this.dataGirdViewTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dataGirdViewTableLayoutPanel.ColumnCount = 1;
            this.dataGirdViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataGirdViewTableLayoutPanel.Controls.Add(this.displaySuspectedCaseCheckBox, 0, 2);
            this.dataGirdViewTableLayoutPanel.Controls.Add(this.healthDataGridView, 0, 1);
            this.dataGirdViewTableLayoutPanel.Controls.Add(this.employeeHealthDataLabel, 0, 0);
            this.dataGirdViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGirdViewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dataGirdViewTableLayoutPanel.Name = "dataGirdViewTableLayoutPanel";
            this.dataGirdViewTableLayoutPanel.RowCount = 3;
            this.dataGirdViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.dataGirdViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.dataGirdViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.dataGirdViewTableLayoutPanel.Size = new System.Drawing.Size(1872, 1258);
            this.dataGirdViewTableLayoutPanel.TabIndex = 0;
            // 
            // displaySuspectedCaseCheckBox
            // 
            this.displaySuspectedCaseCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displaySuspectedCaseCheckBox.AutoSize = true;
            this.displaySuspectedCaseCheckBox.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySuspectedCaseCheckBox.ForeColor = System.Drawing.Color.Black;
            this.displaySuspectedCaseCheckBox.Location = new System.Drawing.Point(1352, 1209);
            this.displaySuspectedCaseCheckBox.Name = "displaySuspectedCaseCheckBox";
            this.displaySuspectedCaseCheckBox.Size = new System.Drawing.Size(516, 45);
            this.displaySuspectedCaseCheckBox.TabIndex = 18;
            this.displaySuspectedCaseCheckBox.Text = "Display Suspected Cases";
            this.displaySuspectedCaseCheckBox.UseVisualStyleBackColor = true;
            this.displaySuspectedCaseCheckBox.CheckedChanged += new System.EventHandler(this.DisplaySuspectedCaseCheckBox_CheckedChanged);
            // 
            // healthDataGridView
            // 
            this.healthDataGridView.AllowUserToAddRows = false;
            this.healthDataGridView.AllowUserToDeleteRows = false;
            this.healthDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.healthDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.healthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.healthDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthDataGridView.Location = new System.Drawing.Point(4, 55);
            this.healthDataGridView.MultiSelect = false;
            this.healthDataGridView.Name = "healthDataGridView";
            this.healthDataGridView.ReadOnly = true;
            this.healthDataGridView.RowHeadersWidth = 10;
            this.healthDataGridView.RowTemplate.Height = 44;
            this.healthDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.healthDataGridView.Size = new System.Drawing.Size(1864, 1147);
            this.healthDataGridView.TabIndex = 0;
            this.healthDataGridView.SelectionChanged += new System.EventHandler(this.SelectRowChange);
            // 
            // employeeHealthDataLabel
            // 
            this.employeeHealthDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.employeeHealthDataLabel.AutoSize = true;
            this.employeeHealthDataLabel.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeHealthDataLabel.Location = new System.Drawing.Point(4, 6);
            this.employeeHealthDataLabel.Name = "employeeHealthDataLabel";
            this.employeeHealthDataLabel.Size = new System.Drawing.Size(375, 40);
            this.employeeHealthDataLabel.TabIndex = 2;
            this.employeeHealthDataLabel.Text = "Employee Health Data";
            // 
            // suspectedCaseBindingSource
            // 
            this.suspectedCaseBindingSource.AllowNew = true;
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.modifyButton.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(1961, 243);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(209, 58);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(2178, 244);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(195, 57);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ginNumberTextBox
            // 
            this.ginNumberTextBox.Location = new System.Drawing.Point(1961, 185);
            this.ginNumberTextBox.Name = "ginNumberTextBox";
            this.ginNumberTextBox.Size = new System.Drawing.Size(412, 42);
            this.ginNumberTextBox.TabIndex = 10;
            this.ginNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerCheck);
            // 
            // ginNumberLabel
            // 
            this.ginNumberLabel.AutoSize = true;
            this.ginNumberLabel.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ginNumberLabel.Location = new System.Drawing.Point(1954, 125);
            this.ginNumberLabel.Name = "ginNumberLabel";
            this.ginNumberLabel.Size = new System.Drawing.Size(369, 39);
            this.ginNumberLabel.TabIndex = 11;
            this.ginNumberLabel.Text = "Search By Gin Number:";
            // 
            // errorGinNumberLabel
            // 
            this.errorGinNumberLabel.AutoSize = true;
            this.errorGinNumberLabel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGinNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorGinNumberLabel.Location = new System.Drawing.Point(2391, 187);
            this.errorGinNumberLabel.Name = "errorGinNumberLabel";
            this.errorGinNumberLabel.Size = new System.Drawing.Size(495, 40);
            this.errorGinNumberLabel.TabIndex = 16;
            this.errorGinNumberLabel.Text = "Gin Number must be an integer";
            this.errorGinNumberLabel.Visible = false;
            // 
            // errorCannotFindGinNumberLabel
            // 
            this.errorCannotFindGinNumberLabel.AutoSize = true;
            this.errorCannotFindGinNumberLabel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCannotFindGinNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCannotFindGinNumberLabel.Location = new System.Drawing.Point(2391, 185);
            this.errorCannotFindGinNumberLabel.Name = "errorCannotFindGinNumberLabel";
            this.errorCannotFindGinNumberLabel.Size = new System.Drawing.Size(443, 40);
            this.errorCannotFindGinNumberLabel.TabIndex = 17;
            this.errorCannotFindGinNumberLabel.Text = "Cannot find the Gin Number";
            this.errorCannotFindGinNumberLabel.Visible = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3339, 1577);
            this.Controls.Add(this.errorCannotFindGinNumberLabel);
            this.Controls.Add(this.errorGinNumberLabel);
            this.Controls.Add(this.ginNumberLabel);
            this.Controls.Add(this.ginNumberTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.importFromFileButton);
            this.Controls.Add(this.databasePanel);
            this.Controls.Add(this.saveToFileButton);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.databasePanel.ResumeLayout(false);
            this.dataGirdViewTableLayoutPanel.ResumeLayout(false);
            this.dataGirdViewTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspectedCaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button importFromFileButton;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel databasePanel;
        private System.Windows.Forms.BindingSource suspectedCaseBindingSource;
        private System.Windows.Forms.BindingSource healthDatabaseBindingSource;
        private System.Windows.Forms.TableLayoutPanel dataGirdViewTableLayoutPanel;
        private System.Windows.Forms.DataGridView healthDataGridView;
        private System.Windows.Forms.Label employeeHealthDataLabel;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox ginNumberTextBox;
        private System.Windows.Forms.Label ginNumberLabel;
        private System.Windows.Forms.Label errorGinNumberLabel;
        private System.Windows.Forms.Label errorCannotFindGinNumberLabel;
        private System.Windows.Forms.CheckBox displaySuspectedCaseCheckBox;
    }
}