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
    public partial class FormLayMatKhau : Form
    {
        public FormLayMatKhau()
        {
            InitializeComponent();
        }

        //CHỮ CHÌM
        //MẬT KHẨU MỚI
        private void txbMatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txbMatKhauMoi.Text == "Nhập mật khẩu")
            {
                txbMatKhauMoi.Text = "";
                txbMatKhauMoi.ForeColor = Color.Black;
            }
        }

        private void txbMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txbMatKhauMoi.Text == "")
            {
                txbMatKhauMoi.Text = "Nhập mật khẩu";
                txbMatKhauMoi.ForeColor = Color.Gray;
            }
        }

        //XÁC NHẬN LẠI MẬT KHẨU
        private void txbXacNhanLai_Enter(object sender, EventArgs e)
        {
            if (txbXacNhanLai.Text == "Xác nhận lại mật khẩu")
            {
                txbXacNhanLai.Text = "";
                txbXacNhanLai.ForeColor = Color.Black;
            }
        }

        private void txbXacNhanLai_Leave(object sender, EventArgs e)
        {
            if(txbXacNhanLai.Text == "")
            {
                txbXacNhanLai.Text = "Xác nhận lại mật khẩu";
                txbXacNhanLai.ForeColor = Color.Gray;
            }
        }
    }
}
