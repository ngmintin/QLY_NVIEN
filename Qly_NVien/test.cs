using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Qly_NVien
{
    public partial class test : DevExpress.XtraEditors.XtraForm
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            TRINHDOs td = new TRINHDOs();
            gridControl1.DataSource = td.getList();
        }
    }
}