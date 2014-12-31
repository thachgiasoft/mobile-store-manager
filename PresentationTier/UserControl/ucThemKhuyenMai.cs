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
using System.Xml.Linq;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemKhuyenMai : DevExpress.XtraEditors.XtraUserControl
    {
        private String maKM = "";

        //thông tin sản phẩm.
        private String maSP = "";
        private String tenSP = "";
        private int soLuong = 0;
        private Decimal tienSP = 0;
        public ucThemKhuyenMai()
        {
            InitializeComponent();
            this.LoadData();

        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.TenChuongTrinh = this.menoETenChuongTrinhKhuyenMai.Text;
            km.ThoiGianDB = this.dateBatDau.DateTime.ToString("dd/MM/yyyy");
            km.ThoiGianKT = this.dateKetThuc.DateTime.ToString("dd/MM/yyyy");
            km.GhiChu = this.txtGhiChu.Text;
            if (km.TenChuongTrinh.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên chương trình khuyến mãi", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // kiểm tra ngày bắt đầu và ngày kết thúc
            if (DateTime.Compare(this.dateBatDau.DateTime, DateTime.Now) < 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại ngày bắt đầu \n Ngày bắt đầu không được nhỏ hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (DateTime.Compare(this.dateBatDau.DateTime, this.dateKetThuc.DateTime) > 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại ngày bắt đầu và ngày kết thúc \n Ngày bắt đầu không được nhỏ hơn ngày kết thúc.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (km.TenChuongTrinh.Equals("") && km.ThoiGianDB.Equals("") && km.ThoiGianKT.Equals(""))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu \n Dữ liệu không được để trống.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //kiêm tra bên girdSpMua có sp nào chưa.
            if (this.gridSpMua.RowCount == 0)
            {
                MessageBox.Show("Danh sách sản phẩm khuyến mãi không được để trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            XElement xlmData;
            this.ConvertDataToXML(out xlmData);
            if (Assist.gKhuyenMai == null)
            {
                if (xlmData != null)
                {
                    if (new KhuyenMaiBLT().ThemCTKhuyenMai(km, xlmData))
                    {
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);                       
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
                    km.MaKhuyenMai = this.maKM;
                    if (new KhuyenMaiBLT().CapNhatCTKhuyenMai(km, xlmData))
                    {
                        MessageBox.Show("Cập nhật chương trình khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chương trình khuyến mãi thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ConvertDataToXML(out XElement XML)
        {
            List<CTKHuyenMai> lstKhuyenMai = new List<CTKHuyenMai>();

            XML = new XElement(new XElement("Root"));
            for (int i = 0; i < gridSpMua.RowCount; i++)
            {
                CTKHuyenMai temp = new CTKHuyenMai();
                
                temp.MatHang.MaMatHang = gridSpMua.GetRowCellValue(i, "Mã sản phẩm").ToString();
                temp.SoLuong = Convert.ToInt32(gridSpMua.GetRowCellValue(i, "Số lượng"));
                temp.GiaKhuyenMai = Convert.ToDecimal(gridSpMua.GetRowCellValue(i, "Giá bán"));

                lstKhuyenMai.Add(temp);
            }

            foreach (CTKHuyenMai item in lstKhuyenMai)
            {
                XElement xml = new XElement("XmlData",
                    new XElement("MaCTKhuyenMai", item.MaCTKhuyenMai == null ? "" : item.MaCTKhuyenMai),
                    new XElement("MaMatHang", item.MatHang.MaMatHang == null ? "" : item.MatHang.MaMatHang),
                    new XElement("SoLuong", item.SoLuong == null ? 0 : item.SoLuong),
                    new XElement("GiaKhuyenMai", item.GiaKhuyenMai == 0 ? 0 : item.GiaKhuyenMai)
                    );
                XML.Add(xml);
            }
        }

        private void ucThemKhuyenMai_Enter(object sender, EventArgs e)
        {
            if (Assist.gKhuyenMai != null)
            {
                this.maKM = Assist.gKhuyenMai.MaKhuyenMai;
                this.menoETenChuongTrinhKhuyenMai.Text = Assist.gKhuyenMai.TenChuongTrinh;
                this.dateBatDau.Text = Assist.gKhuyenMai.ThoiGianDB;
                this.dateKetThuc.Text = Assist.gKhuyenMai.ThoiGianKT;
                this.txtGhiChu.Text = Assist.gKhuyenMai.GhiChu;

                KhuyenMai km = new KhuyenMai();
                km.MaKhuyenMai = this.maKM;
               /// gridSanPhamKM.DataSource = (new KhuyenMaiBLT().TimKiemChiTietCTKhuyenMai(km));
            }
            else
            {
                this.maKM = "";
                this.menoETenChuongTrinhKhuyenMai.Text = "";
                this.dateBatDau.Text = "";
                this.dateKetThuc.Text = "";
                this.txtGhiChu.Text = "";

                //Xóa dữ liệu bảng hàng hóa đã chọn mua
                //DataTable dt = this.gridSanPhamKM.DataSource as DataTable;
                //dt.Clear();
                //this.gridSanPhamKM.DataSource = dt;
            }
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            if (this.maSP.Equals(""))
                return;

            if (!txtSoLuong.Text.Equals(""))
            {
                this.soLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            else
                this.soLuong = 1;
         
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
                    if (sluong < this.soLuong)
                    {
                        MessageBox.Show("Số lượng sản phẩm qúa lớn!", "Thông báo lỗi", MessageBoxButtons.OK);
                        return;
                    }
                    isAddExistRow = true;
                    index = j;
                    break;
                }

            }

            //Tính % tiền để gửi
            Decimal phanTram = this.teGiaKhuyenMai.Text == "" ? 0 : Convert.ToDecimal(this.teGiaKhuyenMai.Text);
            if (phanTram == 100)
                phanTram = this.tienSP;
            else
            {
                phanTram = phanTram / 100;
                phanTram = phanTram * this.tienSP;
            }

            
            if (isAddExistRow)
            {                                     
                gridSpMua.SetRowCellValue(index, "Số lượng", this.soLuong);
                Decimal x = new Decimal(3);
                x = this.tienSP - phanTram;
                gridSpMua.SetRowCellValue(index, "Giá bán", Math.Round(x, 3));   
            }
            else
            {
                this.addRow(phanTram);
            }

            if (gridSpMua.RowCount == 0)
            {
                this.addRow(phanTram);
            }         
        }

        private void addRow(Decimal phanTram)
        {        
            DataTable dt = gridSanPhamKM.DataSource as DataTable;
            DataRow newRow = dt.NewRow();
            newRow.BeginEdit();
            newRow["Mã sản phẩm"] = this.maSP;
            newRow["Tên sản phẩm"] = this.tenSP;
            newRow["Số lượng"] = this.soLuong;
            Decimal x = new Decimal(3);
            x = this.tienSP - phanTram;
            newRow["Giá bán"] = Math.Round(x,3); ////////////////thêm % khuyến mãi
            newRow.EndEdit();
            dt.Rows.Add(newRow);
            gridSanPhamKM.DataSource = dt;
        }


        private void sbXoa_Click(object sender, EventArgs e)
        {
            gridSpMua.DeleteRow(gridSpMua.FocusedRowHandle);
        }

        private void LoadData()
        {
            this.teTenNhanVien.Text = Assist.nhanVien.TenNhanVien;
            this.teMaNhanVien.Text = Assist.nhanVien.MaNhanVien;

            //load danh sách san phẩm
            this.girdSanPham.DataSource = (new MatHangBLT().LayDanhSachMatHangBan());

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã sản phẩm"));
            dt.Columns.Add(new DataColumn("Tên sản phẩm"));
            dt.Columns.Add(new DataColumn("Số lượng"));
            dt.Columns.Add(new DataColumn("Giá bán"));
            this.gridSanPhamKM.DataSource = (dt);

            this.dateBatDau.DateTime = DateTime.Now;
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            this.menoETenChuongTrinhKhuyenMai.Text = "";
            this.dateBatDau.Text = "";
            this.dateKetThuc.Text = "";
            this.txtSoLuong.Text = "";
            DataTable dt = this.gridSanPhamKM.DataSource as DataTable;
            dt.Clear();

            this.gridSanPhamKM.DataSource = dt;
        }

        private void girdSanPham_Click(object sender, EventArgs e)
        {
            this.maSP = this.gridViewSp.GetRowCellValue(this.gridViewSp.FocusedRowHandle, "Mã sản phẩm").ToString();
            this.tenSP = this.gridViewSp.GetRowCellValue(this.gridViewSp.FocusedRowHandle, "Tên sản phẩm").ToString();
            this.tienSP = Convert.ToDecimal(this.gridViewSp.GetRowCellValue(this.gridViewSp.FocusedRowHandle, "Giá bán").ToString());
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {
            this.teTenNhanVien.Text = Assist.nhanVien.TenNhanVien;
            this.teMaNhanVien.Text = Assist.nhanVien.MaNhanVien;
            if (Assist.gKhuyenMai != null)
            {
               
                this.maKM = Assist.gKhuyenMai.MaKhuyenMai;
                this.menoETenChuongTrinhKhuyenMai.Text = Assist.gKhuyenMai.TenChuongTrinh;
                this.dateBatDau.Text = Assist.gKhuyenMai.ThoiGianDB;
                this.dateKetThuc.Text = Assist.gKhuyenMai.ThoiGianKT;
                this.txtSoLuong.Text = "";

                CTKHuyenMai ctKM = new CTKHuyenMai();
                ctKM.KhuyenMai.MaKhuyenMai = Assist.gKhuyenMai.MaKhuyenMai;
                this.gridSanPhamKM.DataSource = (new KhuyenMaiBLT().TimKiemChiTietCTKhuyenMai(ctKM));

                // nếu khuyến mãi này đã kết thúc thì không cho update
                if (DateTime.Compare(this.dateKetThuc.DateTime, DateTime.Now) < 0)
                {
                    this.sbLuu.Enabled = false;
                }
                else
                    this.sbLuu.Enabled = true;
            }
            else
            {
                this.sbLamMoi_Click(null, null);
            }
        }

        private void beLamMoi_Click(object sender, EventArgs e)
        {
            this.sbLamMoi_Click(null, null);
        }
    }
}
