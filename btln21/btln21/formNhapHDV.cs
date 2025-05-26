using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace btln21
{
    public partial class formNhapHDV : Form
    {
        public formNhapHDV()
        {
            InitializeComponent();
        }

        private void formNhapHDV_Load(object sender, EventArgs e)
        {
            this.Text = "Nhập thông tin hướng dẫn viên";
        }
        //nhan nut xac nhan
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string id = inputID_hdv.Text;
            string table = "TourGuide";
            string collumn = "TourGuideID";
            //check xem co truong nao nhap sai hoac de trong
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(inputName_hdv.Text) || !int.TryParse(inputYob_hdv.Text, out int year) || !int.TryParse(inputYears_hdv.Text, out int works) || !decimal.TryParse(inputSalary_hdv.Text, out decimal salary))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin.");
                return;
            }
            //check lai id neu trung (dbhelper)
            if (DatabaseHelper.checkID(id, table, collumn ))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.");
                return;
            }

            bool success = DatabaseHelper.AddTourGuide(id, inputName_hdv.Text.Trim(), year, inputPhone_hdv.Text.Trim(), inputAddress_hdv.Text.Trim(), inputYears_hdv.ToString(), salary
            );

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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputYears_hdv_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(inputYears_hdv.Text, out int year))
            {
                decimal salary = 5000000 + (500000 * year);
                inputSalary_hdv.Text = salary.ToString();
            }
            else
            {
                inputSalary_hdv.Text = "";
            }
        }
        //chan cac ky tu khong phai so khi nhap vao works
        private void inputYears_hdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
