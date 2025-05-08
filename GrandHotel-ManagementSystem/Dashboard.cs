using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotel_ManagementSystem
{
    public partial class frmDashboard: Form
    {
        public frmDashboard()
        {
           

            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = true;
            controllDashboard1.Visible = true;
            controllDashboard1.BringToFront();
            btnBooking.Checked = false; 
            btnRoom.Checked = false;
            btnStaff.Checked = false;
            btnCheckOut.Checked = false;
            lblChngeTittle.Text = "Dashboard";
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            btnBooking.Checked = true;
            bookingController1.Visible = true;
            bookingController1.BringToFront();
            btnDashboard.Checked = false;
            btnRoom.Checked = false;
            btnStaff.Checked = false;
            btnCheckOut.Checked = false;
            lblChngeTittle.Text = "Booking";
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            btnRoom.Checked = true;
            roomController1.Visible = true;
            roomController1.BringToFront(); 
            btnDashboard.Checked = false;
            btnBooking.Checked = false;
            btnStaff.Checked = false;
            btnCheckOut.Checked = false;
            lblChngeTittle.Text = "Room";

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            btnStaff.Checked = true;
            staffController1.Visible=true;
            staffController1.BringToFront();
            btnRoom.Checked=false;
            btnBooking.Checked=false;
            btnDashboard.Checked=false;
            btnCheckOut.Checked=false;
            lblChngeTittle.Text = "Staff";

        }
    }
}
