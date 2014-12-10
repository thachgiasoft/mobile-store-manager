﻿using System;
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
using System.Collections;
using DataTransferObject;
using System.Xml.Linq;
using QL_Ban_DienThoai.XtraReport;
using DevExpress.XtraReports.UI;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucHoaDonDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaCungCapBLT   _NhaCungCapBLT;
        private MatHangBLT      _MatHangBLT;
       // private HoaDonBLT       _HoaDonBLT;
        private HoaDonDatHangBLT _HoaDonDatHangBLT;
        private ChiTietHoaDonDatHangBLT _ChiTietHoaDonDatHangBLT;

        Hashtable htNhaCungCap;
        int QuyDinhSoSanPhamToiThieu;
        int leftselection, rightselection;
        double tongtien;
        string TenNhanVienLap;
        public ucHoaDonDatHang()
        {
            InitializeComponent();
            _NhaCungCapBLT  = new NhaCungCapBLT();
            _MatHangBLT     = new MatHangBLT();
            _HoaDonDatHangBLT = new HoaDonDatHangBLT();
            _ChiTietHoaDonDatHangBLT = new ChiTietHoaDonDatHangBLT();
            QuyDinhSoSanPhamToiThieu = 1000;
            leftselection = -1;
            rightselection = -1;
            tongtien = 0;
            TenNhanVienLap = Assist.nhanVien.TenNhanVien;
        }

        private void cbeNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbeNhaCungCap.SelectedItem.ToString() != null)
            {
                string MaNhaCungcap = htNhaCungCap.Keys.OfType<String>().FirstOrDefault(a => htNhaCungCap[a] == cbeNhaCungCap.SelectedItem.ToString());
                gcSanPhamDatHang.DataSource = _MatHangBLT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungcap, QuyDinhSoSanPhamToiThieu);
            }
        }

        private void ucHoaDonDatHang_Load(object sender, EventArgs e)
        {
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            htNhaCungCap = new Hashtable();
            Object[] cbeNhaCungCapItem = new Object[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbeNhaCungCapItem[i] = dt.Rows[i].ItemArray[0];
                htNhaCungCap.Add(dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[0]);
            }
            cbeNhaCungCap.Properties.Items.Clear();
            cbeNhaCungCap.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCap.SelectedIndex = 0;
            cbeNhaCungCapFilter.Properties.Items.Add("Tất Cả");
            cbeNhaCungCapFilter.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCapFilter.SelectedIndex = 0;

            if (cbeNhaCungCap.SelectedItem.ToString() != null)
            {
                string MaNhaCungcap = htNhaCungCap.Keys.OfType<String>().FirstOrDefault(a => htNhaCungCap[a] == cbeNhaCungCap.SelectedItem.ToString());
                gcSanPhamDatHang.DataSource = _MatHangBLT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungcap, QuyDinhSoSanPhamToiThieu);
            }

            deNgayDatHang.EditValue = DateTime.Now;
            deNgayGiaoHang.EditValue = DateTime.Now;

            layDanhSachHoaDonDatHang();
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
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
                            int soluong = int.Parse(teSoLuong.Text);
                            float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                            double temp = soluong * gia;
                            dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp);
                        }
                        else
                        {
                            int soluong = int.Parse(teSoLuong.Text);
                            float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                            double temp = soluong * gia;
                            dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp);
                        
                        }
                       }
                }
                else 
                {
                    //neu datagrid view 2 trong thi tao datamoi va add du lieu vao
                    dtgr2 = new DataTable();
                    dtgr2.Columns.Add("Tên hàng hóa", typeof(string));
                    dtgr2.Columns.Add("Số Lượng Đặt", typeof(string));
                    dtgr2.Columns.Add("Tổng Tiền", typeof(string));
                    int soluong = int.Parse(teSoLuong.Text);
                    float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                    double temp = soluong * gia;
                    dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp);
                }
                gcSanPhamTrongHoaDon.DataSource = dtgr2;
                tongtien = 0;
                for (int i = 0; i < dtgr2.Rows.Count; i++) 
                {
                    tongtien += float.Parse(dtgr2.Rows[i].ItemArray[2].ToString());
                }
                lcTongTien.Text = "Tổng Tiền: " + tongtien + " VND";
            }
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dtgr2 != null)
            {
                for (int i = 0; i < dtgr2.Rows.Count; i++)
                {
                    if( dtgr2.Rows[i].ItemArray[0].ToString() == dtgr3.Rows[leftselection].ItemArray[0].ToString())
                        gvSanPhamTrongHoaDon.FocusedRowHandle = i;
                }
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            rightselection = gvSanPhamTrongHoaDon.GetSelectedRows()[0];
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int soluonghientai = int.Parse(teSoLuong.Text);
            soluonghientai++;
            if (soluonghientai < 1)
                soluonghientai = 1;
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int soluonghientai = int.Parse(teSoLuong.Text);
            soluonghientai--;
            if (soluonghientai < 1)
                soluonghientai = 1;
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void teSoLuong_TextChanged(object sender, EventArgs e)
        {
            int soluonghientai = int.Parse(teSoLuong.Text);
            if (soluonghientai < 1)
                soluonghientai = 1;
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            teSoLuong.Text = "1";
            gcSanPhamTrongHoaDon.DataSource = new DataTable();
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            if (rightselection >= 0)
            {
                DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                dt.Rows.RemoveAt(rightselection);
                rightselection--;
                gcSanPhamTrongHoaDon.DataSource = dt;
                if (gcSanPhamTrongHoaDon.CanFocus)
                     gcSanPhamTrongHoaDon.Focus();
                tongtien = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tongtien += float.Parse(dt.Rows[i].ItemArray[2].ToString());
                }
                lcTongTien.Text = "Tổng Tiền: " + tongtien + " VND";
            }
        }

        private void deNgayGiaoHang_TextChanged(object sender, EventArgs e)
        {

            if (DateTime.Compare(deNgayDatHang.DateTime, deNgayGiaoHang.DateTime) > 0)
            {
                deNgayGiaoHang.EditValue = DateTime.Now;
            }
        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            HoaDonDatHang hd = new HoaDonDatHang();
            hd.MaNhanVien = Assist.nhanVien.MaNhanVien;
            hd.TongTien = tongtien;
            hd.TienThanhToan = 0;
            hd.MaTinhTrang = "TT0000000000001";//tinh trang dat hang
            hd.NgayGiaoHang = deNgayGiaoHang.Text;
            hd.NgayLap = deNgayDatHang.Text;
            hd.GhiChu ="";
            hd.MaNhaCungCap = htNhaCungCap.Keys.OfType<String>().FirstOrDefault(a => htNhaCungCap[a] == cbeNhaCungCap.SelectedItem.ToString());
            string mahoadon = (string)_HoaDonDatHangBLT.ThemHoaDonDatHang(hd);
            themChiTietHoaDon(mahoadon);
            if (mahoadon != "")
                MessageBox.Show("Them Hoa Don Thanh Cong");
            else
                MessageBox.Show("Them Hoa Don That Bai");

            layDanhSachHoaDonDatHang();
            sbCapNhat.Enabled = false;
        }

        private void  layDanhSachHoaDonDatHang()
        {
            HoaDonBLT _HoaDonBLT = new HoaDonBLT();
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
                    DateTime comparedate = new DateTime(tempday.Year ,  tempday.Day ,tempday.Month);
                    int r1 = DateTime.Compare(date, comparedate);
                    int r2 = DateTime.Compare(date2, comparedate) ;
                    if ( r1 <= 0 && r2>= 0)
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

            gcKetQua.DataSource = resulttable2;
        }

        private void cbeNhaCungCapFilter_TextChanged(object sender, EventArgs e)
        {
            layDanhSachHoaDonDatHang();
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
            layDanhSachHoaDonDatHang();
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
            layDanhSachHoaDonDatHang();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt2 = gcKetQua.DataSource as DataTable;
            int selectrow = gvKetQua.GetSelectedRows()[0];
            if (selectrow != -1)
            {
                string MaHoaDonDatHang = dt2.Rows[selectrow].ItemArray[0].ToString();
                //xoa chi tiet hoa don dat hang
                _ChiTietHoaDonDatHangBLT.XoaChiTietHoaDonDathang(MaHoaDonDatHang);


                bool result2 = false;
                DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                string MaNhaCungcap = htNhaCungCap.Keys.OfType<String>().FirstOrDefault(a => htNhaCungCap[a] == cbeNhaCungCap.SelectedItem.ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChiTietHoaDonDatHangBLT chitiethoadondathangblt = new ChiTietHoaDonDatHangBLT();
                    ChiTietHoaDonDatHang cthd = new ChiTietHoaDonDatHang();
                    cthd.MaMatHang = _MatHangBLT.LayMaMatHang(dt.Rows[i].ItemArray[0].ToString()).Rows[0].ItemArray[0].ToString();
                    cthd.SoLuong = int.Parse(dt.Rows[i].ItemArray[1].ToString());
                    cthd.GiaNhap = float.Parse(dt.Rows[i].ItemArray[2].ToString()) / cthd.SoLuong;
                    cthd.MaHoaDonDatHang = MaHoaDonDatHang;
                    chitiethoadondathangblt.ThemChiTietHoaDonDatHang(cthd);
                    result2 = _ChiTietHoaDonDatHangBLT.ThemChiTietHoaDonDatHang(cthd);
                    if (result2)
                        //co loi xay ra trong qua trinh them chitiet va out ra khoi vong lap
                        break;
                }

                if (!result2)
                    MessageBox.Show("Cap Nhat Hoa Don Thanh Cong");
                else
                    MessageBox.Show("Cap Nhat Hoa Don That Bai");

                layDanhSachHoaDonDatHang();

                sbCapNhat.Enabled = false;
            }
        }

        private void gvKetQua_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int selectrow = gvKetQua.GetSelectedRows()[0];
            if (selectrow != -1)
            {
                DataTable dt2 = gcKetQua.DataSource as DataTable;
                TenNhanVienLap = dt2.Rows[selectrow].ItemArray[3].ToString();
                sbCapNhat.Enabled = true;
                gcSanPhamTrongHoaDon.DataSource = null;
                gvSanPhamTrongHoaDon.Columns.Clear();
                DataTable dt = gcKetQua.DataSource as DataTable;
                string mahoadon = dt.Rows[selectrow].ItemArray[0].ToString();
                DataTable danhsachmathang = _ChiTietHoaDonDatHangBLT.LayChiTietHoaDonDatHangTheoMaHoaDon(mahoadon);
                for (int i = 0; i < danhsachmathang.Rows.Count; i++)
                {
                    danhsachmathang.Rows[i].ItemArray[2] = float.Parse(danhsachmathang.Rows[i].ItemArray[2].ToString()) * int.Parse(danhsachmathang.Rows[i].ItemArray[1].ToString());
                }
                gcSanPhamTrongHoaDon.DataSource = danhsachmathang;
            }
        }

        private void themChiTietHoaDon(string mahoadon)
        {
            if (mahoadon != "")
            {
                DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChiTietHoaDonDatHangBLT chitiethoadondathangblt = new ChiTietHoaDonDatHangBLT();
                    ChiTietHoaDonDatHang cthd = new ChiTietHoaDonDatHang();
                    cthd.MaMatHang = _MatHangBLT.LayMaMatHang(dt.Rows[i].ItemArray[0].ToString()).Rows[0].ItemArray[0].ToString();
                    cthd.SoLuong = int.Parse(dt.Rows[i].ItemArray[1].ToString());
                    cthd.GiaNhap = float.Parse(dt.Rows[i].ItemArray[2].ToString()) / cthd.SoLuong;
                    cthd.MaHoaDonDatHang = mahoadon;
                    chitiethoadondathangblt.ThemChiTietHoaDonDatHang(cthd);
                }
            }
        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {

        }

        private void sbIn_Click(object sender, EventArgs e)
        {
            HoaDonDatHang hd = new HoaDonDatHang();
            hd.DanhSachSanPham = gcSanPhamTrongHoaDon.DataSource as DataTable;
            hd.NgayGiaoHang = deNgayGiaoHang.DateTime.ToString();
            hd.NgayLap = deNgayDatHang.DateTime.ToString();
            hd.NhaCungCap = cbeNhaCungCap.Text;
            hd.TenNhanVien = TenNhanVienLap;
            XtraReportLapHoaDonDatHang BanInHoaDonDatHang = new XtraReportLapHoaDonDatHang(hd);
            try
            {
                BanInHoaDonDatHang.CreateDocument();
            }
            catch (Exception ex)
            {

            }
            ReportPrintTool printTool = new ReportPrintTool(BanInHoaDonDatHang);
            printTool.ShowPreviewDialog();
        }
    }
}
