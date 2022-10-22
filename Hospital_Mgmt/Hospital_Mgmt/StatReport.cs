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
    public partial class StatReport : UserControl
    {
        public StatReport()
        {
            InitializeComponent();
        }

        private string _totalDocs;

        public string total_Docs
        {
            get { return _totalDocs; }
            set { _totalDocs = value; lbl_emp_tot_doc.Text = value; }
        }

        private string _totalAdmins;

        public string total_Admins
        {
            get { return _totalAdmins; }
            set { _totalAdmins = value; lbl_emp_tot_adm.Text = value; }
        }

        private string _totalNurses;

        public string total_Nurses
        {
            get { return _totalNurses; }
            set { _totalNurses = value; lbl_emp_tot_nur.Text = value; }
        }

        private string _totalEmployees;

        public string total_Employees
        {
            get { return _totalEmployees; }
            set { _totalEmployees = value; lbl_emp_tot_total.Text = value; }
        }

        private int _total_Patients;

        public int total_Patients
        {
            get { return _total_Patients; }
            set { _total_Patients = value; lbl_pat_tot_total.Text = value.ToString(); }
        }


    }
}
