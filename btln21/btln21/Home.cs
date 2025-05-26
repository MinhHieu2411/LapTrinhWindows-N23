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
        //double click vao 1 cell

        private void dgvHDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //cac nut them--------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            formNhapVehicle formNhap = new formNhapVehicle();
            formNhap.Closed += (s, e) => getVehicle();
            formNhap.ShowDialog();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            formNhapTour formNhap = new formNhapTour();
            formNhap.ShowDialog();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            formNhapKH formNhap = new formNhapKH();
            formNhap.Closed += (s, e) => getCustomer();
            formNhap.ShowDialog();
        }
        private void btnAddHdv_Click(object sender, EventArgs e)
        {
            formNhapHDV formNhap = new formNhapHDV();
            formNhap.Closed += (s, e) => getHDV();
            formNhap.ShowDialog();
        }
        //cac nut xoa -----------------------------------------------------------------------------------------------------------------------------------------------------
        //xoa hdv ----------------------------------------------------------------------------------
        private void btnDeleteHdv_Click(object sender, EventArgs e)
        {
            string table = "Tourguide";
            string collumn = "TourGuideID";
            if (dgvHDV.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa hướng dẫn viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvHDV.CurrentRow;
                    string id = row.Cells[0].Value.ToString();

                    bool success = DatabaseHelper.Delete(id, table, collumn);
                    if (success)
                    {
                        MessageBox.Show("Xóa hướng dẫn viên thành công!", "Thông báo");
                        getHDV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, không thể xóa", "Lỗi");
                    }
                }
                else { return; }
            }
        }
        //xoa khach hang --------------------------------------------------------------------------------
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string table = "Customer";
            string collumn = "CustomerID";
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvCustomers.CurrentRow;
                    string id = row.Cells[0].Value.ToString();

                    bool success = DatabaseHelper.Delete(id, table, collumn);
                    if (success)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                        getCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, không thể xóa", "Lỗi");
                    }
                }
                else { return; }
            }
        }
        //xoa phuong tien ----------------------------------------------------------------------------------
        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            string table = "Vehicle";
            string collumn = "VehicleID";
            if (dgvVehicles.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa phương tiện này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvVehicles.CurrentRow;
                    string id = row.Cells[0].Value.ToString();

                    bool success = DatabaseHelper.Delete(id, table, collumn);
                    if (success)
                    {
                        MessageBox.Show("Xóa phương tiện thành công!", "Thông báo");
                        getVehicle();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, không thể xóa", "Lỗi");
                    }
                }
                else { return; }
            }
        }
        //cac nut sua-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnEditHdv_Click(object sender, EventArgs e)
        {
            if (dgvHDV.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

            }
        }
        




        //khởi chạy ở home-----------------------------------------------------------------------------------------------------------------------------------------------
        private void Home_Load(object sender, EventArgs e)
        {
            getHDV();
            getCustomer();
            getVehicle();
            GetTour();
        }


        //load du lieu
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
            foreach (DataRow row in dt.Rows)
            {
                dgvVehicles.Rows.Add(row["VehicleID"], row["Description"], row["LicensePlate"], row["Capability"]);
            }
        }
        private void GetTour()
        {
            string query = "Select * from Tour";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvTours.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvTours.Rows.Add(row["TourID"], row["Start"], row["Duration"], row["CustomerNumber"], row["CustomerID"], row["TourGuideID"], row["VehicleID"], row["Revenue"], row["Status"]);
            }
        }
        private void getCustomer()
        {
            string query = "Select * from Customer";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvCustomers.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvCustomers.Rows.Add(row["CustomerID"], row["Name"], row["YearOfBirth"], row["Phone"], row["Address"]);
            }
        }

        
    }
}
