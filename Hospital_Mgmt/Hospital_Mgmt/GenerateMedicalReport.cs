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
    public partial class GenerateMedicalReport : Form
    {
        MedicationStatus medicationStatus1;
        public GenerateMedicalReport()
        {
            InitializeComponent();
            medicationStatus1 = new MedicationStatus();
        }

        private void GenerateMedicalReport_Load(object sender, EventArgs e)
        {
            medicationStatus1.Exp_Address = "ETH";
            medicationStatus1.Exp_Age = 20;
            medicationStatus1.Exp_Gender = "Male";
            medicationStatus1.Exp_PatientName = "Dman";
            medicationStatus1.Exp_PetientID = 125689;
            medicationStatus1.Exp_Recommendation = "Just Die";
            medicationStatus1.Exp_RoomNo = "052";
            medicationStatus1.Exp_Treatment = "I said die already";
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.Controls.Add(medicationStatus1);
        }
    }
}
