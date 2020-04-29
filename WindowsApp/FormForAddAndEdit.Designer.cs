using System;

namespace WindowsApp
{
    partial class FormForAddAndEdit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ginNumberLabel = new System.Windows.Forms.Label();
            this.ginNumberTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.visitHubeiLabel = new System.Windows.Forms.Label();
            this.hasAbnormalSymptomLabel = new System.Windows.Forms.Label();
            this.temepratureLabel = new System.Windows.Forms.Label();
            this.temperatureTextbox = new System.Windows.Forms.TextBox();
            this.errorGinNumber = new System.Windows.Forms.Label();
            this.errorFirstName = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.errorVisitHubei = new System.Windows.Forms.Label();
            this.errorAbnormalSymptom = new System.Windows.Forms.Label();
            this.errorTemperature = new System.Windows.Forms.Label();
            this.addConfirmButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.visitHubeiYesRadioButton = new System.Windows.Forms.RadioButton();
            this.hasAbnormalSymptomYesRadioButton = new System.Windows.Forms.RadioButton();
            this.hasAbnormalSymptomNoRadioButton = new System.Windows.Forms.RadioButton();
            this.visitHubeiNoRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.errorLastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ginNumberLabel
            // 
            this.ginNumberLabel.AutoSize = true;
            this.ginNumberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ginNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ginNumberLabel.Location = new System.Drawing.Point(184, 65);
            this.ginNumberLabel.Name = "ginNumberLabel";
            this.ginNumberLabel.Size = new System.Drawing.Size(198, 39);
            this.ginNumberLabel.TabIndex = 3;
            this.ginNumberLabel.Text = "Gin Number:";
            // 
            // ginNumberTextbox
            // 
            this.ginNumberTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ginNumberTextbox.Location = new System.Drawing.Point(394, 62);
            this.ginNumberTextbox.Name = "ginNumberTextbox";
            this.ginNumberTextbox.Size = new System.Drawing.Size(462, 46);
            this.ginNumberTextbox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstNameTextBox.Location = new System.Drawing.Point(394, 165);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(462, 46);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // visitHubeiLabel
            // 
            this.visitHubeiLabel.AutoSize = true;
            this.visitHubeiLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitHubeiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.visitHubeiLabel.Location = new System.Drawing.Point(36, 479);
            this.visitHubeiLabel.Name = "visitHubeiLabel";
            this.visitHubeiLabel.Size = new System.Drawing.Size(346, 39);
            this.visitHubeiLabel.TabIndex = 6;
            this.visitHubeiLabel.Text = "Visited Hubei Recently:";
            // 
            // hasAbnormalSymptomLabel
            // 
            this.hasAbnormalSymptomLabel.AutoSize = true;
            this.hasAbnormalSymptomLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasAbnormalSymptomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hasAbnormalSymptomLabel.Location = new System.Drawing.Point(7, 585);
            this.hasAbnormalSymptomLabel.Name = "hasAbnormalSymptomLabel";
            this.hasAbnormalSymptomLabel.Size = new System.Drawing.Size(375, 39);
            this.hasAbnormalSymptomLabel.TabIndex = 9;
            this.hasAbnormalSymptomLabel.Text = "Has Abnormal Symptom:";
            // 
            // temepratureLabel
            // 
            this.temepratureLabel.AutoSize = true;
            this.temepratureLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temepratureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.temepratureLabel.Location = new System.Drawing.Point(93, 689);
            this.temepratureLabel.Name = "temepratureLabel";
            this.temepratureLabel.Size = new System.Drawing.Size(289, 39);
            this.temepratureLabel.TabIndex = 12;
            this.temepratureLabel.Text = "Body Temperature:";
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperatureTextbox.Location = new System.Drawing.Point(394, 686);
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(462, 46);
            this.temperatureTextbox.TabIndex = 6;
            // 
            // errorGinNumber
            // 
            this.errorGinNumber.AutoSize = true;
            this.errorGinNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGinNumber.ForeColor = System.Drawing.Color.Red;
            this.errorGinNumber.Location = new System.Drawing.Point(390, 114);
            this.errorGinNumber.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorGinNumber.Name = "errorGinNumber";
            this.errorGinNumber.Size = new System.Drawing.Size(470, 39);
            this.errorGinNumber.TabIndex = 15;
            this.errorGinNumber.Text = "Gin Number must be an integer";
            this.errorGinNumber.Visible = false;
            // 
            // errorFirstName
            // 
            this.errorFirstName.AutoSize = true;
            this.errorFirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFirstName.ForeColor = System.Drawing.Color.Red;
            this.errorFirstName.Location = new System.Drawing.Point(390, 217);
            this.errorFirstName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorFirstName.Name = "errorFirstName";
            this.errorFirstName.Size = new System.Drawing.Size(424, 39);
            this.errorFirstName.TabIndex = 16;
            this.errorFirstName.Text = "First Name cannot be empty";
            this.errorFirstName.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.closeButton.Location = new System.Drawing.Point(705, 789);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 60);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // errorVisitHubei
            // 
            this.errorVisitHubei.AutoSize = true;
            this.errorVisitHubei.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorVisitHubei.ForeColor = System.Drawing.Color.Red;
            this.errorVisitHubei.Location = new System.Drawing.Point(390, 529);
            this.errorVisitHubei.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorVisitHubei.Name = "errorVisitHubei";
            this.errorVisitHubei.Size = new System.Drawing.Size(397, 39);
            this.errorVisitHubei.TabIndex = 19;
            this.errorVisitHubei.Text = "This field cannot be empty";
            this.errorVisitHubei.Visible = false;
            // 
            // errorAbnormalSymptom
            // 
            this.errorAbnormalSymptom.AutoSize = true;
            this.errorAbnormalSymptom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAbnormalSymptom.ForeColor = System.Drawing.Color.Red;
            this.errorAbnormalSymptom.Location = new System.Drawing.Point(390, 635);
            this.errorAbnormalSymptom.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorAbnormalSymptom.Name = "errorAbnormalSymptom";
            this.errorAbnormalSymptom.Size = new System.Drawing.Size(397, 39);
            this.errorAbnormalSymptom.TabIndex = 20;
            this.errorAbnormalSymptom.Text = "This field cannot be empty";
            this.errorAbnormalSymptom.Visible = false;
            // 
            // errorTemperature
            // 
            this.errorTemperature.AutoSize = true;
            this.errorTemperature.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTemperature.ForeColor = System.Drawing.Color.Red;
            this.errorTemperature.Location = new System.Drawing.Point(390, 741);
            this.errorTemperature.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorTemperature.Name = "errorTemperature";
            this.errorTemperature.Size = new System.Drawing.Size(380, 39);
            this.errorTemperature.TabIndex = 17;
            this.errorTemperature.Text = "Invalid body temperature";
            this.errorTemperature.Visible = false;
            // 
            // addConfirmButton
            // 
            this.addConfirmButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addConfirmButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addConfirmButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addConfirmButton.Location = new System.Drawing.Point(397, 789);
            this.addConfirmButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.addConfirmButton.Name = "addConfirmButton";
            this.addConfirmButton.Size = new System.Drawing.Size(150, 60);
            this.addConfirmButton.TabIndex = 7;
            this.addConfirmButton.Text = "Add";
            this.addConfirmButton.UseVisualStyleBackColor = false;
            this.addConfirmButton.Click += new System.EventHandler(this.AddSaveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clearButton.Location = new System.Drawing.Point(551, 789);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 60);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // visitHubeiYesRadioButton
            // 
            this.visitHubeiYesRadioButton.AutoSize = true;
            this.visitHubeiYesRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitHubeiYesRadioButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.visitHubeiYesRadioButton.Location = new System.Drawing.Point(3, 3);
            this.visitHubeiYesRadioButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.visitHubeiYesRadioButton.Name = "visitHubeiYesRadioButton";
            this.visitHubeiYesRadioButton.Size = new System.Drawing.Size(103, 43);
            this.visitHubeiYesRadioButton.TabIndex = 2;
            this.visitHubeiYesRadioButton.TabStop = true;
            this.visitHubeiYesRadioButton.Text = "Yes";
            this.visitHubeiYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // hasAbnormalSymptomYesRadioButton
            // 
            this.hasAbnormalSymptomYesRadioButton.AutoSize = true;
            this.hasAbnormalSymptomYesRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasAbnormalSymptomYesRadioButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hasAbnormalSymptomYesRadioButton.Location = new System.Drawing.Point(3, 3);
            this.hasAbnormalSymptomYesRadioButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.hasAbnormalSymptomYesRadioButton.Name = "hasAbnormalSymptomYesRadioButton";
            this.hasAbnormalSymptomYesRadioButton.Size = new System.Drawing.Size(103, 43);
            this.hasAbnormalSymptomYesRadioButton.TabIndex = 4;
            this.hasAbnormalSymptomYesRadioButton.TabStop = true;
            this.hasAbnormalSymptomYesRadioButton.Text = "Yes";
            this.hasAbnormalSymptomYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // hasAbnormalSymptomNoRadioButton
            // 
            this.hasAbnormalSymptomNoRadioButton.AutoSize = true;
            this.hasAbnormalSymptomNoRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasAbnormalSymptomNoRadioButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hasAbnormalSymptomNoRadioButton.Location = new System.Drawing.Point(112, 3);
            this.hasAbnormalSymptomNoRadioButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.hasAbnormalSymptomNoRadioButton.Name = "hasAbnormalSymptomNoRadioButton";
            this.hasAbnormalSymptomNoRadioButton.Size = new System.Drawing.Size(97, 43);
            this.hasAbnormalSymptomNoRadioButton.TabIndex = 5;
            this.hasAbnormalSymptomNoRadioButton.TabStop = true;
            this.hasAbnormalSymptomNoRadioButton.Text = "No";
            this.hasAbnormalSymptomNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // visitHubeiNoRadioButton
            // 
            this.visitHubeiNoRadioButton.AutoSize = true;
            this.visitHubeiNoRadioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitHubeiNoRadioButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.visitHubeiNoRadioButton.Location = new System.Drawing.Point(112, 3);
            this.visitHubeiNoRadioButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.visitHubeiNoRadioButton.Name = "visitHubeiNoRadioButton";
            this.visitHubeiNoRadioButton.Size = new System.Drawing.Size(97, 43);
            this.visitHubeiNoRadioButton.TabIndex = 3;
            this.visitHubeiNoRadioButton.TabStop = true;
            this.visitHubeiNoRadioButton.Text = "No";
            this.visitHubeiNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteButton.Location = new System.Drawing.Point(551, 789);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 60);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.visitHubeiYesRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.visitHubeiNoRadioButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(394, 474);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 49);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.hasAbnormalSymptomYesRadioButton);
            this.flowLayoutPanel2.Controls.Add(this.hasAbnormalSymptomNoRadioButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(394, 580);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(462, 49);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(394, 371);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 46);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            // 
            // errorDateLabel
            // 
            this.errorDateLabel.AutoSize = true;
            this.errorDateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDateLabel.ForeColor = System.Drawing.Color.Red;
            this.errorDateLabel.Location = new System.Drawing.Point(390, 423);
            this.errorDateLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorDateLabel.Name = "errorDateLabel";
            this.errorDateLabel.Size = new System.Drawing.Size(397, 39);
            this.errorDateLabel.TabIndex = 22;
            this.errorDateLabel.Text = "This field cannot be empty";
            this.errorDateLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateLabel.Location = new System.Drawing.Point(290, 377);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(92, 39);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Date:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameLabel.Location = new System.Drawing.Point(203, 168);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(179, 39);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastNameLabel.Location = new System.Drawing.Point(206, 271);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(176, 39);
            this.lastNameLabel.TabIndex = 24;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lastNameTextBox.Location = new System.Drawing.Point(394, 268);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(462, 46);
            this.lastNameTextBox.TabIndex = 25;
            // 
            // errorLastName
            // 
            this.errorLastName.AutoSize = true;
            this.errorLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLastName.ForeColor = System.Drawing.Color.Red;
            this.errorLastName.Location = new System.Drawing.Point(390, 320);
            this.errorLastName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorLastName.Name = "errorLastName";
            this.errorLastName.Size = new System.Drawing.Size(421, 39);
            this.errorLastName.TabIndex = 26;
            this.errorLastName.Text = "Last Name cannot be empty";
            this.errorLastName.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLastName);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.errorDateLabel);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.ginNumberTextbox);
            this.panel1.Controls.Add(this.errorGinNumber);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.errorFirstName);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.addConfirmButton);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.errorVisitHubei);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.temepratureLabel);
            this.panel1.Controls.Add(this.hasAbnormalSymptomLabel);
            this.panel1.Controls.Add(this.visitHubeiLabel);
            this.panel1.Controls.Add(this.errorAbnormalSymptom);
            this.panel1.Controls.Add(this.ginNumberLabel);
            this.panel1.Controls.Add(this.temperatureTextbox);
            this.panel1.Controls.Add(this.errorTemperature);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 895);
            this.panel1.TabIndex = 27;
            // 
            // FormForAddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(917, 907);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "FormForAddAndEdit";
            this.Text = "Add";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForAddAndEdit_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ginNumberLabel;
        private System.Windows.Forms.TextBox ginNumberTextbox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label visitHubeiLabel;
        private System.Windows.Forms.Label hasAbnormalSymptomLabel;
        private System.Windows.Forms.Label temepratureLabel;
        private System.Windows.Forms.TextBox temperatureTextbox;
        private System.Windows.Forms.Label errorGinNumber;
        private System.Windows.Forms.Label errorFirstName;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label errorVisitHubei;
        private System.Windows.Forms.Label errorAbnormalSymptom;
        private System.Windows.Forms.Label errorTemperature;
        private System.Windows.Forms.Button addConfirmButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton visitHubeiYesRadioButton;
        private System.Windows.Forms.RadioButton hasAbnormalSymptomYesRadioButton;
        private System.Windows.Forms.RadioButton hasAbnormalSymptomNoRadioButton;
        private System.Windows.Forms.RadioButton visitHubeiNoRadioButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label errorDateLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label errorLastName;
        private System.Windows.Forms.Panel panel1;
    }
}

