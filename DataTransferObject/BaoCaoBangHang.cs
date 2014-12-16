using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BaoCaoBangHang
    {
        public BaoCaoBangHang()
        { }

        public String MaNhanVien { get; set; }

        private String tenNhanVien;
        public String TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private String tuNgay;
        public String TuNgay
        {
            get { return tuNgay; }
            set { tuNgay = value; }
        }

        private String denNgay;
        public String DenNgay
        {
            get { return denNgay; }
            set { denNgay = value; }
        }

        private DataTable data;
        public DataTable Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
