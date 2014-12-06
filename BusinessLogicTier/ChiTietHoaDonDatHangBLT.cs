using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;

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
    }
}
