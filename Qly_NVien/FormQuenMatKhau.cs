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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        //VỀ FORM ĐĂNG NHẬP
        private void LLDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Hide();
        }

        //CHỮ CHÌM
        private void txbTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txbTenDangNhap.Text == "Nhập tên đăng nhập")
            {
                txbTenDangNhap.Text = "";
                txbTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txbTenDangNhap_Leave(object sender, EventArgs e)
        {
            if(txbTenDangNhap.Text == "")
            {
                txbTenDangNhap.Text = "Nhập tên đăng nhập";
                txbTenDangNhap.ForeColor = Color.Gray;
            }
        }
    }
}
