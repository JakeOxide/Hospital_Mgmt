namespace Hospital_Mgmt
{
    partial class Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.gbx_UserType = new System.Windows.Forms.GroupBox();
            this.rbtn_Nurse = new System.Windows.Forms.RadioButton();
            this.rbtn_Doctor = new System.Windows.Forms.RadioButton();
            this.rbtn_Admin = new System.Windows.Forms.RadioButton();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel_LoginPanel = new System.Windows.Forms.Panel();
            this.gbx_UserType.SuspendLayout();
            this.panel_LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(316, 7);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(332, 170);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.Click += new System.EventHandler(this.lbl_Login_Click);
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(11, 128);
            this.lbl_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(121, 47);
            this.lbl_UserID.TabIndex = 1;
            this.lbl_UserID.Text = "User ID";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(11, 198);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(148, 47);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(178, 141);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(245, 29);
            this.txt_UserID.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(178, 211);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(245, 29);
            this.txt_Password.TabIndex = 4;
            // 
            // gbx_UserType
            // 
            this.gbx_UserType.Controls.Add(this.rbtn_Nurse);
            this.gbx_UserType.Controls.Add(this.rbtn_Doctor);
            this.gbx_UserType.Controls.Add(this.rbtn_Admin);
            this.gbx_UserType.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_UserType.Location = new System.Drawing.Point(20, 13);
            this.gbx_UserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_UserType.Name = "gbx_UserType";
            this.gbx_UserType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_UserType.Size = new System.Drawing.Size(402, 81);
            this.gbx_UserType.TabIndex = 5;
            this.gbx_UserType.TabStop = false;
            this.gbx_UserType.Text = "User Type";
            // 
            // rbtn_Nurse
            // 
            this.rbtn_Nurse.AutoSize = true;
            this.rbtn_Nurse.Location = new System.Drawing.Point(308, 37);
            this.rbtn_Nurse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_Nurse.Name = "rbtn_Nurse";
            this.rbtn_Nurse.Size = new System.Drawing.Size(88, 37);
            this.rbtn_Nurse.TabIndex = 2;
            this.rbtn_Nurse.TabStop = true;
            this.rbtn_Nurse.Text = "Nurse";
            this.rbtn_Nurse.UseVisualStyleBackColor = true;
            this.rbtn_Nurse.CheckedChanged += new System.EventHandler(this.rbtn_Nurse_CheckedChanged);
            // 
            // rbtn_Doctor
            // 
            this.rbtn_Doctor.AutoSize = true;
            this.rbtn_Doctor.Location = new System.Drawing.Point(158, 37);
            this.rbtn_Doctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_Doctor.Name = "rbtn_Doctor";
            this.rbtn_Doctor.Size = new System.Drawing.Size(99, 37);
            this.rbtn_Doctor.TabIndex = 1;
            this.rbtn_Doctor.TabStop = true;
            this.rbtn_Doctor.Text = "Doctor";
            this.rbtn_Doctor.UseVisualStyleBackColor = true;
            this.rbtn_Doctor.CheckedChanged += new System.EventHandler(this.rbtn_Doctor_CheckedChanged);
            // 
            // rbtn_Admin
            // 
            this.rbtn_Admin.AutoSize = true;
            this.rbtn_Admin.Location = new System.Drawing.Point(10, 37);
            this.rbtn_Admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_Admin.Name = "rbtn_Admin";
            this.rbtn_Admin.Size = new System.Drawing.Size(98, 37);
            this.rbtn_Admin.TabIndex = 0;
            this.rbtn_Admin.TabStop = true;
            this.rbtn_Admin.Text = "Admin";
            this.rbtn_Admin.UseVisualStyleBackColor = true;
            this.rbtn_Admin.CheckedChanged += new System.EventHandler(this.rbtn_Admin_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(85, 313);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(122, 32);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(250, 313);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(122, 32);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel_LoginPanel
            // 
            this.panel_LoginPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_LoginPanel.Controls.Add(this.gbx_UserType);
            this.panel_LoginPanel.Controls.Add(this.btn_Reset);
            this.panel_LoginPanel.Controls.Add(this.lbl_UserID);
            this.panel_LoginPanel.Controls.Add(this.btn_Login);
            this.panel_LoginPanel.Controls.Add(this.lbl_Password);
            this.panel_LoginPanel.Controls.Add(this.txt_UserID);
            this.panel_LoginPanel.Controls.Add(this.txt_Password);
            this.panel_LoginPanel.Location = new System.Drawing.Point(232, 180);
            this.panel_LoginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_LoginPanel.Name = "panel_LoginPanel";
            this.panel_LoginPanel.Size = new System.Drawing.Size(461, 376);
            this.panel_LoginPanel.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(964, 741);
            this.Controls.Add(this.panel_LoginPanel);
            this.Controls.Add(this.lbl_Login);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbx_UserType.ResumeLayout(false);
            this.gbx_UserType.PerformLayout();
            this.panel_LoginPanel.ResumeLayout(false);
            this.panel_LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.GroupBox gbx_UserType;
        private System.Windows.Forms.RadioButton rbtn_Nurse;
        private System.Windows.Forms.RadioButton rbtn_Doctor;
        private System.Windows.Forms.RadioButton rbtn_Admin;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel_LoginPanel;
    }
}

