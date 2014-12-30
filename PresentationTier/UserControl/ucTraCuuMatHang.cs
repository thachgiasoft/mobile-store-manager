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
    public partial class ucTraCuuMatHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ucTraCuuMatHang()
        {
            InitializeComponent();

            //ComboBox NhaSanXuat
            DataTable table1 = (new NhaSanXuatBLT().LoadComBoBox());
            this.lueNhaSX.Properties.DataSource = table1;
            this.lueNhaSX.Properties.DisplayMember = "TenNSX";
            this.lueNhaSX.Properties.ValueMember = "MaNSX";
            this.lueNhaSX.Properties.NullText = "Please Select Item";
            this.lueNhaSX.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenNSX" });

            //ConboBox LoaiMatHang
            DataTable table = (new LoaiMatHangBLT().LoadComBoBox());
            this.lueLoaiSanPham.Properties.DataSource = table;
            this.lueLoaiSanPham.Properties.DisplayMember = "TenLoaiMatHang";
            this.lueLoaiSanPham.Properties.ValueMember = "MaLoaiMatHang";
            this.lueLoaiSanPham.Properties.NullText = "Please Select Item";
            this.lueLoaiSanPham.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenLoaiMatHang" });
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            MatHang matHang = new MatHang();
            matHang.TenMatHang = this.teTenSanPham.Text;

            matHang.MaLoaiMatHang = this.lueLoaiSanPham.EditValue == null ? "" : this.lueLoaiSanPham.EditValue.ToString();
            matHang.MaNhaSanXuat = this.lueNhaSX.EditValue == null ? "" : this.lueNhaSX.EditValue.ToString();

            int kichthuoc = -1;
            int pin = -1;
            int soSim = -1;
            int ram = -1;
            int boNho = -1;
            string maCPU = "";

            DataTable data = new MatHangBLT().TimKiemMatHang(matHang, kichthuoc, "",
                 "", pin, soSim, ram, boNho, maCPU);

            int x = data.Rows.Count;
        }
    }
}
