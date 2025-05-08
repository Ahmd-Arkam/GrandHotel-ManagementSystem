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
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "grand" && txtPassword.Text == "grand123")
            {
                frmDashboard dashbord = new frmDashboard();
                dashbord.ShowDialog();
                this.Close();
            }
        }
    }
}
