using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThemSanPham()
        {
            InitializeComponent();
        }

        private void sbThem_Click(object sender, EventArgs e)
        {

        }

        private void sbThemMoi_Click(object sender, EventArgs e)
        {
            this.teSoLuongTon.Text = "";
            this.teTenMatHang.Text = "";
            this.meGhiChu.Text = "";
            this.meMoTa.Text = "";

            //focus
            this.teTenMatHang.Focus();
        }
    }
}
