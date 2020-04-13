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
            this.nameLabel = new System.Windows.Forms.Label();
            this.ginNumberLabel = new System.Windows.Forms.Label();
            this.ginNumberTextbox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.visitHubeiLabel = new System.Windows.Forms.Label();
            this.hasAbnormalSymptomLabel = new System.Windows.Forms.Label();
            this.temepratureLabel = new System.Windows.Forms.Label();
            this.temperatureTextbox = new System.Windows.Forms.TextBox();
            this.errorGinNumber = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(282, 213);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 39);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // ginNumberLabel
            // 
            this.ginNumberLabel.AutoSize = true;
            this.ginNumberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ginNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ginNumberLabel.Location = new System.Drawing.Point(194, 103);
            this.ginNumberLabel.Name = "ginNumberLabel";
            this.ginNumberLabel.Size = new System.Drawing.Size(198, 39);
            this.ginNumberLabel.TabIndex = 3;
            this.ginNumberLabel.Text = "Gin Number:";
            // 
            // ginNumberTextbox
            // 
            this.ginNumberTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ginNumberTextbox.Location = new System.Drawing.Point(3, 3);
            this.ginNumberTextbox.Name = "ginNumberTextbox";
            this.ginNumberTextbox.Size = new System.Drawing.Size(462, 46);
            this.ginNumberTextbox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 113);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(462, 46);
            this.nameTextBox.TabIndex = 1;
            // 
            // visitHubeiLabel
            // 
            this.visitHubeiLabel.AutoSize = true;
            this.visitHubeiLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitHubeiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.visitHubeiLabel.Location = new System.Drawing.Point(46, 325);
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
            this.hasAbnormalSymptomLabel.Location = new System.Drawing.Point(17, 435);
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
            this.temepratureLabel.Location = new System.Drawing.Point(103, 543);
            this.temepratureLabel.Name = "temepratureLabel";
            this.temepratureLabel.Size = new System.Drawing.Size(289, 39);
            this.temepratureLabel.TabIndex = 12;
            this.temepratureLabel.Text = "Body Temperature:";
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperatureTextbox.Location = new System.Drawing.Point(3, 443);
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(462, 46);
            this.temperatureTextbox.TabIndex = 6;
            // 
            // errorGinNumber
            // 
            this.errorGinNumber.AutoSize = true;
            this.errorGinNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGinNumber.ForeColor = System.Drawing.Color.Red;
            this.errorGinNumber.Location = new System.Drawing.Point(0, 58);
            this.errorGinNumber.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorGinNumber.Name = "errorGinNumber";
            this.errorGinNumber.Size = new System.Drawing.Size(470, 39);
            this.errorGinNumber.TabIndex = 15;
            this.errorGinNumber.Text = "Gin Number must be an integer";
            this.errorGinNumber.Visible = false;
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(0, 168);
            this.errorName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(355, 39);
            this.errorName.TabIndex = 16;
            this.errorName.Text = "Name cannot be empty";
            this.errorName.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.closeButton.Location = new System.Drawing.Point(732, 655);
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
            this.errorVisitHubei.Location = new System.Drawing.Point(0, 278);
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
            this.errorAbnormalSymptom.Location = new System.Drawing.Point(0, 388);
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
            this.errorTemperature.Location = new System.Drawing.Point(0, 498);
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
            this.addConfirmButton.Location = new System.Drawing.Point(412, 655);
            this.addConfirmButton.Name = "addConfirmButton";
            this.addConfirmButton.Size = new System.Drawing.Size(150, 60);
            this.addConfirmButton.TabIndex = 7;
            this.addConfirmButton.Text = "Add";
            this.addConfirmButton.UseVisualStyleBackColor = false;
            this.addConfirmButton.Click += new System.EventHandler(this.AddConfirmButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clearButton.Location = new System.Drawing.Point(572, 655);
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
            this.deleteButton.Location = new System.Drawing.Point(572, 655);
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(565, 49);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.hasAbnormalSymptomYesRadioButton);
            this.flowLayoutPanel2.Controls.Add(this.hasAbnormalSymptomNoRadioButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 333);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(565, 49);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.temperatureTextbox, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.errorTemperature, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.errorName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.errorVisitHubei, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.errorAbnormalSymptom, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.errorGinNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ginNumberTextbox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(412, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 552);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // FormForAddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 773);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addConfirmButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.temepratureLabel);
            this.Controls.Add(this.hasAbnormalSymptomLabel);
            this.Controls.Add(this.visitHubeiLabel);
            this.Controls.Add(this.ginNumberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deleteButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "FormForAddAndEdit";
            this.Text = "Add";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ginNumberLabel;
        private System.Windows.Forms.TextBox ginNumberTextbox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label visitHubeiLabel;
        private System.Windows.Forms.Label hasAbnormalSymptomLabel;
        private System.Windows.Forms.Label temepratureLabel;
        private System.Windows.Forms.TextBox temperatureTextbox;
        private System.Windows.Forms.Label errorGinNumber;
        private System.Windows.Forms.Label errorName;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

