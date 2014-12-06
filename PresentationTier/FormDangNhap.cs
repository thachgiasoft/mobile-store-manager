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
            //lay thong tin nhan vien va truyen vao mainform
            mainform formchinh = new mainform( "Nguyễn Văn A",  "Nhân Viên Kho");
            Assist.nhanVien = new NhanVien();
            Assist.nhanVien.MaNhanVien = "NV00000001";//ma nhan vien ho xuan vinh
            formchinh.Show();
            this.Hide();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}