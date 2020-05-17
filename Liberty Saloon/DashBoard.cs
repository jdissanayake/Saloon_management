using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liberty_Saloon
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            home1.Visible = true;
            appoinment1.Visible = false;
            attendence1.Visible = false;
            customer1.Visible = false;
            payment1.Visible = false;
            employee1.Visible = false;
        }

        private void bTnHome_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            appoinment1.Visible = false;
            attendence1.Visible = false;
            customer1.Visible = false;
            payment1.Visible = false;
            employee1.Visible = false;
        }

        private void bTnAttendence_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            appoinment1.Visible = false;
            attendence1.Visible = true;
            customer1.Visible = false;
            payment1.Visible = false;
            employee1.Visible = false;
        }

        private void bTnAppoinment_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            appoinment1.Visible = true;
            attendence1.Visible = false;
            customer1.Visible = false;
            payment1.Visible = false;
            employee1.Visible = false;
        }

        private void bTnPayment_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            appoinment1.Visible = false;
            attendence1.Visible = false;
            customer1.Visible = false;
            payment1.Visible = true;
            employee1.Visible = false;
        }

        private void bTnCustomer_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            appoinment1.Visible = false;
            attendence1.Visible = false;
            customer1.Visible = true;
            payment1.Visible = false;
            employee1.Visible = false;
        }

        private void bTnEmployee_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            appoinment1.Visible = false;
            attendence1.Visible = false;
            customer1.Visible = false;
            payment1.Visible = false;
            employee1.Visible = true;
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
