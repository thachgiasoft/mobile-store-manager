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
using DataTransferObject;
using System.Xml.Linq;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucLapPhieuBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        private ChiTietHoaDonBanBLT hoaDonBanBLT;

        public ucLapPhieuBanHang()
        {
            InitializeComponent();
            this.hoaDonBanBLT = new ChiTietHoaDonBanBLT();
        }

        private void sbThemHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void sbXoaHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            hd.MaHoaDon = this.teMaHoaDon.Text;
            hd.NgayTT = this.deThoiGianLap.Text;
            hd.KhachHang.MaKhachHang = this.teMaKhachHang.Text;
            hd.KhachHang.TenKhachHang = this.teTenKhachHang.Text;
            hd.CtHoaDon.NhanVien.TenNhanVien = this.teTenNhanVien.Text;
            hd.CtHoaDon.NhanVien.MaNhanVien = this.teMaNhanVien.Text;          
        }

        private void ConvertDataToXML(out XElement XML)
        {
            List<ChiTietHoaDonBan> lstHoaDonBan = new List<ChiTietHoaDonBan>();

            XML = new XElement(new XElement("Root"));
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                 var item = gridView1.GetRow(i);
                 lstHoaDonBan[i].CtHoaDon.MatHang.MaMatHang = gridView1.GetRowCellValue(i, gridView1.Columns["MaMatHang"]).ToString();
                 lstHoaDonBan[i].CtHoaDon.NhanVien.MaNhanVien = gridView1.GetRowCellValue(i, gridView1.Columns["MaNhanVien"]).ToString();
                 lstHoaDonBan[i].CtHoaDon.SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["SoLuong"]).ToString());
            }

            foreach (ChiTietHoaDonBan item in lstHoaDonBan)
            {
                XElement xml = new XElement("XmlData",
                    new XElement("MaMatHang", item.CtHoaDon.MatHang.MaMatHang == null ? "" : item.CtHoaDon.MatHang.MaMatHang),
                    new XElement("MaNhanVien", item.CtHoaDon.NhanVien.MaNhanVien == null ? "" : item.CtHoaDon.NhanVien.MaNhanVien),
                    new XElement("SoLuong", item.CtHoaDon.SoLuong == null ? Decimal.Zero : item.CtHoaDon.SoLuong)
                    );
                XML.Add(xml);
            }
        }
    }
}
