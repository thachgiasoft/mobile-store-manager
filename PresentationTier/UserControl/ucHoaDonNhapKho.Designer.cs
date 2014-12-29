namespace QL_Ban_DienThoai.UserControl
{
    partial class ucHoaDonNhapKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbIn = new DevExpress.XtraEditors.SimpleButton();
            this.sbLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lcTongTien = new DevExpress.XtraEditors.LabelControl();
            this.sbLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gcSanPhamTrongHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamTrongHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gcSanPhamDatHang = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamDatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayThanhToan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbeNhaCungCapFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deNgayDatHangTo = new DevExpress.XtraEditors.DateEdit();
            this.deNgayDatHangFrom = new DevExpress.XtraEditors.DateEdit();
            this.gcDanhSachHoaDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachhoaDonDatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamTrongHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamTrongHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThanhToan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeNhaCungCapFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachHoaDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachhoaDonDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sbIn);
            this.groupBox1.Controls.Add(this.sbLuu);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.deNgayThanhToan);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(591, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn nhập kho";
            // 
            // sbIn
            // 
            this.sbIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbIn.Appearance.Options.UseFont = true;
            this.sbIn.Location = new System.Drawing.Point(415, 41);
            this.sbIn.Name = "sbIn";
            this.sbIn.Size = new System.Drawing.Size(183, 23);
            this.sbIn.TabIndex = 12;
            this.sbIn.Text = "In Hóa Đơn Thanh Toán";
            this.sbIn.Click += new System.EventHandler(this.sbIn_Click);
            // 
            // sbLuu
            // 
            this.sbLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbLuu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLuu.Appearance.Options.UseFont = true;
            this.sbLuu.Enabled = false;
            this.sbLuu.Location = new System.Drawing.Point(415, 16);
            this.sbLuu.Name = "sbLuu";
            this.sbLuu.Size = new System.Drawing.Size(183, 23);
            this.sbLuu.TabIndex = 11;
            this.sbLuu.Text = "Thêm Hóa Đơn";
            this.sbLuu.Click += new System.EventHandler(this.sbLuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lcTongTien);
            this.groupBox2.Controls.Add(this.sbLamMoi);
            this.groupBox2.Controls.Add(this.sbXoa);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.teSoLuong);
            this.groupBox2.Controls.Add(this.sbThem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 474);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // lcTongTien
            // 
            this.lcTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcTongTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcTongTien.Location = new System.Drawing.Point(401, 451);
            this.lcTongTien.Name = "lcTongTien";
            this.lcTongTien.Size = new System.Drawing.Size(103, 17);
            this.lcTongTien.TabIndex = 22;
            this.lcTongTien.Text = "Tổng Tiền: 0 VND";
            // 
            // sbLamMoi
            // 
            this.sbLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbLamMoi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLamMoi.Appearance.Options.UseFont = true;
            this.sbLamMoi.Location = new System.Drawing.Point(297, 351);
            this.sbLamMoi.Name = "sbLamMoi";
            this.sbLamMoi.Size = new System.Drawing.Size(100, 23);
            this.sbLamMoi.TabIndex = 9;
            this.sbLamMoi.Text = "Làm Mới";
            this.sbLamMoi.Click += new System.EventHandler(this.sbLamMoi_Click);
            // 
            // sbXoa
            // 
            this.sbXoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(297, 223);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(100, 23);
            this.sbXoa.TabIndex = 8;
            this.sbXoa.Text = "Xóa >>";
            this.sbXoa.Click += new System.EventHandler(this.sbXoa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gcSanPhamTrongHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(400, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 423);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mặt Hàng Trong Hóa Đơn";
            // 
            // gcSanPhamTrongHoaDon
            // 
            this.gcSanPhamTrongHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSanPhamTrongHoaDon.Location = new System.Drawing.Point(6, 19);
            this.gcSanPhamTrongHoaDon.MainView = this.gvSanPhamTrongHoaDon;
            this.gcSanPhamTrongHoaDon.Name = "gcSanPhamTrongHoaDon";
            this.gcSanPhamTrongHoaDon.Size = new System.Drawing.Size(184, 398);
            this.gcSanPhamTrongHoaDon.TabIndex = 10;
            this.gcSanPhamTrongHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamTrongHoaDon});
            // 
            // gvSanPhamTrongHoaDon
            // 
            this.gvSanPhamTrongHoaDon.GridControl = this.gcSanPhamTrongHoaDon;
            this.gvSanPhamTrongHoaDon.Name = "gvSanPhamTrongHoaDon";
            this.gvSanPhamTrongHoaDon.OptionsBehavior.Editable = false;
            this.gvSanPhamTrongHoaDon.OptionsView.ShowGroupPanel = false;
            this.gvSanPhamTrongHoaDon.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvSanPhamTrongHoaDon_RowClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.gcSanPhamDatHang);
            this.groupBox3.Location = new System.Drawing.Point(3, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 450);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mặt Hàng Đặt Hàng";
            // 
            // gcSanPhamDatHang
            // 
            this.gcSanPhamDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSanPhamDatHang.Location = new System.Drawing.Point(6, 19);
            this.gcSanPhamDatHang.MainView = this.gvSanPhamDatHang;
            this.gcSanPhamDatHang.Name = "gcSanPhamDatHang";
            this.gcSanPhamDatHang.Size = new System.Drawing.Size(277, 425);
            this.gcSanPhamDatHang.TabIndex = 5;
            this.gcSanPhamDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamDatHang});
            // 
            // gvSanPhamDatHang
            // 
            this.gvSanPhamDatHang.GridControl = this.gcSanPhamDatHang;
            this.gvSanPhamDatHang.Name = "gvSanPhamDatHang";
            this.gvSanPhamDatHang.OptionsBehavior.Editable = false;
            this.gvSanPhamDatHang.OptionsView.ShowGroupPanel = false;
            this.gvSanPhamDatHang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvSanPhamDatHang_RowClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(298, 167);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 17);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Số lượng";
            // 
            // teSoLuong
            // 
            this.teSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teSoLuong.EditValue = "1";
            this.teSoLuong.Location = new System.Drawing.Point(357, 164);
            this.teSoLuong.Name = "teSoLuong";
            this.teSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSoLuong.Properties.Appearance.Options.UseFont = true;
            this.teSoLuong.Properties.Mask.EditMask = "d";
            this.teSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teSoLuong.Properties.MaxLength = 5;
            this.teSoLuong.Size = new System.Drawing.Size(41, 24);
            this.teSoLuong.TabIndex = 6;
            this.teSoLuong.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // sbThem
            // 
            this.sbThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(297, 194);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(100, 23);
            this.sbThem.TabIndex = 7;
            this.sbThem.Text = "Thêm >>";
            this.sbThem.Click += new System.EventHandler(this.sbThem_Click);
            // 
            // deNgayThanhToan
            // 
            this.deNgayThanhToan.EditValue = null;
            this.deNgayThanhToan.Location = new System.Drawing.Point(137, 18);
            this.deNgayThanhToan.Name = "deNgayThanhToan";
            this.deNgayThanhToan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayThanhToan.Properties.Appearance.Options.UseFont = true;
            this.deNgayThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThanhToan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThanhToan.Properties.ReadOnly = true;
            this.deNgayThanhToan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deNgayThanhToan.Size = new System.Drawing.Size(180, 24);
            this.deNgayThanhToan.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày thanh toán";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.groupBox5);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1200, 578);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Lập Hóa Đơn Nhập Kho";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelControl7);
            this.groupBox5.Controls.Add(this.labelControl6);
            this.groupBox5.Controls.Add(this.labelControl5);
            this.groupBox5.Controls.Add(this.cbeNhaCungCapFilter);
            this.groupBox5.Controls.Add(this.deNgayDatHangTo);
            this.groupBox5.Controls.Add(this.deNgayDatHangFrom);
            this.groupBox5.Controls.Add(this.gcDanhSachHoaDonDatHang);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(4, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(584, 532);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Hóa Đơn Đặt Hàng";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(273, 46);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 17);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "đến";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(160, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 17);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Ngày đặt hàng";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(4, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 17);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Nhà cung cấp";
            // 
            // cbeNhaCungCapFilter
            // 
            this.cbeNhaCungCapFilter.Location = new System.Drawing.Point(4, 41);
            this.cbeNhaCungCapFilter.Name = "cbeNhaCungCapFilter";
            this.cbeNhaCungCapFilter.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeNhaCungCapFilter.Properties.Appearance.Options.UseFont = true;
            this.cbeNhaCungCapFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeNhaCungCapFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeNhaCungCapFilter.Size = new System.Drawing.Size(150, 24);
            this.cbeNhaCungCapFilter.TabIndex = 0;
            this.cbeNhaCungCapFilter.TextChanged += new System.EventHandler(this.cbeNhaCungCapFilter_TextChanged);
            // 
            // deNgayDatHangTo
            // 
            this.deNgayDatHangTo.EditValue = null;
            this.deNgayDatHangTo.Location = new System.Drawing.Point(299, 41);
            this.deNgayDatHangTo.Name = "deNgayDatHangTo";
            this.deNgayDatHangTo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayDatHangTo.Properties.Appearance.Options.UseFont = true;
            this.deNgayDatHangTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDatHangTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDatHangTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deNgayDatHangTo.Size = new System.Drawing.Size(106, 24);
            this.deNgayDatHangTo.TabIndex = 2;
            this.deNgayDatHangTo.TextChanged += new System.EventHandler(this.deNgayDatHangTo_TextChanged);
            // 
            // deNgayDatHangFrom
            // 
            this.deNgayDatHangFrom.EditValue = null;
            this.deNgayDatHangFrom.Location = new System.Drawing.Point(160, 41);
            this.deNgayDatHangFrom.Name = "deNgayDatHangFrom";
            this.deNgayDatHangFrom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayDatHangFrom.Properties.Appearance.Options.UseFont = true;
            this.deNgayDatHangFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDatHangFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDatHangFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deNgayDatHangFrom.Size = new System.Drawing.Size(111, 24);
            this.deNgayDatHangFrom.TabIndex = 1;
            this.deNgayDatHangFrom.TextChanged += new System.EventHandler(this.deNgayDatHangFrom_TextChanged);
            // 
            // gcDanhSachHoaDonDatHang
            // 
            this.gcDanhSachHoaDonDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSachHoaDonDatHang.Location = new System.Drawing.Point(1, 68);
            this.gcDanhSachHoaDonDatHang.MainView = this.gvDanhSachhoaDonDatHang;
            this.gcDanhSachHoaDonDatHang.Name = "gcDanhSachHoaDonDatHang";
            this.gcDanhSachHoaDonDatHang.Size = new System.Drawing.Size(579, 457);
            this.gcDanhSachHoaDonDatHang.TabIndex = 3;
            this.gcDanhSachHoaDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachhoaDonDatHang});
            this.gcDanhSachHoaDonDatHang.Click += new System.EventHandler(this.gcDanhSachHoaDonDatHang_Click);
            // 
            // gvDanhSachhoaDonDatHang
            // 
            this.gvDanhSachhoaDonDatHang.GridControl = this.gcDanhSachHoaDonDatHang;
            this.gvDanhSachhoaDonDatHang.Name = "gvDanhSachhoaDonDatHang";
            this.gvDanhSachhoaDonDatHang.OptionsBehavior.Editable = false;
            this.gvDanhSachhoaDonDatHang.OptionsView.ShowGroupPanel = false;
            // 
            // ucHoaDonNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucHoaDonNhapKho";
            this.Size = new System.Drawing.Size(1200, 578);
            this.Load += new System.EventHandler(this.ucHoaDonNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamTrongHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamTrongHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThanhToan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeNhaCungCapFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHangFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachHoaDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachhoaDonDatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit deNgayThanhToan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbLamMoi;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gcSanPhamTrongHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamTrongHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gcSanPhamDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamDatHang;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teSoLuong;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private DevExpress.XtraEditors.SimpleButton sbIn;
        private DevExpress.XtraEditors.SimpleButton sbLuu;
        private DevExpress.XtraGrid.GridControl gcDanhSachHoaDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachhoaDonDatHang;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbeNhaCungCapFilter;
        private DevExpress.XtraEditors.DateEdit deNgayDatHangTo;
        private DevExpress.XtraEditors.DateEdit deNgayDatHangFrom;
        private DevExpress.XtraEditors.LabelControl lcTongTien;


    }
}
