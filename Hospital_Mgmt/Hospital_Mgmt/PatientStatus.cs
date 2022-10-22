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
    public partial class PatientStatus : UserControl
    {
        public PatientStatus()
        {
            InitializeComponent();
        }

        private int _ID;

        public int Exp_ID
        {
            get { return _ID; }
            set { _ID = value; txt_ID.Text = value.ToString(); }
        }

        private string _name;

        public string Exp_Name
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = value; }
        }

        private int _age;

        public int Exp_Age
        {
            get { return _age; }
            set { _age = value; lbl_age.Text = value.ToString(); }
        }


    }
}
