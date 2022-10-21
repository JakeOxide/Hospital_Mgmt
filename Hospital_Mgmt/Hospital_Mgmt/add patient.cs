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
    public partial class add_patient : Form
    {
        public add_patient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_patientid.Text = "";
            txt_patientFN.Text = "";
            txt_patientLN.Text = "";
            txt_patientG.Text = "";
            txt_patientAD.Text = "";
          

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
