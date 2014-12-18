namespace QL_Ban_DienThoai.UserControl
{
    partial class ucCPU
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
            this.GridCPU = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teTenCPU = new DevExpress.XtraEditors.TextEdit();
            this.teMaCPU = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbXoaCPU = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapNhatCPU = new DevExpress.XtraEditors.SimpleButton();
            this.sbThemCPU = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiemCPU = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teSoNhan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenCPU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaCPU.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSoNhan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.GridCPU);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(775, 515);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh Sách CPU";
            // 
            // GridCPU
            // 
            this.GridCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCPU.Location = new System.Drawing.Point(5, 220);
            this.GridCPU.MainView = this.gridView1;
            this.GridCPU.Name = "GridCPU";
            this.GridCPU.Size = new System.Drawing.Size(765, 292);
            this.GridCPU.TabIndex = 1;
            this.GridCPU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridCPU;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.teSoNhan);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.teTenCPU);
            this.groupBox1.Controls.Add(this.teMaCPU);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin CPU";
            // 
            // teTenCPU
            // 
            this.teTenCPU.Location = new System.Drawing.Point(113, 72);
            this.teTenCPU.Name = "teTenCPU";
            this.teTenCPU.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenCPU.Properties.Appearance.Options.UseFont = true;
            this.teTenCPU.Size = new System.Drawing.Size(208, 24);
            this.teTenCPU.TabIndex = 9;
            // 
            // teMaCPU
            // 
            this.teMaCPU.Location = new System.Drawing.Point(113, 31);
            this.teMaCPU.Name = "teMaCPU";
            this.teMaCPU.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaCPU.Properties.Appearance.Options.UseFont = true;
            this.teMaCPU.Size = new System.Drawing.Size(208, 24);
            this.teMaCPU.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(27, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên CPU";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã CPU";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.sbXoaCPU);
            this.groupBox2.Controls.Add(this.sbCapNhatCPU);
            this.groupBox2.Controls.Add(this.sbThemCPU);
            this.groupBox2.Controls.Add(this.sbTimKiemCPU);
            this.groupBox2.Location = new System.Drawing.Point(422, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // sbXoaCPU
            // 
            this.sbXoaCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoaCPU.Appearance.Options.UseFont = true;
            this.sbXoaCPU.Location = new System.Drawing.Point(251, 33);
            this.sbXoaCPU.Name = "sbXoaCPU";
            this.sbXoaCPU.Size = new System.Drawing.Size(75, 23);
            this.sbXoaCPU.TabIndex = 3;
            this.sbXoaCPU.Text = "Xóa";
            this.sbXoaCPU.Click += new System.EventHandler(this.sbXoaCPU_Click);
            // 
            // sbCapNhatCPU
            // 
            this.sbCapNhatCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCapNhatCPU.Appearance.Options.UseFont = true;
            this.sbCapNhatCPU.Location = new System.Drawing.Point(170, 33);
            this.sbCapNhatCPU.Name = "sbCapNhatCPU";
            this.sbCapNhatCPU.Size = new System.Drawing.Size(75, 23);
            this.sbCapNhatCPU.TabIndex = 2;
            this.sbCapNhatCPU.Text = "Cập Nhật";
            this.sbCapNhatCPU.Click += new System.EventHandler(this.sbCapNhatCPU_Click);
            // 
            // sbThemCPU
            // 
            this.sbThemCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThemCPU.Appearance.Options.UseFont = true;
            this.sbThemCPU.Location = new System.Drawing.Point(89, 33);
            this.sbThemCPU.Name = "sbThemCPU";
            this.sbThemCPU.Size = new System.Drawing.Size(75, 23);
            this.sbThemCPU.TabIndex = 1;
            this.sbThemCPU.Text = "Thêm";
            this.sbThemCPU.Click += new System.EventHandler(this.sbThemCPU_Click);
            // 
            // sbTimKiemCPU
            // 
            this.sbTimKiemCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiemCPU.Appearance.Options.UseFont = true;
            this.sbTimKiemCPU.Location = new System.Drawing.Point(8, 33);
            this.sbTimKiemCPU.Name = "sbTimKiemCPU";
            this.sbTimKiemCPU.Size = new System.Drawing.Size(75, 23);
            this.sbTimKiemCPU.TabIndex = 0;
            this.sbTimKiemCPU.Text = "Tìm Kiếm";
            this.sbTimKiemCPU.Click += new System.EventHandler(this.sbTimKiemCPU_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(28, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 17);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Số nhân";
            // 
            // teSoNhan
            // 
            this.teSoNhan.Location = new System.Drawing.Point(113, 115);
            this.teSoNhan.Name = "teSoNhan";
            this.teSoNhan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teSoNhan.Properties.Appearance.Options.UseFont = true;
            this.teSoNhan.Size = new System.Drawing.Size(208, 24);
            this.teSoNhan.TabIndex = 11;
            // 
            // ucCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucCPU";
            this.Size = new System.Drawing.Size(775, 515);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenCPU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaCPU.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teSoNhan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridCPU;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit teSoNhan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teTenCPU;
        private DevExpress.XtraEditors.TextEdit teMaCPU;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbXoaCPU;
        private DevExpress.XtraEditors.SimpleButton sbCapNhatCPU;
        private DevExpress.XtraEditors.SimpleButton sbThemCPU;
        private DevExpress.XtraEditors.SimpleButton sbTimKiemCPU;
    }
}
