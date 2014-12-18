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
    public partial class ucDanhSachSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDanhSachSanPham()
        {
            InitializeComponent();
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            String Name = "Thêm Sản Phẩm";
            if (!Assist.isTabExist(Name))
            {
                Assist.addNewTab(new ucThemSanPham(), Name);
            } 
        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
