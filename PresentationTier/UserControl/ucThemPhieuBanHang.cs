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
using System.Xml.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemPhieuBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        private HoaDonBanBLT hoaDonBanBLT;
        private String maHD = "";

        //thông tin sản phẩm.
        private String maSP = "";
        private String tenSP = "";
        private int soLuong = 0;
        private Decimal tienSP = 0;
        private Decimal tienLephi = 0;
        private Decimal tienTongSp = 0;
        private String maKhuyenMai = "";

        public ucThemPhieuBanHang()
        {
            InitializeComponent();
            this.hoaDonBanBLT = new HoaDonBanBLT();

            this.rdbDsSanPham.Checked = true;
            ////Lấy ds khách hàng
            this.lueKhachHang.Properties.DataSource = (new HoaDonBanBLT().LayDanhSachKhachHang());
           // this.lueKhachHang.Properties.Columns.Add(new LookUpColumnInfo(this.lueKhachHang.Properties.DisplayMember));
            ////Lấy ds trạng thái.
            this.lueTrangThai.Properties.DataSource = (new HoaDonBanBLT().LayDanhSachTrangThai());
            this.lueTrangThai.Properties.Columns.Add(new LookUpColumnInfo(this.lueTrangThai.Properties.DisplayMember));

            ////Lấy ds khu vuc
            this.lueKhuVu.Properties.DataSource = (new LePhiGiaoHangBLT().LayDanhSachLePhiGiaoHang());
            this.lueKhuVu.Properties.Columns.Add(new LookUpColumnInfo(this.lueKhuVu.Properties.DisplayMember));

            this.LoadData();        
        }

        private void sbThemHangHoa_Click(object sender, EventArgs e)
        {
        
        }

        private void sbXoaHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void ConvertDataToXML(out XElement XML)
        {
            List<HoaDonBan> lstHoaDonBan = new List<HoaDonBan>();

            XML = new XElement(new XElement("Root"));
            for (int i = 0; i < gridSpMua.RowCount; i++)
            {
                HoaDonBan temp = new HoaDonBan();
                temp.CtHoaDon.MatHang.MaMatHang = gridSpMua.GetRowCellValue(i, "Mã sản phẩm").ToString();
                temp.CtHoaDon.SoLuong = Convert.ToInt32(gridSpMua.GetRowCellValue(i, "Số lượng"));
                temp.CtHoaDon.GiaBan = Convert.ToDecimal(gridSpMua.GetRowCellValue(i, "Giá bán"));

                lstHoaDonBan.Add(temp);
            }

            foreach (HoaDonBan item in lstHoaDonBan)
            {
                XElement xml = new XElement("XmlData",
                    new XElement("MaCTHoaDon", item.CtHoaDon.MaCTHoaDonBan == null ? "" : item.CtHoaDon.MaCTHoaDonBan),                  
                    new XElement("MaMatHang", item.CtHoaDon.MatHang.MaMatHang == null ? "" : item.CtHoaDon.MatHang.MaMatHang),                  
                    new XElement("SoLuong", item.CtHoaDon.SoLuong == null ? Decimal.Zero : item.CtHoaDon.SoLuong),
                     new XElement("GiaBan", item.CtHoaDon.GiaBan == null ? Decimal.Zero : item.CtHoaDon.GiaBan)
                    );
                XML.Add(xml);
            }
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {

            if (Assist.gHoaDonBan != null)
            {
                this.maHD = Assist.gHoaDonBan.HoaDon.MaHoaDon;
                this.lueKhachHang.EditValue = Assist.gHoaDonBan.KhachHang.MaKhachHang;
                this.lueTrangThai.Text = Assist.gHoaDonBan.HoaDon.TrangThai.TenTrangThai;
                this.teTenKhachHang.Text = Assist.gHoaDonBan.KhachHang.TenKhachHang;
                this.teMaNhanVien.Text = Assist.gHoaDonBan.HoaDon.NhanVien.MaNhanVien;
                this.teTenNhanVien.Text = Assist.gHoaDonBan.HoaDon.NhanVien.TenNhanVien;
                this.teTongTien.Text = Assist.gHoaDonBan.HoaDon.TongTien.ToString();
                this.tienTongSp = Convert.ToDecimal(this.teTongTien.Text);
                this.teTienDTT.Text = Assist.gHoaDonBan.HoaDon.TienDaTT.ToString();
                this.teTienConLai.Text = (Assist.gHoaDonBan.HoaDon.TongTien - Assist.gHoaDonBan.HoaDon.TienDaTT + Assist.gHoaDonBan.LePhiGiaoHang.Dongia).ToString();

                this.deThoiGianLap.Text = Assist.gHoaDonBan.HoaDon.NgayLap;
                this.txtDiaChiGH.Text = Assist.gHoaDonBan.DiaChiGH;
                this.lueKhuVu.Text = Assist.gHoaDonBan.LePhiGiaoHang.TenKhuVuc;
                this.dateGiaoHang.Text = Assist.gHoaDonBan.NgayGiaoHang;

                HoaDonBan hd = new HoaDonBan();
                hd.HoaDon.MaHoaDon = this.maHD;
                this.gridSanPhamMua.DataSource = (new HoaDonBanBLT().TimKiemCThoaDon(hd));

                for (int j = 0; j < this.gridSpMua.RowCount; j++)
                {
                    Decimal giaBan = Convert.ToDecimal(gridSpMua.GetRowCellValue(j, "Giá bán"));
                    int slTemp = Convert.ToInt32(gridSpMua.GetRowCellValue(j, "Số lượng"));
                    gridSpMua.SetRowCellValue(j, "Giá bán", (slTemp) * giaBan);
                }
            }
            else
            {
                this.btnLamMoi_Click(null, null);
            }
        }

        private void sbLuu_Click_1(object sender, EventArgs e)
        {
            HoaDonBan hd = new HoaDonBan();
            hd.HoaDon.MaHoaDon = this.maHD;
            
            hd.KhachHang.MaKhachHang = this.lueKhachHang.EditValue == null ? "" : this.lueKhachHang.EditValue.ToString();
            hd.HoaDon.TrangThai.MaTrangThai = this.lueTrangThai.EditValue == null ? "" : this.lueTrangThai.EditValue.ToString();

            if (!hd.HoaDon.TrangThai.MaTrangThai.Equals("") && hd.HoaDon.TrangThai.MaTrangThai.Contains("Đã Thanh toán"))
                hd.NgayTT = DateTime.Now.ToString("dd/MM/yyyy");
            else
                hd.NgayTT = "";

            hd.KhachHang.TenKhachHang = this.teTenKhachHang.Text;
            hd.HoaDon.NhanVien.TenNhanVien = this.teTenNhanVien.Text;
            hd.HoaDon.NhanVien.MaNhanVien = this.teMaNhanVien.Text;
            hd.HoaDon.TongTien = (this.teTongTien.Text == "" ? Decimal.Zero : Convert.ToDecimal(this.teTongTien.Text));
            hd.HoaDon.TienDaTT = (this.teTienDTT.Text == "" ? Decimal.Zero : Convert.ToDecimal(this.teTienDTT.Text));
            hd.HoaDon.NgayLap = this.deThoiGianLap.DateTime.ToString("dd/MM/yyyy");

            if (hd.KhachHang.TenKhachHang.Equals(""))
            {
                MessageBox.Show("Tên Khách hàng không được bỏ trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (this.gridSpMua.RowCount == 0)
            {
                MessageBox.Show("Danh sách sản phẩm mua không được để trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            hd.LePhiGiaoHang.MaKhuVuc = this.lueKhuVu.EditValue == null ? null : this.lueKhuVu.EditValue.ToString();
            hd.NgayGiaoHang = this.dateGiaoHang.DateTime.ToString("dd/MM/yyyy");
            if (hd.NgayGiaoHang.Equals("01-01-0001"))
            {
                hd.NgayGiaoHang = "";
            }
             hd.DiaChiGH = this.txtDiaChiGH.Text;
            if(hd.DiaChiGH.Equals(""))
            {
                MessageBox.Show("Địa chỉ giao hàng không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
                
            if (hd.HoaDon.TongTien < (hd.HoaDon.TienDaTT))
            {
                MessageBox.Show("Số tiền trả không được lớn hơn tổng tiền", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (hd.KhachHang.TenKhachHang.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            XElement xlmData;
            this.ConvertDataToXML(out xlmData);
            if (Assist.gHoaDonBan == null)
            {
                if (xlmData != null)
                {
                    // Kiểm tra xem sp đó có phải sp khuyến mãi không
                    if (this.rdbDSKhuyenMai.Checked && gridSpMua.RowCount != 0)
                    {
                       
                        //ct.SoLuong = 
                        for (int j = 0; j < this.gridSpMua.RowCount; j++)
                        {
                            CTKHuyenMai ct = new CTKHuyenMai();
                            ct.KhuyenMai.MaKhuyenMai = this.maKhuyenMai;
                            ct.MatHang.MaMatHang = gridSpMua.GetRowCellValue(j, "Mã sản phẩm").ToString();
                            ct.SoLuong += Convert.ToInt32(gridSpMua.GetRowCellValue(j, "Số lượng"));
                            bool result = (new KhuyenMaiBLT()).CapNhatCTSoLuongKhuyenMai(ct);
                        }
                       
                    }
                    if (new HoaDonBanBLT().ThemhoaDon(hd, xlmData))
                    {
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        this.LoadData();

                        
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (xlmData != null)
                {
                    if (new HoaDonBanBLT().CapNhathoaDon(hd, xlmData))
                    {
                        MessageBox.Show("Cập nhật hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật đơn thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            
        }
     
        private void sbThem_Click(object sender, EventArgs e)
        {

            if (!txtSoLuong.Text.Equals(""))
            {
              this.soLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            else
                this.soLuong = 0;

            Decimal sluong = Convert.ToDecimal(this.gridViewSp.GetRowCellValue(this.gridViewSp.FocusedRowHandle, "Số lượng").ToString());

            if (sluong < this.soLuong)
            {
                MessageBox.Show("Số lượng sản phẩm qúa lớn!", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }

            int numRows = gridSpMua.RowCount;
            bool isAddExistRow = false;
            int index = 0;
            int slTemp = 0;
            for (int j = 0; j < numRows; j++)
            {
                String mspTemp = gridSpMua.GetRowCellValue(j, "Mã sản phẩm").ToString();
                slTemp = Convert.ToInt32(gridSpMua.GetRowCellValue(j, "Số lượng"));
                if (!maSP.Equals(mspTemp))
                {
                    
                    isAddExistRow = false;
                }
                else
                {                  
                    isAddExistRow = true;
                    index = j;
                    break;                 
                }
             
            }

            if (isAddExistRow)
            {
                gridSpMua.SetRowCellValue(index, "Số lượng", this.soLuong);
                gridSpMua.SetRowCellValue(index, "Giá bán", (this.soLuong) * this.tienSP);
            } 
            else
            {
                this.addRow();
            }
            
            if (gridSpMua.RowCount == 0)
            {
                this.addRow();
            }
            // tính tổng lại số tiền cần trả
            Decimal tongTemp = 0;
            for (int j = 0; j < this.gridSpMua.RowCount; j++)
            {
                tongTemp += Convert.ToDecimal(gridSpMua.GetRowCellValue(j, "Giá bán"));
            }
            this.teTongTien.Text = (tongTemp + this.tienLephi).ToString();
            this.teTienDTT.Text = this.teTongTien.Text;
            this.tienTongSp = Convert.ToDecimal(this.teTongTien.Text);
        }

        private void gridViewSp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gridViewSp.RowCount != 0)
            {
                this.maSP = gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Mã sản phẩm").ToString();
                this.tenSP = gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Tên sản phẩm").ToString();
                this.soLuong = Convert.ToInt32(gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Số lượng"));
                this.tienSP = Convert.ToDecimal(gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Giá bán"));
            }
        }

        private void addRow()
        {
            DataTable dt = gridSanPhamMua.DataSource as DataTable;      
            DataRow newRow = dt.NewRow();
            newRow.BeginEdit();
            newRow["Mã sản phẩm"] = this.maSP;
            newRow["Tên sản phẩm"] = this.tenSP;
            newRow["Số lượng"] = this.soLuong;
            newRow["Giá bán"] = this.soLuong * this.tienSP;
            newRow.EndEdit();
            dt.Rows.Add(newRow);
            gridSanPhamMua.DataSource = dt;
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            gridSpMua.DeleteRow(gridSpMua.FocusedRowHandle);
        }

        private void teTienDTT_TextChanged(object sender, EventArgs e)
        {
            Decimal t = this.teTongTien.Text == "" ? Decimal.Zero : Convert.ToDecimal(this.teTongTien.Text);
            Decimal tr = this.teTienDTT.Text == "" ? Decimal.Zero : Convert.ToDecimal(this.teTienDTT.Text);
            Decimal cl = this.teTienConLai.Text == "" ? Decimal.Zero : Convert.ToDecimal(this.teTienConLai.Text);
            if ((t - tr) >= 0)
            {
                cl = t - tr;
                this.teTienConLai.Text = cl.ToString();
            }
            else
            {
                this.teTienDTT.Text = t.ToString();
            }
        }

        private void LoadData()
        {           
            
            //load danh sách san phẩm                        
            if(rdbDSKhuyenMai.Checked)
            {
                CTKHuyenMai ctKhuyenMai = new CTKHuyenMai();
                ctKhuyenMai.KhuyenMai.ThoiGianKT = DateTime.Now.ToString("dd/MM/yyyy");
                this.girdSanPham.DataSource = (new KhuyenMaiBLT().TimKiemChiTietCTKhuyenMai(ctKhuyenMai));

                DataTable dtx = this.girdSanPham.DataSource as DataTable;
                int indexRowForcus = gridViewSp.FocusedRowHandle;
                this.maKhuyenMai = dtx.Rows[indexRowForcus].Field<String>("Mã Khuyến mãi");
            }
            else
                this.girdSanPham.DataSource = (new MatHangBLT().LayDanhSachMatHangBan());   

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã sản phẩm"));
            dt.Columns.Add(new DataColumn("Tên sản phẩm"));
            dt.Columns.Add(new DataColumn("Số lượng"));
            dt.Columns.Add(new DataColumn("Giá bán"));

            this.gridSanPhamMua.DataSource = (dt);

            this.teTenNhanVien.Text = Assist.nhanVien.TenNhanVien;
            this.teMaNhanVien.Text = Assist.nhanVien.MaNhanVien;

            this.deThoiGianLap.DateTime = DateTime.Now;       
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            this.deThoiGianLap.DateTime = DateTime.Now;
            this.teTenNhanVien.Text = Assist.nhanVien.TenNhanVien;
            this.teMaNhanVien.Text = Assist.nhanVien.MaNhanVien;
            //Xóa dữ liệu bảng hàng hóa đã chọn mua
            DataTable dt = this.gridSanPhamMua.DataSource as DataTable;
            dt.Clear();
            this.gridSanPhamMua.DataSource = dt;

        }

        private void rdbDsSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbDsSanPham.Checked == true)
            {
                this.girdSanPham.DataSource = (new MatHangBLT().LayDanhSachMatHangBan());
            }
            else
            {
                CTKHuyenMai ctKhuyenMai = new CTKHuyenMai();
                ctKhuyenMai.KhuyenMai.ThoiGianKT = DateTime.Now.ToString("dd/MM/yyyy");
                this.girdSanPham.DataSource = (new KhuyenMaiBLT().TimKiemChiTietCTKhuyenMai(ctKhuyenMai));
       
                DataTable dtx = this.girdSanPham.DataSource as DataTable;
                if (dtx.Rows.Count != 0)
                {
                    int indexRowForcus = 0;
                    this.maKhuyenMai = dtx.Rows[indexRowForcus].Field<String>("Mã Khuyến mãi");
                }
            }
        }

        private void lueKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lueKhachHang.GetColumnValue("Tên khách hàng") != null)
              this.teTenKhachHang.Text = this.lueKhachHang.GetColumnValue("Tên khách hàng").ToString();
        }

        private void lueKhuVu_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView lephi = (DataRowView)this.lueKhuVu.GetSelectedDataRow();
             Decimal x = new Decimal();
            if( lephi == null)
                x = 0;
            else
                x = Convert.ToDecimal(lephi[2].ToString());
            this.tienLephi = x;
            x += this.tienTongSp;
            this.teTongTien.Text = x.ToString();
            this.teTienDTT.Text = this.teTongTien.Text;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.sbLamMoi_Click(null, null);
            this.lueKhuVu.EditValue = "";
            this.lueKhachHang.EditValue = "";
            this.lueTrangThai.EditValue = "";
            this.teTenKhachHang.Text = "";
            this.teTienConLai.Text = "";
            this.teTongTien.Text = "";
            this.teTienDTT.Text = "";
            this.dateGiaoHang.Text = "";
            this.txtDiaChiGH.Text = "";
            this.tienTongSp = 0;
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
