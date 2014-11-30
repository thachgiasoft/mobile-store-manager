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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcKetQua = new DevExpress.XtraGrid.GridControl();
            this.panelp = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sbChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbeNhaSanXuat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeLoaiSanPham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teMaSanPham = new DevExpress.XtraEditors.TextEdit();
            this.sbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelp)).BeginInit();
            this.panelp.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeNhaSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcKetQua;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gcKetQua
            // 
            this.gcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKetQua.Location = new System.Drawing.Point(5, 208);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(963, 303);
            this.gcKetQua.TabIndex = 1;
            this.gcKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcKetQua.Click += new System.EventHandler(this.gcKetQua_Click);
            // 
            // panelp
            // 
            this.panelp.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelp.AppearanceCaption.Options.UseFont = true;
            this.panelp.AppearanceCaption.Options.UseTextOptions = true;
            this.panelp.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.panelp.Controls.Add(this.groupBox3);
            this.panelp.Controls.Add(this.gcKetQua);
            this.panelp.Controls.Add(this.groupBox1);
            this.panelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelp.Location = new System.Drawing.Point(0, 0);
            this.panelp.Name = "panelp";
            this.panelp.Size = new System.Drawing.Size(973, 562);
            this.panelp.TabIndex = 6;
            this.panelp.Text = "Danh Sách Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.sbChinhSua);
            this.groupBox3.Controls.Add(this.sbXoa);
            this.groupBox3.Controls.Add(this.sbThem);
            this.groupBox3.Location = new System.Drawing.Point(513, 517);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 40);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // sbChinhSua
            // 
            this.sbChinhSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbChinhSua.Appearance.Options.UseFont = true;
            this.sbChinhSua.Location = new System.Drawing.Point(303, 11);
            this.sbChinhSua.Name = "sbChinhSua";
            this.sbChinhSua.Size = new System.Drawing.Size(104, 23);
            this.sbChinhSua.TabIndex = 10;
            this.sbChinhSua.Text = "Chỉnh Sửa";
            // 
            // sbXoa
            // 
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(174, 11);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(104, 23);
            this.sbXoa.TabIndex = 11;
            this.sbXoa.Text = "Xóa";
            // 
            // sbThem
            // 
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(43, 11);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(104, 23);
            this.sbThem.TabIndex = 12;
            this.sbThem.Text = "Thêm";
            this.sbThem.Click += new System.EventHandler(this.sbThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.teTenSanPham);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.cbeNhaSanXuat);
            this.groupBox2.Controls.Add(this.cbeLoaiSanPham);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.teMaSanPham);
            this.groupBox2.Controls.Add(this.sbTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // teTenSanPham
            // 
            this.teTenSanPham.Location = new System.Drawing.Point(149, 71);
            this.teTenSanPham.Name = "teTenSanPham";
            this.teTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.teTenSanPham.Size = new System.Drawing.Size(135, 24);
            this.teTenSanPham.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(43, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Tên Sản Phẩm";
            // 
            // cbeNhaSanXuat
            // 
            this.cbeNhaSanXuat.Location = new System.Drawing.Point(429, 27);
            this.cbeNhaSanXuat.Name = "cbeNhaSanXuat";
            this.cbeNhaSanXuat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbeNhaSanXuat.Properties.Appearance.Options.UseFont = true;
            this.cbeNhaSanXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeNhaSanXuat.Size = new System.Drawing.Size(127, 24);
            this.cbeNhaSanXuat.TabIndex = 13;
            // 
            // cbeLoaiSanPham
            // 
            this.cbeLoaiSanPham.Location = new System.Drawing.Point(430, 68);
            this.cbeLoaiSanPham.Name = "cbeLoaiSanPham";
            this.cbeLoaiSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbeLoaiSanPham.Properties.Appearance.Options.UseFont = true;
            this.cbeLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLoaiSanPham.Size = new System.Drawing.Size(127, 24);
            this.cbeLoaiSanPham.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(320, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Nhà Sản Xuất";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(320, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Loại Sản Phẩm";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(44, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Sản Phẩm";
            // 
            // teMaSanPham
            // 
            this.teMaSanPham.Location = new System.Drawing.Point(149, 27);
            this.teMaSanPham.Name = "teMaSanPham";
            this.teMaSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaSanPham.Properties.Appearance.Options.UseFont = true;
            this.teMaSanPham.Size = new System.Drawing.Size(135, 24);
            this.teMaSanPham.TabIndex = 7;
            // 
            // sbTimKiem
            // 
            this.sbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiem.Appearance.Options.UseFont = true;
            this.sbTimKiem.Location = new System.Drawing.Point(660, 49);
            this.sbTimKiem.Name = "sbTimKiem";
            this.sbTimKiem.Size = new System.Drawing.Size(104, 23);
            this.sbTimKiem.TabIndex = 0;
            this.sbTimKiem.Text = "Tìm kiếm";
            // 
            // ucDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelp);
            this.Name = "ucDanhSachSanPham";
            this.Size = new System.Drawing.Size(973, 562);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelp)).EndInit();
            this.panelp.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeNhaSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraEditors.GroupControl panelp;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton sbChinhSua;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teMaSanPham;
        private DevExpress.XtraEditors.SimpleButton sbTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbeNhaSanXuat;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLoaiSanPham;
        private DevExpress.XtraEditors.TextEdit teTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
