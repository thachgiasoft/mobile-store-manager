namespace QL_Ban_DienThoai.UserControl
{
    partial class ucDanhSachPhieuGiaoHang
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
            this.sbThoat = new DevExpress.XtraEditors.SimpleButton();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbeTimKiemTheo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teCumTuTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.sbThemHangHoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelp)).BeginInit();
            this.panelp.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTimKiemTheo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCumTuTimKiem.Properties)).BeginInit();
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
            this.gcKetQua.Location = new System.Drawing.Point(5, 156);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(955, 348);
            this.gcKetQua.TabIndex = 1;
            this.gcKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.panelp.Size = new System.Drawing.Size(965, 555);
            this.panelp.TabIndex = 5;
            this.panelp.Text = "Danh Sách Phiếu Giao Hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.sbChinhSua);
            this.groupBox3.Controls.Add(this.sbThoat);
            this.groupBox3.Controls.Add(this.sbXoa);
            this.groupBox3.Controls.Add(this.sbThem);
            this.groupBox3.Location = new System.Drawing.Point(500, 510);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 40);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // sbChinhSua
            // 
            this.sbChinhSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbChinhSua.Appearance.Options.UseFont = true;
            this.sbChinhSua.Location = new System.Drawing.Point(229, 11);
            this.sbChinhSua.Name = "sbChinhSua";
            this.sbChinhSua.Size = new System.Drawing.Size(104, 23);
            this.sbChinhSua.TabIndex = 10;
            this.sbChinhSua.Text = "Chỉnh Sửa";
            this.sbChinhSua.Click += new System.EventHandler(this.sbChinhSua_Click);
            // 
            // sbThoat
            // 
            this.sbThoat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThoat.Appearance.Options.UseFont = true;
            this.sbThoat.Location = new System.Drawing.Point(339, 11);
            this.sbThoat.Name = "sbThoat";
            this.sbThoat.Size = new System.Drawing.Size(104, 23);
            this.sbThoat.TabIndex = 13;
            this.sbThoat.Text = "Thoát";
            this.sbThoat.Click += new System.EventHandler(this.sbThoat_Click);
            // 
            // sbXoa
            // 
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(119, 11);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(104, 23);
            this.sbXoa.TabIndex = 11;
            this.sbXoa.Text = "Xóa";
            this.sbXoa.Click += new System.EventHandler(this.sbXoa_Click);
            // 
            // sbThem
            // 
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(9, 11);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(104, 23);
            this.sbThem.TabIndex = 12;
            this.sbThem.Text = "Thêm";
            this.sbThem.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm phiếu giao hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbeTimKiemTheo);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.teCumTuTimKiem);
            this.groupBox2.Controls.Add(this.sbThemHangHoa);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbeTimKiemTheo
            // 
            this.cbeTimKiemTheo.Location = new System.Drawing.Point(602, 27);
            this.cbeTimKiemTheo.Name = "cbeTimKiemTheo";
            this.cbeTimKiemTheo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeTimKiemTheo.Properties.Appearance.Options.UseFont = true;
            this.cbeTimKiemTheo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeTimKiemTheo.Size = new System.Drawing.Size(174, 24);
            this.cbeTimKiemTheo.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(514, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Tìm kiếm theo";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cụm từ tìm kiếm";
            // 
            // teCumTuTimKiem
            // 
            this.teCumTuTimKiem.Location = new System.Drawing.Point(107, 27);
            this.teCumTuTimKiem.Name = "teCumTuTimKiem";
            this.teCumTuTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCumTuTimKiem.Properties.Appearance.Options.UseFont = true;
            this.teCumTuTimKiem.Size = new System.Drawing.Size(369, 24);
            this.teCumTuTimKiem.TabIndex = 7;
            // 
            // sbThemHangHoa
            // 
            this.sbThemHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbThemHangHoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThemHangHoa.Appearance.Options.UseFont = true;
            this.sbThemHangHoa.Location = new System.Drawing.Point(833, 30);
            this.sbThemHangHoa.Name = "sbThemHangHoa";
            this.sbThemHangHoa.Size = new System.Drawing.Size(104, 23);
            this.sbThemHangHoa.TabIndex = 0;
            this.sbThemHangHoa.Text = "Tìm kiếm";
            // 
            // ucDanhSachPhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelp);
            this.Name = "ucDanhSachPhieuGiaoHang";
            this.Size = new System.Drawing.Size(965, 555);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelp)).EndInit();
            this.panelp.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTimKiemTheo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCumTuTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraEditors.GroupControl panelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit cbeTimKiemTheo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teCumTuTimKiem;
        private DevExpress.XtraEditors.SimpleButton sbThemHangHoa;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private DevExpress.XtraEditors.SimpleButton sbChinhSua;
        private DevExpress.XtraEditors.SimpleButton sbThoat;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
