namespace btln21
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Nhan nut dang nhap
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {

                if (DatabaseHelper.checkLogin(username, password))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng nhập";
        }
    }
}
