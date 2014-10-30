namespace QL_Ban_DienThoai.UserControl
{
    partial class ucHoaDonDatHang
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
            this.gcKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbIn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.meDanhSachHangHoaHoaDon = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.meDanhSachHangHoa = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayDatHang = new DevExpress.XtraEditors.DateEdit();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayGiaoHang = new DevExpress.XtraEditors.DateEdit();
            this.teTenNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDanhSachHangHoaHoaDon.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDanhSachHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGiaoHang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGiaoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhaCungCap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.gcKetQua);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(847, 555);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Lập Hóa Đơn Đặt Hàng";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // gcKetQua
            // 
            this.gcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKetQua.Location = new System.Drawing.Point(503, 41);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(339, 509);
            this.gcKetQua.TabIndex = 1;
            this.gcKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcKetQua;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sbIn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.deNgayDatHang);
            this.groupBox1.Controls.Add(this.sbXoa);
            this.groupBox1.Controls.Add(this.deNgayGiaoHang);
            this.groupBox1.Controls.Add(this.teTenNhaCungCap);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà sản xuất";
            // 
            // sbIn
            // 
            this.sbIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbIn.Appearance.Options.UseFont = true;
            this.sbIn.Location = new System.Drawing.Point(400, 102);
            this.sbIn.Name = "sbIn";
            this.sbIn.Size = new System.Drawing.Size(75, 23);
            this.sbIn.TabIndex = 16;
            this.sbIn.Text = "In";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 392);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.meDanhSachHangHoaHoaDon);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(283, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 368);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sản Phẩm Trong Hóa Đơn";
            // 
            // meDanhSachHangHoaHoaDon
            // 
            this.meDanhSachHangHoaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meDanhSachHangHoaHoaDon.EditValue = "";
            this.meDanhSachHangHoaHoaDon.Location = new System.Drawing.Point(3, 21);
            this.meDanhSachHangHoaHoaDon.Name = "meDanhSachHangHoaHoaDon";
            this.meDanhSachHangHoaHoaDon.Size = new System.Drawing.Size(200, 344);
            this.meDanhSachHangHoaHoaDon.TabIndex = 14;
            this.meDanhSachHangHoaHoaDon.UseOptimizedRendering = true;
            this.meDanhSachHangHoaHoaDon.EditValueChanged += new System.EventHandler(this.meDanhSachHangHoaHoaDon_EditValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.meDanhSachHangHoa);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 368);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản Phẩm Đặt Hàng";
            // 
            // meDanhSachHangHoa
            // 
            this.meDanhSachHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meDanhSachHangHoa.EditValue = "";
            this.meDanhSachHangHoa.Location = new System.Drawing.Point(3, 21);
            this.meDanhSachHangHoa.Name = "meDanhSachHangHoa";
            this.meDanhSachHangHoa.Size = new System.Drawing.Size(148, 344);
            this.meDanhSachHangHoa.TabIndex = 12;
            this.meDanhSachHangHoa.UseOptimizedRendering = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(166, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 17);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Số lượng";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(225, 127);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(55, 24);
            this.textEdit1.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(166, 153);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Thêm >>";
            // 
            // deNgayDatHang
            // 
            this.deNgayDatHang.EditValue = null;
            this.deNgayDatHang.Location = new System.Drawing.Point(137, 18);
            this.deNgayDatHang.Name = "deNgayDatHang";
            this.deNgayDatHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayDatHang.Properties.Appearance.Options.UseFont = true;
            this.deNgayDatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDatHang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDatHang.Size = new System.Drawing.Size(349, 24);
            this.deNgayDatHang.TabIndex = 11;
            // 
            // sbXoa
            // 
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(319, 102);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(75, 23);
            this.sbXoa.TabIndex = 3;
            this.sbXoa.Text = "Lưu";
            // 
            // deNgayGiaoHang
            // 
            this.deNgayGiaoHang.EditValue = null;
            this.deNgayGiaoHang.Location = new System.Drawing.Point(137, 45);
            this.deNgayGiaoHang.Name = "deNgayGiaoHang";
            this.deNgayGiaoHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayGiaoHang.Properties.Appearance.Options.UseFont = true;
            this.deNgayGiaoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayGiaoHang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayGiaoHang.Size = new System.Drawing.Size(349, 24);
            this.deNgayGiaoHang.TabIndex = 10;
            // 
            // teTenNhaCungCap
            // 
            this.teTenNhaCungCap.Location = new System.Drawing.Point(137, 72);
            this.teTenNhaCungCap.Name = "teTenNhaCungCap";
            this.teTenNhaCungCap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenNhaCungCap.Properties.Appearance.Options.UseFont = true;
            this.teTenNhaCungCap.Size = new System.Drawing.Size(349, 24);
            this.teTenNhaCungCap.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(6, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên nhà cung cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(6, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày giao hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày đặt hàng";
            // 
            // ucHoaDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucHoaDonDatHang";
            this.Size = new System.Drawing.Size(847, 555);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meDanhSachHangHoaHoaDon.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meDanhSachHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGiaoHang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGiaoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhaCungCap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.MemoEdit meDanhSachHangHoa;
        private DevExpress.XtraEditors.MemoEdit meDanhSachHangHoaHoaDon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit deNgayDatHang;
        private DevExpress.XtraEditors.DateEdit deNgayGiaoHang;
        private DevExpress.XtraEditors.TextEdit teTenNhaCungCap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton sbIn;
    }
}
