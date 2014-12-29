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
using System.IO;
using System.Data.SqlClient;
using BusinessLogicTier;
using DataTransferObject;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemHinhVaoDataBase : DevExpress.XtraEditors.XtraUserControl
    {HinhAnhBLT _HinhAnhBLT;
        public ucThemHinhVaoDataBase()
        {
            InitializeComponent();
            _HinhAnhBLT = new HinhAnhBLT();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HinhAnh hinhanh = new HinhAnh();
            hinhanh.MaSanPham = "MH0000000000001";
            hinhanh.NoiDungHinhAnh = ImageToBase64(peHinhAnh.Image,
                      System.Drawing.Imaging.ImageFormat.Png);
            if (_HinhAnhBLT.ThemHinhAnh(hinhanh))
                MessageBox.Show("them thanh cong");
            else
                MessageBox.Show("them that bai");

            //lay data moi nhat de them vao hinh
            DataTable dt = _HinhAnhBLT.LayHinhAnhMoiNhat();
            if (dt != null && dt.Rows.Count > 0)
            {
                peTestResult.Image = Base64ToImage(dt.Rows[0].ItemArray[2].ToString());
                peTestResult.Invalidate();
            }
        }

        public string ImageToBase64(Image image,
          System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
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

        private void peHinhAnh_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn Hình";
            openFileDialog1.FileName = "hinhanh.png";
            openFileDialog1.Filter = "Hình Ảnh (*.PNG;)|*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                this.peHinhAnh.Image = img;
            }
        }

    }
}
