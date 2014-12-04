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
    public partial class ucHoaDonDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaCungCapBLT _NhaCungCapBLT;
        private MatHangBLT _MatHangBLT;
        public ucHoaDonDatHang()
        {
            InitializeComponent();
            _NhaCungCapBLT = new NhaCungCapBLT();
            _MatHangBLT = new MatHangBLT();
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            Object[] cbeNhaCungCapItem = new Object[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                cbeNhaCungCapItem[i] = dt.Rows[i].ItemArray[0];
            cbeNhaCungCap.Properties.Items.Clear();
            cbeNhaCungCap.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCap.SelectedIndex = 0;

            gcSanPhamDatHang.DataSource = _MatHangBLT.LayDanhSachTenMatHang();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void meDanhSachHangHoaHoaDon_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbeNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
