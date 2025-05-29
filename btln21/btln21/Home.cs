using Microsoft.VisualBasic.Devices;
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
        //double click vao 1 cell ở hướng dẫn viên---------------------------------------------------------------------------

        private void dgvHDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHDV.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                int year = Convert.ToInt32(row.Cells[2].Value);
                string phone = row.Cells[3].Value.ToString();
                string address = row.Cells[4].Value.ToString();
                int works = Convert.ToInt32(row.Cells[5].Value);

                // true = readonly
                formNhapHDV viewForm = new formNhapHDV(id, name, year, phone, address, works, true);
                viewForm.ShowDialog();
            }
        }
        //doubleclick vào một cell ở phương tiện-------------------------------------------------------------------------------
        private void dgvVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string des = row.Cells[1].Value.ToString();
                string lp = row.Cells[2].Value.ToString();
                int cap = Convert.ToInt32(row.Cells[3].Value);

                // true = readonly
                formNhapVehicle viewForm = new formNhapVehicle(id, des, lp, cap, true);
                viewForm.ShowDialog();
            }
        }//doubleclick vào một cell ở khách hàng--------------------------------------------------------------------------------
        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                int yob = Convert.ToInt32(row.Cells[2].Value);
                string phone = row.Cells[3].Value.ToString();
                string address = row.Cells[4].Value.ToString();

                // true = readonly
                formNhapKH viewForm = new formNhapKH(id, name, yob, phone, address, true);
                viewForm.ShowDialog();
            }
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
            formNhap.Closed += (s, e) => GetTour();
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
        //xoa hdv --------------------------------------------------------------------------------------
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
        //xoa tour -------------------------------------------------------------------------------------------
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            string table = "Tour";
            string collumn = "TourID";
            if (dgvTours.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa Tour này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvTours.CurrentRow;
                    string id = row.Cells[0].Value.ToString();

                    bool success = DatabaseHelper.Delete(id, table, collumn);
                    if (success)
                    {
                        MessageBox.Show("Xóa Tour thành công!", "Thông báo");
                        GetTour();
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
        //hdv
        private void btnEditHdv_Click(object sender, EventArgs e)
        {
            if (dgvHDV.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string id = dgvHDV.CurrentRow.Cells[0].Value.ToString();
                string name = dgvHDV.CurrentRow.Cells[1].Value.ToString();
                int year = Convert.ToInt32(dgvHDV.CurrentRow.Cells[2].Value);
                string phone = dgvHDV.CurrentRow.Cells[3].Value.ToString();
                string address = dgvHDV.CurrentRow.Cells[4].Value.ToString();
                int works = Convert.ToInt32(dgvHDV.CurrentRow.Cells[5].Value);

                formNhapHDV editForm = new formNhapHDV(id, name, year, phone, address, works);

                editForm.Closed += (s, e) => getHDV();
                editForm.ShowDialog();
            }
        }
        //phuong tien
        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string id = dgvVehicles.CurrentRow.Cells[0].Value.ToString();
                string des = dgvVehicles.CurrentRow.Cells[1].Value.ToString();
                string lp = dgvVehicles.CurrentRow.Cells[2].Value.ToString();
                int cap = Convert.ToInt32(dgvVehicles.CurrentRow.Cells[3].Value);

                formNhapVehicle editForm = new formNhapVehicle(id, des, lp, cap);
                editForm.Closed += (s, e) => getVehicle();
                editForm.ShowDialog();
            }
        }
        //khach hang
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string id = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                int yob = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[2].Value);
                string phone = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
                string address = dgvCustomers.CurrentRow.Cells[4].Value.ToString();


                formNhapKH editForm = new formNhapKH(id, name, yob, phone, address);
                editForm.Closed += (s, e) => getCustomer();
                editForm.ShowDialog();
            }
        }
        //tour
        private void btnEditTour_Click(object sender, EventArgs e)
        {
            if (dgvTours.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dòng mà bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string id = dgvTours.CurrentRow.Cells[0].Value.ToString();
                DateTime date = Convert.ToDateTime(dgvTours.CurrentRow.Cells[1].Value).Date;
                int duration = Convert.ToInt32(dgvTours.CurrentRow.Cells[2].Value);
                int cusnumber = Convert.ToInt32(dgvTours.CurrentRow.Cells[3].Value);
                string cusID = dgvTours.CurrentRow.Cells[4].Value.ToString();
                string hdvID = dgvTours.CurrentRow.Cells[5].Value.ToString();
                string vehID = dgvTours.CurrentRow.Cells[6].Value.ToString();
                int revenue = Convert.ToInt32(dgvTours.CurrentRow.Cells[7].Value);


                formNhapTour editForm = new formNhapTour(id, date, duration, cusnumber, cusID, hdvID, vehID, revenue);
                editForm.Closed += (s, e) => GetTour();
                editForm.ShowDialog();
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


        //load du lieu------------------------------------------------------------------------------------------------------------------------------------
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

        //tìm kiếm theo sự thay đổi của textbox search----------------------------------------------------------------------------------------------------
        private void txtSearchHdv_TextChanged(object sender, EventArgs e)
        {
            find(dgvHDV, txtSearchHdv);
        }

        private void txtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            find(dgvVehicles, txtSearchVehicle);
        }
        private void txtSearchTour_TextChanged(object sender, EventArgs e)
        {
            find(dgvTours, txtSearchTour);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            find(dgvCustomers, txtSearchCustomer);
        }
        //hàm tìm-----------------------------------------------------------------------------
        private void find(DataGridView dgv, TextBox txtfind)
        {
            string f = txtfind.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgv.Rows)
            {

                if (row.IsNewRow) continue;
                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().ToLower().Contains(f))
                    {
                        visible = true;
                        break;
                    }
                }
                row.Visible = visible;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
        //them quản trị viên-----------------------------------------------------------------------------------------------------------------------------------
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            formNhapAdmin formNhap = new formNhapAdmin();
            formNhap.ShowDialog();
        }
        //đăng xuất----------------------------------------------------------------------------------------------------------------------------------------
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn sắp đăng xuất", "Thông báo", MessageBoxButtons.OKCancel);

            if(dialog == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
