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
    public partial class ucLePhiGiaoHang : DevExpress.XtraEditors.XtraUserControl
    {
        private String maLePhi = "";
        public ucLePhiGiaoHang()
        {
            InitializeComponent();

            this.gcKetQua.DataSource = (new LePhiGiaoHangBLT().LayDanhSachLePhiGiaoHang());
        }

        private void beLamMoi_Click(object sender, EventArgs e)
        {
            this.teDonGia.Text = "0";
            this.teTenKhuVuc.Text = "";
            this.maLePhi = "";
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            LePhiGiaoHang gh = new LePhiGiaoHang();
            gh.TenKhuVuc = this.teTenKhuVuc.Text;
            gh.Dongia = this.teDonGia.Text == "" ? 0 : Convert.ToDecimal(this.teDonGia.Text);

            this.gcKetQua.DataSource = (new LePhiGiaoHangBLT().TimKiemLePhiGiaoHang(gh));
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            LePhiGiaoHang gh = new LePhiGiaoHang();
            gh.TenKhuVuc = this.teTenKhuVuc.Text;
            gh.Dongia = this.teDonGia.Text == null ? 0 : Convert.ToDecimal(this.teDonGia.Text);

            if (gh.TenKhuVuc == null && gh.TenKhuVuc.Equals(""))
            {
                MessageBox.Show("Tên Khu Vực không được để trống", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if ((new LePhiGiaoHangBLT().ThemLePhiGiaoHang(gh)))
                {
                    MessageBox.Show("Thêm lệ phí giao phí thành công", "Thông báo", MessageBoxButtons.OK);
                    this.gcKetQua.DataSource = (new LePhiGiaoHangBLT().LayDanhSachLePhiGiaoHang());
                }
                else
                {
                    MessageBox.Show("Thêm lệ phí giao phí thất bại", "Thông báo", MessageBoxButtons.OK);
                }         
            }
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            LePhiGiaoHang gh = new LePhiGiaoHang();
            gh.MaKhuVuc = this.maLePhi;
            gh.TenKhuVuc = this.teTenKhuVuc.Text;
            gh.Dongia = this.teDonGia.Text == null ? 0 : Convert.ToDecimal(this.teDonGia.Text);

            if (gh.TenKhuVuc == null && gh.TenKhuVuc.Equals(""))
            {
                MessageBox.Show("Tên Khu Vực không được để trống", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (!this.maLePhi.Equals("") && (new LePhiGiaoHangBLT().CapNhatLePhiGiaoHang(gh)))
                {
                    MessageBox.Show("Cập nhật lệ phí giao phí thành công", "Thông báo", MessageBoxButtons.OK);
                    this.gcKetQua.DataSource = (new LePhiGiaoHangBLT().LayDanhSachLePhiGiaoHang());
                }
                else
                {
                    MessageBox.Show("Cập nhật lệ phí giao phí thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            String message = "";
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này hay không ?",
            "Thông báo",
             MessageBoxButtons.YesNoCancel,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!this.maLePhi.Equals("") && (new LePhiGiaoHangBLT()).XoaLePhiGiaoHang(this.maLePhi))
                    message += "Xóa thành công";
                else
                    message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                gridView1.FocusedRowHandle = 0;

                this.gcKetQua.DataSource = (new LePhiGiaoHangBLT().LayDanhSachLePhiGiaoHang());
            }         
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {
            this.maLePhi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã khu vực").ToString();
            this.teTenKhuVuc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên khu vực").ToString();
            this.teDonGia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Đơn giá").ToString();
            //tại beep hả
        }
    }
}
