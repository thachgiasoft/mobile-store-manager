using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using BusinessLogicTier;

namespace QL_Ban_DienThoai
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!this.teMK.Equals("") && !this.teTenDN.Equals(""))
            {
                NhanVien nv = (new NhanVienBLT().DangNhap(this.teTenDN.Text, new Encrypt().MD52(this.teMK.Text, 2)));
                if (nv != null)
                {
                    Assist.nhanVien = new NhanVien();
                    Assist.nhanVien.TenNhanVien = nv.TenNhanVien;
                    Assist.nhanVien.MaNhanVien = nv.MaNhanVien;
                    Assist.nhanVien.ChucVuNhanVien.MaChucVu = nv.ChucVuNhanVien.MaChucVu;
                    Assist.nhanVien.ChucVuNhanVien.TenChucVu = nv.ChucVuNhanVien.TenChucVu;

                    FormMain formchinh = new FormMain(Assist.nhanVien.TenNhanVien, Assist.nhanVien.ChucVuNhanVien.TenChucVu, Assist.nhanVien.ChucVuNhanVien.MaChucVu);
                    formchinh.Show();
                    this.Hide();
                }
            }

            //FormMain formchinh = new FormMain("", "", "CV0000000000001");
            //formchinh.Show();
            //this.Hide();
            //lay thong tin nhan vien va truyen vao mainform                            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}