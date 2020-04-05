namespace WindowsApp
{
    partial class EnterForm
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
            this.visitHubeiYesCheckBox = new System.Windows.Forms.CheckBox();
            this.visitHubeiNoCheckBox = new System.Windows.Forms.CheckBox();
            this.hasAbnormalSymptomLabel = new System.Windows.Forms.Label();
            this.abnormalSymptomYesCheckBox = new System.Windows.Forms.CheckBox();
            this.abnormalSymptomNoCheckBox = new System.Windows.Forms.CheckBox();
            this.temepratureLabel = new System.Windows.Forms.Label();
            this.temperatureTextbox = new System.Windows.Forms.TextBox();
            this.errorGinNumber = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.errorVisitHubei = new System.Windows.Forms.Label();
            this.errorAbnormalSymptom = new System.Windows.Forms.Label();
            this.errorTemperature = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(433, 235);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(138, 45);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // ginNumberLabel
            // 
            this.ginNumberLabel.AutoSize = true;
            this.ginNumberLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ginNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ginNumberLabel.Location = new System.Drawing.Point(328, 133);
            this.ginNumberLabel.Name = "ginNumberLabel";
            this.ginNumberLabel.Size = new System.Drawing.Size(243, 45);
            this.ginNumberLabel.TabIndex = 3;
            this.ginNumberLabel.Text = "Gin Number:";
            // 
            // ginNumberTextbox
            // 
            this.ginNumberTextbox.Location = new System.Drawing.Point(593, 140);
            this.ginNumberTextbox.Name = "ginNumberTextbox";
            this.ginNumberTextbox.Size = new System.Drawing.Size(401, 42);
            this.ginNumberTextbox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(593, 242);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(401, 42);
            this.nameTextBox.TabIndex = 5;
            // 
            // visitHubeiLabel
            // 
            this.visitHubeiLabel.AutoSize = true;
            this.visitHubeiLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitHubeiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.visitHubeiLabel.Location = new System.Drawing.Point(148, 335);
            this.visitHubeiLabel.Name = "visitHubeiLabel";
            this.visitHubeiLabel.Size = new System.Drawing.Size(423, 45);
            this.visitHubeiLabel.TabIndex = 6;
            this.visitHubeiLabel.Text = "Visited Hubei Recently:";
            // 
            // visitHubeiYes
            // 
            this.visitHubeiYesCheckBox.AutoSize = true;
            this.visitHubeiYesCheckBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitHubeiYesCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.visitHubeiYesCheckBox.Location = new System.Drawing.Point(593, 334);
            this.visitHubeiYesCheckBox.Name = "visitHubeiYes";
            this.visitHubeiYesCheckBox.Size = new System.Drawing.Size(115, 44);
            this.visitHubeiYesCheckBox.TabIndex = 7;
            this.visitHubeiYesCheckBox.Text = "Yes";
            this.visitHubeiYesCheckBox.UseVisualStyleBackColor = true;
            this.visitHubeiYesCheckBox.CheckedChanged += new System.EventHandler(this.VisitHubeiYes_CheckedChanged);
            // 
            // visitHubeiNo
            // 
            this.visitHubeiNoCheckBox.AutoSize = true;
            this.visitHubeiNoCheckBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitHubeiNoCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.visitHubeiNoCheckBox.Location = new System.Drawing.Point(731, 334);
            this.visitHubeiNoCheckBox.Name = "visitHubeiNo";
            this.visitHubeiNoCheckBox.Size = new System.Drawing.Size(95, 44);
            this.visitHubeiNoCheckBox.TabIndex = 8;
            this.visitHubeiNoCheckBox.Text = "No";
            this.visitHubeiNoCheckBox.UseVisualStyleBackColor = true;
            this.visitHubeiNoCheckBox.CheckedChanged += new System.EventHandler(this.VisitHubeiNo_CheckedChanged);
            // 
            // hasAbnormalSymptomLabel
            // 
            this.hasAbnormalSymptomLabel.AutoSize = true;
            this.hasAbnormalSymptomLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasAbnormalSymptomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hasAbnormalSymptomLabel.Location = new System.Drawing.Point(112, 439);
            this.hasAbnormalSymptomLabel.Name = "hasAbnormalSymptomLabel";
            this.hasAbnormalSymptomLabel.Size = new System.Drawing.Size(459, 45);
            this.hasAbnormalSymptomLabel.TabIndex = 9;
            this.hasAbnormalSymptomLabel.Text = "Has Abnormal Symptom:";
            // 
            // abnormalSymptomYes
            // 
            this.abnormalSymptomYesCheckBox.AutoSize = true;
            this.abnormalSymptomYesCheckBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abnormalSymptomYesCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.abnormalSymptomYesCheckBox.Location = new System.Drawing.Point(593, 438);
            this.abnormalSymptomYesCheckBox.Name = "abnormalSymptomYes";
            this.abnormalSymptomYesCheckBox.Size = new System.Drawing.Size(115, 44);
            this.abnormalSymptomYesCheckBox.TabIndex = 10;
            this.abnormalSymptomYesCheckBox.Text = "Yes";
            this.abnormalSymptomYesCheckBox.UseVisualStyleBackColor = true;
            this.abnormalSymptomYesCheckBox.CheckedChanged += new System.EventHandler(this.HasAbnormalSymptomYes_CheckedChanged);
            // 
            // abnormalSymptomNo
            // 
            this.abnormalSymptomNoCheckBox.AutoSize = true;
            this.abnormalSymptomNoCheckBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abnormalSymptomNoCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.abnormalSymptomNoCheckBox.Location = new System.Drawing.Point(731, 439);
            this.abnormalSymptomNoCheckBox.Name = "abnormalSymptomNo";
            this.abnormalSymptomNoCheckBox.Size = new System.Drawing.Size(95, 44);
            this.abnormalSymptomNoCheckBox.TabIndex = 11;
            this.abnormalSymptomNoCheckBox.Text = "No";
            this.abnormalSymptomNoCheckBox.UseVisualStyleBackColor = true;
            this.abnormalSymptomNoCheckBox.CheckedChanged += new System.EventHandler(this.HasAbnormalSymptomNo_CheckedChanged);
            // 
            // temepratureLabel
            // 
            this.temepratureLabel.AutoSize = true;
            this.temepratureLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temepratureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.temepratureLabel.Location = new System.Drawing.Point(318, 539);
            this.temepratureLabel.Name = "temepratureLabel";
            this.temepratureLabel.Size = new System.Drawing.Size(253, 45);
            this.temepratureLabel.TabIndex = 12;
            this.temepratureLabel.Text = "Temperature:";
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Location = new System.Drawing.Point(593, 539);
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(401, 42);
            this.temperatureTextbox.TabIndex = 13;
            // 
            // errorGinNumber
            // 
            this.errorGinNumber.AutoSize = true;
            this.errorGinNumber.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGinNumber.ForeColor = System.Drawing.Color.Red;
            this.errorGinNumber.Location = new System.Drawing.Point(1020, 142);
            this.errorGinNumber.Name = "errorGinNumber";
            this.errorGinNumber.Size = new System.Drawing.Size(495, 40);
            this.errorGinNumber.TabIndex = 15;
            this.errorGinNumber.Text = "Gin Number must be an integer";
            this.errorGinNumber.Visible = false;
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(1020, 235);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(369, 40);
            this.errorName.TabIndex = 16;
            this.errorName.Text = "Name cannot be empty";
            this.errorName.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.closeButton.Location = new System.Drawing.Point(593, 785);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(407, 60);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // errorVisitHubei
            // 
            this.errorVisitHubei.AutoSize = true;
            this.errorVisitHubei.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorVisitHubei.ForeColor = System.Drawing.Color.Red;
            this.errorVisitHubei.Location = new System.Drawing.Point(1020, 324);
            this.errorVisitHubei.Name = "errorVisitHubei";
            this.errorVisitHubei.Size = new System.Drawing.Size(415, 40);
            this.errorVisitHubei.TabIndex = 19;
            this.errorVisitHubei.Text = "This field cannot be empty";
            this.errorVisitHubei.Visible = false;
            // 
            // errorAbnormalSymptom
            // 
            this.errorAbnormalSymptom.AutoSize = true;
            this.errorAbnormalSymptom.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAbnormalSymptom.ForeColor = System.Drawing.Color.Red;
            this.errorAbnormalSymptom.Location = new System.Drawing.Point(1020, 438);
            this.errorAbnormalSymptom.Name = "errorAbnormalSymptom";
            this.errorAbnormalSymptom.Size = new System.Drawing.Size(415, 40);
            this.errorAbnormalSymptom.TabIndex = 20;
            this.errorAbnormalSymptom.Text = "This field cannot be empty";
            this.errorAbnormalSymptom.Visible = false;
            // 
            // errorTemperature
            // 
            this.errorTemperature.AutoSize = true;
            this.errorTemperature.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTemperature.ForeColor = System.Drawing.Color.Red;
            this.errorTemperature.Location = new System.Drawing.Point(1020, 536);
            this.errorTemperature.Name = "errorTemperature";
            this.errorTemperature.Size = new System.Drawing.Size(306, 40);
            this.errorTemperature.TabIndex = 17;
            this.errorTemperature.Text = "Invalid temperature";
            this.errorTemperature.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.submitButton.Location = new System.Drawing.Point(593, 671);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(186, 63);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.resetButton.Location = new System.Drawing.Point(808, 671);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(186, 63);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // EnterHealthInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1149);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.errorAbnormalSymptom);
            this.Controls.Add(this.errorVisitHubei);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.errorTemperature);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.errorGinNumber);
            this.Controls.Add(this.temperatureTextbox);
            this.Controls.Add(this.temepratureLabel);
            this.Controls.Add(this.abnormalSymptomNoCheckBox);
            this.Controls.Add(this.abnormalSymptomYesCheckBox);
            this.Controls.Add(this.hasAbnormalSymptomLabel);
            this.Controls.Add(this.visitHubeiNoCheckBox);
            this.Controls.Add(this.visitHubeiYesCheckBox);
            this.Controls.Add(this.visitHubeiLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ginNumberTextbox);
            this.Controls.Add(this.ginNumberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.submitButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "EnterHealthInformation";
            this.Text = "HealthMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ginNumberLabel;
        private System.Windows.Forms.TextBox ginNumberTextbox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label visitHubeiLabel;
        private System.Windows.Forms.CheckBox visitHubeiYesCheckBox;
        private System.Windows.Forms.CheckBox visitHubeiNoCheckBox;
        private System.Windows.Forms.Label hasAbnormalSymptomLabel;
        private System.Windows.Forms.CheckBox abnormalSymptomYesCheckBox;
        private System.Windows.Forms.CheckBox abnormalSymptomNoCheckBox;
        private System.Windows.Forms.Label temepratureLabel;
        private System.Windows.Forms.TextBox temperatureTextbox;
        private System.Windows.Forms.Label errorGinNumber;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label errorVisitHubei;
        private System.Windows.Forms.Label errorAbnormalSymptom;
        private System.Windows.Forms.Label errorTemperature;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

