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
    public partial class DocMDI : Form
    {
        string logged_in_as;
        Form loginForm;
        public DocMDI(string logged_in_as, Form loginForm)
        {
            InitializeComponent();
            this.logged_in_as = logged_in_as;
            this.loginForm = loginForm;
        }

        private void DocMDI_Load(object sender, EventArgs e)
        {
            signedInAsToolStripMenuItem.Text = "Signed in as " + logged_in_as;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_patient obj = new add_patient();

            var thisForm = ActiveMdiChild;
            if (thisForm != null)
            {
                thisForm.Close();
            }

            obj.MdiParent = this;
            obj.Show();
        }

     

        private void viewPatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_patient_info obj = new view_patient_info();

            var thisForm = ActiveMdiChild;
            if (thisForm != null)
            {
                thisForm.Close();
            }

            obj.MdiParent = this;
            obj.Show();
        }

        private void editPatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_patient_info obj = new edit_patient_info();

            var thisForm = ActiveMdiChild;
            if (thisForm != null)
            {
                thisForm.Close();
            }

            obj.MdiParent = this;
            obj.Show();
        }
    }
}
