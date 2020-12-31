namespace Everything_App
{
    partial class Password_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Manager));
            this.btnPasswordGenerator = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnAddDelete = new System.Windows.Forms.Button();
            this.btnShrink = new System.Windows.Forms.Button();
            this.btnLogDisplay = new System.Windows.Forms.Button();
            this.tabAddDelete = new System.Windows.Forms.TabPage();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAddPassword = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReferenceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPasswordChecker = new System.Windows.Forms.TabPage();
            this.tabPasswordGenerator = new System.Windows.Forms.TabPage();
            this.lblPasswordJokes = new System.Windows.Forms.Label();
            this.lblCopied = new System.Windows.Forms.Label();
            this.lblCopyPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtGenLog = new System.Windows.Forms.RichTextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddDelete.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.tabPasswordGenerator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPasswordGenerator
            // 
            this.btnPasswordGenerator.Location = new System.Drawing.Point(12, 23);
            this.btnPasswordGenerator.Name = "btnPasswordGenerator";
            this.btnPasswordGenerator.Size = new System.Drawing.Size(125, 54);
            this.btnPasswordGenerator.TabIndex = 0;
            this.btnPasswordGenerator.Text = "Password Generator";
            this.btnPasswordGenerator.UseVisualStyleBackColor = true;
            this.btnPasswordGenerator.Click += new System.EventHandler(this.btnPasswordGenerator_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(176, 23);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 54);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Password";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnAddDelete
            // 
            this.btnAddDelete.Location = new System.Drawing.Point(349, 23);
            this.btnAddDelete.Name = "btnAddDelete";
            this.btnAddDelete.Size = new System.Drawing.Size(125, 54);
            this.btnAddDelete.TabIndex = 2;
            this.btnAddDelete.Text = "Add / Delete Passwords";
            this.btnAddDelete.UseVisualStyleBackColor = true;
            this.btnAddDelete.Click += new System.EventHandler(this.btnAddDelete_Click);
            // 
            // btnShrink
            // 
            this.btnShrink.Enabled = false;
            this.btnShrink.Location = new System.Drawing.Point(674, 23);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(125, 54);
            this.btnShrink.TabIndex = 3;
            this.btnShrink.Text = "Shrink";
            this.btnShrink.UseVisualStyleBackColor = true;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // btnLogDisplay
            // 
            this.btnLogDisplay.Enabled = false;
            this.btnLogDisplay.Location = new System.Drawing.Point(517, 23);
            this.btnLogDisplay.Name = "btnLogDisplay";
            this.btnLogDisplay.Size = new System.Drawing.Size(125, 54);
            this.btnLogDisplay.TabIndex = 4;
            this.btnLogDisplay.Text = "Hide Log";
            this.btnLogDisplay.UseVisualStyleBackColor = true;
            this.btnLogDisplay.Click += new System.EventHandler(this.btnLogDisplay_Click);
            // 
            // tabAddDelete
            // 
            this.tabAddDelete.Controls.Add(this.panelDelete);
            this.tabAddDelete.Controls.Add(this.panelAdd);
            this.tabAddDelete.Controls.Add(this.radDelete);
            this.tabAddDelete.Controls.Add(this.radAdd);
            this.tabAddDelete.Controls.Add(this.label3);
            this.tabAddDelete.Location = new System.Drawing.Point(4, 22);
            this.tabAddDelete.Name = "tabAddDelete";
            this.tabAddDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddDelete.Size = new System.Drawing.Size(789, 384);
            this.tabAddDelete.TabIndex = 2;
            this.tabAddDelete.Text = "Add / Delete";
            this.tabAddDelete.UseVisualStyleBackColor = true;
            // 
            // panelDelete
            // 
            this.panelDelete.Enabled = false;
            this.panelDelete.Location = new System.Drawing.Point(425, 98);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(346, 280);
            this.panelDelete.TabIndex = 6;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnAddPassword);
            this.panelAdd.Controls.Add(this.richTextBox1);
            this.panelAdd.Controls.Add(this.label8);
            this.panelAdd.Controls.Add(this.txtPassword);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.txtReferenceName);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.comboGroup);
            this.panelAdd.Location = new System.Drawing.Point(20, 79);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(346, 299);
            this.panelAdd.TabIndex = 4;
            // 
            // btnAddPassword
            // 
            this.btnAddPassword.Location = new System.Drawing.Point(140, 261);
            this.btnAddPassword.Name = "btnAddPassword";
            this.btnAddPassword.Size = new System.Drawing.Size(73, 23);
            this.btnAddPassword.TabIndex = 6;
            this.btnAddPassword.Text = "Add";
            this.btnAddPassword.UseVisualStyleBackColor = true;
            this.btnAddPassword.Click += new System.EventHandler(this.btnAddPassword_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(72, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 141);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Notes";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // txtReferenceName
            // 
            this.txtReferenceName.Location = new System.Drawing.Point(51, 45);
            this.txtReferenceName.Name = "txtReferenceName";
            this.txtReferenceName.Size = new System.Drawing.Size(193, 20);
            this.txtReferenceName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category Selector";
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Items.AddRange(new object[] {
            "Online Banking",
            "Pin Numbers",
            "Email",
            "Social Media",
            "Online Shopping",
            "Other"});
            this.comboGroup.Location = new System.Drawing.Point(116, 18);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(121, 21);
            this.comboGroup.TabIndex = 3;
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Location = new System.Drawing.Point(70, 56);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(56, 17);
            this.radDelete.TabIndex = 2;
            this.radDelete.Text = "Delete";
            this.radDelete.UseVisualStyleBackColor = true;
            this.radDelete.CheckedChanged += new System.EventHandler(this.radDelete_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(20, 56);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(44, 17);
            this.radAdd.TabIndex = 1;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choice";
            // 
            // tabPasswordChecker
            // 
            this.tabPasswordChecker.Location = new System.Drawing.Point(4, 22);
            this.tabPasswordChecker.Name = "tabPasswordChecker";
            this.tabPasswordChecker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasswordChecker.Size = new System.Drawing.Size(789, 384);
            this.tabPasswordChecker.TabIndex = 1;
            this.tabPasswordChecker.Text = "Password Checker";
            this.tabPasswordChecker.UseVisualStyleBackColor = true;
            // 
            // tabPasswordGenerator
            // 
            this.tabPasswordGenerator.Controls.Add(this.lblPasswordJokes);
            this.tabPasswordGenerator.Controls.Add(this.lblCopied);
            this.tabPasswordGenerator.Controls.Add(this.lblCopyPassword);
            this.tabPasswordGenerator.Controls.Add(this.lblPassword);
            this.tabPasswordGenerator.Controls.Add(this.btnGeneratePassword);
            this.tabPasswordGenerator.Controls.Add(this.txtWord);
            this.tabPasswordGenerator.Controls.Add(this.txtPasswordLength);
            this.tabPasswordGenerator.Controls.Add(this.radNo);
            this.tabPasswordGenerator.Controls.Add(this.radYes);
            this.tabPasswordGenerator.Controls.Add(this.label2);
            this.tabPasswordGenerator.Controls.Add(this.label1);
            this.tabPasswordGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabPasswordGenerator.Name = "tabPasswordGenerator";
            this.tabPasswordGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasswordGenerator.Size = new System.Drawing.Size(789, 384);
            this.tabPasswordGenerator.TabIndex = 0;
            this.tabPasswordGenerator.Text = "Password Generator";
            this.tabPasswordGenerator.UseVisualStyleBackColor = true;
            // 
            // lblPasswordJokes
            // 
            this.lblPasswordJokes.AutoSize = true;
            this.lblPasswordJokes.Location = new System.Drawing.Point(602, 160);
            this.lblPasswordJokes.Name = "lblPasswordJokes";
            this.lblPasswordJokes.Size = new System.Drawing.Size(153, 13);
            this.lblPasswordJokes.TabIndex = 10;
            this.lblPasswordJokes.Text = "Click for some Password Jokes";
            this.lblPasswordJokes.Click += new System.EventHandler(this.lblPasswordJokes_Click);
            // 
            // lblCopied
            // 
            this.lblCopied.BackColor = System.Drawing.Color.White;
            this.lblCopied.Image = ((System.Drawing.Image)(resources.GetObject("lblCopied.Image")));
            this.lblCopied.Location = new System.Drawing.Point(378, 149);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(47, 44);
            this.lblCopied.TabIndex = 9;
            this.lblCopied.Visible = false;
            // 
            // lblCopyPassword
            // 
            this.lblCopyPassword.BackColor = System.Drawing.Color.White;
            this.lblCopyPassword.Image = ((System.Drawing.Image)(resources.GetObject("lblCopyPassword.Image")));
            this.lblCopyPassword.Location = new System.Drawing.Point(325, 149);
            this.lblCopyPassword.Name = "lblCopyPassword";
            this.lblCopyPassword.Size = new System.Drawing.Size(47, 44);
            this.lblCopyPassword.TabIndex = 8;
            this.lblCopyPassword.Visible = false;
            this.lblCopyPassword.Click += new System.EventHandler(this.lblCopyPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 13);
            this.lblPassword.TabIndex = 7;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(194, 139);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(125, 54);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtGenLog
            // 
            this.txtGenLog.Location = new System.Drawing.Point(815, 131);
            this.txtGenLog.Name = "txtGenLog";
            this.txtGenLog.Size = new System.Drawing.Size(291, 384);
            this.txtGenLog.TabIndex = 6;
            this.txtGenLog.Text = "";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(299, 78);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(169, 20);
            this.txtWord.TabIndex = 5;
            this.txtWord.Visible = false;
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(104, 20);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordLength.TabIndex = 1;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Location = new System.Drawing.Point(254, 81);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 4;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(205, 81);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 3;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Want to include something meaningful?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPasswordGenerator);
            this.tabControl1.Controls.Add(this.tabPasswordChecker);
            this.tabControl1.Controls.Add(this.tabAddDelete);
            this.tabControl1.Location = new System.Drawing.Point(12, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 410);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Visible = false;
            // 
            // Password_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogDisplay);
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.btnAddDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGenLog);
            this.Controls.Add(this.btnPasswordGenerator);
            this.Name = "Password_Manager";
            this.Text = "Password_Manager";
            this.tabAddDelete.ResumeLayout(false);
            this.tabAddDelete.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.tabPasswordGenerator.ResumeLayout(false);
            this.tabPasswordGenerator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPasswordGenerator;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnAddDelete;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Button btnLogDisplay;
        private System.Windows.Forms.TabPage tabAddDelete;
        private System.Windows.Forms.TabPage tabPasswordChecker;
        private System.Windows.Forms.TabPage tabPasswordGenerator;
        private System.Windows.Forms.Label lblPasswordJokes;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Label lblCopyPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.RichTextBox txtGenLog;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnAddPassword;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReferenceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Label label3;
    }
}