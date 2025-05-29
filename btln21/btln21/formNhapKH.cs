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
    public partial class formNhapKH : Form
    {
        //dùng cho sự kiện doubleclick vào cell và nút sửa ở home
        bool isEdit = false;
        bool isRead = false;
        string editCustomerID;
        public formNhapKH()
        {
            InitializeComponent();
            isEdit = false;
            isRead = false;
        }
        //load sự kiện sửa
        public formNhapKH(string id, string name, int yearOfBirth, string phone, string address)
        {
            InitializeComponent();
            isEdit = true;
            editCustomerID = id;
            
            //không cho sửa id
            inputID_customer.Enabled = false;
            btnConfirm.Text = "Cập nhật";

            inputID_customer.Text = id;
            inputName_customer.Text = name;
            inputYob_customer.Text = yearOfBirth.ToString();
            inputPhone_customer.Text = phone;
            inputAddress_customer.Text = address;

        }
        //sự kiện đọc
        public formNhapKH(string id, string name, int yearOfBirth, string phone, string address, bool isReadMode)
        {
            InitializeComponent();
            isRead = isReadMode;

            if (isRead)
            {

                inputID_customer.Text = id;
                inputName_customer.Text = name;
                inputYob_customer.Text = yearOfBirth.ToString();
                inputPhone_customer.Text = phone;
                inputAddress_customer.Text = address;

                inputID_customer.Enabled = false;
                inputName_customer.Enabled = false;
                inputYob_customer.Enabled = false;
                inputPhone_customer.Enabled = false;
                inputAddress_customer.Enabled = false;

                btnConfirm.Visible = false;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id = inputID_customer.Text;
            string name = inputName_customer.Text;
            string address = inputAddress_customer.Text;
            int yob = Convert.ToInt32(inputYob_customer.Text);
            string phone = inputPhone_customer.Text;

            //nếu là sự kiện sửa
            if (isEdit)
            {
                string query = @"UPDATE Customer
                    SET Name = @name, YearOfBirth = @yob, Phone = @phone, Address = @Address
                    WHERE CustomerID = @id";

                using (SqlConnection con = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@yob", yob);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để cập nhật");
                    }
                }
            }
            //sự kiện thêm
            else
            {
                string table = "Customer";
                string collumn = "CustomerID";
                //check xem co truong nao trong khong
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(inputName_customer.Text) || !int.TryParse(inputYob_customer.Text, out int year) || string.IsNullOrEmpty(inputPhone_customer.Text) || string.IsNullOrEmpty(inputAddress_customer.Text))
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
                bool success = DatabaseHelper.AddCustomer(id, inputName_customer.Text.Trim(), year, inputPhone_customer.Text.Trim(), inputAddress_customer.Text.Trim());
                if (success)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm vào cơ sở dữ liệu.", "Lỗi");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
