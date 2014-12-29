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
using DataTransferObject;
using BusinessLogicTier;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucTraCuuMatHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ucTraCuuMatHang()
        {
            InitializeComponent();
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            MatHang matHang = new MatHang();
            matHang.TenMatHang = this.teTenSanPham.Text;

            matHang.MaLoaiMatHang = this.lueLoaiSanPham.EditValue == null ? "" : this.lueLoaiSanPham.EditValue.ToString();
            matHang.MaNhaSanXuat = this.lueNhaSX.EditValue == null ? "" : this.lueNhaSX.EditValue.ToString();

            int kichthuoc = -1;
            int pin = -1;
            int soSim = -1;
            int ram = -1;
            int boNho = -1;
            string maCPU = "";

            DataTable data = new DataTable();
            data = new MatHangBLT().TimKiemMatHang(matHang, kichthuoc, "",
                 "", pin, soSim, ram, boNho, maCPU);       

        }
    }
}
