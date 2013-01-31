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
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // IsLoginNameAvailableAndValid
            // 
            this.IsLoginNameAvailableAndValid.Location = new System.Drawing.Point(12, 38);
            this.IsLoginNameAvailableAndValid.Name = "IsLoginNameAvailableAndValid";
            this.IsLoginNameAvailableAndValid.Size = new System.Drawing.Size(190, 23);
            this.IsLoginNameAvailableAndValid.TabIndex = 2;
            this.IsLoginNameAvailableAndValid.Text = "IsLoginNameAvailableAndValid";
            this.IsLoginNameAvailableAndValid.UseVisualStyleBackColor = true;
            this.IsLoginNameAvailableAndValid.Click += new System.EventHandler(this.IsLoginNameAvailableAndValid_Click);
            // 
            // tbIsLoginNameAvailableAndValid1
            // 
            this.tbIsLoginNameAvailableAndValid1.Location = new System.Drawing.Point(208, 40);
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
            this.tbResult.Location = new System.Drawing.Point(6, 19);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(317, 340);
            this.tbResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 365);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // IsEmailAvailableAndValid
            // 
            this.IsEmailAvailableAndValid.Location = new System.Drawing.Point(12, 67);
            this.IsEmailAvailableAndValid.Name = "IsEmailAvailableAndValid";
            this.IsEmailAvailableAndValid.Size = new System.Drawing.Size(190, 23);
            this.IsEmailAvailableAndValid.TabIndex = 6;
            this.IsEmailAvailableAndValid.Text = "IsEmailAvailableAndValid";
            this.IsEmailAvailableAndValid.UseVisualStyleBackColor = true;
            this.IsEmailAvailableAndValid.Click += new System.EventHandler(this.IsEmailAvailableAndValid_Click);
            // 
            // tbIsEmailAvailableAndValid1
            // 
            this.tbIsEmailAvailableAndValid1.Location = new System.Drawing.Point(208, 69);
            this.tbIsEmailAvailableAndValid1.Name = "tbIsEmailAvailableAndValid1";
            this.tbIsEmailAvailableAndValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsEmailAvailableAndValid1.TabIndex = 3;
            // 
            // IsPersonNameValid
            // 
            this.IsPersonNameValid.Location = new System.Drawing.Point(12, 96);
            this.IsPersonNameValid.Name = "IsPersonNameValid";
            this.IsPersonNameValid.Size = new System.Drawing.Size(190, 23);
            this.IsPersonNameValid.TabIndex = 6;
            this.IsPersonNameValid.Text = "IsPersonNameValid";
            this.IsPersonNameValid.UseVisualStyleBackColor = true;
            this.IsPersonNameValid.Click += new System.EventHandler(this.IsPersonNameValid_Click);
            // 
            // IsPasswordValid
            // 
            this.IsPasswordValid.Location = new System.Drawing.Point(12, 125);
            this.IsPasswordValid.Name = "IsPasswordValid";
            this.IsPasswordValid.Size = new System.Drawing.Size(190, 23);
            this.IsPasswordValid.TabIndex = 6;
            this.IsPasswordValid.Text = "IsPasswordValid";
            this.IsPasswordValid.UseVisualStyleBackColor = true;
            this.IsPasswordValid.Click += new System.EventHandler(this.IsPasswordValid_Click);
            // 
            // tbIsPasswordValid1
            // 
            this.tbIsPasswordValid1.Location = new System.Drawing.Point(208, 127);
            this.tbIsPasswordValid1.Name = "tbIsPasswordValid1";
            this.tbIsPasswordValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsPasswordValid1.TabIndex = 3;
            // 
            // tbIsPersonNameValid1
            // 
            this.tbIsPersonNameValid1.Location = new System.Drawing.Point(208, 98);
            this.tbIsPersonNameValid1.Name = "tbIsPersonNameValid1";
            this.tbIsPersonNameValid1.Size = new System.Drawing.Size(190, 20);
            this.tbIsPersonNameValid1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 389);
            this.Controls.Add(this.IsPasswordValid);
            this.Controls.Add(this.IsPersonNameValid);
            this.Controls.Add(this.IsEmailAvailableAndValid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbIsPasswordValid1);
            this.Controls.Add(this.tbIsPersonNameValid1);
            this.Controls.Add(this.tbIsEmailAvailableAndValid1);
            this.Controls.Add(this.tbIsLoginNameAvailableAndValid1);
            this.Controls.Add(this.IsLoginNameAvailableAndValid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Sample Test for ml.accesscontrol.dotnet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
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
    }
}