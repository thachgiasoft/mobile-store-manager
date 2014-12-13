using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using DataTransferObject;
namespace BusinessLogicTier
{
    public class ChiTietBaoCaoTonKhoBLT
    {
        ChiTietBaoCaoTonKhoDAT _ChiTietBaoCaoTonKhoDAT;

        public ChiTietBaoCaoTonKhoBLT()
        {
            _ChiTietBaoCaoTonKhoDAT = new ChiTietBaoCaoTonKhoDAT();
        }

        public DataTable LayChiTietTonKho(string thoigian)
        {
            return _ChiTietBaoCaoTonKhoDAT.LayChiTietTonKho(thoigian);
        }

        public bool ThemChiTietBaoCaoTonKho(ChiTietBaoCaoTonKho ct)
        {
            return _ChiTietBaoCaoTonKhoDAT.ThemChiTietBaoCaoTonKho(ct);
        }

        public bool XoaChiTietBaoCaoTonKho(string mabaocao)
        {
            return _ChiTietBaoCaoTonKhoDAT.XoaChiTietBaoCaoTonKho(mabaocao);
        }
       
        public DataTable LayThongTinTonKho()
        {
            return _ChiTietBaoCaoTonKhoDAT.LayThongTinTonKho();
        }
    }
}
