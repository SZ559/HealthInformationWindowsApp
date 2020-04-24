namespace WindowsApp
{
    partial class OverlapedHealthInformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlapedHealthInformationForm));
            this.originalPersonDataGridView2 = new System.Windows.Forms.DataGridView();
            this.ginNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitedHebei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAbnormalSymptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedPersonDataGridView = new System.Windows.Forms.DataGridView();
            this.ginNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitedHubei2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAbnormalSymptom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.overwriteAllButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.skipAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalPersonDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatedPersonDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalPersonDataGridView2
            // 
            this.originalPersonDataGridView2.AllowUserToAddRows = false;
            this.originalPersonDataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.originalPersonDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.originalPersonDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.originalPersonDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.originalPersonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originalPersonDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ginNumber,
            this.lastName,
            this.firstName,
            this.date,
            this.visitedHebei,
            this.hasAbnormalSymptom,
            this.temperature});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.originalPersonDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.originalPersonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPersonDataGridView2.Location = new System.Drawing.Point(3, 42);
            this.originalPersonDataGridView2.MultiSelect = false;
            this.originalPersonDataGridView2.Name = "originalPersonDataGridView2";
            this.originalPersonDataGridView2.ReadOnly = true;
            this.originalPersonDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.originalPersonDataGridView2.RowTemplate.Height = 44;
            this.originalPersonDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.originalPersonDataGridView2.Size = new System.Drawing.Size(1409, 431);
            this.originalPersonDataGridView2.TabIndex = 3;
            this.originalPersonDataGridView2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.originalPersonDataGridView2_Scroll);
            this.originalPersonDataGridView2.SelectionChanged += new System.EventHandler(this.originalPersonDataGridView2_SelectionChanged);
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
            this.firstName.MinimumWidth = 12;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 12;
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
            this.temperature.HeaderText = "Temperature";
            this.temperature.MinimumWidth = 12;
            this.temperature.Name = "temperature";
            this.temperature.ReadOnly = true;
            // 
            // updatedPersonDataGridView
            // 
            this.updatedPersonDataGridView.AllowUserToAddRows = false;
            this.updatedPersonDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updatedPersonDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.updatedPersonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updatedPersonDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.updatedPersonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedPersonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ginNumber2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.date2,
            this.visitedHubei2,
            this.hasAbnormalSymptom2,
            this.temperature2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.updatedPersonDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.updatedPersonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatedPersonDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.updatedPersonDataGridView.Location = new System.Drawing.Point(3, 42);
            this.updatedPersonDataGridView.MultiSelect = false;
            this.updatedPersonDataGridView.Name = "updatedPersonDataGridView";
            this.updatedPersonDataGridView.ReadOnly = true;
            this.updatedPersonDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.updatedPersonDataGridView.RowTemplate.Height = 44;
            this.updatedPersonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updatedPersonDataGridView.Size = new System.Drawing.Size(1409, 431);
            this.updatedPersonDataGridView.TabIndex = 4;
            // 
            // ginNumber2
            // 
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
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // date2
            // 
            this.date2.HeaderText = "Date";
            this.date2.MinimumWidth = 12;
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
            this.temperature2.HeaderText = "Temperature";
            this.temperature2.MinimumWidth = 12;
            this.temperature2.Name = "temperature2";
            this.temperature2.ReadOnly = true;
            // 
            // overwriteButton
            // 
            this.overwriteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.overwriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overwriteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overwriteButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.overwriteButton.Location = new System.Drawing.Point(60, 1032);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(280, 60);
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
            this.overwriteAllButton.Location = new System.Drawing.Point(812, 1032);
            this.overwriteAllButton.Name = "overwriteAllButton";
            this.overwriteAllButton.Size = new System.Drawing.Size(280, 60);
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
            this.skipButton.Location = new System.Drawing.Point(436, 1032);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(280, 60);
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
            this.skipAllButton.Location = new System.Drawing.Point(1188, 1032);
            this.skipAllButton.Name = "skipAllButton";
            this.skipAllButton.Size = new System.Drawing.Size(280, 60);
            this.skipAllButton.TabIndex = 11;
            this.skipAllButton.Text = "Skip All";
            this.skipAllButton.UseVisualStyleBackColor = false;
            this.skipAllButton.Click += new System.EventHandler(this.skipAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.originalPersonDataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(57, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1415, 476);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Updated Health Records";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updatedPersonDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(57, 524);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1415, 476);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Original Health Records";
            // 
            // OverlapedHealthInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 1121);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.skipAllButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.overwriteAllButton);
            this.Controls.Add(this.overwriteButton);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverlapedHealthInformationForm";
            this.Text = "Repeated Health Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForAddAndEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.originalPersonDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatedPersonDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView originalPersonDataGridView2;
        private System.Windows.Forms.DataGridView updatedPersonDataGridView;
        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button overwriteAllButton;
        private System.Windows.Forms.Button skipButton;
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
        private System.Windows.Forms.Button skipAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}