namespace QL_Ban_DienThoai.UserControl
{
    partial class ucBaoCaoTonKho
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
            this.gcBaocaoTonKho = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbIn = new DevExpress.XtraEditors.SimpleButton();
            this.sbXemTonKho = new DevExpress.XtraEditors.SimpleButton();
            this.gcKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaocaoTonKho)).BeginInit();
            this.gcBaocaoTonKho.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBaocaoTonKho
            // 
            this.gcBaocaoTonKho.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcBaocaoTonKho.AppearanceCaption.Options.UseFont = true;
            this.gcBaocaoTonKho.AppearanceCaption.Options.UseTextOptions = true;
            this.gcBaocaoTonKho.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcBaocaoTonKho.Controls.Add(this.groupBox2);
            this.gcBaocaoTonKho.Controls.Add(this.gcKetQua);
            this.gcBaocaoTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBaocaoTonKho.Location = new System.Drawing.Point(0, 0);
            this.gcBaocaoTonKho.Name = "gcBaocaoTonKho";
            this.gcBaocaoTonKho.Size = new System.Drawing.Size(786, 475);
            this.gcBaocaoTonKho.TabIndex = 0;
            this.gcBaocaoTonKho.Text = "Báo Cáo Tồn Kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.deThoiGian);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(5, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thời gian";
            // 
            // deThoiGian
            // 
            this.deThoiGian.EditValue = null;
            this.deThoiGian.Location = new System.Drawing.Point(76, 17);
            this.deThoiGian.Name = "deThoiGian";
            this.deThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGian.Properties.Appearance.Options.UseFont = true;
            this.deThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGian.Size = new System.Drawing.Size(267, 24);
            this.deThoiGian.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.sbIn);
            this.groupBox1.Controls.Add(this.sbXemTonKho);
            this.groupBox1.Location = new System.Drawing.Point(495, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sbIn
            // 
            this.sbIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbIn.Appearance.Options.UseFont = true;
            this.sbIn.Location = new System.Drawing.Point(151, 14);
            this.sbIn.Name = "sbIn";
            this.sbIn.Size = new System.Drawing.Size(99, 23);
            this.sbIn.TabIndex = 1;
            this.sbIn.Text = "In";
            this.sbIn.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // sbXemTonKho
            // 
            this.sbXemTonKho.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXemTonKho.Appearance.Options.UseFont = true;
            this.sbXemTonKho.Location = new System.Drawing.Point(23, 14);
            this.sbXemTonKho.Name = "sbXemTonKho";
            this.sbXemTonKho.Size = new System.Drawing.Size(105, 23);
            this.sbXemTonKho.TabIndex = 0;
            this.sbXemTonKho.Text = "Xem tồn kho";
            this.sbXemTonKho.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcKetQua
            // 
            this.gcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKetQua.Location = new System.Drawing.Point(5, 113);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(770, 351);
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
            // ucBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcBaocaoTonKho);
            this.Name = "ucBaoCaoTonKho";
            this.Size = new System.Drawing.Size(786, 475);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaocaoTonKho)).EndInit();
            this.gcBaocaoTonKho.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcBaocaoTonKho;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deThoiGian;
        private DevExpress.XtraEditors.SimpleButton sbIn;
        private DevExpress.XtraEditors.SimpleButton sbXemTonKho;
    }
}
