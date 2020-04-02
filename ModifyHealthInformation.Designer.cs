namespace WindowsFormsApp6
{
    partial class ModifyHealthInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterID = new System.Windows.Forms.TextBox();
            this.modifyPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.enterIDPanel = new System.Windows.Forms.Panel();
            this.errorID = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.displayHealthInformation = new System.Windows.Forms.Label();
            this.modifyPanel.SuspendLayout();
            this.enterIDPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter The ID of the Employee: ";
            // 
            // enterID
            // 
            this.enterID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterID.Location = new System.Drawing.Point(65, 121);
            this.enterID.Name = "enterID";
            this.enterID.Size = new System.Drawing.Size(546, 53);
            this.enterID.TabIndex = 1;
            this.enterID.TextChanged += new System.EventHandler(this.enterID_TextChanged);
            // 
            // modifyPanel
            // 
            this.modifyPanel.Controls.Add(this.button5);
            this.modifyPanel.Controls.Add(this.checkBox2);
            this.modifyPanel.Controls.Add(this.checkBox1);
            this.modifyPanel.Controls.Add(this.textBox2);
            this.modifyPanel.Controls.Add(this.button1);
            this.modifyPanel.Controls.Add(this.comboBox1);
            this.modifyPanel.Controls.Add(this.label2);
            this.modifyPanel.Location = new System.Drawing.Point(674, 477);
            this.modifyPanel.Name = "modifyPanel";
            this.modifyPanel.Size = new System.Drawing.Size(1035, 520);
            this.modifyPanel.TabIndex = 2;
            this.modifyPanel.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(628, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 53);
            this.button5.TabIndex = 8;
            this.button5.Text = "Confirm";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(294, 228);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 49);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(68, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 49);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(68, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(543, 53);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(476, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finish Modifying";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Visited Hubei Recently",
            "Has Abnormal Symptom",
            "Temperature"});
            this.comboBox1.Location = new System.Drawing.Point(65, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(546, 53);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(792, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose The Field Needed To Be Modified";
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backToMainMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenu.Location = new System.Drawing.Point(75, 430);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(473, 94);
            this.backToMainMenu.TabIndex = 3;
            this.backToMainMenu.Text = "Back To Main Menu";
            this.backToMainMenu.UseVisualStyleBackColor = false;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(65, 290);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(205, 62);
            this.modify.TabIndex = 4;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // enterIDPanel
            // 
            this.enterIDPanel.Controls.Add(this.errorID);
            this.enterIDPanel.Controls.Add(this.delete);
            this.enterIDPanel.Controls.Add(this.displayHealthInformation);
            this.enterIDPanel.Controls.Add(this.modify);
            this.enterIDPanel.Controls.Add(this.label1);
            this.enterIDPanel.Controls.Add(this.enterID);
            this.enterIDPanel.Location = new System.Drawing.Point(674, 67);
            this.enterIDPanel.Name = "enterIDPanel";
            this.enterIDPanel.Size = new System.Drawing.Size(1035, 395);
            this.enterIDPanel.TabIndex = 5;
            // 
            // errorID
            // 
            this.errorID.AutoSize = true;
            this.errorID.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorID.ForeColor = System.Drawing.Color.Red;
            this.errorID.Location = new System.Drawing.Point(621, 128);
            this.errorID.Name = "errorID";
            this.errorID.Size = new System.Drawing.Size(403, 40);
            this.errorID.TabIndex = 6;
            this.errorID.Text = "ID must be a valid integer";
            this.errorID.Visible = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(294, 290);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(205, 62);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // displayHealthInformation
            // 
            this.displayHealthInformation.AutoSize = true;
            this.displayHealthInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayHealthInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.displayHealthInformation.Location = new System.Drawing.Point(60, 204);
            this.displayHealthInformation.Name = "displayHealthInformation";
            this.displayHealthInformation.Size = new System.Drawing.Size(449, 45);
            this.displayHealthInformation.TabIndex = 2;
            this.displayHealthInformation.Text = "displayHealthInformation";
            this.displayHealthInformation.Visible = false;
            // 
            // ModifyHealthInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 1053);
            this.Controls.Add(this.enterIDPanel);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.modifyPanel);
            this.Name = "ModifyHealthInformation";
            this.Text = "Form1";
            this.modifyPanel.ResumeLayout(false);
            this.modifyPanel.PerformLayout();
            this.enterIDPanel.ResumeLayout(false);
            this.enterIDPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterID;
        private System.Windows.Forms.Panel modifyPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel enterIDPanel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label displayHealthInformation;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label errorID;
    }
}