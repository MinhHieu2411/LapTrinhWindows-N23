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
    public partial class formDoiMK : Form
    {
        public formDoiMK(string username)
        {
            InitializeComponent();
            txtusername.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mkCu.Text == "" || mkMoi.Text == "" || nhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(mkMoi.Text != nhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp");
                return;
            }
            if(mkMoi.Text == mkCu.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác với mật khẩu cũ");
                return;
            }
            else
            {
                string username = txtusername.Text;
                string oldPassword = mkCu.Text;
                string newPassword = mkMoi.Text;

                if (DatabaseHelper.checkLogin(username, oldPassword))
                {
                    if (DatabaseHelper.updatePassword(username, newPassword))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
