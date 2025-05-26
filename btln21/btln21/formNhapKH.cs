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
    public partial class formNhapKH : Form
    {
        public formNhapKH()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id = inputID_customer.Text.Trim();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
