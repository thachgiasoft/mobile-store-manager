namespace QL_Ban_DienThoai
{
    partial class FormDangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teTenDN = new DevExpress.XtraEditors.TextEdit();
            this.teMK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lcKetQuaDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(30, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Tài Khoản";
            // 
            // teTenDN
            // 
            this.teTenDN.Location = new System.Drawing.Point(130, 68);
            this.teTenDN.Name = "teTenDN";
            this.teTenDN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenDN.Properties.Appearance.Options.UseFont = true;
            this.teTenDN.Properties.MaxLength = 20;
            this.teTenDN.Size = new System.Drawing.Size(270, 28);
            this.teTenDN.TabIndex = 1;
            this.teTenDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teTenDN_KeyPress);
            // 
            // teMK
            // 
            this.teMK.Location = new System.Drawing.Point(130, 106);
            this.teMK.Name = "teMK";
            this.teMK.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMK.Properties.Appearance.Options.UseFont = true;
            this.teMK.Properties.MaxLength = 20;
            this.teMK.Properties.PasswordChar = '*';
            this.teMK.Size = new System.Drawing.Size(270, 28);
            this.teMK.TabIndex = 2;
            this.teMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teMK_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(30, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(332, 161);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 32);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(216, 161);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(110, 32);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Đăng Nhập";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(81, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(259, 37);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Đăng Nhập Hệ Thống";
            // 
            // lcKetQuaDangNhap
            // 
            this.lcKetQuaDangNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcKetQuaDangNhap.Location = new System.Drawing.Point(130, 138);
            this.lcKetQuaDangNhap.Name = "lcKetQuaDangNhap";
            this.lcKetQuaDangNhap.Size = new System.Drawing.Size(0, 17);
            this.lcKetQuaDangNhap.TabIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(216, 199);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(212, 32);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Đăng Nhập Với Quyền Khách";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 238);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.lcKetQuaDangNhap);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.teMK);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teTenDN);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDangNhap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.teTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teTenDN;
        private DevExpress.XtraEditors.TextEdit teMK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lcKetQuaDangNhap;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}