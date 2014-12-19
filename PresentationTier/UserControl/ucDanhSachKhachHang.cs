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
using System.Data.SqlClient;
using DataAccessTier;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucDanhSachKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        //private DataBases db = new DataBases();
        private KhachHangBLT khBLT;
        public ucDanhSachKhachHang()
        {
            InitializeComponent();
            this.khBLT = new KhachHangBLT();
            this.LoadData();
        }

        

        private void teSoDienThoai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            string name = "Thêm Khách Hàng";
            if (!Assist.isTabExist(name))
            {
                Assist.gKhachHang = null;
                Assist.addNewTab(new ucThemKhachHang(), name);
            }
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            String name = "Chỉnh sửa khách hàng";
            if (!Assist.isTabExist(name))
            {
                Assist.addNewTab(new ucThemKhachHang(), name);
            }
            

            //this.gridControl1.DataSource = db.LoadDataTable(
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            kh.MaKhachHang = this.teMaKhachHang.Text;
            kh.TenKhachHang = this.teTenKhachHang.Text;
            kh.DiaChi = this.teDiaChi.Text;
            kh.SoDienThoai = this.teSoDienThoai.Text;
            kh.Email = this.teEmail.Text;
            kh.GhiChu = this.txtGhiChu.Text;

            this.gridControl1.DataSource = this.khBLT.TimKiemKhachHang(kh);
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Bạn muốn xóa khách hàng?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string makh = this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã khách hàng").ToString();
                string message = "";
                if (khBLT.XoaKhachHang(makh))
                    message += "Xóa thành công!";
                else
                    message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                this.gridView1.SetFocusedValue(1);
                gridView1.FocusedRowHandle = 0;
                this.LoadData();
            }
            else
            {
                return;
            }
        }

        private void teSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void LoadData()
        {
            DataTable data = new DataTable();
            data = khBLT.LayDanhSachKhachHang();
            this.gridControl1.DataSource = data;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Assist.gKhachHang = new KhachHang();
            if (this.gridView1.RowCount != 0)
            {
                Assist.gKhachHang.MaKhachHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã khách hàng").ToString();
                Assist.gKhachHang.TenKhachHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên khách hàng").ToString();
                Assist.gKhachHang.DiaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
                Assist.gKhachHang.SoDienThoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số điện thoại").ToString();
                Assist.gKhachHang.Email = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
                Assist.gKhachHang.GhiChu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            }
        }


    }
}
