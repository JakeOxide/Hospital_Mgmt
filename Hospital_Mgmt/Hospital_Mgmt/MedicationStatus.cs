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
    public partial class MedicationStatus : UserControl
    {
        public MedicationStatus()
        {
            InitializeComponent();
        }

        private int _PatientID;

        public int Exp_PetientID
        {
            get { return _PatientID; }
            set { _PatientID = value; txtBox_patient_ID.Text = value.ToString(); }
        }

        private string _PatientName;

        public string Exp_PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value;  txtBox_patient_name.Text = value.ToString(); }
        }

        private string _Gender;

        public string Exp_Gender
        {
            get { return _Gender; }
            set { _Gender = value; txtBox_gender.Text = value.ToString(); }
        }

        private int _Age;

        public int Exp_Age
        {
            get { return _Age; }
            set { _Age = value; txtBox_age.Text = value.ToString(); }
        }

        private string _Address;

        public string Exp_Address
        {
            get { return _Address; }
            set { _Address = value; txtBox_address.Text = value.ToString(); }
        }

        private string _RoomNo;

        public string Exp_RoomNo
        {
            get { return _RoomNo; }
            set { _RoomNo = value; txtBox_room_no.Text = value.ToString(); }
        }

        private string _Treatment;

        public string Exp_Treatment
        {
            get { return _Treatment; }
            set { _Treatment = value; txtBox_treatment.Text = value.ToString(); }
        }

        private string _Recommendation;

        public string Exp_Recommendation
        {
            get { return _Recommendation; }
            set { _Recommendation = value; txtBox_recommendation.Text = value.ToString(); }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }

        private void MedicationStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
