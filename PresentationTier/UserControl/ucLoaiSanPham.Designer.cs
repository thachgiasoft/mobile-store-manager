namespace QL_Ban_DienThoai.UserControl
{
    partial class ucLoaiSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GridLoaiMatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teTenLoaiMatHang = new DevExpress.XtraEditors.TextEdit();
            this.teGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.teDacDiem = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teLoaiMatHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLoaiMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenLoaiMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDacDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLoaiMatHang.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.GridLoaiMatHang);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(817, 550);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh Sách Loại Mặt Hàng";
            // 
            // GridLoaiMatHang
            // 
            this.GridLoaiMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLoaiMatHang.Location = new System.Drawing.Point(5, 256);
            this.GridLoaiMatHang.MainView = this.gridView1;
            this.GridLoaiMatHang.Name = "GridLoaiMatHang";
            this.GridLoaiMatHang.Size = new System.Drawing.Size(807, 291);
            this.GridLoaiMatHang.TabIndex = 1;
            this.GridLoaiMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridLoaiMatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.teTenLoaiMatHang);
            this.groupBox1.Controls.Add(this.teGhiChu);
            this.groupBox1.Controls.Add(this.teDacDiem);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.teLoaiMatHang);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại mặt hàng";
            // 
            // teTenLoaiMatHang
            // 
            this.teTenLoaiMatHang.Location = new System.Drawing.Point(420, 35);
            this.teTenLoaiMatHang.Name = "teTenLoaiMatHang";
            this.teTenLoaiMatHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenLoaiMatHang.Properties.Appearance.Options.UseFont = true;
            this.teTenLoaiMatHang.Size = new System.Drawing.Size(140, 24);
            this.teTenLoaiMatHang.TabIndex = 3;
            // 
            // teGhiChu
            // 
            this.teGhiChu.Location = new System.Drawing.Point(420, 89);
            this.teGhiChu.Name = "teGhiChu";
            this.teGhiChu.Size = new System.Drawing.Size(140, 114);
            this.teGhiChu.TabIndex = 4;
            this.teGhiChu.UseOptimizedRendering = true;
            // 
            // teDacDiem
            // 
            this.teDacDiem.Location = new System.Drawing.Point(144, 89);
            this.teDacDiem.Name = "teDacDiem";
            this.teDacDiem.Size = new System.Drawing.Size(140, 114);
            this.teDacDiem.TabIndex = 2;
            this.teDacDiem.UseOptimizedRendering = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(301, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Ghi chú";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(23, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Đặc điểm";
            // 
            // teLoaiMatHang
            // 
            this.teLoaiMatHang.Location = new System.Drawing.Point(144, 35);
            this.teLoaiMatHang.Name = "teLoaiMatHang";
            this.teLoaiMatHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLoaiMatHang.Properties.Appearance.Options.UseFont = true;
            this.teLoaiMatHang.Size = new System.Drawing.Size(140, 24);
            this.teLoaiMatHang.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(300, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên loại mặt hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã loại mặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.sbXoa);
            this.groupBox2.Controls.Add(this.sbCapNhat);
            this.groupBox2.Controls.Add(this.sbThem);
            this.groupBox2.Controls.Add(this.sbTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(563, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // sbXoa
            // 
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(130, 33);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(75, 23);
            this.sbXoa.TabIndex = 8;
            this.sbXoa.Text = "Xóa";
            this.sbXoa.Click += new System.EventHandler(this.sbXoa_Click);
            // 
            // sbCapNhat
            // 
            this.sbCapNhat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCapNhat.Appearance.Options.UseFont = true;
            this.sbCapNhat.Location = new System.Drawing.Point(130, 107);
            this.sbCapNhat.Name = "sbCapNhat";
            this.sbCapNhat.Size = new System.Drawing.Size(75, 23);
            this.sbCapNhat.TabIndex = 9;
            this.sbCapNhat.Text = "Cập Nhật";
            this.sbCapNhat.Click += new System.EventHandler(this.sbCapNhat_Click);
            // 
            // sbThem
            // 
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(19, 107);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(75, 23);
            this.sbThem.TabIndex = 7;
            this.sbThem.Text = "Thêm";
            this.sbThem.Click += new System.EventHandler(this.sbThem_Click);
            // 
            // sbTimKiem
            // 
            this.sbTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiem.Appearance.Options.UseFont = true;
            this.sbTimKiem.Location = new System.Drawing.Point(19, 33);
            this.sbTimKiem.Name = "sbTimKiem";
            this.sbTimKiem.Size = new System.Drawing.Size(75, 23);
            this.sbTimKiem.TabIndex = 6;
            this.sbTimKiem.Text = "Tìm Kiếm";
            this.sbTimKiem.Click += new System.EventHandler(this.sbTimKiem_Click);
            // 
            // ucLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucLoaiSanPham";
            this.Size = new System.Drawing.Size(817, 550);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLoaiMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenLoaiMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDacDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLoaiMatHang.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridLoaiMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit teGhiChu;
        private DevExpress.XtraEditors.MemoEdit teDacDiem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teLoaiMatHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit teTenLoaiMatHang;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private DevExpress.XtraEditors.SimpleButton sbCapNhat;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private DevExpress.XtraEditors.SimpleButton sbTimKiem;
    }
}
