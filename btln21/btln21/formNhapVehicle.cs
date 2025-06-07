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
    public partial class formNhapVehicle : Form
    {
        //dùng cho sự kiện doubleclick vào cell và nút sửa ở home
        bool isEdit = false;
        bool isRead = false;
        string editVehicleID;
        public formNhapVehicle()
        {
            InitializeComponent();
            isEdit = false;
            isRead = false;
        }
        //load sự kiện sửa
        public formNhapVehicle(string id, string des, string licenseplate, int cap)
        {
            InitializeComponent();
            isEdit = true;
            editVehicleID = id;

            //không cho sửa id
            inputID_vehicle.Enabled = false;
            btnConfirm.Text = "Cập nhật";

            inputID_vehicle.Text = id;
            inputDes_vehicle.Text= des;
            inputLP_vehicle.Text = licenseplate;
            inputCap_vehicle.Text = cap.ToString();

        }
        //sự kiện đọc
        public formNhapVehicle(string id, string des, string licenseplate, int cap, bool isReadMode)
        {
            InitializeComponent();
            isRead = isReadMode;

            if (isRead)
            {
                inputID_vehicle.Text = id;
                inputDes_vehicle.Text = des;
                inputLP_vehicle.Text = licenseplate;
                inputCap_vehicle.Text = cap.ToString();

                inputID_vehicle.Enabled = false;
                inputDes_vehicle.Enabled = false;
                inputLP_vehicle.Enabled= false;
                inputCap_vehicle.Enabled = false;

                btnConfirm.Visible = false;
            }
        }
        private void formNhapVehicle_Load(object sender, EventArgs e)
        {
            this.Text = "Phương tiện";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputID_vehicle.Text) || string.IsNullOrEmpty(inputDes_vehicle.Text) || string.IsNullOrEmpty(inputLP_vehicle.Text) || string.IsNullOrEmpty(inputCap_vehicle.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.");
                return;
            }

            //nếu sự kiện sửa xảy ra
            if (isEdit)
            {
                string id = inputID_vehicle.Text;
                string des = inputDes_vehicle.Text;
                string licenseplate = inputLP_vehicle.Text;
                int cap = Convert.ToInt32(inputCap_vehicle.Text);
                btnConfirm.Text = "Cập nhật";
                string query = @"UPDATE Vehicle
                    SET Description = @des, LicensePlate = @licenseplate, Capability = @cap
                    WHERE VehicleID = @id";

                using (SqlConnection con = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("des", des);
                    cmd.Parameters.AddWithValue("licenseplate", licenseplate);
                    cmd.Parameters.AddWithValue("cap", cap);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phương tiện để cập nhật");
                    }
                }
            }
            //su kien them nhu binh thuong
            else
            {

                string id = inputID_vehicle.Text;
                string des = inputDes_vehicle.Text;
                string licenseplate = inputLP_vehicle.Text;
                int cap = Convert.ToInt32(inputCap_vehicle.Text);
                string table = "Vehicle";
                string collumn = "VehicleID";
                //check xem co truong nao trong khong
                
                //kiem tra trung lap 
                if (DatabaseHelper.checkID(id, table, collumn))
                {
                    MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.");
                    return;
                }
                bool success = DatabaseHelper.AddVehicle(id, inputDes_vehicle.Text.Trim(), inputLP_vehicle.Text.Trim(), int.Parse(inputCap_vehicle.Text));
                if (success)
                {
                    MessageBox.Show("Thêm phương tiện thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm vào cơ sở dữ liệu.", "Lỗi");
                }
            }
        }
    }
}
