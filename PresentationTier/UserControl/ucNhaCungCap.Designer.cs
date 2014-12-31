namespace QL_Ban_DienThoai.UserControl
{
    partial class ucNhaCungCap
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
            this.GridCungCap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teWeb = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.teTenNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.teDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teMaNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbXoaNhaCC = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapNhatNhaCC = new DevExpress.XtraEditors.SimpleButton();
            this.sbThemNhaCC = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiemNhaCC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhaCC.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.GridCungCap);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(859, 496);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // GridCungCap
            // 
            this.GridCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCungCap.Location = new System.Drawing.Point(5, 308);
            this.GridCungCap.MainView = this.gridView1;
            this.GridCungCap.Name = "GridCungCap";
            this.GridCungCap.Size = new System.Drawing.Size(849, 185);
            this.GridCungCap.TabIndex = 1;
            this.GridCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridCungCap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.teSoDienThoai);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.teWeb);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.teTenNhaCC);
            this.groupBox1.Controls.Add(this.teDiaChi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.teMaNhaCC);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // teSoDienThoai
            // 
            this.teSoDienThoai.Location = new System.Drawing.Point(420, 82);
            this.teSoDienThoai.Name = "teSoDienThoai";
            this.teSoDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teSoDienThoai.Properties.Appearance.Options.UseFont = true;
            this.teSoDienThoai.Size = new System.Drawing.Size(140, 24);
            this.teSoDienThoai.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(300, 86);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 17);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Số điện thoại";
            // 
            // teWeb
            // 
            this.teWeb.Location = new System.Drawing.Point(144, 83);
            this.teWeb.Name = "teWeb";
            this.teWeb.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teWeb.Properties.Appearance.Options.UseFont = true;
            this.teWeb.Size = new System.Drawing.Size(140, 24);
            this.teWeb.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(23, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 17);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Website";
            // 
            // teTenNhaCC
            // 
            this.teTenNhaCC.Location = new System.Drawing.Point(420, 35);
            this.teTenNhaCC.Name = "teTenNhaCC";
            this.teTenNhaCC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenNhaCC.Properties.Appearance.Options.UseFont = true;
            this.teTenNhaCC.Size = new System.Drawing.Size(140, 24);
            this.teTenNhaCC.TabIndex = 4;
            // 
            // teDiaChi
            // 
            this.teDiaChi.Location = new System.Drawing.Point(144, 136);
            this.teDiaChi.Name = "teDiaChi";
            this.teDiaChi.Size = new System.Drawing.Size(140, 114);
            this.teDiaChi.TabIndex = 3;
            this.teDiaChi.UseOptimizedRendering = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(23, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // teMaNhaCC
            // 
            this.teMaNhaCC.Location = new System.Drawing.Point(144, 35);
            this.teMaNhaCC.Name = "teMaNhaCC";
            this.teMaNhaCC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaNhaCC.Properties.Appearance.Options.UseFont = true;
            this.teMaNhaCC.Size = new System.Drawing.Size(140, 24);
            this.teMaNhaCC.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(300, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên nhà cung cấp";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.sbXoaNhaCC);
            this.groupBox2.Controls.Add(this.sbCapNhatNhaCC);
            this.groupBox2.Controls.Add(this.sbThemNhaCC);
            this.groupBox2.Controls.Add(this.sbTimKiemNhaCC);
            this.groupBox2.Location = new System.Drawing.Point(584, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // sbXoaNhaCC
            // 
            this.sbXoaNhaCC.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoaNhaCC.Appearance.Options.UseFont = true;
            this.sbXoaNhaCC.Location = new System.Drawing.Point(130, 33);
            this.sbXoaNhaCC.Name = "sbXoaNhaCC";
            this.sbXoaNhaCC.Size = new System.Drawing.Size(75, 23);
            this.sbXoaNhaCC.TabIndex = 9;
            this.sbXoaNhaCC.Text = "Xóa";
            this.sbXoaNhaCC.Click += new System.EventHandler(this.sbXoaNhaCC_Click);
            // 
            // sbCapNhatNhaCC
            // 
            this.sbCapNhatNhaCC.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCapNhatNhaCC.Appearance.Options.UseFont = true;
            this.sbCapNhatNhaCC.Location = new System.Drawing.Point(130, 107);
            this.sbCapNhatNhaCC.Name = "sbCapNhatNhaCC";
            this.sbCapNhatNhaCC.Size = new System.Drawing.Size(75, 23);
            this.sbCapNhatNhaCC.TabIndex = 9;
            this.sbCapNhatNhaCC.Text = "Cập Nhật";
            this.sbCapNhatNhaCC.Click += new System.EventHandler(this.sbCapNhatNhaCC_Click);
            // 
            // sbThemNhaCC
            // 
            this.sbThemNhaCC.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThemNhaCC.Appearance.Options.UseFont = true;
            this.sbThemNhaCC.Location = new System.Drawing.Point(19, 107);
            this.sbThemNhaCC.Name = "sbThemNhaCC";
            this.sbThemNhaCC.Size = new System.Drawing.Size(75, 23);
            this.sbThemNhaCC.TabIndex = 8;
            this.sbThemNhaCC.Text = "Thêm";
            this.sbThemNhaCC.Click += new System.EventHandler(this.sbThemNhaCC_Click);
            // 
            // sbTimKiemNhaCC
            // 
            this.sbTimKiemNhaCC.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiemNhaCC.Appearance.Options.UseFont = true;
            this.sbTimKiemNhaCC.Location = new System.Drawing.Point(19, 33);
            this.sbTimKiemNhaCC.Name = "sbTimKiemNhaCC";
            this.sbTimKiemNhaCC.Size = new System.Drawing.Size(75, 23);
            this.sbTimKiemNhaCC.TabIndex = 7;
            this.sbTimKiemNhaCC.Text = "Tìm Kiếm";
            this.sbTimKiemNhaCC.Click += new System.EventHandler(this.sbTimKiemNhaCC_Click);
            // 
            // ucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucNhaCungCap";
            this.Size = new System.Drawing.Size(859, 496);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhaCC.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit teSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teWeb;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit teTenNhaCC;
        private DevExpress.XtraEditors.MemoEdit teDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teMaNhaCC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbXoaNhaCC;
        private DevExpress.XtraEditors.SimpleButton sbCapNhatNhaCC;
        private DevExpress.XtraEditors.SimpleButton sbThemNhaCC;
        private DevExpress.XtraEditors.SimpleButton sbTimKiemNhaCC;
    }
}
