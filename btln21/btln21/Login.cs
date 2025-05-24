namespace btln21
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng nhập";
        }
    }
}
