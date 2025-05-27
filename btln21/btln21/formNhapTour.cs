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
using System.Security.Cryptography;

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
        //auto lay gia tri cho textbox luong
        private void inputCN_tour_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(inputCN_tour.Text, out int number) && int.TryParse(inputDuration_tour.Text, out int day))
            {
                int revenue = number * day * 600000;
                inputRevenue_tour.Text = revenue.ToString();
                if(inputDuration_tour != null)
                {
                    vehiceFilter();
                }
            }
            else
            {
                inputRevenue_tour.Text = "";
            }
        }
        //lay ra hdv khi duration thay doi
        private void inputDuration_tour_TextChanged(object sender, EventArgs e)
        {
            hdvFilter();
            vehiceFilter();
        }
        //đoạn này hơi rườm rà vì chỉ lấy mỗi id ở combobox
        private void button1_Click(object sender, EventArgs e)
        {
            string id = inputID_tour.Text;
            string table = "Tour";
            string collumn = "TourID";
            string cusID = "", hdvID = "", vehID="";
            char space = ' ';
            //lay dung phan ID tu combobox------------------------------------------------------------------------------------
            for(int i =0; i<inputCus_tour.Text.Length; i++)
            {
                if(inputCus_tour.Text[i] == space)
                {
                    break;
                }
                else
                {
                    cusID += inputCus_tour.Text[i];
                }
            }
            for (int i = 0; i < inputHdv_tour.Text.Length; i++)
            {
                if (inputHdv_tour.Text[i] == space)
                {
                    break;
                }
                else
                {
                    hdvID += inputHdv_tour.Text[i];
                }
            }
            for (int i = 0; i < inputVehicle_tour.Text.Length; i++)
            {
                if (inputVehicle_tour.Text[i] == space)
                {
                    break;
                }
                else
                {
                    vehID += inputVehicle_tour.Text[i];
                }
            }
            DateTime start = inputStart_tour.Value.Date;
            if(string.IsNullOrEmpty(id) || !int.TryParse(inputDuration_tour.Text, out int duration) || !int.TryParse(inputCN_tour.Text, out int cusnumber) || string.IsNullOrEmpty(cusID) || string.IsNullOrEmpty(hdvID) || string.IsNullOrEmpty(vehID) || string.IsNullOrEmpty(inputRevenue_tour.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.");
                return;
            }
            //kiem tra trung lap---------------------------------------------------------------------------------------------------------------------------
            if(DatabaseHelper.checkID(id, table, collumn))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.");
                return;
            }
            int revenue = int.Parse(inputRevenue_tour.Text);
            bool success = DatabaseHelper.AddTour(id, start, duration, cusnumber, cusID, hdvID, vehID, revenue);
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
            loadCBCustomer();
            inputCN_tour.SelectedIndex = 0;
        }
        //dua vao cac combobox-----------------------------------------------------------------------------------------------------------------------------
        private void loadCBCustomer()
        {
            ComboBox cb = inputCus_tour;
            string clm1 = "CustomerID", clm2 = "Name", table = "Customer";
            LoadCB(table, clm1, clm2, cb);
        }
        //load cac data tu database ra combobox
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


        //lọc để lấy ra các hdv và vehicle khớp với startdate cũng như duration----------------------------------------------------------------------------
        private void hdvFilter()
        {
            DateTime startNew = inputStart_tour.Value.Date;
            int duration = int.Parse(inputDuration_tour.Text);
            DateTime endNew = startNew.AddDays(duration);
            //lọc ra những hướng dẫn viên đã có job trong khoảng thời gian mình cần từ bảng tour
            string query = @"SELECT tg.TourGuideID, tg.Name
            FROM TourGuide tg
            WHERE tg.TourGuideID NOT IN (
            SELECT t.TourGuideID FROM Tour t
            WHERE t.Start <= @EndNew AND DATEADD(day, t.Duration, t.Start) >= @StartNew)";

            using (SqlConnection con = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@StartNew", startNew);
                cmd.Parameters.AddWithValue("@EndNew", endNew);

                SqlDataReader reader = cmd.ExecuteReader();
                inputHdv_tour.Items.Clear(); 
                while (reader.Read())
                {
                    string hdv = reader["TourGuideID"].ToString() + " - " + reader["Name"].ToString();
                    inputHdv_tour.Items.Add(hdv);
                }
            }
        }
        private void vehiceFilter()
        {

            DateTime startNew = inputStart_tour.Value.Date;
            int duration = int.Parse(inputDuration_tour.Text);
            DateTime endNew = startNew.AddDays(duration);
            int customerNumber = int.Parse(inputCN_tour.Text);
            //lọc ra những xe đã được sử dụng trong khoảng thời gian mình cần từ bảng tour
            string query = @"SELECT xe.VehicleID, xe.LicensePlate
            FROM Vehicle xe 
            WHERE xe.VehicleID NOT IN (
            SELECT t.VehicleID FROM Tour t
            WHERE t.Start <= @EndNew AND DATEADD(day, t.Duration, t.Start) >= @StartNew)
            AND xe.Capability >= @customerNumber";

            using (SqlConnection con = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@StartNew", startNew);
                cmd.Parameters.AddWithValue("@EndNew", endNew);
                cmd.Parameters.AddWithValue("@customerNumber", customerNumber);

                SqlDataReader reader = cmd.ExecuteReader();
                inputVehicle_tour.Items.Clear(); 
                while (reader.Read())
                {
                    string hdv = reader["VehicleID"].ToString() + " - " + reader["LicensePlate"].ToString();
                    inputVehicle_tour.Items.Add(hdv);
                }
            }
        }
        
    }
}
