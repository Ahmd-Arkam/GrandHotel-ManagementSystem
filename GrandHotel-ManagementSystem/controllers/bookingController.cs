using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotel_ManagementSystem.controllers
{
    public partial class bookingController: UserControl
    {
        public bookingController()
        {
            InitializeComponent();
        }

        private void bookingController_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnAddCustomer.Checked = true;
            AddCustomerGroup1.Visible = true;
            btnCustomerView.Checked = false;
            customerView1.Visible = false;
            btnCustomerHistory.Checked = false;
            customerHistory1.Visible = false;

        }

        private void btnCustomerView_Click(object sender, EventArgs e)
        {
            btnCustomerView.Checked = true;
            customerView1.Visible = true;
            customerView1.BringToFront();
            btnAddCustomer.Checked = false;
            AddCustomerGroup1.Visible = false;
            btnCustomerHistory.Checked = false;

        }

        private void btnCustomerHistory_Click(object sender, EventArgs e)
        {
            btnCustomerHistory.Checked = true;
            customerHistory1.Visible = true;
            customerHistory1.BringToFront();
            btnCustomerView.Checked = false;
            btnAddCustomer.Checked = false;
            AddCustomerGroup1.Visible = false;
            customerView1.Visible = false;
           
        }
    }
}
