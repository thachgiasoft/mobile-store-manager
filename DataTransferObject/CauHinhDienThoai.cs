using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CauHinhDienThoai
    {
        public CauHinhDienThoai()
        { }

        private string maCauHinh;

        public string MaCauHinh
        {
            get { return maCauHinh; }
            set { maCauHinh = value; }
        }
        private string tenCauHinh;

        public string TenCauHinh
        {
            get { return tenCauHinh; }
            set { tenCauHinh = value; }
        }
        private string maMatHang;

        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }
        private int kichThuocManHinh;

        public int KichThuocManHinh
        {
            get { return kichThuocManHinh; }
            set { kichThuocManHinh = value; }
        }
        private string heDieuHanh;

        public string HeDieuHanh
        {
            get { return heDieuHanh; }
            set { heDieuHanh = value; }
        }
        private int ram;

        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        private string maMauSac;

        public string MaMauSac
        {
            get { return maMauSac; }
            set { maMauSac = value; }
        }
        private int dungLuongPin;

        public int DungLuongPin
        {
            get { return dungLuongPin; }
            set { dungLuongPin = value; }
        }
        private string maCPU;

        public string MaCPU
        {
            get { return maCPU; }
            set { maCPU = value; }
        }
        private int boNho;

        public int BoNho
        {
            get { return boNho; }
            set { boNho = value; }
        }
        private int soSim;

        public int SoSim
        {
            get { return soSim; }
            set { soSim = value; }
        }
    }
}
