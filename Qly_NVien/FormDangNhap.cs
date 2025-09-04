namespace Qly_NVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        //CHỮ CHÌM
        //TÀI KHOẢN
        private void txbTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "Tên đăng nhập")
            {
                txbTaiKhoan.Text = "";
                txbTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txbTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "")
            {
                txbTaiKhoan.Text = "Tên đăng nhập";
                txbTaiKhoan.ForeColor = Color.Gray;
            }
        }

        //MẬT KHẨU
        private void txbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "Mật khẩu")
            {
                txbMatKhau.Text = "";
                txbMatKhau.ForeColor = Color.Black;
            }
        }

        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "")
            {
                txbMatKhau.Text = "Mật khẩu";
                txbMatKhau.ForeColor = Color.Gray;
            }
        }

        //LIÊN KẾT FORM ĐĂNG KÝ
        private void llDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy dk = new FormDangKy();
            dk.Show();
            this.Hide();
        }

        //ẨN HIỆN MẬT KHẨU
        private void pictureBoxHien_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.PasswordChar == '\0')
            {
                pictureBoxAn.BringToFront();
                txbMatKhau.PasswordChar = '*';
            }
        }

        private void pictureBoxAn_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.PasswordChar == '*')
            {
                pictureBoxHien.BringToFront();
                txbMatKhau.PasswordChar = '\0';
            }
        }

        //LIÊN KẾT FORM QUÊN MẬT KHẨU
        private void llQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau qmk = new FormQuenMatKhau();
            qmk.Show();
            this.Hide();
        }
    }
}
