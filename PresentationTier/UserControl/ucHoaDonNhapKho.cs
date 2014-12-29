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
using DevExpress.XtraReports.UI;
using QL_Ban_DienThoai.XtraReport;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucHoaDonNhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonNhapHangBLT _HoaDonNhapHang;
        HoaDonDatHangBLT _HoaDonDatHang;
        NhaCungCapBLT _NhaCungCapBLT;
        MatHangBLT _MatHangBLT;
        ChiTietHoaDonDatHangBLT _ChiTietHoaDonDatHangBLT;
        //ma hoa don dang chon
        string MaHoaDonDatHang;
        double tongtien;
        public ucHoaDonNhapKho()
        {
            InitializeComponent();
            _HoaDonNhapHang = new HoaDonNhapHangBLT();
            _HoaDonDatHang = new HoaDonDatHangBLT();
            _NhaCungCapBLT = new NhaCungCapBLT();
            _ChiTietHoaDonDatHangBLT = new ChiTietHoaDonDatHangBLT();
            _MatHangBLT = new MatHangBLT();
            tongtien = 0;
        }

        void LayDanhSachHoaDonDatHang()
        {
            gvSanPhamDatHang.Columns.Clear();
            gcSanPhamDatHang.DataSource = null;
            gvDanhSachhoaDonDatHang.Columns.Clear();
            gcSanPhamTrongHoaDon.DataSource = null;
            DataTable dt = _HoaDonDatHang.LayDanhSachHoaDonDatHang();
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
                        DateTime comparedate = new DateTime(tempday.Year,  tempday.Month, tempday.Day);
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

                gvDanhSachhoaDonDatHang.Columns[0].Width = 140;
                gvDanhSachhoaDonDatHang.Columns[1].Width = 80;
                gvDanhSachhoaDonDatHang.Columns[2].Width = 150;
                gvDanhSachhoaDonDatHang.Columns[3].Width = 150;
                gvDanhSachhoaDonDatHang.Columns[4].Width = 150;
                gvDanhSachhoaDonDatHang.Columns[5].Width = 50;
            }
        }

        private void ucHoaDonNhapKho_Load(object sender, EventArgs e)
        {
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            Object[] cbeNhaCungCapItem = new Object[dt.Rows.Count + 1];
            cbeNhaCungCapItem[0] = "Tất Cả";
            for (int i = 1; i < dt.Rows.Count + 1; i++)
            {
                cbeNhaCungCapItem[i] = dt.Rows[i - 1].ItemArray[1];
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
            if (dtgr3 != null && dtgr3.Rows.Count > 0)
            {
                    int leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
                    if (leftselection >= 0)
                    {

                        int soluongmathang = int.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                        if (soluonghientai > soluongmathang)
                            soluonghientai = soluongmathang;
                    }
                
            }
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void gcDanhSachHoaDonDatHang_Click(object sender, EventArgs e)
        {
            DataTable dtt = gcDanhSachHoaDonDatHang.DataSource as DataTable;
            if (dtt != null && dtt.Rows.Count > 0)
            {
                int selectrow = gvDanhSachhoaDonDatHang.GetSelectedRows()[0];
                if (selectrow != -1)
                {
                    DataTable dt = gcDanhSachHoaDonDatHang.DataSource as DataTable;
                    string mahoadon = dt.Rows[selectrow].ItemArray[0].ToString();
                    if (MaHoaDonDatHang != mahoadon)
                    {
                        MaHoaDonDatHang = mahoadon;
                        gcSanPhamTrongHoaDon.DataSource = null;
                        gvSanPhamTrongHoaDon.Columns.Clear();
                        DataTable danhsachmathang = _ChiTietHoaDonDatHangBLT.LayChiTietHoaDonDatHangTheoMaHoaDon(mahoadon);
                        for (int i = 0; i < danhsachmathang.Rows.Count; i++)
                        {
                            danhsachmathang.Rows[i].ItemArray[2] = float.Parse(danhsachmathang.Rows[i].ItemArray[2].ToString()) * int.Parse(danhsachmathang.Rows[i].ItemArray[1].ToString());
                        }
                        gcSanPhamDatHang.DataSource = danhsachmathang;
                        gvSanPhamDatHang.Columns[0].Width = 200;
                        gvSanPhamDatHang.Columns[1].Width = 50;
                        gvSanPhamDatHang.Columns[2].Width = 120;
                    }
                    sbLuu.Enabled = true;
                    tinhTongTien();
                }
            }
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            if (dtgr3 != null && dtgr3.Rows.Count > 0)
            {
                int leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
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
                                dtgr2.Rows[i][2] = float.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[2].ToString()) / float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
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
                                float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[2].ToString());
                                double temp = soluong * gia / float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                                dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp);
                            }
                            else
                            {
                                int soluong = int.Parse(teSoLuong.Text);
                                float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[2].ToString());
                                double temp = soluong * gia / float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
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
                        float gia = float.Parse(dtgr3.Rows[leftselection].ItemArray[2].ToString());
                        double temp = soluong * gia / float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                        dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, temp);
                    }
                    gcSanPhamTrongHoaDon.DataSource = dtgr2;

                    tinhTongTien();
                    gvSanPhamTrongHoaDon.Columns[0].Width = 300;
                    gvSanPhamTrongHoaDon.Columns[1].Width = 50;
                    gvSanPhamTrongHoaDon.Columns[2].Width = 120;
                }
            }
            else
            {
                MessageBox.Show("Không Có Sản Phẩm Nào Để Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvSanPhamDatHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;

            //update lai textedit so luong, khi no nho hon 0 va lon hon so luong dat hang
            if (dtgr3 != null && dtgr3.Rows.Count > 0)
            {
                int leftselection = gvSanPhamDatHang.GetSelectedRows()[0];
                if (leftselection >= 0)
                {
                    teSoLuong.Text = dtgr3.Rows[leftselection].ItemArray[1].ToString();
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
        }

        private void gvSanPhamTrongHoaDon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dtgr2 != null & dtgr2.Rows.Count >0)
            {
                int rightselection = gvSanPhamTrongHoaDon.GetSelectedRows()[0];
                if (dtgr3 != null)
                {
                    for (int i = 0; i < dtgr3.Rows.Count; i++)
                    {
                        if (dtgr2.Rows[rightselection].ItemArray[0].ToString() == dtgr3.Rows[i].ItemArray[0].ToString())
                        {
                            gvSanPhamDatHang.FocusedRowHandle = i;
                            teSoLuong.Text = dtgr2.Rows[rightselection].ItemArray[1].ToString();
                        }
                    }
                }
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
                DialogResult dresult = MessageBox.Show("Bạn có chắc là thêm hóa đơn nhập hàng này???",
                                                       "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dresult == DialogResult.Yes)
                {
                    HoaDonNhapHang hdnh = new HoaDonNhapHang();
                    hdnh.MaNhanVien = Assist.nhanVien.MaNhanVien;
                    hdnh.TongTien = tongtien;
                    hdnh.TienThanhToan = 0;
                    hdnh.MaTinhTrang = "TT0000000000001";//tinh trang dat hang
                    hdnh.NgayGiaoHang = DateTime.Now.ToString("MM/dd/yyyy");
                    hdnh.NgayLap = DateTime.Now.ToString("MM/dd/yyyy");
                    hdnh.GhiChu = "";
                    hdnh.MaHoaDonDatHang = MaHoaDonDatHang;
                    string mahoadon = (string)_HoaDonNhapHang.ThemHoaDonNhapHang(hdnh);
                    themChiTietHoaDon(mahoadon);
                    if (mahoadon != "")
                        MessageBox.Show("Thêm hoá đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm hóa đơn thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachHoaDonDatHang();
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
                    ChiTietHoaDonNhapHangBLT _ChiTietHoaDonNhapHangBLT = new ChiTietHoaDonNhapHangBLT();
                    ChiTietHoaDonNhapHang cthd = new ChiTietHoaDonNhapHang();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                      //  cthd.MaMatHang = _MatHangBLT.LayMaMatHang(dt.Rows[i].ItemArray[0].ToString()).Rows[0].ItemArray[0].ToString();
                        cthd.SoLuong = int.Parse(dt.Rows[i].ItemArray[1].ToString());
                        cthd.MaHoaDonNhapHang = mahoadon;
                        _ChiTietHoaDonNhapHangBLT.ThemChiTietHoaDonNhapHang(cthd);
                    }
                }
            }
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
                 DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                 if (dt != null && dt.Rows.Count > 0)
                 {
                     int rightselection = gvSanPhamTrongHoaDon.GetSelectedRows()[0];
                     if (rightselection >= 0)
                     {
                         dt.Rows.RemoveAt(rightselection);
                         rightselection--;
                         gcSanPhamTrongHoaDon.DataSource = dt;
                         if (gcSanPhamTrongHoaDon.CanFocus)
                             gcSanPhamTrongHoaDon.Focus();
                         tinhTongTien();
                     }
                 }
                 else
                 {
                     MessageBox.Show("Không Có Sản Phẩm Nào Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DataTable dt = gcDanhSachHoaDonDatHang.DataSource as DataTable;
                if (dt != null && dt.Rows.Count > 0)
                {
                    int selectrow = gvDanhSachhoaDonDatHang.GetSelectedRows()[0];
                    if (selectrow != -1)
                    {
                        HoaDonNhapHang hd = new HoaDonNhapHang();
                        hd.DanhSachSanPham = gcSanPhamTrongHoaDon.DataSource as DataTable;
                        hd.NgayGiaoHang = deNgayThanhToan.DateTime.ToString();
                        hd.NgayLap = deNgayThanhToan.DateTime.ToString();
                        hd.NhaCungCap = dt.Rows[selectrow].ItemArray[2].ToString();
                        hd.TenNhanVien = dt.Rows[selectrow].ItemArray[3].ToString();
                        hd.TongTien = tongtien;
                        XRLapHoaDonThanhToanNhapHang BanInHoaDonNhapHang = new XRLapHoaDonThanhToanNhapHang(hd);
                        try
                        {
                            BanInHoaDonNhapHang.CreateDocument();
                        }
                        catch (Exception ex)
                        {

                        }
                        ReportPrintTool printTool = new ReportPrintTool(BanInHoaDonNhapHang);
                        printTool.ShowPreviewDialog();
                    }
                }
            }
        }
    }
}
