namespace QL_Ban_DienThoai.UserControl
{
    partial class ucDanhSachSanPham
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
            this.panelp = new DevExpress.XtraEditors.GroupControl();
            this.GridMatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lueMauSac = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCPU = new DevExpress.XtraEditors.LookUpEdit();
            this.lueLoaiSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.lueNhaSX = new DevExpress.XtraEditors.LookUpEdit();
            this.teBoNho = new DevExpress.XtraEditors.TextEdit();
            this.teRAM = new DevExpress.XtraEditors.TextEdit();
            this.tePIN = new DevExpress.XtraEditors.TextEdit();
            this.teHeDieuHanh = new DevExpress.XtraEditors.TextEdit();
            this.teKichThuoc = new DevExpress.XtraEditors.TextEdit();
            this.teSoSim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sbChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.teTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teMaSanPham = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelp)).BeginInit();
            this.panelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMauSac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCPU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBoNho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRAM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHeDieuHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKichThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoSim.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelp
            // 
            this.panelp.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelp.AppearanceCaption.Options.UseFont = true;
            this.panelp.AppearanceCaption.Options.UseTextOptions = true;
            this.panelp.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.panelp.Controls.Add(this.GridMatHang);
            this.panelp.Controls.Add(this.groupBox1);
            this.panelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelp.Location = new System.Drawing.Point(0, 0);
            this.panelp.Name = "panelp";
            this.panelp.Size = new System.Drawing.Size(973, 562);
            this.panelp.TabIndex = 6;
            this.panelp.Text = "Danh Sách Sản Phẩm";
            // 
            // GridMatHang
            // 
            this.GridMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMatHang.Location = new System.Drawing.Point(7, 292);
            this.GridMatHang.MainView = this.gridView1;
            this.GridMatHang.Name = "GridMatHang";
            this.GridMatHang.Size = new System.Drawing.Size(961, 265);
            this.GridMatHang.TabIndex = 2;
            this.GridMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridMatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lueMauSac);
            this.groupBox2.Controls.Add(this.lueCPU);
            this.groupBox2.Controls.Add(this.lueLoaiSanPham);
            this.groupBox2.Controls.Add(this.lueNhaSX);
            this.groupBox2.Controls.Add(this.teBoNho);
            this.groupBox2.Controls.Add(this.teRAM);
            this.groupBox2.Controls.Add(this.tePIN);
            this.groupBox2.Controls.Add(this.teHeDieuHanh);
            this.groupBox2.Controls.Add(this.teKichThuoc);
            this.groupBox2.Controls.Add(this.teSoSim);
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.teTenSanPham);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.teMaSanPham);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lueMauSac
            // 
            this.lueMauSac.Location = new System.Drawing.Point(385, 120);
            this.lueMauSac.Name = "lueMauSac";
            this.lueMauSac.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueMauSac.Properties.Appearance.Options.UseFont = true;
            this.lueMauSac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMauSac.Size = new System.Drawing.Size(141, 24);
            this.lueMauSac.TabIndex = 13;
            // 
            // lueCPU
            // 
            this.lueCPU.Location = new System.Drawing.Point(620, 27);
            this.lueCPU.Name = "lueCPU";
            this.lueCPU.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueCPU.Properties.Appearance.Options.UseFont = true;
            this.lueCPU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCPU.Size = new System.Drawing.Size(141, 24);
            this.lueCPU.TabIndex = 16;
            // 
            // lueLoaiSanPham
            // 
            this.lueLoaiSanPham.Location = new System.Drawing.Point(385, 72);
            this.lueLoaiSanPham.Name = "lueLoaiSanPham";
            this.lueLoaiSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueLoaiSanPham.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiSanPham.Size = new System.Drawing.Size(141, 24);
            this.lueLoaiSanPham.TabIndex = 12;
            // 
            // lueNhaSX
            // 
            this.lueNhaSX.Location = new System.Drawing.Point(385, 27);
            this.lueNhaSX.Name = "lueNhaSX";
            this.lueNhaSX.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueNhaSX.Properties.Appearance.Options.UseFont = true;
            this.lueNhaSX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhaSX.Size = new System.Drawing.Size(141, 24);
            this.lueNhaSX.TabIndex = 11;
            // 
            // teBoNho
            // 
            this.teBoNho.Location = new System.Drawing.Point(620, 166);
            this.teBoNho.Name = "teBoNho";
            this.teBoNho.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teBoNho.Properties.Appearance.Options.UseFont = true;
            this.teBoNho.Size = new System.Drawing.Size(141, 24);
            this.teBoNho.TabIndex = 19;
            // 
            // teRAM
            // 
            this.teRAM.Location = new System.Drawing.Point(620, 120);
            this.teRAM.Name = "teRAM";
            this.teRAM.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teRAM.Properties.Appearance.Options.UseFont = true;
            this.teRAM.Size = new System.Drawing.Size(141, 24);
            this.teRAM.TabIndex = 18;
            // 
            // tePIN
            // 
            this.tePIN.Location = new System.Drawing.Point(385, 166);
            this.tePIN.Name = "tePIN";
            this.tePIN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tePIN.Properties.Appearance.Options.UseFont = true;
            this.tePIN.Size = new System.Drawing.Size(141, 24);
            this.tePIN.TabIndex = 15;
            // 
            // teHeDieuHanh
            // 
            this.teHeDieuHanh.Location = new System.Drawing.Point(117, 166);
            this.teHeDieuHanh.Name = "teHeDieuHanh";
            this.teHeDieuHanh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teHeDieuHanh.Properties.Appearance.Options.UseFont = true;
            this.teHeDieuHanh.Size = new System.Drawing.Size(145, 24);
            this.teHeDieuHanh.TabIndex = 10;
            // 
            // teKichThuoc
            // 
            this.teKichThuoc.Location = new System.Drawing.Point(117, 120);
            this.teKichThuoc.Name = "teKichThuoc";
            this.teKichThuoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teKichThuoc.Properties.Appearance.Options.UseFont = true;
            this.teKichThuoc.Size = new System.Drawing.Size(145, 24);
            this.teKichThuoc.TabIndex = 9;
            // 
            // teSoSim
            // 
            this.teSoSim.Location = new System.Drawing.Point(620, 71);
            this.teSoSim.Name = "teSoSim";
            this.teSoSim.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teSoSim.Properties.Appearance.Options.UseFont = true;
            this.teSoSim.Size = new System.Drawing.Size(141, 24);
            this.teSoSim.TabIndex = 17;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl12.Location = new System.Drawing.Point(547, 74);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(39, 17);
            this.labelControl12.TabIndex = 25;
            this.labelControl12.Text = "Số sim";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl11.Location = new System.Drawing.Point(547, 30);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(24, 17);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "CPU";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl10.Location = new System.Drawing.Point(547, 169);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 17);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Bộ nhớ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(278, 169);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(93, 17);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Dung lượng PIN";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl8.Location = new System.Drawing.Point(278, 123);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 17);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Màu sắc";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(547, 123);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 17);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "RAM";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(18, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 17);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Hệ điều hành";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(18, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 17);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Kích thước";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sbChinhSua);
            this.groupBox4.Controls.Add(this.sbThem);
            this.groupBox4.Controls.Add(this.sbTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(812, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 184);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // sbChinhSua
            // 
            this.sbChinhSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbChinhSua.Appearance.Options.UseFont = true;
            this.sbChinhSua.Location = new System.Drawing.Point(6, 84);
            this.sbChinhSua.Name = "sbChinhSua";
            this.sbChinhSua.Size = new System.Drawing.Size(104, 23);
            this.sbChinhSua.TabIndex = 21;
            this.sbChinhSua.Text = "Chỉnh Sửa";
            this.sbChinhSua.Click += new System.EventHandler(this.sbChinhSua_Click);
            // 
            // sbThem
            // 
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(6, 144);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(104, 23);
            this.sbThem.TabIndex = 22;
            this.sbThem.Text = "Thêm";
            this.sbThem.Click += new System.EventHandler(this.sbThem_Click);
            // 
            // sbTimKiem
            // 
            this.sbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiem.Appearance.Options.UseFont = true;
            this.sbTimKiem.Location = new System.Drawing.Point(6, 24);
            this.sbTimKiem.Name = "sbTimKiem";
            this.sbTimKiem.Size = new System.Drawing.Size(104, 23);
            this.sbTimKiem.TabIndex = 20;
            this.sbTimKiem.Text = "Tìm kiếm";
            this.sbTimKiem.Click += new System.EventHandler(this.sbTimKiem_Click);
            // 
            // teTenSanPham
            // 
            this.teTenSanPham.Location = new System.Drawing.Point(117, 71);
            this.teTenSanPham.Name = "teTenSanPham";
            this.teTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.teTenSanPham.Size = new System.Drawing.Size(145, 24);
            this.teTenSanPham.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(18, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Tên Sản Phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(278, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Nhà Sản Xuất";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(278, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Loại Sản Phẩm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Sản Phẩm";
            // 
            // teMaSanPham
            // 
            this.teMaSanPham.Location = new System.Drawing.Point(117, 27);
            this.teMaSanPham.Name = "teMaSanPham";
            this.teMaSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaSanPham.Properties.Appearance.Options.UseFont = true;
            this.teMaSanPham.Size = new System.Drawing.Size(145, 24);
            this.teMaSanPham.TabIndex = 7;
            // 
            // ucDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelp);
            this.Name = "ucDanhSachSanPham";
            this.Size = new System.Drawing.Size(973, 562);
            ((System.ComponentModel.ISupportInitialize)(this.panelp)).EndInit();
            this.panelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMauSac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCPU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBoNho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRAM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHeDieuHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKichThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoSim.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl panelp;
        private DevExpress.XtraEditors.SimpleButton sbChinhSua;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teMaSanPham;
        private DevExpress.XtraEditors.SimpleButton sbTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.TextEdit teSoSim;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit teBoNho;
        private DevExpress.XtraEditors.TextEdit teRAM;
        private DevExpress.XtraEditors.TextEdit tePIN;
        private DevExpress.XtraEditors.TextEdit teHeDieuHanh;
        private DevExpress.XtraEditors.TextEdit teKichThuoc;
        private DevExpress.XtraEditors.LookUpEdit lueCPU;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiSanPham;
        private DevExpress.XtraEditors.LookUpEdit lueNhaSX;
        private DevExpress.XtraEditors.LookUpEdit lueMauSac;
        private DevExpress.XtraGrid.GridControl GridMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
