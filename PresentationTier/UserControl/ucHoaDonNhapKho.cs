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

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucHoaDonNhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLT _HoaDonBLT;
        NhaCungCapBLT _NhaCungCapBLT;
        ChiTietHoaDonDatHangBLT _ChiTietHoaDonDatHangBLT;

        float tongtien;
        public ucHoaDonNhapKho()
        {
            InitializeComponent();
            _HoaDonBLT = new HoaDonBLT();
            _NhaCungCapBLT = new NhaCungCapBLT();
            _ChiTietHoaDonDatHangBLT = new ChiTietHoaDonDatHangBLT();
            tongtien = 0;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        void LayDanhSachHoaDonDatHang()
        {
            DataTable dt = _HoaDonBLT.LayDanhSachHoaDonDatHang();

            DataTable resulttable = new DataTable();
            resulttable.Columns.Add("Mã Hóa Đơn", typeof(string));
            resulttable.Columns.Add("Ngày Lập", typeof(string));
            resulttable.Columns.Add("Tên Nhà Cung Cấp", typeof(string));
            resulttable.Columns.Add("Nhân Viên Lập", typeof(string));
            resulttable.Columns.Add("Tổng Tiền", typeof(string));
            resulttable.Columns.Add("Trạng Thái", typeof(string));

            //loc lan 1
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cbeNhaCungCapFilter.Text == "Tất Cả")
                    resulttable.Rows.Add(dt.Rows[i].ItemArray[0],
                        dt.Rows[i].ItemArray[1],
                        dt.Rows[i].ItemArray[2],
                        dt.Rows[i].ItemArray[3],
                        dt.Rows[i].ItemArray[4],
                        dt.Rows[i].ItemArray[5]);
                else
                    if (cbeNhaCungCapFilter.Text == dt.Rows[i].ItemArray[2].ToString())
                    {
                        resulttable.Rows.Add(dt.Rows[i].ItemArray[0],
                        dt.Rows[i].ItemArray[1],
                        dt.Rows[i].ItemArray[2],
                        dt.Rows[i].ItemArray[3],
                        dt.Rows[i].ItemArray[4],
                        dt.Rows[i].ItemArray[5]);
                    }
            }

            //loc lan 2
            DataTable resulttable2 = new DataTable();
            resulttable2.Columns.Add("Mã Hóa Đơn", typeof(string));
            resulttable2.Columns.Add("Ngày Lập", typeof(string));
            resulttable2.Columns.Add("Tên Nhà Cung Cấp", typeof(string));
            resulttable2.Columns.Add("Nhân Viên Lập", typeof(string));
            resulttable2.Columns.Add("Tổng Tiền", typeof(string));
            resulttable2.Columns.Add("Trạng Thái", typeof(string));

            if (deNgayDatHangFrom.Text == "" && deNgayDatHangTo.Text == "")
            {
                resulttable2 = resulttable;
            }
            else
            {
                for (int i = 0; i < resulttable.Rows.Count; i++)
                {
                    DateTime date = deNgayDatHangFrom.DateTime;
                    DateTime date2 = deNgayDatHangTo.DateTime;
                    DateTime tempday = Convert.ToDateTime(resulttable.Rows[i].ItemArray[1]);
                    DateTime comparedate = new DateTime(tempday.Year, tempday.Day, tempday.Month);
                    int r1 = DateTime.Compare(date, comparedate);
                    int r2 = DateTime.Compare(date2, comparedate);
                    if (r1 <= 0 && r2 >= 0)
                    {
                        resulttable2.Rows.Add(resulttable.Rows[i].ItemArray[0],
                        resulttable.Rows[i].ItemArray[1],
                        resulttable.Rows[i].ItemArray[2],
                        resulttable.Rows[i].ItemArray[3],
                        resulttable.Rows[i].ItemArray[4],
                        resulttable.Rows[i].ItemArray[5]);
                    }
                }
            }

            gcDanhSachHoaDonDatHang.DataSource = resulttable2;
        }

        private void ucHoaDonNhapKho_Load(object sender, EventArgs e)
        {
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            Object[] cbeNhaCungCapItem = new Object[dt.Rows.Count + 1];
            cbeNhaCungCapItem[0] = "Tất Cả";
            for (int i = 1; i < dt.Rows.Count + 1; i++)
            {
                cbeNhaCungCapItem[i] = dt.Rows[i - 1].ItemArray[0];
            }
            cbeNhaCungCapFilter.Properties.Items.Clear();
            cbeNhaCungCapFilter.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCapFilter.SelectedIndex = 0;
            LayDanhSachHoaDonDatHang();
            deNgayThanhToan.EditValue = DateTime.Now;
        }

        private void deNgayDatHangFrom_TextChanged(object sender, EventArgs e)
        {
            if (deNgayDatHangFrom.Text == "")
            {
                deNgayDatHangTo.Text = "";
            }
            else
                if (deNgayDatHangTo.Text == "")
                    deNgayDatHangTo.EditValue = DateTime.Now;
            LayDanhSachHoaDonDatHang();
        }

        private void deNgayDatHangTo_TextChanged(object sender, EventArgs e)
        {
            if (deNgayDatHangTo.Text == "")
            {
                deNgayDatHangFrom.Text = "";
            }
            else
                if (deNgayDatHangFrom.Text == "")
                    deNgayDatHangFrom.EditValue = DateTime.Now;
            LayDanhSachHoaDonDatHang();
        }

        private void cbeNhaCungCapFilter_TextChanged(object sender, EventArgs e)
        {
            LayDanhSachHoaDonDatHang();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            int soluonghientai = int.Parse(teSoLuong.Text);
            if (soluonghientai < 1)
                soluonghientai = 1;

            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            if (dtgr3 != null)
            {
                if (dtgr3.Rows.Count > 0)
                {
                    int leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
                    if (leftselection >= 0)
                    {

                        int soluongmathang = int.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                        if (soluonghientai > soluongmathang)
                            soluonghientai = soluongmathang;
                    }
                }
            }

            teSoLuong.Text = soluonghientai.ToString();
        }

        private void gcDanhSachHoaDonDatHang_Click(object sender, EventArgs e)
        {
            int selectrow = gvDanhSachhoaDonDatHang.GetSelectedRows()[0];
            if (selectrow != -1)
            {
                DataTable dt = gcDanhSachHoaDonDatHang.DataSource as DataTable;
                string mahoadon = dt.Rows[selectrow].ItemArray[0].ToString();
                DataTable danhsachmathang = _ChiTietHoaDonDatHangBLT.LayChiTietHoaDonDatHangTheoMaHoaDon(mahoadon);
                for (int i = 0; i < danhsachmathang.Rows.Count; i++)
                {
                    danhsachmathang.Rows[i].ItemArray[2] = float.Parse(danhsachmathang.Rows[i].ItemArray[2].ToString()) * int.Parse(danhsachmathang.Rows[i].ItemArray[1].ToString());
                }
                gcSanPhamDatHang.DataSource = danhsachmathang;
            }
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            int leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
            if (leftselection != -1)
            {
                DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
                DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
                if (dtgr2 != null)
                {
                    bool isAddable = true;
                    for (int i = 0; i < dtgr2.Rows.Count; i++)
                    {
                        if (dtgr2.Rows[i].ItemArray[0].ToString() == dtgr3.Rows[leftselection].ItemArray[0].ToString())
                        {
                            //kiem tra trung
                            isAddable = false;
                            dtgr2.Rows[i][1] = teSoLuong.Text;
                            dtgr2.Rows[i][2] = float.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                            break;
                        }
                    }
                    //neu khong trung thi them vao
                    if (isAddable)
                    {
                        //truong hop xoa het du lieu va data table khong bi null, ma no het hang
                        if (dtgr2.Rows.Count == 0)
                        {
                            dtgr2 = new DataTable();
                            dtgr2.Columns.Add("Tên hàng hóa", typeof(string));
                            dtgr2.Columns.Add("Số Lượng Đặt", typeof(string));
                            dtgr2.Columns.Add("Tổng Tiền", typeof(string));
                            dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, float.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString()));
                        }
                        else
                            dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, float.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString()));
                    }
                }
                else
                {
                    //neu datagrid view 2 trong thi tao datamoi va add du lieu vao
                    dtgr2 = new DataTable();
                    dtgr2.Columns.Add("Tên hàng hóa", typeof(string));
                    dtgr2.Columns.Add("Số Lượng Đặt", typeof(string));
                    dtgr2.Columns.Add("Tổng Tiền", typeof(string));

                    dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, float.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString()));
                }
                gcSanPhamTrongHoaDon.DataSource = dtgr2;
                tongtien = 0;
                for (int i = 0; i < dtgr2.Rows.Count; i++)
                {
                    tongtien += float.Parse(dtgr2.Rows[i].ItemArray[2].ToString());
                }
                lcTongTien.Text = "Tổng Tiền: " + tongtien + " VND";
                teSoLuong.Text = "1";
            }
          
        }

        private void gvSanPhamDatHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;

            //update lai textedit so luong, khi no nho hon 0 va lon hon so luong dat hang
            int soluonghientai = int.Parse(teSoLuong.Text);
            if (soluonghientai < 1)
                soluonghientai = 1;

            int leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
            if (leftselection >= 0)
            {
                int soluongmathang = int.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                if (soluonghientai > soluongmathang)
                    soluonghientai = soluongmathang;
            }

            if (dtgr2 != null)
            {
                for (int i = 0; i < dtgr2.Rows.Count; i++)
                {
                    if (dtgr2.Rows[i].ItemArray[0].ToString() == dtgr3.Rows[leftselection].ItemArray[0].ToString())
                        gvSanPhamTrongHoaDon.FocusedRowHandle = i;
                }
            }
        }

        private void gvSanPhamTrongHoaDon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int rightselection = gvSanPhamTrongHoaDon.GetSelectedRows()[0];
            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dtgr3 != null)
            {
                for (int i = 0; i < dtgr3.Rows.Count; i++)
                {
                    if (dtgr2.Rows[rightselection].ItemArray[0].ToString() == dtgr3.Rows[i].ItemArray[0].ToString())
                    {
                        gvSanPhamDatHang.FocusedRowHandle = i;
                    }
                }
            }
        }
    }
}
