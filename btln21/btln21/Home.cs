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
            formNhapTour formNhap = new formNhapTour();
            formNhap.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            getHDV();
            getVehicle();
        }
        private void getHDV()
        {
            string query = "Select * from TourGuide";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvHDV.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dgvHDV.Rows.Add(row["TourGuideID"], row["Name"], row["YearOfBirth"], row["Phone"], row["Address"], row["Works"], row["Salary"]);
            }
        }
        private void getVehicle()
        {
            string query = "Select * from Vehicle";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvVehicles.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                dgvVehicles.Rows.Add(row["VehicleID"], row["Description"], row["LisencePlate"], row["Capability"]);
            }
        }
    }
}
