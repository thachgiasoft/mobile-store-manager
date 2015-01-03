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
    public partial class ucThemPhieuBaoHanh : DevExpress.XtraEditors.XtraUserControl
    {
        private HoaDonBaoHanhBLT hoaDonBaoHanhBLT;
        private String maHD = "";

        //Product Information
        private String maSP = "";
        private String tenSP = "";
        private int soLuong = 0;
        private Decimal tienSP = 0;
        private Decimal tienLephi = 0;
        private Decimal tienTongSp = 0;
        private String maKhuyenMai = "";
        public ucThemPhieuBaoHanh()
        {
            InitializeComponent();

            this.hoaDonBaoHanhBLT = new HoaDonBaoHanhBLT();
            // Lấy danh sách khách hàng
            //this.teMaKhachHang.Properties.DataSource = (new HoaDonBaoHanhBLT().LayDanhSachKhachHang());
            // this.lueKhachHang.Properties.Columns.Add(new LookUpColumnInfo(this.lueKhachHang.Properties.DisplayMember));
            ////Lấy ds trạng thái.
            this.leTrangThai.Properties.DataSource = (new HoaDonBaoHanhBLT().LayDanhSachTrangThai());
            this.leTrangThai.Properties.Columns.Add(new LookUpColumnInfo(this.leTrangThai.Properties.DisplayMember));

            this.LoadData();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            HoaDonBaoHanh hd = new HoaDonBaoHanh();
            hd.HoaDon.MaHoaDon = this.teMaHDBaoHanh.Text;
            hd.HoaDonBan.HoaDon.MaHoaDon = this.teMaHoaDon.Text;

            hd.KhachHang.MaKhachHang = this.teMaKhachHang.EditValue == null ? "" : this.teMaKhachHang.EditValue.ToString();
            hd.HoaDon.TrangThai.MaTrangThai = this.leTrangThai.EditValue == null ? "" : this.leTrangThai.EditValue.ToString();



            hd.KhachHang.TenKhachHang = this.teTenKhachHang.Text;
            hd.HoaDon.NhanVien.TenNhanVien = this.teTenNhanVien.Text;
            hd.HoaDon.NhanVien.MaNhanVien = this.teMaNhanVien.Text;
            hd.HoaDon.NgayLap = this.deThoiGianLap.DateTime.ToString("dd/MM/yyyy");
            hd.HoaDon.GhiChu = this.meGhiChu.Text;

            if (hd.KhachHang.TenKhachHang.Equals(""))
            {
                MessageBox.Show("Tên Khách hàng không được bỏ trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (this.gridSpBH.RowCount == 0)
            {
                MessageBox.Show("Danh sách sản phẩm bảo hành không được để trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            if (hd.KhachHang.TenKhachHang.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            XElement xlmData;
            this.ConvertDataToXML(out xlmData);
            if (Assist.gHoaDonBaoHanh == null)
            {
                if (xlmData != null)
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.LoadData();
                    /*
                    if (new HoaDonBaoHanhBLT().ThemHoaDonBaoHanh(hd, xlmData))
                    {
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK);
                    }*/
                }
            }
            else
            {
                if (xlmData != null)
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.LoadData();
                    /*  if (new HoaDonBaoHanhBLT().CapNhatHoaDonBaoHanh(hd, xlmData))
                    {
                        MessageBox.Show("Cập nhật hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật đơn thất bại", "Thông báo", MessageBoxButtons.OK);
                    }*/
                }
            }
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã sản phẩm"));
            dt.Columns.Add(new DataColumn("Tên sản phẩm"));
            dt.Columns.Add(new DataColumn("Số lượng"));
            this.gridSanPhamBH.DataSource = (dt);

           
            this.deThoiGianLap.DateTime = DateTime.Now;
        }

        private void ConvertDataToXML(out XElement XML)
        {
            List<HoaDonBaoHanh> lstHoaDonBaoHanh = new List<HoaDonBaoHanh>();

            XML = new XElement(new XElement("Root"));
            for (int i = 0; i < gridSpBH.RowCount; i++)
            {
                HoaDonBaoHanh temp = new HoaDonBaoHanh();
                temp.CtHoaDonBH.MatHang.MaMatHang = gridSpBH.GetRowCellValue(i, "Mã sản phẩm").ToString();
                temp.CtHoaDonBH.MatHang.TenMatHang = gridSpBH.GetRowCellValue(i, "Tên sản phẩm").ToString();
                temp.CtHoaDonBH.SoLuong = Convert.ToInt32(gridSpBH.GetRowCellValue(i, "Số lượng"));

                lstHoaDonBaoHanh.Add(temp);
            }

            foreach (HoaDonBaoHanh item in lstHoaDonBaoHanh)
            {
                XElement xml = new XElement("XmlData",
                    new XElement("MaCTHoaDonBaoHanh", item.CtHoaDonBH.MaCTHoaDonBaoHanh == null ? "" : item.CtHoaDonBH.MaCTHoaDonBaoHanh),
                    new XElement("MaMatHang", item.CtHoaDonBH.MatHang.MaMatHang == null ? "" : item.CtHoaDonBH.MatHang.MaMatHang),
                    new XElement("TenMatHang", item.CtHoaDonBH.MatHang.TenMatHang == null ? "" : item.CtHoaDonBH.MatHang.TenMatHang),
                    new XElement("SoLuong", item.CtHoaDonBH.SoLuong == null ? Decimal.Zero : item.CtHoaDonBH.SoLuong)
                    );
                XML.Add(xml);
            }
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {
            if (Assist.gHoaDonBaoHanh != null)
            {
                this.maHD = Assist.gHoaDonBaoHanh.HoaDon.MaHoaDon;
                this.teMaHDBaoHanh.Text = this.maHD;
                this.teMaHoaDon.Text = Assist.gHoaDonBaoHanh.HoaDonBan.HoaDon.MaHoaDon;
                this.deThoiGianLap.Text = Assist.gHoaDonBaoHanh.HoaDon.NgayLap;
                this.teMaKhachHang.Text = Assist.gHoaDonBaoHanh.KhachHang.MaKhachHang;
                this.leTrangThai.Text = Assist.gHoaDonBaoHanh.HoaDon.TrangThai.TenTrangThai;
                this.teTenKhachHang.Text = Assist.gHoaDonBaoHanh.KhachHang.TenKhachHang;
                this.teMaNhanVien.Text = Assist.gHoaDonBaoHanh.HoaDon.NhanVien.MaNhanVien;
                this.teTenNhanVien.Text = Assist.gHoaDonBaoHanh.HoaDon.NhanVien.TenNhanVien;
                this.meGhiChu.Text = Assist.gHoaDonBaoHanh.HoaDon.GhiChu;

                //HoaDonBaoHanh hd = new HoaDonBaoHanh();
                //hd.HoaDon.MaHoaDon = this.maHD;
                this.gridSanPham.DataSource = (new HoaDonBanBLT().TimKiemCThoaDon(Assist.gHoaDonBaoHanh.HoaDonBan));

                this.gridSanPhamBH.DataSource = (new HoaDonBaoHanhBLT().TimKiemCTHoaDonBaoHanh(Assist.gHoaDonBaoHanh));

            }
            else
            {
                this.sbLamMoi_Click(null, null);
            }
        }

        private void sbLm_Click(object sender, EventArgs e)
        {
            teMaHoaDon.Text = "";
            deThoiGianLap.Text = "";
            teMaNhanVien.Text = "";
            teTenNhanVien.Text = "";
            teMaKhachHang.Text = "";
            teTenKhachHang.Text = "";
            leTrangThai.Text = "";
            meGhiChu.Text = "";
            teSoLuong.Text = "";
        }

        private void gridViewSp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.maSP = gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Mã sản phẩm").ToString();
            this.tenSP = gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Tên sản phẩm").ToString();
            this.soLuong = Convert.ToInt32(gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Số lượng"));
        }

        //private void leMaKhachHang_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (this.leMaKhachHang.GetColumnValue("Tên khách hàng") != null)
        //        this.teTenKhachHang.Text = this.leMaKhachHang.GetColumnValue("Tên khách hàng").ToString();
        //}

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            this.deThoiGianLap.DateTime = DateTime.Now;
            this.teTenNhanVien.Text = "Phạm Thị Tâm ";
            this.teMaNhanVien.Text = "NV0000000000005";
            //Xóa dữ liệu bảng hàng hóa đã chọn mua
            //DataTable dt = this.gridSanPhamBH.DataSource as DataTable;
            //dt.Clear();
            //this.gridSanPhamBH.DataSource = dt;
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            gridSpBH.DeleteRow(gridSpBH.FocusedRowHandle);
        }

        

        private void sbThem_Click(object sender, EventArgs e)
        {
            DataTable dtasd =gridSanPham.DataSource as DataTable;
            if (dtasd != null && dtasd.Rows.Count > 0)
            {
                if (!teSoLuong.Text.Equals(""))
                {
                    this.soLuong = Convert.ToInt32(teSoLuong.Text);
                }
                else
                    this.soLuong = 0;

                Decimal sluong = Convert.ToDecimal(this.gridViewSp.GetRowCellValue(this.gridViewSp.FocusedRowHandle, "Số lượng").ToString());

                if (sluong < this.soLuong)
                {
                    MessageBox.Show("Số lượng sản phẩm được bảo hành phải nhỏ hơn số sản phẩm đã mua!", "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }

                int numRows = gridSpBH.RowCount;
                bool isAddExistRow = false;
                int index = 0;
                int slTemp = 0;
                for (int j = 0; j < numRows; j++)
                {
                    String mspTemp = gridSpBH.GetRowCellValue(j, "Mã sản phẩm").ToString();
                    slTemp = Convert.ToInt32(gridSpBH.GetRowCellValue(j, "Số lượng"));
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
                    gridSpBH.SetRowCellValue(index, "Số lượng", this.soLuong);
                }
                else
                {
                    this.addRow();
                }

                if (gridSpBH.RowCount == 0)
                {
                    this.addRow();
                }
            }
            else
            {
                MessageBox.Show("Danh Sách sản phẩm trống nên không thêm được");
            }
        }

        private void addRow()
        {
            DataTable dt = gridSanPhamBH.DataSource as DataTable;
            DataRow newRow = dt.NewRow();
            newRow.BeginEdit();
            newRow["Mã sản phẩm"] = this.maSP;
            newRow["Tên sản phẩm"] = this.tenSP;
            newRow["Số lượng"] = this.soLuong;
            newRow.EndEdit();
            dt.Rows.Add(newRow);
            gridSanPhamBH.DataSource = dt;
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            this.maHD = teMaHoaDon.Text;
            if (this.maHD == "")
            {
                MessageBox.Show("Điền thông tin mã hóa đơn!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                HoaDonBaoHanh hd = new HoaDonBaoHanh();
                hd.HoaDonBan.HoaDon.MaHoaDon = this.maHD;
                DataTable data = new DataTable();
                data = (new HoaDonBanBLT().TimKiemCThoaDonBH(hd.HoaDonBan));
                // nó ddang fix lai, roi vay skip qua giao diện khác
                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("Sai mã mã hóa đơn bán. Vui lòng nhâp lại!", "Thông báo", MessageBoxButtons.OKCancel);
                }
                else
                {
                    this.gridSanPham.DataSource = data;
                    teMaHoaDon.Text = this.gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Mã hóa đơn bán").ToString();
                    teMaKhachHang.Text = this.gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Mã khách hàng").ToString();
                    teTenKhachHang.Text = this.gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Tên khách hàng").ToString();
                }
                
            }
            
        }

        private void teSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (teSoLuong.Text == "")
                teSoLuong.Text = "0";
            if (Convert.ToDecimal(teSoLuong.Text) < 0)
                teSoLuong.Text = "0";
        }
    }
}
