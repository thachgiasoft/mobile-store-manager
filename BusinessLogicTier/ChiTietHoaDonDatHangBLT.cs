using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data;

namespace BusinessLogicTier
{
    public class ChiTietHoaDonDatHangBLT
    {
        private ChiTietHoaDonDatHangDAT _ChiTietHoaDonDatHangDAT;
        public ChiTietHoaDonDatHangBLT()
        {
            _ChiTietHoaDonDatHangDAT = new ChiTietHoaDonDatHangDAT();
        }

        public bool ThemChiTietHoaDonDatHang(ChiTietHoaDonDatHang cthd)
        {
            return _ChiTietHoaDonDatHangDAT.ThemChiTietHoaDonDatHang(cthd);
        }

        public DataTable LayChiTietHoaDonDatHangTheoMaHoaDon(string mahoadon)
        {
            return _ChiTietHoaDonDatHangDAT.LayChiTietHoaDonDatHangTheoMaHoaDon(mahoadon);
        }

        public bool XoaChiTietHoaDonDathang(string MaHoaDon)
        {
            return _ChiTietHoaDonDatHangDAT.XoaChiTietHoaDonDathang(MaHoaDon);
        }
    }
}
