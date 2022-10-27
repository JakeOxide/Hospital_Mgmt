namespace Hospital_Mgmt
{
    partial class NurseMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMedicalCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signedInAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.medicalDataToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(744, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.checkStatusToolStripMenuItem,
            this.viewPatientInfoToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.addPatientToolStripMenuItem.Text = "Check Medication";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // checkStatusToolStripMenuItem
            // 
            this.checkStatusToolStripMenuItem.Name = "checkStatusToolStripMenuItem";
            this.checkStatusToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.checkStatusToolStripMenuItem.Text = "Check Status";
            this.checkStatusToolStripMenuItem.Click += new System.EventHandler(this.checkStatusToolStripMenuItem_Click);
            // 
            // viewPatientInfoToolStripMenuItem
            // 
            this.viewPatientInfoToolStripMenuItem.Name = "viewPatientInfoToolStripMenuItem";
            this.viewPatientInfoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.viewPatientInfoToolStripMenuItem.Text = "Administer Medication";
            // 
            // medicalDataToolStripMenuItem
            // 
            this.medicalDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuePrescriptionToolStripMenuItem,
            this.issueMedicalCertificateToolStripMenuItem});
            this.medicalDataToolStripMenuItem.Name = "medicalDataToolStripMenuItem";
            this.medicalDataToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.medicalDataToolStripMenuItem.Text = "Medical Data";
            // 
            // issuePrescriptionToolStripMenuItem
            // 
            this.issuePrescriptionToolStripMenuItem.Name = "issuePrescriptionToolStripMenuItem";
            this.issuePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.issuePrescriptionToolStripMenuItem.Text = "Update Patient Status";
            this.issuePrescriptionToolStripMenuItem.Click += new System.EventHandler(this.issuePrescriptionToolStripMenuItem_Click);
            // 
            // issueMedicalCertificateToolStripMenuItem
            // 
            this.issueMedicalCertificateToolStripMenuItem.Name = "issueMedicalCertificateToolStripMenuItem";
            this.issueMedicalCertificateToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.issueMedicalCertificateToolStripMenuItem.Text = "Generate Medical Report";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.signedInAsToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // signedInAsToolStripMenuItem
            // 
            this.signedInAsToolStripMenuItem.Name = "signedInAsToolStripMenuItem";
            this.signedInAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signedInAsToolStripMenuItem.Text = "Signed in as";
            // 
            // NurseMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NurseMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseMDI";
            this.Load += new System.EventHandler(this.NurseMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuePrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueMedicalCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signedInAsToolStripMenuItem;
    }
}