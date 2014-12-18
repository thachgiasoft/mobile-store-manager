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

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucMauSac : DevExpress.XtraEditors.XtraUserControl
    {
        private MauSacBLT mauSacBLT;
        private MauSac mauSac;
        
      
        public ucMauSac()
        {
            InitializeComponent();
            this.mauSacBLT = new MauSacBLT();
            //Lấy ds mau sac
            LoadData();

            //Max length of type text
            this.teTenMau.Properties.MaxLength = 50;
            this.teMaMauSac.Properties.MaxLength = 15;
           
        }

        private void LoadData()
        {
            
            DataTable data = new DataTable();
            data = this.mauSacBLT.LayDanhSachMauSac();
            this.GridMauSac.DataSource = data;//Add data 
        }

        private void sbTimKiemMau_Click(object sender, EventArgs e)
        {
            mauSac = new MauSac();
            mauSac.MaMau = this.teMaMauSac.Text;
            mauSac.TenMau = this.teTenMau.Text;

            DataTable data = new DataTable();
            data = this.mauSacBLT.TimKiemMauSac(mauSac);

            this.GridMauSac.DataSource = data; 
        }

        private void sbThemMauSac_Click(object sender, EventArgs e)
        {
            MauSac ns = new MauSac();

            if (this.teTenMau.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên màu sắc");
                return;
            }
            else
            {
                ns.TenMau = this.teTenMau.Text;

                if (this.mauSacBLT.ThemMauSac(ns) == true)
                {
                    MessageBox.Show("Thêm màu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm màu thất bại", "Thông báo", MessageBoxButtons.OK);
                }

                LoadData();   
            }

            
        }

        private void sbCapNhatMauSac_Click(object sender, EventArgs e)
        {
            mauSac = new MauSac();
            mauSac.MaMau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã màu").ToString();

            if (this.teTenMau.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên màu");
                return;
            }

            else{

                mauSac.TenMau = this.teTenMau.Text;
                String message = "";
                if (mauSacBLT.CapNhatMauSac(mauSac))
                    message += "Cập Nhật thành công";
                else
                    message += "Cập Nhật lỗi! \nVui lòng kiểm tra lại thông tin trước khi Cập Nhật.";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                gridView1.FocusedRowHandle = 0;
                LoadData();
            }
            

          
        }

        private void sbXoaMauSac_Click(object sender, EventArgs e)
        {
            String message = "";
            if (mauSacBLT.XoaMauSac(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã màu").ToString()))
            {
                 message += "Xóa thành công";
                 gridView1.FocusedRowHandle = 0;
            }
               
            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            if (gridView1.RowCount != 0)//Get data
            {
                this.teMaMauSac.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã màu").ToString();
                this.teTenMau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên màu").ToString();
              
            }
        }
    }
}
