namespace SampleWinForms
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.IsLoginNameAvailableAndValid = new System.Windows.Forms.Button();
            this.tbIsLoginNameAvailableAndValid1 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsEmailAvailableAndValid = new System.Windows.Forms.Button();
            this.tbIsEmailAvailableAndValid1 = new System.Windows.Forms.TextBox();
            this.IsPersonNameValid = new System.Windows.Forms.Button();
            this.IsPasswordValid = new System.Windows.Forms.Button();
            this.tbIsPasswordValid1 = new System.Windows.Forms.TextBox();
            this.tbIsPersonNameValid1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlDataProvider = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Random Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsLoginNameAvailableAndValid
            // 
            this.IsLoginNameAvailableAndValid.Location = new System.Drawing.Point(6, 3);
            this.IsLoginNameAvailableAndValid.Name = "IsLoginNameAvailableAndValid";
            this.IsLoginNameAvailableAndValid.Size = new System.Drawing.Size(190, 23);
            this.IsLoginNameAvailableAndValid.TabIndex = 2;
            this.IsLoginNameAvailableAndValid.Text = "IsLoginNameAvailableAndValid";
            this.IsLoginNameAvailableAndValid.UseVisualStyleBackColor = true;
            this.IsLoginNameAvailableAndValid.Click += new System.EventHandler(this.IsLoginNameAvailableAndValid_Click);
            // 
            // tbIsLoginNameAvailableAndValid1
            // 
            this.tbIsLoginNameAvailableAndValid1.Location = new System.Drawing.Point(202, 5);
            this.tbIsLoginNameAvailableAndValid1.Name = "tbIsLoginNameAvailableAndValid1";
            this.tbIsLoginNameAvailableAndValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsLoginNameAvailableAndValid1.TabIndex = 3;
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.BackColor = System.Drawing.Color.White;
            this.tbResult.Font = new System.Drawing.Font("Courier New", 8F);
            this.tbResult.Location = new System.Drawing.Point(6, 19);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(652, 141);
            this.tbResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // IsEmailAvailableAndValid
            // 
            this.IsEmailAvailableAndValid.Location = new System.Drawing.Point(6, 32);
            this.IsEmailAvailableAndValid.Name = "IsEmailAvailableAndValid";
            this.IsEmailAvailableAndValid.Size = new System.Drawing.Size(190, 23);
            this.IsEmailAvailableAndValid.TabIndex = 6;
            this.IsEmailAvailableAndValid.Text = "IsEmailAvailableAndValid";
            this.IsEmailAvailableAndValid.UseVisualStyleBackColor = true;
            this.IsEmailAvailableAndValid.Click += new System.EventHandler(this.IsEmailAvailableAndValid_Click);
            // 
            // tbIsEmailAvailableAndValid1
            // 
            this.tbIsEmailAvailableAndValid1.Location = new System.Drawing.Point(202, 34);
            this.tbIsEmailAvailableAndValid1.Name = "tbIsEmailAvailableAndValid1";
            this.tbIsEmailAvailableAndValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsEmailAvailableAndValid1.TabIndex = 3;
            // 
            // IsPersonNameValid
            // 
            this.IsPersonNameValid.Location = new System.Drawing.Point(6, 61);
            this.IsPersonNameValid.Name = "IsPersonNameValid";
            this.IsPersonNameValid.Size = new System.Drawing.Size(190, 23);
            this.IsPersonNameValid.TabIndex = 6;
            this.IsPersonNameValid.Text = "IsPersonNameValid";
            this.IsPersonNameValid.UseVisualStyleBackColor = true;
            this.IsPersonNameValid.Click += new System.EventHandler(this.IsPersonNameValid_Click);
            // 
            // IsPasswordValid
            // 
            this.IsPasswordValid.Location = new System.Drawing.Point(6, 90);
            this.IsPasswordValid.Name = "IsPasswordValid";
            this.IsPasswordValid.Size = new System.Drawing.Size(190, 23);
            this.IsPasswordValid.TabIndex = 6;
            this.IsPasswordValid.Text = "IsPasswordValid";
            this.IsPasswordValid.UseVisualStyleBackColor = true;
            this.IsPasswordValid.Click += new System.EventHandler(this.IsPasswordValid_Click);
            // 
            // tbIsPasswordValid1
            // 
            this.tbIsPasswordValid1.Location = new System.Drawing.Point(202, 92);
            this.tbIsPasswordValid1.Name = "tbIsPasswordValid1";
            this.tbIsPasswordValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsPasswordValid1.TabIndex = 3;
            // 
            // tbIsPersonNameValid1
            // 
            this.tbIsPersonNameValid1.Location = new System.Drawing.Point(202, 63);
            this.tbIsPersonNameValid1.Name = "tbIsPersonNameValid1";
            this.tbIsPersonNameValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsPersonNameValid1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbLoginName);
            this.panel1.Location = new System.Drawing.Point(449, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 195);
            this.panel1.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(76, 158);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(125, 23);
            this.btnCreateAccount.TabIndex = 11;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(89, 116);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(89, 90);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(89, 64);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(89, 38);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbLoginName
            // 
            this.tbLoginName.Location = new System.Drawing.Point(89, 12);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(100, 20);
            this.tbLoginName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.IsLoginNameAvailableAndValid);
            this.panel2.Controls.Add(this.IsPasswordValid);
            this.panel2.Controls.Add(this.tbIsLoginNameAvailableAndValid1);
            this.panel2.Controls.Add(this.IsPersonNameValid);
            this.panel2.Controls.Add(this.tbIsEmailAvailableAndValid1);
            this.panel2.Controls.Add(this.IsEmailAvailableAndValid);
            this.panel2.Controls.Add(this.tbIsPersonNameValid1);
            this.panel2.Controls.Add(this.tbIsPasswordValid1);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 164);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Provider";
            // 
            // ddlDataProvider
            // 
            this.ddlDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDataProvider.FormattingEnabled = true;
            this.ddlDataProvider.Items.AddRange(new object[] {
            "SQLite",
            "SQL Server"});
            this.ddlDataProvider.Location = new System.Drawing.Point(91, 10);
            this.ddlDataProvider.Name = "ddlDataProvider";
            this.ddlDataProvider.Size = new System.Drawing.Size(121, 21);
            this.ddlDataProvider.TabIndex = 10;
            this.ddlDataProvider.SelectedIndexChanged += new System.EventHandler(this.ddlDataProvider_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 430);
            this.Controls.Add(this.ddlDataProvider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Sample Test for ml.accesscontrol.dotnet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IsLoginNameAvailableAndValid;
        private System.Windows.Forms.TextBox tbIsLoginNameAvailableAndValid1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button IsEmailAvailableAndValid;
        private System.Windows.Forms.TextBox tbIsEmailAvailableAndValid1;
        private System.Windows.Forms.Button IsPersonNameValid;
        private System.Windows.Forms.Button IsPasswordValid;
        private System.Windows.Forms.TextBox tbIsPasswordValid1;
        private System.Windows.Forms.TextBox tbIsPersonNameValid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlDataProvider;
    }
}