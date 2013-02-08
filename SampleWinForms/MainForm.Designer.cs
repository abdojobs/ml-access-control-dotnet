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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlDataProvider = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlOperation = new System.Windows.Forms.ComboBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.tbResult.Size = new System.Drawing.Size(623, 141);
            this.tbResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Operation";
            // 
            // ddlOperation
            // 
            this.ddlOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOperation.FormattingEnabled = true;
            this.ddlOperation.Location = new System.Drawing.Point(346, 10);
            this.ddlOperation.Name = "ddlOperation";
            this.ddlOperation.Size = new System.Drawing.Size(250, 21);
            this.ddlOperation.TabIndex = 12;
            this.ddlOperation.SelectedIndexChanged += new System.EventHandler(this.ddlOperation_SelectedIndexChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Location = new System.Drawing.Point(12, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(635, 207);
            this.MainPanel.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 428);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ddlOperation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlDataProvider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Sample Test for ml.accesscontrol.dotnet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlDataProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlOperation;
        private System.Windows.Forms.Panel MainPanel;
    }
}