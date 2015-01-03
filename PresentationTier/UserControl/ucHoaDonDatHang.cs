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
using System.Collections;
using DataTransferObject;
using System.Xml.Linq;
using QL_Ban_DienThoai.XtraReport;
using DevExpress.XtraReports.UI;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucHoaDonDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaCungCapBLT           _NhaCungCapBLT;
        private MatHangBLT              _MatHangBLT;
        private HoaDonDatHangBLT        _HoaDonDatHangBLT;
        private ChiTietHoaDonDatHangBLT _ChiTietHoaDonDatHangBLT;
        private ThamSoBLT               _ThamSoBLT;
        int     QuyDinhSoSanPhamToiThieu;
        int     leftselection, rightselection;
        double  tongtien;
        string  TenNhanVienLap;
        public ucHoaDonDatHang()
        {
            InitializeComponent();
            _NhaCungCapBLT      = new NhaCungCapBLT();
            _MatHangBLT         = new MatHangBLT();
            _HoaDonDatHangBLT   = new HoaDonDatHangBLT();
            _ChiTietHoaDonDatHangBLT = new ChiTietHoaDonDatHangBLT();
            _ThamSoBLT = new ThamSoBLT();
            ThamSo ts =new ThamSo();
            ts.TenThamSo = "SoSanPhamTonToiDaDeDatHang";
            QuyDinhSoSanPhamToiThieu = (int)Convert.ToDecimal(_ThamSoBLT.LayGiaTriThamSo(ts));
            leftselection   = -1;
            rightselection  = -1;
            tongtien        = 0;
            TenNhanVienLap  = Assist.nhanVien.TenNhanVien;
        }

        private void cbeNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbeNhaCungCap.SelectedItem.ToString() != null)
            {
                string MaNhaCungcap = _NhaCungCapBLT.LayMaNhaCCBangTenNhaCungCap(cbeNhaCungCap.SelectedItem.ToString());
                DataTable dt= _MatHangBLT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungcap, QuyDinhSoSanPhamToiThieu);
                gcSanPhamDatHang.DataSource = dt ;
                gvSanPhamDatHang.Columns[0].Width = 250;
                gvSanPhamDatHang.Columns[1].Width = 140;
                gcSanPhamTrongHoaDon.DataSource = null;
                gvSanPhamTrongHoaDon.Columns.Clear();
            }
        }

        private void ucHoaDonDatHang_Load(object sender, EventArgs e)
        {
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            Object[] cbeNhaCungCapItem = new Object[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbeNhaCungCapItem[i] = dt.Rows[i].ItemArray[1];
            }
            cbeNhaCungCap.Properties.Items.Clear();
            cbeNhaCungCap.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCap.SelectedIndex = 0;
            cbeNhaCungCapLoc.Properties.Items.Add("Tất Cả");
            cbeNhaCungCapLoc.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCapLoc.SelectedIndex = 0;

            if (cbeNhaCungCap.SelectedItem.ToString() != null)
            {
                string MaNhaCungcap = _NhaCungCapBLT.LayMaNhaCCBangTenNhaCungCap(cbeNhaCungCap.SelectedItem.ToString());
                gcSanPhamDatHang.DataSource = _MatHangBLT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungcap, QuyDinhSoSanPhamToiThieu);
            }

            deNgayDatHang.EditValue = DateTime.Now;
            deNgayGiaoHang.EditValue = DateTime.Now;

            layDanhSachHoaDonDatHang();
        }

        private void sbThem_Click(object sender, EventArgs e)
        {

            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            if (dtgr3 != null && dtgr3.Rows.Count > 0)
            {
                leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
                if (leftselection != -1)
                {
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
                                double temp = float.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                                dtgr2.Rows[i][2] = temp.ToString();
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
                                dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp.ToString());
                            }
                            else
                            {
                                int soluong = int.Parse(teSoLuong.Text);
                                float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                                double temp = soluong * gia;
                                dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp.ToString());

                            }
                        }
                    }
                    else
                    {
                        if (teSoLuong.Text == "")
                            teSoLuong.Text = "1";
                        gcSanPhamTrongHoaDon.DataSource = null;
                        gvSanPhamTrongHoaDon.Columns.Clear();
                        //neu datagrid view 2 trong thi tao datamoi va add du lieu vao
                        dtgr2 = new DataTable();
                        dtgr2.Columns.Add("Tên hàng hóa", typeof(string));
                        dtgr2.Columns.Add("Số Lượng Đặt", typeof(string));
                        dtgr2.Columns.Add("Tổng Tiền", typeof(string));
                        int soluong = int.Parse(teSoLuong.Text);
                        float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                        double temp = soluong * gia;
                        dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp.ToString());

                    }
                    gcSanPhamTrongHoaDon.DataSource = dtgr2;
                    gvSanPhamTrongHoaDon.Columns[0].Width = 250;
                    gvSanPhamTrongHoaDon.Columns[1].Width = 60;
                    gvSanPhamTrongHoaDon.Columns[2].Width = 140;

                    tinhTongTien();
                }
            }
        }

        private void tinhTongTien()
        {
            DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
            tongtien = 0;
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tongtien += float.Parse(dt.Rows[i].ItemArray[2].ToString());
                }
            }
            lcTongTien.Text = "Tổng Tiền: " + tongtien + " VND";
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            if (dtgr3 != null && dtgr3.Rows.Count > 0)
            {
                leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
                DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
                if (dtgr2 != null)
                {
                    for (int i = 0; i < dtgr2.Rows.Count; i++)
                    {
                        if (dtgr2.Rows[i].ItemArray[0].ToString() == dtgr3.Rows[leftselection].ItemArray[0].ToString())
                            gvSanPhamTrongHoaDon.FocusedRowHandle = i;
                    }
                }
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dtgr2 != null && dtgr2.Rows.Count > 0)
            {
                rightselection = gvSanPhamTrongHoaDon.GetSelectedRows()[0];
                DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
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
            
             DialogResult dresult = MessageBox.Show("Bạn có chắc là xóa các sản phẩm trong danh sách sản phẩm đặt hàng???",
                                                    "Thông Báo",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dresult == DialogResult.Yes)
             {
                 teSoLuong.Text = "1";
                 gcSanPhamTrongHoaDon.DataSource = null;
                 gvSanPhamTrongHoaDon.Columns.Clear();
             }
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
            DataTable dt3 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dt3 == null || dt3.Rows.Count == 0)
            {
                MessageBox.Show("Hóa Đơn Này Không Có Sản Phẩm",
                                                       "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dresult = MessageBox.Show("Bạn có chắc là thêm hóa đơn đặt hàng này???",
                                                        "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dresult == DialogResult.Yes)
                {
                    HoaDonDatHang hd = new HoaDonDatHang();
                    hd.MaNhanVien = Assist.nhanVien.MaNhanVien;
                    hd.TongTien = tongtien;
                    hd.TienThanhToan = 0;
                    hd.MaTinhTrang = "TT0000000000001";//tinh trang dat hang
                    hd.NgayGiaoHang = ((DateTime)deNgayGiaoHang.EditValue).ToString("MM/dd/yyyy");
                    hd.NgayLap = ((DateTime)deNgayDatHang.EditValue).ToString("MM/dd/yyyy");
                    hd.GhiChu = "";
                    hd.MaNhaCungCap =  _NhaCungCapBLT.LayMaNhaCCBangTenNhaCungCap(cbeNhaCungCap.SelectedItem.ToString());
                    string mahoadon = (string)_HoaDonDatHangBLT.ThemHoaDonDatHang(hd);
                    themChiTietHoaDon(mahoadon);
                    if (mahoadon != "")
                        MessageBox.Show("Thêm hoá đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm hóa đơn thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    layDanhSachHoaDonDatHang();
                    sbCapNhatHoaDon.Enabled = false;
                }
            }
        }

        private void  layDanhSachHoaDonDatHang()
        {
            DataTable dt = _HoaDonDatHangBLT.LayDanhSachHoaDonDatHang();
            if (dt != null && dt.Rows.Count > 0)
            {
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
                    if (cbeNhaCungCapLoc.Text == "Tất Cả")
                        resulttable.Rows.Add(dt.Rows[i].ItemArray[0],
                            dt.Rows[i].ItemArray[1],
                            dt.Rows[i].ItemArray[2],
                            dt.Rows[i].ItemArray[3],
                            dt.Rows[i].ItemArray[4],
                            dt.Rows[i].ItemArray[5]);
                    else
                        if (cbeNhaCungCapLoc.Text == dt.Rows[i].ItemArray[2].ToString())
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

                if (deNgayDatHangTu.Text == "" && deNgayDatHangDen.Text == "")
                {
                    resulttable2 = resulttable;
                }
                else
                {
                    for (int i = 0; i < resulttable.Rows.Count; i++)
                    {
                        DateTime date = deNgayDatHangTu.DateTime;
                        DateTime date2 = deNgayDatHangDen.DateTime;
                        DateTime tempday = Convert.ToDateTime(resulttable.Rows[i].ItemArray[1]);
                        DateTime comparedate = new DateTime(tempday.Year,tempday.Month ,  tempday.Day);
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
                gcDanhSachPhieuDatHang.DataSource = resulttable2;
            }

        }

        private void cbeNhaCungCapFilter_TextChanged(object sender, EventArgs e)
        {
            layDanhSachHoaDonDatHang();
        }

        private void deNgayDatHangFrom_TextChanged(object sender, EventArgs e)
        {
            if (deNgayDatHangTu.Text == "")
            {
                deNgayDatHangDen.Text = "";
            }
            else
            if (deNgayDatHangDen.Text == "")
                deNgayDatHangDen.EditValue = DateTime.Now;
            layDanhSachHoaDonDatHang();
        }

        private void deNgayDatHangTo_TextChanged(object sender, EventArgs e)
        {
            if (deNgayDatHangDen.Text == "")
            {
                deNgayDatHangTu.Text = "";
            }
            else
            if (deNgayDatHangTu.Text == "")
                deNgayDatHangTu.EditValue = DateTime.Now;
            layDanhSachHoaDonDatHang();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt3 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dt3 == null || dt3.Rows.Count == 0)
            {
                MessageBox.Show("Hóa Đơn Này Không Có Sản Phẩm",
                                                       "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dresult = MessageBox.Show("Bạn có chắc là sửa hóa đơn đặt hàng này???",
                                                        "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dresult == DialogResult.Yes)
                {
                    DataTable dt2 = gcDanhSachPhieuDatHang.DataSource as DataTable;
                    if (dt2 != null && dt2.Rows.Count > 0)
                    {
                        int selectrow = gvKetQua.GetSelectedRows()[0];
                        if (selectrow != -1)
                        {
                            string MaHoaDonDatHang = dt2.Rows[selectrow].ItemArray[0].ToString();
                            //cap nhat ngay giao hang
                            HoaDonDatHang hd = new HoaDonDatHang();
                            hd.MaHoaDon = MaHoaDonDatHang;
                            hd.NgayGiaoHang = ((DateTime)deNgayGiaoHang.EditValue).ToString("MM/dd/yyyy");
                            _HoaDonDatHangBLT.CapNhatHoaDonDatHang(hd);
                            //xoa chi tiet hoa don dat hang
                            _ChiTietHoaDonDatHangBLT.XoaChiTietHoaDonDathang(MaHoaDonDatHang);

                            bool result2 = false;
                            DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                            if (dt != null)
                            {
                                string MaNhaCungcap = _NhaCungCapBLT.LayMaNhaCCBangTenNhaCungCap(cbeNhaCungCap.SelectedItem.ToString());

                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    ChiTietHoaDonDatHangBLT chitiethoadondathangblt = new ChiTietHoaDonDatHangBLT();
                                    ChiTietHoaDonDatHang cthd = new ChiTietHoaDonDatHang();
                                    cthd.SoLuong = int.Parse(dt.Rows[i].ItemArray[1].ToString());
                                    cthd.GiaNhap = float.Parse(dt.Rows[i].ItemArray[2].ToString()) / cthd.SoLuong;
                                    cthd.MaHoaDonDatHang = MaHoaDonDatHang;

                                    MatHang mh = new MatHang();
                                    mh.MaNhaCungCap = _NhaCungCapBLT.LayMaNhaCCBangTenNhaCungCap(cbeNhaCungCap.SelectedItem.ToString());
                                    mh.TenMatHang = dt.Rows[i].ItemArray[0].ToString();
                                    cthd.MaMatHang = _MatHangBLT.LayMaMatHangTuTenMatHangVaMaNhaCungCap(mh);

                                    chitiethoadondathangblt.ThemChiTietHoaDonDatHang(cthd);
                                    result2 = _ChiTietHoaDonDatHangBLT.ThemChiTietHoaDonDatHang(cthd);
                                    if (result2)
                                        //co loi xay ra trong qua trinh them chi tiet va out ra khoi vong lap
                                        break;
                                }
                            }
                            if (!result2)
                                MessageBox.Show("Thêm hoá đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Thêm hóa đơn thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            layDanhSachHoaDonDatHang();

                            sbCapNhatHoaDon.Enabled = false;
                        }
                    }
                }
            }
        }

        private void gvKetQua_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataTable dt2 = gcDanhSachPhieuDatHang.DataSource as DataTable;
            if (dt2 != null && dt2.Rows.Count > 0)
            {
                int selectrow = gvKetQua.GetSelectedRows()[0];
                if (selectrow != -1)
                {

                    TenNhanVienLap = dt2.Rows[selectrow].ItemArray[3].ToString();
                    sbCapNhatHoaDon.Enabled = true;
                    gcSanPhamTrongHoaDon.DataSource = null;
                    gvSanPhamTrongHoaDon.Columns.Clear();
                    DataTable dt = gcDanhSachPhieuDatHang.DataSource as DataTable;
                    string mahoadon = dt.Rows[selectrow].ItemArray[0].ToString();
                    DataTable danhsachmathang = _ChiTietHoaDonDatHangBLT.LayChiTietHoaDonDatHangTheoMaHoaDon(mahoadon);
                    if (danhsachmathang.Rows.Count > 0)
                    {
                        for (int i = 0; i < danhsachmathang.Rows.Count; i++)
                        {
                            danhsachmathang.Rows[i].ItemArray[2] = float.Parse(danhsachmathang.Rows[i].ItemArray[2].ToString()) * int.Parse(danhsachmathang.Rows[i].ItemArray[1].ToString());
                        }
                        gcSanPhamTrongHoaDon.DataSource = danhsachmathang;
                    }
                    else
                    {
                        gcSanPhamTrongHoaDon.DataSource = null;
                        gvSanPhamTrongHoaDon.Columns.Clear();
                    }
                    tinhTongTien();
                }
            }
        }

        private void themChiTietHoaDon(string mahoadon)
        {
            if (mahoadon != "")
            {
                DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ChiTietHoaDonDatHangBLT chitiethoadondathangblt = new ChiTietHoaDonDatHangBLT();
                        ChiTietHoaDonDatHang cthd = new ChiTietHoaDonDatHang();
                        MatHang mh = new MatHang();
                        mh.MaNhaCungCap = _NhaCungCapBLT.LayMaNhaCCBangTenNhaCungCap(cbeNhaCungCap.SelectedItem.ToString());
                        mh.TenMatHang = dt.Rows[i].ItemArray[0].ToString();
                        cthd.MaMatHang = _MatHangBLT.LayMaMatHangTuTenMatHangVaMaNhaCungCap(mh);
                        cthd.SoLuong = int.Parse(dt.Rows[i].ItemArray[1].ToString());
                        cthd.GiaNhap = float.Parse(dt.Rows[i].ItemArray[2].ToString()) / cthd.SoLuong;
                        cthd.MaHoaDonDatHang = mahoadon;
                        chitiethoadondathangblt.ThemChiTietHoaDonDatHang(cthd);
                    }
                }
            }
        }

        private void sbIn_Click(object sender, EventArgs e)
        {
            DataTable dt3 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dt3 == null || dt3.Rows.Count == 0)
            {
                MessageBox.Show("Hóa Đơn Này Không Có Sản Phẩm",
                                                       "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                HoaDonDatHang hd = new HoaDonDatHang();
                hd.DanhSachSanPham = gcSanPhamTrongHoaDon.DataSource as DataTable;
                hd.NgayGiaoHang = deNgayGiaoHang.DateTime.ToString();
                hd.NgayLap = deNgayDatHang.DateTime.ToString();
                hd.NhaCungCap = cbeNhaCungCap.Text;
                hd.TenNhanVien = TenNhanVienLap;
                hd.TongTien = tongtien;
                XRLapHoaDonDatHang BanInHoaDonDatHang = new XRLapHoaDonDatHang(hd);
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
}
