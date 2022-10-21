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
    public partial class edit_patient_info : Form
    {
        public edit_patient_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Text = "";
            txt_patientFN.Text = "";
            txt_patientLN.Text = "";
            txt_patientG.Text = "";
            txt_patientAD.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
