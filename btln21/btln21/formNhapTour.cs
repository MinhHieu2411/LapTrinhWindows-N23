using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btln21
{
    public partial class formNhapTour : Form
    {
        public formNhapTour()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputCN_tour_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(inputCN_tour.Text, out int number) && int.TryParse(inputDuration_tour.Text, out int day))
            {
                int revenue = number * day * 600000;
                inputRevenue_tour.Text = revenue.ToString();
            }
            else
            {
                inputRevenue_tour.Text = "";
            }
        }
        //struggle đoạn này vì chưa biết làm thế nào để lấy mỗi id
        private void button1_Click(object sender, EventArgs e)
        {
            string id = inputID_tour.Text;
            string table = "Tour";
            string collumn = "TourID";
            DateTime start = inputStart_tour.Value.Date;
            if(string.IsNullOrEmpty(id) || !int.TryParse(inputDuration_tour.Text, out int duration) || !int.TryParse(inputCN_tour.Text, out int cusnumber) || string.IsNullOrEmpty(inputCus_tour.Text) || string.IsNullOrEmpty(inputHdv_tour.Text) || string.IsNullOrEmpty(inputVehicle_tour.Text) || string.IsNullOrEmpty(inputRevenue_tour.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.");
                return;
            }
            //kiem tra trung lap
            if(DatabaseHelper.checkID(id, table, collumn))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.");
                return;
            }
            int revenue = int.Parse(inputRevenue_tour.Text);
            bool success = DatabaseHelper.AddTour(id.Trim(), start, duration, cusnumber, inputCus_tour.Text.Trim(), inputHdv_tour.Text.Trim(), inputVehicle_tour.Text.Trim(), revenue);
            if (success)
            {
                MessageBox.Show("Thêm Tour thành công!", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm vào cơ sở dữ liệu.", "Lỗi");
            }

        }

        private void formNhapTour_Load(object sender, EventArgs e)
        {
            loadCBHdv();
            loadCBCustomer();
            loadCBVehicle();
        }

        private void loadCBHdv()
        {
            ComboBox cb = inputHdv_tour;
            string clm1 = "TourGuideID", clm2 = "Name", table = "TourGuide";
            LoadCB(table, clm1, clm2, cb);
        }
        private void loadCBCustomer()
        {
            ComboBox cb = inputCus_tour;
            string clm1 = "CustomerID", clm2 = "Name", table = "Customer";
            LoadCB(table, clm1, clm2, cb);
        }
        private void loadCBVehicle()
        {
            ComboBox cb = inputVehicle_tour;
            string clm1 = "VehicleID", clm2 = "LicensePlate", table = "Vehicle";
            LoadCB(table, clm1, clm2, cb);
        }
        private void LoadCB(string table, string clm1, string clm2, ComboBox cb)
        {
            string query = "SELECT " + clm1 + "," + clm2 + " FROM " + table;
            using (SqlConnection con = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                cb.Items.Clear();

                while (reader.Read())
                {
                    cb.Items.Add(reader[clm1].ToString() + " - " + reader[clm2].ToString());
                }
            }
        }
        

        
    }
}
