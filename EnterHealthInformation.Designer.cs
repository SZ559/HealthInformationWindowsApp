namespace WindowsFormsApp6
{
    partial class EnterHealthInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.visitHubeiYes = new System.Windows.Forms.CheckBox();
            this.visitHubeiNo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abnormalSymptomYes = new System.Windows.Forms.CheckBox();
            this.abnormalSymptomNo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.temperatureTextbox = new System.Windows.Forms.TextBox();
            this.errorID = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.errorVisitHubei = new System.Windows.Forms.Label();
            this.errorAbnormalSymptom = new System.Windows.Forms.Label();
            this.errorTemperature = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(433, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(501, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(593, 140);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(401, 42);
            this.idTextbox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(593, 235);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(401, 42);
            this.nameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(148, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Visited Hubei Recently:";
            // 
            // visitHubeiYes
            // 
            this.visitHubeiYes.AutoSize = true;
            this.visitHubeiYes.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitHubeiYes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.visitHubeiYes.Location = new System.Drawing.Point(593, 334);
            this.visitHubeiYes.Name = "visitHubeiYes";
            this.visitHubeiYes.Size = new System.Drawing.Size(115, 44);
            this.visitHubeiYes.TabIndex = 7;
            this.visitHubeiYes.Text = "Yes";
            this.visitHubeiYes.UseVisualStyleBackColor = true;
            this.visitHubeiYes.CheckedChanged += new System.EventHandler(this.VisitHubeiYes_CheckedChanged);
            // 
            // visitHubeiNo
            // 
            this.visitHubeiNo.AutoSize = true;
            this.visitHubeiNo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitHubeiNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.visitHubeiNo.Location = new System.Drawing.Point(731, 334);
            this.visitHubeiNo.Name = "visitHubeiNo";
            this.visitHubeiNo.Size = new System.Drawing.Size(95, 44);
            this.visitHubeiNo.TabIndex = 8;
            this.visitHubeiNo.Text = "No";
            this.visitHubeiNo.UseVisualStyleBackColor = true;
            this.visitHubeiNo.CheckedChanged += new System.EventHandler(this.VisitHubeiNo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(112, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "Has Abnormal Symptom:";
            // 
            // abnormalSymptomYes
            // 
            this.abnormalSymptomYes.AutoSize = true;
            this.abnormalSymptomYes.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abnormalSymptomYes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.abnormalSymptomYes.Location = new System.Drawing.Point(593, 438);
            this.abnormalSymptomYes.Name = "abnormalSymptomYes";
            this.abnormalSymptomYes.Size = new System.Drawing.Size(115, 44);
            this.abnormalSymptomYes.TabIndex = 10;
            this.abnormalSymptomYes.Text = "Yes";
            this.abnormalSymptomYes.UseVisualStyleBackColor = true;
            this.abnormalSymptomYes.CheckedChanged += new System.EventHandler(this.HasAbnormalSymptomYes_CheckedChanged);
            // 
            // abnormalSymptomNo
            // 
            this.abnormalSymptomNo.AutoSize = true;
            this.abnormalSymptomNo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abnormalSymptomNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.abnormalSymptomNo.Location = new System.Drawing.Point(731, 439);
            this.abnormalSymptomNo.Name = "abnormalSymptomNo";
            this.abnormalSymptomNo.Size = new System.Drawing.Size(95, 44);
            this.abnormalSymptomNo.TabIndex = 11;
            this.abnormalSymptomNo.Text = "No";
            this.abnormalSymptomNo.UseVisualStyleBackColor = true;
            this.abnormalSymptomNo.CheckedChanged += new System.EventHandler(this.HasAbnormalSymptomNo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(318, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Temperature:";
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Location = new System.Drawing.Point(593, 539);
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(401, 42);
            this.temperatureTextbox.TabIndex = 13;
            // 
            // errorID
            // 
            this.errorID.AutoSize = true;
            this.errorID.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorID.ForeColor = System.Drawing.Color.Red;
            this.errorID.Location = new System.Drawing.Point(1020, 142);
            this.errorID.Name = "errorID";
            this.errorID.Size = new System.Drawing.Size(157, 40);
            this.errorID.TabIndex = 15;
            this.errorID.Text = "Invalid ID";
            this.errorID.Visible = false;
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
            // backToMainMenu
            // 
            this.backToMainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenu.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.backToMainMenu.Location = new System.Drawing.Point(593, 785);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(407, 60);
            this.backToMainMenu.TabIndex = 18;
            this.backToMainMenu.Text = "Back To Main Menu";
            this.backToMainMenu.UseVisualStyleBackColor = false;
            this.backToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // errorVisitHubei
            // 
            this.errorVisitHubei.AutoSize = true;
            this.errorVisitHubei.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorVisitHubei.ForeColor = System.Drawing.Color.Red;
            this.errorVisitHubei.Location = new System.Drawing.Point(1020, 334);
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
            this.errorTemperature.Location = new System.Drawing.Point(1020, 539);
            this.errorTemperature.Name = "errorTemperature";
            this.errorTemperature.Size = new System.Drawing.Size(306, 40);
            this.errorTemperature.TabIndex = 17;
            this.errorTemperature.Text = "Invalid temperature";
            this.errorTemperature.Visible = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.submit.Location = new System.Drawing.Point(593, 671);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(186, 63);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
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
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.errorTemperature);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.errorID);
            this.Controls.Add(this.temperatureTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.abnormalSymptomNo);
            this.Controls.Add(this.abnormalSymptomYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.visitHubeiNo);
            this.Controls.Add(this.visitHubeiYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "EnterHealthInformation";
            this.Text = "HealthMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox visitHubeiYes;
        private System.Windows.Forms.CheckBox visitHubeiNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox abnormalSymptomYes;
        private System.Windows.Forms.CheckBox abnormalSymptomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox temperatureTextbox;
        private System.Windows.Forms.Label errorID;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Label errorVisitHubei;
        private System.Windows.Forms.Label errorAbnormalSymptom;
        private System.Windows.Forms.Label errorTemperature;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button resetButton;
    }
}

