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
    public partial class EmployeeCard : UserControl
    {
        public EmployeeCard()
        {
            InitializeComponent();
        }

        private string _ID;

        public string EmployeeID
        {
            get { return _ID; }
            set { _ID = value; lbl_ID.Text = value; }
        }

        private string _name;

        public string EmployeeName
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = value; }
        }

        private string _position;

        public string EmployeePosition
        {
            get { return _position; }
            set { _position = value; lbl_position.Text = value; }
        }


    }
}
