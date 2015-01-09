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
using DevExpress.XtraTab;
using DataTransferObject;
using System.Collections;


namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucDonGia : DevExpress.XtraEditors.XtraUserControl
    {
        private DonGiaBLT _DonGiaBLT;
        private DonGia donGia;
        private MatHangBLT _MatHangBLT;
        private NhaCungCapBLT _NhaCungCapBLT;
        public ucDonGia()
        {
            InitializeComponent();
            _DonGiaBLT = new DonGiaBLT();
            _MatHangBLT = new MatHangBLT();
            _NhaCungCapBLT = new NhaCungCapBLT();

            //Lấy ds mau sac
            LoadData();

        }

        private void LoadData()
        {
            TimKiem();
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            dt.Columns.RemoveAt(2);
            dt.Columns.RemoveAt(2);
            dt.Columns.RemoveAt(2);
            gcDanhSachNhaCungCap.DataSource =  dt;
            gvDanhSachNhaCungCap.Columns[0].Width = 10;
            gvDanhSachNhaCungCap.Columns[1].Width = 120;

            NhapVaoDanhSachMatHang();
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void TimKiem()
        {
            gvDanhSachMatHang.Columns.Clear();
            gcDanhSachMatHang.DataSource = null;
            MatHang mh = new MatHang();
            mh.TenMatHang = teTenMatHang.Text;
            gcDanhSachMatHang.DataSource = _MatHangBLT.TimKiemMatHangBangTenMatHangDonGian(mh);
     
        }

        private void gvDanhSachMatHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            NhapVaoDanhSachMatHang();
        }

        private void NhapVaoDanhSachMatHang()
        {
            MatHang mh = new MatHang();
            DataTable dt2 = gcDanhSachMatHang.DataSource as DataTable;
            mh.MaMatHang = dt2.Rows[gvDanhSachMatHang.FocusedRowHandle].ItemArray[0].ToString();

            DataTable dt3 = _MatHangBLT.LayThongTinDonGiaVaNhaSanXuat(mh);
            gcChiTietDonGia.DataSource = dt3;

            ArrayList deletedRows = new ArrayList();
            gvDanhSachNhaCungCap.Columns.Clear();
            gcDanhSachNhaCungCap.DataSource = null;
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            dt.Columns.RemoveAt(2);
            dt.Columns.RemoveAt(2);
            dt.Columns.RemoveAt(2);
            if (dt!=null)
            foreach (DataRow row in dt.Rows)
            {
                if(dt3!=null)
                foreach (DataRow row2 in dt3.Rows)
                {
                    if (row[1].ToString().CompareTo(row2[3].ToString()) == 0)
                    {
                        deletedRows.Add(row);
                    }
                }
            }


            foreach (DataRow r in deletedRows)
            {
                dt.Rows.Remove(r);
            }

            gcDanhSachNhaCungCap.DataSource = dt;

            gvDanhSachNhaCungCap.Columns[0].Width = 10;
            gvDanhSachNhaCungCap.Columns[1].Width = 120;
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            DataTable DanhSachMatHang = gcDanhSachMatHang.DataSource as DataTable;
            DataTable DanhSachNhaCungCap = gcDanhSachNhaCungCap.DataSource as DataTable;
            if (DanhSachMatHang != null && DanhSachMatHang.Rows.Count > 0
                && DanhSachNhaCungCap != null && DanhSachNhaCungCap.Rows.Count > 0)
            {
                int luachonmathang =  gvDanhSachMatHang.GetSelectedRows()[0];
                int luachonnhacungcap = gvDanhSachNhaCungCap.GetSelectedRows()[0];
                if (luachonmathang != -1 && luachonnhacungcap != -1)
                {
                    DataTable DanhSachDonGia = gcChiTietDonGia.DataSource as DataTable;
                    if (DanhSachDonGia == null)
                    {
                        DanhSachDonGia = new DataTable();
                        DanhSachDonGia.Columns.Add("Mã Mặt Hàng", typeof(string));
                        DanhSachDonGia.Columns.Add("Tên Mặt Hàng", typeof(string));
                        DanhSachDonGia.Columns.Add("Mã Nhà Cung Cấp", typeof(string));
                        DanhSachDonGia.Columns.Add("Tên Nhà Cung Cấp", typeof(string));
                        DanhSachDonGia.Columns.Add("Giá Nhập", typeof(decimal));
                        DanhSachDonGia.Columns.Add("Giá Xuất", typeof(decimal));
                        gcChiTietDonGia.DataSource = DanhSachDonGia;
                    }
                    DanhSachDonGia.Rows.Add(DanhSachMatHang.Rows[luachonmathang].ItemArray[0],
                       DanhSachMatHang.Rows[luachonmathang].ItemArray[1],
                       DanhSachNhaCungCap.Rows[luachonnhacungcap].ItemArray[0],
                       DanhSachNhaCungCap.Rows[luachonnhacungcap].ItemArray[1],
                       teGiaNhap.Text,
                       teGiaXuat.Text);
                    DanhSachNhaCungCap.Rows.RemoveAt(luachonnhacungcap);
                }
            }
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            DataTable DanhSachDonGia = gcChiTietDonGia.DataSource as DataTable;
            if (DanhSachDonGia != null && DanhSachDonGia.Rows.Count > 0)
            {
                int luachondongia = gvChiTietDonGia.GetSelectedRows()[0];
                if (luachondongia != -1)
                {
                    DataTable DanhSachNhaCungCap = gcDanhSachNhaCungCap.DataSource as DataTable;
                    DanhSachNhaCungCap.Rows.Add(DanhSachDonGia.Rows[luachondongia].ItemArray[2],
                       DanhSachDonGia.Rows[luachondongia].ItemArray[3]);
                    DanhSachDonGia.Rows.RemoveAt(luachondongia);
                }
            }
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            DataTable DanhSachDonGia = gcChiTietDonGia.DataSource as DataTable;
            if (DanhSachDonGia != null && DanhSachDonGia.Rows.Count > 0)
            {
                for (int i = DanhSachDonGia.Rows.Count - 1; i >= 0; i--)
                {
                     DataTable DanhSachNhaCungCap = gcDanhSachNhaCungCap.DataSource as DataTable;
                     DanhSachNhaCungCap.Rows.Add(DanhSachDonGia.Rows[i].ItemArray[2],
                           DanhSachDonGia.Rows[i].ItemArray[3]);
                        DanhSachDonGia.Rows.RemoveAt(i);
                }
            }
        }

        private void sbLuuDonGia_Click(object sender, EventArgs e)
        {
            DataTable DanhSachMatHang = gcDanhSachMatHang.DataSource as DataTable;
            DataTable DanhSachNhaCungCap = gcDanhSachNhaCungCap.DataSource as DataTable;
            if (DanhSachMatHang != null && DanhSachMatHang.Rows.Count > 0
                && DanhSachNhaCungCap != null && DanhSachNhaCungCap.Rows.Count > 0)
            {
                int luachonmathang = gvDanhSachMatHang.GetSelectedRows()[0];
                int luachonnhacungcap = gvDanhSachNhaCungCap.GetSelectedRows()[0];
                if (luachonmathang != -1 && luachonnhacungcap != -1)
                {
                    DonGia dg = new DonGia();
                    dg.MaMatHang = DanhSachMatHang.Rows[luachonmathang].ItemArray[0].ToString();
                    DataTable DanhSachMaDonGia = _DonGiaBLT.LayMaDonGiaBangMaSanPham(dg);

                    //xoa chi tiet nha cung cap trong bang chi tiet nha cung cap
                    _NhaCungCapBLT.XoaChiTietNhaCungCap(dg.MaMatHang);

                    foreach (DataRow dr in DanhSachMaDonGia.Rows)
                    {
                        _DonGiaBLT.XoaDonGia(dr.ItemArray[0].ToString());
                    }

                    DataTable DanhSachDonGia = gcChiTietDonGia.DataSource as DataTable;
                    if (DanhSachDonGia != null && DanhSachDonGia.Rows.Count > 0)
                    {
                        foreach (DataRow dr in DanhSachDonGia.Rows)
                        {
                            DonGia dg2 = new DonGia();
                            dg2.GiaNhap= Convert.ToDecimal(dr.ItemArray[4].ToString());
                            dg2.GiaXuat = Convert.ToDecimal(dr.ItemArray[5].ToString());
                            string madongia = _DonGiaBLT.ThemDonGiaVaLayMaDonGia(dg2);

                            ChiTietNhaCungCap ctncc = new ChiTietNhaCungCap();
                            ctncc.MaDonGia = madongia;
                            ctncc.GhiChu = "";
                            ctncc.MaMatHang = dr.ItemArray[0].ToString();
                            ctncc.MaNhaCungCap = dr.ItemArray[2].ToString();
                            _NhaCungCapBLT.ThemChiTietNhaCungCap(ctncc);
                        }
                        MessageBox.Show("Lưu Thành Công", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Đơn giá trống nhưng vẫn lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void teGiaXuat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void teGiaXuat_TextChanged(object sender, EventArgs e)
        {
            decimal giatri = Convert.ToDecimal(teGiaXuat.Text);
            if (giatri < 0)
                giatri = 0;
            teGiaXuat.Text = giatri.ToString();
        }

        private void teGiaNhap_TextChanged(object sender, EventArgs e)
        {
            decimal giatri = Convert.ToDecimal(teGiaNhap.Text);
            if (giatri < 0)
                giatri = 0;
            teGiaNhap.Text = giatri.ToString();
        }
    }
}
