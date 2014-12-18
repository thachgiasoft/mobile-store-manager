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
    public partial class ucCPU : DevExpress.XtraEditors.XtraUserControl
    {
        private CPUBLT cpuBLT;
        private CPU cpu;
       

        public ucCPU()
        {
            InitializeComponent();
            this.cpuBLT = new CPUBLT();
           
            LoadData();

            //Max length og type text
            this.teTenCPU.Properties.MaxLength = 50; 
            this.teMaCPU.Properties.MaxLength = 15;
            this.teSoNhan.Properties.MaxLength = 2;
            
            // Only type number
            this.teSoNhan.Properties.Mask.EditMask = "n0";
            this.teSoNhan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }

        private void LoadData()
        {

            DataTable data = new DataTable();
            data = this.cpuBLT.LayDanhSachCPU();
            this.GridCPU.DataSource = data;//Add data 
        }

        private void sbXoaCPU_Click(object sender, EventArgs e)
        {
            String message = "";
            if (cpuBLT.XoaCPU(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã CPU").ToString()))
            {
                message += "Xóa thành công";
                gridView1.FocusedRowHandle = 0;
            }
            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
            
        }

        private void sbCapNhatCPU_Click(object sender, EventArgs e)
        {
            cpu = new CPU();
            cpu.MaCPU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã CPU").ToString();

            if (this.teTenCPU.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên CPU");
                return;
            }
            else
            {
                cpu.TenCPU = this.teTenCPU.Text;

                if (this.teTenCPU.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống Số nhân CPU");
                    return;
                }
                else
                {
                    cpu.SonhanCPU = Convert.ToInt32(this.teSoNhan.Text);

                    String message = "";
                    if (cpuBLT.CapNhatCPU(cpu))
                        message += "Cập Nhật thành công";
                    else
                        message += "Cập Nhật lỗi! \nVui lòng kiểm tra lại thông tin trước khi Cập Nhật.";

                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);

                    gridView1.FocusedRowHandle = 0;
                    LoadData();
                    
                }
            }          
        }

        private void sbThemCPU_Click(object sender, EventArgs e)
        {
            cpu = new CPU();

            if (this.teTenCPU.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên CPU");
                return;
            }
            else
            {
                if (this.teSoNhan.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống số nhân CPU");
                    return;
                }else { 

                    cpu.TenCPU = this.teTenCPU.Text;
                    cpu.SonhanCPU = Convert.ToInt32(this.teSoNhan.Text);

                    if (this.cpuBLT.ThemCPU(cpu))
                    {
                        MessageBox.Show("Thêm CPU thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm CPU thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                    LoadData();
                }
            }

            
        }

        private void sbTimKiemCPU_Click(object sender, EventArgs e)
        {
            cpu = new CPU();
            cpu.MaCPU = this.teMaCPU.Text;
            cpu.TenCPU = this.teTenCPU.Text;
            if (!this.teSoNhan.Text.Equals(""))
            {
                cpu.SonhanCPU = Convert.ToInt32(this.teSoNhan.Text);
            }

            DataTable data = new DataTable();
            data = this.cpuBLT.TimKiemCPU(cpu);

            gridView1.FocusedRowHandle = 0;

            this.GridCPU.DataSource = data; 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount != 0)//Get data
            {
                this.teMaCPU.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã CPU").ToString();
                this.teTenCPU.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên CPU").ToString();
                this.teSoNhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số nhân").ToString();
               
            }
         
        }
    }
}
