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
using DevExpress.XtraEditors.Controls;


namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucDanhSachSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private MatHangBLT matHangBLT;
        private MatHang matHang;
       // private Boolean check = false;

        public ucDanhSachSanPham()
        {
            InitializeComponent();
            this.matHangBLT = new MatHangBLT();
            LoadData();

            //Max length of type text
            this.teTenSanPham.Properties.MaxLength = 15;
            //this.teSoSim.Properties.MaxLength = 100;
            this.teKichThuoc.Properties.MaxLength = 2;
            this.teHeDieuHanh.Properties.MaxLength = 50;

            this.tePIN.Properties.MaxLength = 5;
            this.teSoSim.Properties.MaxLength = 2;
            this.teRAM.Properties.MaxLength = 5;
            this.teBoNho.Properties.MaxLength = 5;

            // Only type number
            this.teKichThuoc.Properties.Mask.EditMask = "n0";
            this.teKichThuoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.tePIN.Properties.Mask.EditMask = "n0";
            this.tePIN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teSoSim.Properties.Mask.EditMask = "n0";
            this.teSoSim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teRAM.Properties.Mask.EditMask = "n0";
            this.teRAM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teBoNho.Properties.Mask.EditMask = "n0";
            this.teBoNho.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }

        private void LoadData()
        {
            DataTable data = new DataTable();
            data = this.matHangBLT.LayDanhSachMatHang();
            this.GridMatHang.DataSource = data;//Add data 


            //ConboBox LoaiMatHang
            DataTable table = (new LoaiMatHangBLT().LoadComBoBox());
            this.lueLoaiSanPham.Properties.DataSource = table;
            this.lueLoaiSanPham.Properties.DisplayMember = "TenLoaiMatHang";
            this.lueLoaiSanPham.Properties.ValueMember = "MaLoaiMatHang";
            this.lueLoaiSanPham.Properties.NullText = "Please Select Item";
            this.lueLoaiSanPham.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenLoaiMatHang" });

            //ComboBox NhaSanXuat
            DataTable table1 = (new NhaSanXuatBLT().LoadComBoBox());
            this.lueNhaSX.Properties.DataSource = table1;
            this.lueNhaSX.Properties.DisplayMember = "TenNSX";
            this.lueNhaSX.Properties.ValueMember = "MaNSX";
            this.lueNhaSX.Properties.NullText = "Please Select Item";
            this.lueNhaSX.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenNSX" });

            //ComboBox CPU
            DataTable table2 = (new CPUBLT().LoadComBoBox());
            this.lueCPU.Properties.DataSource = table2;
            this.lueCPU.Properties.DisplayMember = "TenCPU";
            this.lueCPU.Properties.ValueMember = "MaCPU";
            this.lueCPU.Properties.NullText = "Please Select Item";
            this.lueCPU.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenCPU" });

            //ComboBox CPU
            DataTable table3 = (new MauSacBLT().LoadComBoBox());
            this.lueMauSac.Properties.DataSource = table3;
            this.lueMauSac.Properties.DisplayMember = "TenMau";
            this.lueMauSac.Properties.ValueMember = "MaMau";
            this.lueMauSac.Properties.NullText = "Please Select Item";
            this.lueMauSac.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenMau" });
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            String Name = "Thêm Sản Phẩm";
            Assist.gMatHang = null;
            if (!Assist.isTabExist(Name))
            {
                Assist.addNewTab(new ucThemSanPham(), Name);
            }
        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {

        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            matHang = new MatHang();

            matHang.MaMatHang = this.teMaSanPham.Text;
            matHang.TenMatHang = this.teTenSanPham.Text;

            matHang.MaLoaiMatHang = this.lueLoaiSanPham.EditValue == null ? "" : this.lueLoaiSanPham.EditValue.ToString();
            matHang.MaNhaSanXuat = this.lueNhaSX.EditValue == null ? "" : this.lueNhaSX.EditValue.ToString();

            int kichthuoc = 0;
            int pin = 0;
            int soSim = 0;
            int ram = 0;
            int boNho = 0;
            string maCPU = null;

            maCPU = this.lueCPU.EditValue == null ? "" : this.lueCPU.EditValue.ToString();

            if (!this.teKichThuoc.Text.Equals(""))
            {
                kichthuoc = Convert.ToInt32(this.teKichThuoc.Text);
            }

            string hedieuHanh = this.teHeDieuHanh.Text;
            string mauSac = this.lueMauSac.EditValue == null ? "" : this.lueMauSac.EditValue.ToString();

            if (!this.tePIN.Text.Equals(""))
            {
                pin = Convert.ToInt32(this.tePIN.Text);
            }
            if (!this.teSoSim.Text.Equals(""))
            {
                soSim = Convert.ToInt32(this.teSoSim.Text);
            }
            if (!this.teRAM.Text.Equals(""))
            {
                ram = Convert.ToInt32(this.teRAM.Text);
            }
            if (!this.teBoNho.Text.Equals(""))
            {
                boNho = Convert.ToInt32(this.teBoNho.Text);
            }

            DataTable data = new DataTable();

            data = this.matHangBLT.TimKiemMatHang(matHang, kichthuoc, hedieuHanh,
                mauSac, pin, soSim, ram, boNho, maCPU);

           // check = true;

            gridView1.FocusedRowHandle = 0;
            this.GridMatHang.DataSource = data;
            
        }

        private void sbChinhSua_Click(object sender, EventArgs e)
        {
            String Name = "Chỉnh Sửa Sản Phẩm";
            if (!Assist.isTabExist(Name))
            {
                Assist.addNewTab(new ucThemSanPham(), Name);
            }

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Assist.gMatHang = new MatHang();

            if (gridView1.RowCount != 0)//Get data
            {
                Assist.gMatHang.MaMatHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã mặt hàng").ToString();
                Assist.gMatHang.TenMatHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên mặt hàng").ToString();
                Assist.gMatHang.MaLoaiMatHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Loại mặt hàng").ToString();
                Assist.gMatHang.MaNhaSanXuat = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nhà sản xuất").ToString();
                Assist.gMatHang.SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số lượng").ToString());
                Assist.gMatHang.ThoiGianBaoHanh = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời gian bảo hành").ToString());
                Assist.gMatHang.MoTa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mô tả").ToString();
                Assist.gMatHang.GhiChu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();

            }

           /* if (check)
            {
                if (gridView1.RowCount != 0)//Get data
                {
                    MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã mặt hàng").ToString());
                    MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên mặt hàng").ToString());
                    MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Loại mặt hàng").ToString());
                    MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nhà sản xuất").ToString());
                    MessageBox.Show(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số lượng").ToString()) + "");
                    MessageBox.Show(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời gian bảo hành").ToString()) + "");
                    MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mô tả").ToString());
                    MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString());
                }
            }*/
        }


    }
}
