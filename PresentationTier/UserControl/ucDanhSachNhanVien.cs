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
using BusinessLogicTier;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucDanhSachNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private NhanVienBLT nhanVienBLT;

        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            this.nhanVienBLT = new NhanVienBLT();
            //Lấy ds nhân viên nha. doi t xiu
            DataTable data = new DataTable();
            data =this.nhanVienBLT.LayDanhSachNhanVien();       
            this.GridNhanVien.DataSource = data;
            this.GridNhanVien.Invalidate();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
