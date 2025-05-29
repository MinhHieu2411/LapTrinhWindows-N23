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
    public partial class formNhapAdmin : Form
    {
        public formNhapAdmin()
        {
            InitializeComponent();
        }
        //nhấn nút xác nhận để thêm quản trị viên mới
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text.ToString();
            string password = inputPassword.Text.ToString();
            string checkpassword = reTypePassword.Text.ToString();

            string table = "Admin";
            string collumn = "username";
            if (username == null || password == null || checkpassword == null)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!");
                return;
            }
            if (password != checkpassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp, yêu cầu nhập lại", "Thông báo");
                return;
            }
            if (DatabaseHelper.checkID(username, table, collumn))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên đăng nhập khác!", "Thông báo");
                return;
            }
            bool success = DatabaseHelper.AddAdmin(username, password);
            if (success)
            {
                MessageBox.Show("Thêm quản trị viên thành công", "Thông báo");
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

        private void formNhapAdmin_Load(object sender, EventArgs e)
        {
            inputPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu khi nhập
            reTypePassword.UseSystemPasswordChar = true; // Ẩn mật khẩu khi nhập
        }
    }
}
