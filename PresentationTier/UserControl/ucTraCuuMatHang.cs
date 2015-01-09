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
using System.IO;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucTraCuuMatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private MatHangBLT _MatHangBLT;
        private HinhAnhBLT _HinhAnhBLT;
        private CauHinhDienThoaiBLT _CauHinhDienThoaiBLT;
        public ucTraCuuMatHang()
        {
            InitializeComponent();
            _MatHangBLT = new MatHangBLT();
            _HinhAnhBLT = new HinhAnhBLT();
            _CauHinhDienThoaiBLT = new CauHinhDienThoaiBLT();

            //ComboBox NhaSanXuat
            DataTable table1 = (new NhaSanXuatBLT().LoadComBoBox());
            this.lueNhaSX.Properties.DataSource = table1;
            this.lueNhaSX.Properties.DisplayMember = "TenNSX";
            this.lueNhaSX.Properties.ValueMember = "MaNSX";
            this.lueNhaSX.Properties.NullText = "Chọn Nhà Sản Xuất";
            this.lueNhaSX.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenNSX" });

            //ConboBox LoaiMatHang
            DataTable table = (new LoaiMatHangBLT().LoadComBoBox());
            this.lueLoaiSanPham.Properties.DataSource = table;
            this.lueLoaiSanPham.Properties.DisplayMember = "TenLoaiMatHang";
            this.lueLoaiSanPham.Properties.ValueMember = "MaLoaiMatHang";
            this.lueLoaiSanPham.Properties.NullText = "Chọn Loại Mặt Hàng";
            this.lueLoaiSanPham.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenLoaiMatHang" });

            timKiem();
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }

        private void timKiem()
        {
            this.tileGroup1.Items.Clear();
            MatHang matHang = new MatHang();
            matHang.TenMatHang = this.teTenSanPham.Text;

            matHang.MaLoaiMatHang = this.lueLoaiSanPham.EditValue == null ? "" : this.lueLoaiSanPham.EditValue.ToString();
            matHang.MaNhaSanXuat = this.lueNhaSX.EditValue == null ? "" : this.lueNhaSX.EditValue.ToString();

            DataTable data = _MatHangBLT.TimKiemMatHangDonGian(matHang);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DevExpress.XtraEditors.TileItem tileItem1 = new DevExpress.XtraEditors.TileItem();
                DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();

                tileItem1.Id = i;
                tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
                tileItemElement1.TextAlignment = TileItemContentAlignment.TopLeft;
                DataTable dt = _HinhAnhBLT.LayHinhMatHang(data.Rows[i].ItemArray[0].ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    tileItem1.BackgroundImage = Base64ToImage(dt.Rows[0].ItemArray[0].ToString());
                    tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
                }
                else
                {
                    tileItem1.BackgroundImage = Image.FromFile("Resources\\defaultimg.png");
                    tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
                }
                tileItem1.Image = global::QL_Ban_DienThoai.Properties.Resources.blackboard;
                tileItem1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
                tileItem1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;

                CauHinhDienThoai ch = _CauHinhDienThoaiBLT.LayCauHinhByMaMatHang(data.Rows[i].ItemArray[0].ToString());

                tileItemElement1.Text = data.Rows[i].ItemArray[1].ToString() + "\n";
                if (ch != null)
                {
                    tileItemElement1.Text += "Kích thước màn hình: " + ch.KichThuocManHinh + " inch\n";
                    tileItemElement1.Text += "Số Sim: " + ch.SoSim + "\n";
                    tileItemElement1.Text += "Bộ nhớ ram: " + ch.Ram + " MB\n";
                    tileItemElement1.Text += "Hệ điều hành: " + ch.HeDieuHanh + "\n";
                    tileItemElement1.Text += "Bộ nhớ trong: " + ch.BoNho + "MB\n";
                    tileItemElement1.Text += "Dung lượng pin: " + ch.DungLuongPin + " mAh\n";

                    MatHang mh = new MatHang();
                    mh.MaMatHang = data.Rows[i].ItemArray[0].ToString();
                    DataTable dt3 = _MatHangBLT.LayThongTinDonGiaVaNhaSanXuat(mh);
                    decimal giatien = 0;
                    if (dt3 != null&&dt3.Rows.Count >0)
                    {
                        giatien = Convert.ToDecimal(dt3.Rows[0].ItemArray[5].ToString());
                    }
                    tileItemElement1.Text += "Giá: " + giatien.ToString("0.00").Replace(".00", "") +" VNĐ\n";
                }

                tileItem1.Name = tileItemElement1.Text;
                tileItem1.Elements.Add(tileItemElement1);
                this.tileGroup1.Items.Add(tileItem1);
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void teTenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                timKiem();
        }

        private void lueNhaSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                timKiem();
        }

        private void lueLoaiSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                timKiem();
        }
    }
}
