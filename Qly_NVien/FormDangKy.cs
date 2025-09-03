using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NVien
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        //CHỮ CHÌM
        private void textBoxHo_Enter(object sender, EventArgs e)                    //HỌ
        {
            if (textBoxHo.Text == "Họ")
            {
                textBoxHo.Text = "";
                textBoxHo.ForeColor = Color.Black;
            }
        }

        private void textBoxHo_Leave(object sender, EventArgs e)
        {
            if (textBoxHo.Text == "")
            {
                textBoxHo.Text = "Họ";
                textBoxHo.ForeColor = Color.Gray;
            }
        }

        private void textBoxTen_Enter(object sender, EventArgs e)                   //TÊN
        {
            if (textBoxTen.Text == "Tên")
            {
                textBoxTen.Text = "";
                textBoxTen.ForeColor = Color.Black;
            }
        }

        private void textBoxTen_Leave(object sender, EventArgs e)
        {
            if (textBoxTen.Text == "")
            {
                textBoxTen.Text = "Tên";
                textBoxTen.ForeColor = Color.Gray;
            }
        }

        private void textBoxTenDangNhap_Enter(object sender, EventArgs e)           //TÊN ĐĂNG NHẬP
        {
            if (textBoxTenDangNhap.Text == "Tên đăng nhập")
            {
                textBoxTenDangNhap.Text = "";
                textBoxTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void textBoxTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "")
            {
                textBoxTenDangNhap.Text = "Tên đăng nhập";
                textBoxTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void textBoxMatKhau_Enter(object sender, EventArgs e)               //MẬT KHẨU
        {
            if (textBoxMatKhau.Text == "Mật khẩu")
            {
                textBoxMatKhau.Text = "";
                textBoxMatKhau.ForeColor = Color.Black;
            }
        }

        private void textBoxMatKhau_Leave(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "")
            {
                textBoxMatKhau.Text = "Mật khẩu";
                textBoxMatKhau.ForeColor = Color.Gray;
            }
        }

        private void textBoxXacNhan_Enter(object sender, EventArgs e)           //XÁC NHẬN MẬT KHẨU
        {
            if (textBoxXacNhan.Text == "Xác nhận")
            {
                textBoxXacNhan.Text = "";
                textBoxXacNhan.ForeColor = Color.Black;
            }
        }

        private void textBoxXacNhan_Leave(object sender, EventArgs e)
        {
            if (textBoxXacNhan.Text == "")
            {
                textBoxXacNhan.Text = "Xác nhận";
                textBoxXacNhan.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)         //EMAIL
        {
            if (textBoxEmail.Text == "example@gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "example@gmail.com";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

    }
}
