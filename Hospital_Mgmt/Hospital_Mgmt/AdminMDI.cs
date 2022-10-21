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
    public partial class AdminMDI : Form
    {
        private string logged_in_as;
        Form loginForm;
        public AdminMDI(string logged_in_as, Form loginForm)
        {
            InitializeComponent();
            this.logged_in_as = logged_in_as;
            this.loginForm = loginForm;
        }

        private void AdminMDI_Load(object sender, EventArgs e)
        {
            loggedInAsToolStripMenuItem.Text = "Signed in as " + logged_in_as;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new AddEmployee();

            var thisForm = ActiveMdiChild;
            if(thisForm != null)
            {
                thisForm.Close();
            }

            obj.MdiParent = this;
            obj.Show();
        }
    }
}
