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
    public partial class ucDanhSachKhuyenMai : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDanhSachKhuyenMai()
        {
            InitializeComponent();
            this.gcKetQua.DataSource = (new KhuyenMaiBLT().LayDanhSachCTKhuyenMai());
        }

        private void sbTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.MaKhuyenMai = this.teMaKhuyenMai.Text;
            km.TenChuongTrinh = this.teTenChuongTrinhKhuyenMai.Text;
            km.ThoiGianDB = this.deThoiGianBD.DateTime.ToString("dd/MM/yyyy");
            if (km.ThoiGianDB.Equals("01/01/0001"))
                km.ThoiGianDB = "";

            km.ThoiGianKT = this.dateKetThuc.DateTime.ToString("dd/MM/yyyy");
            if (km.ThoiGianKT.Equals("01/01/0001"))
                km.ThoiGianKT = "";

            this.gcKetQua.DataSource = (new KhuyenMaiBLT().TimKiemCTKhuyenMai(km));
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void sbThemCTKhuyenMai_Click(object sender, EventArgs e)
        {
            String Name = "Thêm chương trình khuyến mãi";
            Assist.gKhuyenMai = null;
            if (!Assist.isTabExist(Name))
            {
                Assist.addNewTab(new ucThemKhuyenMai(), Name);
            } 
        }

        private void sbCapNhatCTKHuyenMai_Click(object sender, EventArgs e)
        {
            String Name = "Thêm chương trình khuyến mãi";
            if (!Assist.isTabExist(Name))
            {
                Assist.addNewTab(new ucThemKhuyenMai(), Name);
            } 
        }

        private void sbXoaCTKhuyenMai_Click(object sender, EventArgs e)
        {
            String message = "";
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này hay không ?",
             "Thông báo",
              MessageBoxButtons.YesNoCancel,
              MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (new KhuyenMaiBLT().XoaCTKhuyenMai(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã khuyến mãi").ToString()))
                    message += "Xóa thành công";
                else
                    message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);

                this.gcKetQua.DataSource = (new KhuyenMaiBLT().LayDanhSachCTKhuyenMai());
            }
        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {
            Assist.gKhuyenMai = new KhuyenMai();

            Assist.gKhuyenMai.MaKhuyenMai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã khuyến mãi").ToString();
            Assist.gKhuyenMai.TenChuongTrinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên khuyến mãi").ToString();
            Assist.gKhuyenMai.ThoiGianDB = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời gian bắt đầu").ToString();
            Assist.gKhuyenMai.ThoiGianKT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời gian kết thúc").ToString();
        }

    }
}
