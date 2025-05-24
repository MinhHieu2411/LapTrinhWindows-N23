using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btln21
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btnAddHdv_Click(object sender, EventArgs e)
        {
            formNhapHDV formNhap = new formNhapHDV();
            formNhap.ShowDialog();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            formNhapVehicle formNhap = new formNhapVehicle();
            formNhap.ShowDialog();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {

        }
    }
}
