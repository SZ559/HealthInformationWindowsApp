namespace WindowsFormsApp6
{
    partial class MainMenu
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
            this.enter = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.inputFromFile = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.displaySuspected = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enter.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(642, 145);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(559, 102);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter Health Information";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.LightSkyBlue;
            this.modify.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(642, 294);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(559, 102);
            this.modify.TabIndex = 1;
            this.modify.Text = "Modify/Delete Health Information";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // inputFromFile
            // 
            this.inputFromFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.inputFromFile.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFromFile.Location = new System.Drawing.Point(642, 719);
            this.inputFromFile.Name = "inputFromFile";
            this.inputFromFile.Size = new System.Drawing.Size(559, 102);
            this.inputFromFile.TabIndex = 3;
            this.inputFromFile.Text = "Input From File";
            this.inputFromFile.UseVisualStyleBackColor = false;
            this.inputFromFile.Click += new System.EventHandler(this.InputFromFile_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(642, 865);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(559, 102);
            this.save.TabIndex = 4;
            this.save.Text = "Save To File";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.LightSkyBlue;
            this.display.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(642, 432);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(559, 102);
            this.display.TabIndex = 5;
            this.display.Text = "Display Health Information";
            this.display.UseVisualStyleBackColor = false;
            // 
            // displaySuspected
            // 
            this.displaySuspected.BackColor = System.Drawing.Color.LightSkyBlue;
            this.displaySuspected.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySuspected.Location = new System.Drawing.Point(642, 576);
            this.displaySuspected.Name = "displaySuspected";
            this.displaySuspected.Size = new System.Drawing.Size(559, 102);
            this.displaySuspected.TabIndex = 7;
            this.displaySuspected.Text = "Display Suspected Case";
            this.displaySuspected.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 1368);
            this.Controls.Add(this.displaySuspected);
            this.Controls.Add(this.display);
            this.Controls.Add(this.save);
            this.Controls.Add(this.inputFromFile);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.enter);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button inputFromFile;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button displaySuspected;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}