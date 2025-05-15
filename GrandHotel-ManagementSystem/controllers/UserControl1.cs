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
    public partial class ControllDashboard: UserControl
    {
        public ControllDashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pitSlidShow01.Visible == true)
            {
                pitSlidShow01.Visible = false;
                pitSlidShow02.Visible = true;
            }
            else if (pitSlidShow02.Visible == true)
            {
                pitSlidShow02.Visible = false;
                pitSlidShow03.Visible = true;
            }
            else if (pitSlidShow03.Visible == true)
            {
                pitSlidShow03.Visible = false;
                pitSlidShow04.Visible = true;
            }
            else if (pitSlidShow04.Visible == true) { 
            pitSlidShow04 .Visible = false;
                pitSlidShow01.Visible=true;
            }
        }

        private void ControllDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pitSlidShow02_Click(object sender, EventArgs e)
        {

        }
    }
}
