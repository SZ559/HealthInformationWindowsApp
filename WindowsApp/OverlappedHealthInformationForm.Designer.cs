namespace WindowsApp
{
    partial class OverlappedHealthInformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlappedHealthInformationForm));
            this.dataGridViewOfHealthRecords = new System.Windows.Forms.DataGridView();
            this.dataGridViewOfHealthRecordsToBeOverwritten = new System.Windows.Forms.DataGridView();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.overwriteAllButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.skipAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.healthRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthRecordToBeOverwrittenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ginNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitedHebei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAbnormalSymptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ginNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitedHubei2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAbnormalSymptom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHealthRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHealthRecordsToBeOverwritten)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRecordToBeOverwrittenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOfHealthRecords
            // 
            this.dataGridViewOfHealthRecords.AllowUserToAddRows = false;
            this.dataGridViewOfHealthRecords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOfHealthRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOfHealthRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOfHealthRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOfHealthRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfHealthRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ginNumber,
            this.lastName,
            this.firstName,
            this.date,
            this.visitedHebei,
            this.hasAbnormalSymptom,
            this.temperature});
            this.dataGridViewOfHealthRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOfHealthRecords.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewOfHealthRecords.MultiSelect = false;
            this.dataGridViewOfHealthRecords.Name = "dataGridViewOfHealthRecords";
            this.dataGridViewOfHealthRecords.ReadOnly = true;
            this.dataGridViewOfHealthRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewOfHealthRecords.RowTemplate.Height = 44;
            this.dataGridViewOfHealthRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOfHealthRecords.Size = new System.Drawing.Size(1551, 431);
            this.dataGridViewOfHealthRecords.TabIndex = 3;
            this.dataGridViewOfHealthRecords.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridViewOfhealthRecordsToBeOverwritten_Scroll);
            this.dataGridViewOfHealthRecords.SelectionChanged += new System.EventHandler(this.DataGridViewOfHealthRecords_SelectionChanged);
            // 
            // dataGridViewOfHealthRecordsToBeOverwritten
            // 
            this.dataGridViewOfHealthRecordsToBeOverwritten.AllowUserToAddRows = false;
            this.dataGridViewOfHealthRecordsToBeOverwritten.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOfHealthRecordsToBeOverwritten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOfHealthRecordsToBeOverwritten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOfHealthRecordsToBeOverwritten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOfHealthRecordsToBeOverwritten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfHealthRecordsToBeOverwritten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ginNumber2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.date2,
            this.visitedHubei2,
            this.hasAbnormalSymptom2,
            this.temperature2});
            this.dataGridViewOfHealthRecordsToBeOverwritten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOfHealthRecordsToBeOverwritten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOfHealthRecordsToBeOverwritten.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewOfHealthRecordsToBeOverwritten.MultiSelect = false;
            this.dataGridViewOfHealthRecordsToBeOverwritten.Name = "dataGridViewOfHealthRecordsToBeOverwritten";
            this.dataGridViewOfHealthRecordsToBeOverwritten.ReadOnly = true;
            this.dataGridViewOfHealthRecordsToBeOverwritten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewOfHealthRecordsToBeOverwritten.RowTemplate.Height = 44;
            this.dataGridViewOfHealthRecordsToBeOverwritten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOfHealthRecordsToBeOverwritten.Size = new System.Drawing.Size(1548, 431);
            this.dataGridViewOfHealthRecordsToBeOverwritten.TabIndex = 4;
            // 
            // overwriteButton
            // 
            this.overwriteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.overwriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overwriteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overwriteButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.overwriteButton.Location = new System.Drawing.Point(54, 1025);
            this.overwriteButton.Margin = new System.Windows.Forms.Padding(0);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(280, 73);
            this.overwriteButton.TabIndex = 8;
            this.overwriteButton.Text = "Overwrite";
            this.overwriteButton.UseVisualStyleBackColor = false;
            this.overwriteButton.Click += new System.EventHandler(this.OverwriteButton_Click);
            // 
            // overwriteAllButton
            // 
            this.overwriteAllButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.overwriteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overwriteAllButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overwriteAllButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.overwriteAllButton.Location = new System.Drawing.Point(898, 1025);
            this.overwriteAllButton.Margin = new System.Windows.Forms.Padding(0);
            this.overwriteAllButton.Name = "overwriteAllButton";
            this.overwriteAllButton.Size = new System.Drawing.Size(280, 73);
            this.overwriteAllButton.TabIndex = 9;
            this.overwriteAllButton.Text = "Overwrite All";
            this.overwriteAllButton.UseVisualStyleBackColor = false;
            this.overwriteAllButton.Click += new System.EventHandler(this.OverwriteAllButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.skipButton.Location = new System.Drawing.Point(476, 1025);
            this.skipButton.Margin = new System.Windows.Forms.Padding(0);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(280, 73);
            this.skipButton.TabIndex = 10;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // skipAllButton
            // 
            this.skipAllButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skipAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipAllButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipAllButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.skipAllButton.Location = new System.Drawing.Point(1320, 1025);
            this.skipAllButton.Margin = new System.Windows.Forms.Padding(0);
            this.skipAllButton.Name = "skipAllButton";
            this.skipAllButton.Size = new System.Drawing.Size(280, 73);
            this.skipAllButton.TabIndex = 11;
            this.skipAllButton.Text = "Skip All";
            this.skipAllButton.UseVisualStyleBackColor = false;
            this.skipAllButton.Click += new System.EventHandler(this.SkipAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewOfHealthRecords);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(51, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1557, 476);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Health Records ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOfHealthRecordsToBeOverwritten);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(51, 517);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1554, 476);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Health Records To Be Overwritten";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.skipAllButton);
            this.panel1.Controls.Add(this.skipButton);
            this.panel1.Controls.Add(this.overwriteAllButton);
            this.panel1.Controls.Add(this.overwriteButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 1126);
            this.panel1.TabIndex = 14;
            // 
            // ginNumber
            // 
            this.ginNumber.HeaderText = "Gin Number";
            this.ginNumber.MinimumWidth = 12;
            this.ginNumber.Name = "ginNumber";
            this.ginNumber.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "LastName";
            this.lastName.MinimumWidth = 12;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // visitedHebei
            // 
            this.visitedHebei.HeaderText = "Visited Hubei Recently";
            this.visitedHebei.MinimumWidth = 12;
            this.visitedHebei.Name = "visitedHebei";
            this.visitedHebei.ReadOnly = true;
            // 
            // hasAbnormalSymptom
            // 
            this.hasAbnormalSymptom.HeaderText = "Has Abnormal Symptom";
            this.hasAbnormalSymptom.MinimumWidth = 12;
            this.hasAbnormalSymptom.Name = "hasAbnormalSymptom";
            this.hasAbnormalSymptom.ReadOnly = true;
            // 
            // temperature
            // 
            this.temperature.HeaderText = "Body Temperature";
            this.temperature.MinimumWidth = 14;
            this.temperature.Name = "temperature";
            this.temperature.ReadOnly = true;
            // 
            // ginNumber2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ginNumber2.DefaultCellStyle = dataGridViewCellStyle3;
            this.ginNumber2.HeaderText = "Gin Number";
            this.ginNumber2.MinimumWidth = 12;
            this.ginNumber2.Name = "ginNumber2";
            this.ginNumber2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // date2
            // 
            this.date2.HeaderText = "Date";
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            // 
            // visitedHubei2
            // 
            this.visitedHubei2.HeaderText = "Visited Hubei Recently";
            this.visitedHubei2.MinimumWidth = 12;
            this.visitedHubei2.Name = "visitedHubei2";
            this.visitedHubei2.ReadOnly = true;
            // 
            // hasAbnormalSymptom2
            // 
            this.hasAbnormalSymptom2.HeaderText = "Has Abnormal Symptom";
            this.hasAbnormalSymptom2.MinimumWidth = 12;
            this.hasAbnormalSymptom2.Name = "hasAbnormalSymptom2";
            this.hasAbnormalSymptom2.ReadOnly = true;
            // 
            // temperature2
            // 
            this.temperature2.HeaderText = "Body Temperature";
            this.temperature2.MinimumWidth = 14;
            this.temperature2.Name = "temperature2";
            this.temperature2.ReadOnly = true;
            // 
            // OverlappedHealthInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1676, 1145);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverlappedHealthInformationForm";
            this.Text = "Repeated Health Records";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForAddAndEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHealthRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHealthRecordsToBeOverwritten)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRecordToBeOverwrittenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewOfHealthRecords;
        private System.Windows.Forms.DataGridView dataGridViewOfHealthRecordsToBeOverwritten;
        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button overwriteAllButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button skipAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource healthRecordBindingSource;
        private System.Windows.Forms.BindingSource healthRecordToBeOverwrittenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ginNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitedHebei;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasAbnormalSymptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ginNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitedHubei2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasAbnormalSymptom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature2;
    }
}