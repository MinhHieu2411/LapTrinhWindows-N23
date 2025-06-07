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
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;

namespace btln21
{
    public partial class formNhapHDV : Form
    {
        //để dành cho sự kiện doubleclick vào cell và nhấn nút sửa ở home
        bool isEdit = false;
        bool isRead = false;

        public formNhapHDV()
        {
            InitializeComponent();
            isEdit = false;
            isRead = false;
        }
        //hàm load sự kiện sửa (edit)
        public formNhapHDV(string id, string name, int yearOfBirth, string phone, string address, int works)
        {
            InitializeComponent();
            isEdit = true;

            // không cho sửa id
            inputID_hdv.Enabled = false;
            btnConfirm.Text = "Cập nhật";

            inputID_hdv.Text = id;
            inputName_hdv.Text = name;
            inputYob_hdv.Text = yearOfBirth.ToString();
            inputPhone_hdv.Text = phone;
            inputAddress_hdv.Text = address;
            inputYears_hdv.Text = works.ToString();


        }
        //sự kiện đọc
        public formNhapHDV(string id, string name, int yearOfBirth, string phone, string address, int works, bool isReadMode)
        {

            InitializeComponent();
            isRead = isReadMode;


            if(isRead)
            {

                inputID_hdv.Text = id;
                inputName_hdv.Text = name;
                inputYob_hdv.Text = yearOfBirth.ToString();
                inputPhone_hdv.Text = phone;
                inputAddress_hdv.Text = address;
                inputYears_hdv.Text = works.ToString();

                inputID_hdv.Enabled = false;
                inputName_hdv.Enabled = false;
                inputYob_hdv.Enabled = false;
                inputPhone_hdv.Enabled = false;
                inputAddress_hdv.Enabled = false;
                inputYears_hdv.Enabled = false;

                btnConfirm.Visible = false;
            }
        }

        private void formNhapHDV_Load(object sender, EventArgs e)
        {
        }
        //nut xac nhan
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(inputID_hdv.Text) || string.IsNullOrWhiteSpace(inputName_hdv.Text) || string.IsNullOrEmpty(inputAddress_hdv.Text) || !int.TryParse(inputYob_hdv.Text, out int year) || string.IsNullOrEmpty(inputPhone_hdv.Text) || !int.TryParse(inputYears_hdv.Text, out int works))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.");
                return;
            }

            //su kien them nhu binh thuong
            if (!isEdit)
            {

                string id = inputID_hdv.Text;
                string name = inputName_hdv.Text;
                string phone = inputPhone_hdv.Text;
                string address = inputAddress_hdv.Text;
                string table = "TourGuide";
                string collumn = "TourGuideID";
            
            //check xem co truong nao nhap sai hoac de trong
                
                //check lai id neu trung lap (dbhelper)
                if (DatabaseHelper.checkID(inputID_hdv.Text, table, collumn))
                {
                    MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.");
                    return;
                }
                decimal salary = 10000000 + (500000 * works);
                bool success = DatabaseHelper.AddTourGuide(id, name, year, phone, address, inputYears_hdv.Text.ToString(), salary);

                if (success)
                {
                MessageBox.Show("Đã thêm hướng dẫn viên thành công!");
                    this.Close(); 
                }
                else
                {
                MessageBox.Show("Lỗi khi thêm vào cơ sở dữ liệu.");
                }
            }
            //nếu sự kiện sửa xảy ra
            else
            {

                string id = inputID_hdv.Text;
                string name = inputName_hdv.Text;
                string phone = inputPhone_hdv.Text;
                string address = inputAddress_hdv.Text;
                decimal salary = 10000000 + works * 500000;
                btnConfirm.Text = "Cập nhật";
                string query = @"UPDATE TourGuide 
                    SET Name = @name, YearOfBirth = @year, Phone = @phone, Address = @address, Works = @works, Salary = @salary
                    WHERE TourGuideID = @id";

                using (SqlConnection con = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@works", works);
                    cmd.Parameters.AddWithValue("@salary", salary);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hướng dẫn viên để cập nhật");
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //tự động nhập lương dựa trên năm làm việc
        private void inputYears_hdv_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(inputYears_hdv.Text, out int year))
            {
                decimal salary = 10000000 + (500000 * year);
                inputSalary_hdv.Text = salary.ToString();
            }
            else
            {
                inputSalary_hdv.Text = "";
            }
        }
        //chặn các ký tự không phải số trong ô nhập năm làm việc
        private void inputYears_hdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
