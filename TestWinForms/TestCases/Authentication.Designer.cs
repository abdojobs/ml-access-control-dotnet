namespace TestWinForms.TestCases
{
    partial class Authentication
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAccessPoint = new System.Windows.Forms.TextBox();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSessionGuid = new System.Windows.Forms.TextBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnKeepAlive = new System.Windows.Forms.Button();
            this.btnEndOldSessions = new System.Windows.Forms.Button();
            this.btnKeepAliveAndEndOldSessions = new System.Windows.Forms.Button();
            this.btnDeleteAllSessions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Name";
            // 
            // tbLoginName
            // 
            this.tbLoginName.Location = new System.Drawing.Point(87, 4);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(165, 20);
            this.tbLoginName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(87, 30);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Access Point";
            // 
            // tbAccessPoint
            // 
            this.tbAccessPoint.Location = new System.Drawing.Point(87, 56);
            this.tbAccessPoint.Name = "tbAccessPoint";
            this.tbAccessPoint.Size = new System.Drawing.Size(165, 20);
            this.tbAccessPoint.TabIndex = 2;
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(87, 82);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(165, 23);
            this.btnAuthenticate.TabIndex = 4;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Session Guid";
            // 
            // tbSessionGuid
            // 
            this.tbSessionGuid.Location = new System.Drawing.Point(350, 4);
            this.tbSessionGuid.Name = "tbSessionGuid";
            this.tbSessionGuid.Size = new System.Drawing.Size(236, 20);
            this.tbSessionGuid.TabIndex = 6;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(350, 31);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(69, 23);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnKeepAlive
            // 
            this.btnKeepAlive.Location = new System.Drawing.Point(425, 31);
            this.btnKeepAlive.Name = "btnKeepAlive";
            this.btnKeepAlive.Size = new System.Drawing.Size(71, 23);
            this.btnKeepAlive.TabIndex = 8;
            this.btnKeepAlive.Text = "Keep Alive";
            this.btnKeepAlive.UseVisualStyleBackColor = true;
            this.btnKeepAlive.Click += new System.EventHandler(this.btnKeepAlive_Click);
            // 
            // btnEndOldSessions
            // 
            this.btnEndOldSessions.Location = new System.Drawing.Point(502, 31);
            this.btnEndOldSessions.Name = "btnEndOldSessions";
            this.btnEndOldSessions.Size = new System.Drawing.Size(98, 23);
            this.btnEndOldSessions.TabIndex = 9;
            this.btnEndOldSessions.Text = "End Old Sessions";
            this.btnEndOldSessions.UseVisualStyleBackColor = true;
            this.btnEndOldSessions.Click += new System.EventHandler(this.btnEndOldSessions_Click);
            // 
            // btnKeepAliveAndEndOldSessions
            // 
            this.btnKeepAliveAndEndOldSessions.Location = new System.Drawing.Point(350, 60);
            this.btnKeepAliveAndEndOldSessions.Name = "btnKeepAliveAndEndOldSessions";
            this.btnKeepAliveAndEndOldSessions.Size = new System.Drawing.Size(165, 23);
            this.btnKeepAliveAndEndOldSessions.TabIndex = 10;
            this.btnKeepAliveAndEndOldSessions.Text = "Keep Alive && End Old Sessions";
            this.btnKeepAliveAndEndOldSessions.UseVisualStyleBackColor = true;
            this.btnKeepAliveAndEndOldSessions.Click += new System.EventHandler(this.btnKeepAliveAndEndOldSessions_Click);
            // 
            // btnDeleteAllSessions
            // 
            this.btnDeleteAllSessions.Location = new System.Drawing.Point(350, 89);
            this.btnDeleteAllSessions.Name = "btnDeleteAllSessions";
            this.btnDeleteAllSessions.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteAllSessions.TabIndex = 11;
            this.btnDeleteAllSessions.Text = "Delete All Sessions";
            this.btnDeleteAllSessions.UseVisualStyleBackColor = true;
            this.btnDeleteAllSessions.Click += new System.EventHandler(this.btnDeleteAllSessions_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteAllSessions);
            this.Controls.Add(this.btnKeepAliveAndEndOldSessions);
            this.Controls.Add(this.btnEndOldSessions);
            this.Controls.Add(this.btnKeepAlive);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.tbSessionGuid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.tbAccessPoint);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authentication";
            this.Size = new System.Drawing.Size(626, 232);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAccessPoint;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSessionGuid;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnKeepAlive;
        private System.Windows.Forms.Button btnEndOldSessions;
        private System.Windows.Forms.Button btnKeepAliveAndEndOldSessions;
        private System.Windows.Forms.Button btnDeleteAllSessions;
    }
}
