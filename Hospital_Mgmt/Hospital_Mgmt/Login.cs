using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Mgmt
{
    public partial class Login : Form
    {
        private string accessID = "";
        Form adminForm;
        Form docForm;
        Form nurseForm;

        public Login()
        {
            InitializeComponent();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            lbl_Login.Top = 25;
            panel_LoginPanel.Visible = true;
            panel_LoginPanel.Top = 200;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_Login.Top = 270;
            panel_LoginPanel.Visible = false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            rbtn_Admin.Checked = false;
            rbtn_Doctor.Checked = false;
            rbtn_Nurse.Checked = false;
            txt_UserID.Text = "";
            txt_Password.Text = "";
        }

        private void rbtn_Admin_CheckedChanged(object sender, EventArgs e)
        {
            accessID = "ADMIN";
        }

        private void rbtn_Doctor_CheckedChanged(object sender, EventArgs e)
        {
            accessID = "DOCTOR";
        }

        private void rbtn_Nurse_CheckedChanged(object sender, EventArgs e)
        {
            accessID = "NURSE";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (accessID.Equals("ADMIN"))
            {
                if (txt_UserID.Text.Equals("admin"))
                {
                    if (txt_Password.Text.Equals("admin"))
                    {
                        adminForm = new AdminMDI(txt_UserID.Text, this);
                        rbtn_Admin.Checked = false;
                        rbtn_Doctor.Checked = false;
                        rbtn_Nurse.Checked = false;
                        txt_UserID.Text = "";
                        txt_Password.Text = "";
                        adminForm.Show();
                        adminForm.FormClosing += (obj, args) => { this.Close(); };
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User ID");
                }
            }
            else if (accessID.Equals("DOCTOR"))
            {
                if (txt_UserID.Text.Equals("doc"))
                {
                    if (txt_Password.Text.Equals("doc"))
                    {
                        docForm = new DocMDI(txt_UserID.Text, this);
                        rbtn_Admin.Checked = false;
                        rbtn_Doctor.Checked = false;
                        rbtn_Nurse.Checked = false;
                        txt_UserID.Text = "";
                        txt_Password.Text = "";
                        docForm.Show();
                        docForm.FormClosing += (obj, args) => { this.Close(); };
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User ID");
                }
            }
            else if (accessID.Equals("NURSE"))
            {
                if (txt_UserID.Text.Equals("nurse"))
                {
                    if (txt_Password.Text.Equals("nurse"))
                    {
                        nurseForm = new NurseMDI(txt_UserID.Text, this);
                        rbtn_Admin.Checked = false;
                        rbtn_Doctor.Checked = false;
                        rbtn_Nurse.Checked = false;
                        txt_UserID.Text = "";
                        txt_Password.Text = "";
                        nurseForm.Show();
                        nurseForm.FormClosing += (obj, args) => { this.Close(); };
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User ID");
                }
            }
            else
            {
                MessageBox.Show("Wrong Access ID");
            }
        }
    }
}
