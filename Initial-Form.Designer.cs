namespace Everything_App
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
            this.lblMin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblJoke = new System.Windows.Forms.Label();
            this.lblDayDate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCurrentWeekNumber = new System.Windows.Forms.Label();
            this.btnPasswords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(1284, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "Min";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(1360, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 13);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "Close";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(614, 736);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(94, 13);
            this.lblJoke.TabIndex = 2;
            this.lblJoke.Text = "Click me for a joke";
            this.lblJoke.Click += new System.EventHandler(this.lblJoke_Click);
            // 
            // lblDayDate
            // 
            this.lblDayDate.AutoSize = true;
            this.lblDayDate.Location = new System.Drawing.Point(12, 9);
            this.lblDayDate.Name = "lblDayDate";
            this.lblDayDate.Size = new System.Drawing.Size(58, 13);
            this.lblDayDate.TabIndex = 3;
            this.lblDayDate.Text = "Some Text";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 59);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Some Text";
            // 
            // lblCurrentWeekNumber
            // 
            this.lblCurrentWeekNumber.AutoSize = true;
            this.lblCurrentWeekNumber.Location = new System.Drawing.Point(12, 110);
            this.lblCurrentWeekNumber.Name = "lblCurrentWeekNumber";
            this.lblCurrentWeekNumber.Size = new System.Drawing.Size(58, 13);
            this.lblCurrentWeekNumber.TabIndex = 5;
            this.lblCurrentWeekNumber.Text = "Some Text";
            // 
            // btnPasswords
            // 
            this.btnPasswords.Location = new System.Drawing.Point(15, 175);
            this.btnPasswords.Name = "btnPasswords";
            this.btnPasswords.Size = new System.Drawing.Size(209, 86);
            this.btnPasswords.TabIndex = 6;
            this.btnPasswords.Text = "Password Manager";
            this.btnPasswords.UseVisualStyleBackColor = true;
            this.btnPasswords.Click += new System.EventHandler(this.btnPasswords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 758);
            this.Controls.Add(this.btnPasswords);
            this.Controls.Add(this.lblCurrentWeekNumber);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDayDate);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Label lblDayDate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCurrentWeekNumber;
        private System.Windows.Forms.Button btnPasswords;
    }
}

