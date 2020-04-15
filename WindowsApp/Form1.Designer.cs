namespace WindowsFormsApp.WindowsApp
{
    partial class Form1
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
            this.editHealthDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ginNumberLabel = new System.Windows.Forms.Label();
            this.errorGinNumberLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.errorCannotFindGinNumberLabel = new System.Windows.Forms.Label();
            this.ginNumberTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fileOperationGroupBox = new System.Windows.Forms.GroupBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.editHealthDataGroupBox.SuspendLayout();
            this.fileOperationGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.editHealthDataGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editHealthDataGroupBox.Location = new System.Drawing.Point(147, 18);
            this.editHealthDataGroupBox.Name = "editHealthDataGroupBox";
            this.editHealthDataGroupBox.Size = new System.Drawing.Size(506, 415);
            this.editHealthDataGroupBox.TabIndex = 1;
            this.editHealthDataGroupBox.TabStop = false;
            this.editHealthDataGroupBox.Text = "Edit Employee Health Data";
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
            // ginNumberTextBox
            // 
            this.ginNumberTextBox.Location = new System.Drawing.Point(25, 119);
            this.ginNumberTextBox.Name = "ginNumberTextBox";
            this.ginNumberTextBox.Size = new System.Drawing.Size(426, 47);
            this.ginNumberTextBox.TabIndex = 4;
            this.ginNumberTextBox.TabStop = false;
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
            // 
            // fileOperationGroupBox
            // 
            this.fileOperationGroupBox.Controls.Add(this.saveToFileButton);
            this.fileOperationGroupBox.Controls.Add(this.openFileButton);
            this.fileOperationGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileOperationGroupBox.Location = new System.Drawing.Point(147, 439);
            this.fileOperationGroupBox.Name = "fileOperationGroupBox";
            this.fileOperationGroupBox.Size = new System.Drawing.Size(506, 302);
            this.fileOperationGroupBox.TabIndex = 3;
            this.fileOperationGroupBox.TabStop = false;
            this.fileOperationGroupBox.Text = "File Operation";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 1119);
            this.Controls.Add(this.fileOperationGroupBox);
            this.Controls.Add(this.editHealthDataGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.editHealthDataGroupBox.ResumeLayout(false);
            this.editHealthDataGroupBox.PerformLayout();
            this.fileOperationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox editHealthDataGroupBox;
        private System.Windows.Forms.Label ginNumberLabel;
        private System.Windows.Forms.Label errorGinNumberLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label errorCannotFindGinNumberLabel;
        private System.Windows.Forms.TextBox ginNumberTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox fileOperationGroupBox;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button openFileButton;
    }
}