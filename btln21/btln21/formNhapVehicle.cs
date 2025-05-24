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
    public partial class formNhapVehicle : Form
    {
        public formNhapVehicle()
        {
            InitializeComponent();
        }

        private void formNhapVehicle_Load(object sender, EventArgs e)
        {
            this.Text = "Phương tiện";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
