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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string id = inputID_vehicle.Text.Trim();
            string table = "Vehicle";
            string collumn = "VehicleID";
            //check xem co truong nao trong khong
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(inputDes_vehicle.Text) || string.IsNullOrEmpty(inputLP_vehicle.Text) || string.IsNullOrEmpty(inputCap_vehicle.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.");
                return;
            }
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
