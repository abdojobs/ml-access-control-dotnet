namespace SampleWinForms.TestCases
{
    partial class Roles
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
            this.btnListRoles = new System.Windows.Forms.Button();
            this.btnListHiddenRoles = new System.Windows.Forms.Button();
            this.btnListAllRoles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListRoles
            // 
            this.btnListRoles.Location = new System.Drawing.Point(30, 21);
            this.btnListRoles.Name = "btnListRoles";
            this.btnListRoles.Size = new System.Drawing.Size(135, 23);
            this.btnListRoles.TabIndex = 0;
            this.btnListRoles.Text = "List Roles";
            this.btnListRoles.UseVisualStyleBackColor = true;
            this.btnListRoles.Click += new System.EventHandler(this.btnListRoles_Click);
            // 
            // btnListHiddenRoles
            // 
            this.btnListHiddenRoles.Location = new System.Drawing.Point(30, 50);
            this.btnListHiddenRoles.Name = "btnListHiddenRoles";
            this.btnListHiddenRoles.Size = new System.Drawing.Size(135, 23);
            this.btnListHiddenRoles.TabIndex = 1;
            this.btnListHiddenRoles.Text = "List Hidden Roles";
            this.btnListHiddenRoles.UseVisualStyleBackColor = true;
            this.btnListHiddenRoles.Click += new System.EventHandler(this.btnListHiddenRoles_Click);
            // 
            // btnListAllRoles
            // 
            this.btnListAllRoles.Location = new System.Drawing.Point(30, 79);
            this.btnListAllRoles.Name = "btnListAllRoles";
            this.btnListAllRoles.Size = new System.Drawing.Size(135, 23);
            this.btnListAllRoles.TabIndex = 2;
            this.btnListAllRoles.Text = "List All Roles";
            this.btnListAllRoles.UseVisualStyleBackColor = true;
            this.btnListAllRoles.Click += new System.EventHandler(this.btnListAllRoles_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListAllRoles);
            this.Controls.Add(this.btnListHiddenRoles);
            this.Controls.Add(this.btnListRoles);
            this.Name = "Roles";
            this.Size = new System.Drawing.Size(392, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListRoles;
        private System.Windows.Forms.Button btnListHiddenRoles;
        private System.Windows.Forms.Button btnListAllRoles;
    }
}
