namespace TestWinForms.TestCases
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadUserInfo = new System.Windows.Forms.Button();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadUserInfo
            // 
            this.btnLoadUserInfo.Location = new System.Drawing.Point(200, 22);
            this.btnLoadUserInfo.Name = "btnLoadUserInfo";
            this.btnLoadUserInfo.Size = new System.Drawing.Size(98, 23);
            this.btnLoadUserInfo.TabIndex = 0;
            this.btnLoadUserInfo.Text = "Get User Info";
            this.btnLoadUserInfo.UseVisualStyleBackColor = true;
            this.btnLoadUserInfo.Click += new System.EventHandler(this.btnLoadUserInfo_Click);
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(85, 24);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 20);
            this.tbUserId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Id";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.btnLoadUserInfo);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(439, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadUserInfo;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
    }
}
