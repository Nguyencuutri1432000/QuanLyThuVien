namespace QuanLyThuVien
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTKSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTKSYEAR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTraQuaHan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinToolStripMenuItem,
            this.quảnLýMượnTrảSáchToolStripMenuItem,
            this.traCứuThốngKêToolStripMenuItem,
            this.tsDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSach,
            this.tsLoai,
            this.tsDocGia,
            this.tsTacGia,
            this.tsNXB,
            this.tsTaiKhoan});
            this.quảnLýThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýThôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýThôngTinToolStripMenuItem.Image")));
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản Lý Thông Tin";
            // 
            // tsSach
            // 
            this.tsSach.Name = "tsSach";
            this.tsSach.Size = new System.Drawing.Size(184, 22);
            this.tsSach.Text = "Thông tin sách";
            this.tsSach.Click += new System.EventHandler(this.tsSach_Click);
            // 
            // tsLoai
            // 
            this.tsLoai.Name = "tsLoai";
            this.tsLoai.Size = new System.Drawing.Size(184, 22);
            this.tsLoai.Text = "Thông tin loại sách";
            this.tsLoai.Click += new System.EventHandler(this.tsLoai_Click);
            // 
            // tsDocGia
            // 
            this.tsDocGia.Name = "tsDocGia";
            this.tsDocGia.Size = new System.Drawing.Size(184, 22);
            this.tsDocGia.Text = "Thông tin độc giả";
            this.tsDocGia.Click += new System.EventHandler(this.tsDocGia_Click);
            // 
            // tsTacGia
            // 
            this.tsTacGia.Name = "tsTacGia";
            this.tsTacGia.Size = new System.Drawing.Size(184, 22);
            this.tsTacGia.Text = "Thông tin tác giả";
            this.tsTacGia.Click += new System.EventHandler(this.tsTacGia_Click);
            // 
            // tsNXB
            // 
            this.tsNXB.Name = "tsNXB";
            this.tsNXB.Size = new System.Drawing.Size(184, 22);
            this.tsNXB.Text = "Thông tin nhà xuất bản";
            this.tsNXB.Click += new System.EventHandler(this.tsNXB_Click);
            // 
            // tsTaiKhoan
            // 
            this.tsTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDoiMK,
            this.tsCreateAccount});
            this.tsTaiKhoan.Name = "tsTaiKhoan";
            this.tsTaiKhoan.Size = new System.Drawing.Size(184, 22);
            this.tsTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.tsTaiKhoan.Click += new System.EventHandler(this.tsTaiKhoan_Click);
            // 
            // tsDoiMK
            // 
            this.tsDoiMK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDoiMK.Name = "tsDoiMK";
            this.tsDoiMK.Size = new System.Drawing.Size(156, 22);
            this.tsDoiMK.Text = "Đổi Mật Khẩu";
            this.tsDoiMK.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // tsCreateAccount
            // 
            this.tsCreateAccount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCreateAccount.Name = "tsCreateAccount";
            this.tsCreateAccount.Size = new System.Drawing.Size(156, 22);
            this.tsCreateAccount.Text = "Thêm Tài Khoản";
            this.tsCreateAccount.Click += new System.EventHandler(this.thêmTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảSáchToolStripMenuItem
            // 
            this.quảnLýMượnTrảSáchToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýMượnTrảSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýMượnTrảSáchToolStripMenuItem.Image")));
            this.quảnLýMượnTrảSáchToolStripMenuItem.Name = "quảnLýMượnTrảSáchToolStripMenuItem";
            this.quảnLýMượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.quảnLýMượnTrảSáchToolStripMenuItem.Text = "Quản Lý Mượn - Trả Sách";
            this.quảnLýMượnTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảSáchToolStripMenuItem_Click);
            // 
            // traCứuThốngKêToolStripMenuItem
            // 
            this.traCứuThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTKSach,
            this.tsTKSYEAR,
            this.tsMuon,
            this.tsTra,
            this.tsTraQuaHan});
            this.traCứuThốngKêToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuThốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("traCứuThốngKêToolStripMenuItem.Image")));
            this.traCứuThốngKêToolStripMenuItem.Name = "traCứuThốngKêToolStripMenuItem";
            this.traCứuThốngKêToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.traCứuThốngKêToolStripMenuItem.Text = "Tra cứu - Thống kê";
            // 
            // tsTKSach
            // 
            this.tsTKSach.Name = "tsTKSach";
            this.tsTKSach.Size = new System.Drawing.Size(249, 22);
            this.tsTKSach.Text = "Thống kê thông tin sách";
            this.tsTKSach.Click += new System.EventHandler(this.tsTKSach_Click);
            // 
            // tsTKSYEAR
            // 
            this.tsTKSYEAR.Name = "tsTKSYEAR";
            this.tsTKSYEAR.Size = new System.Drawing.Size(249, 22);
            this.tsTKSYEAR.Text = "Thống kê danh sách độc giả";
            this.tsTKSYEAR.Click += new System.EventHandler(this.tsTKSYEAR_Click);
            // 
            // tsDangXuat
            // 
            this.tsDangXuat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsDangXuat.Image")));
            this.tsDangXuat.Name = "tsDangXuat";
            this.tsDangXuat.Size = new System.Drawing.Size(87, 20);
            this.tsDangXuat.Text = "Đăng Xuất";
            this.tsDangXuat.Click += new System.EventHandler(this.tsDangXuat_Click);
            // 
            // tsMuon
            // 
            this.tsMuon.Name = "tsMuon";
            this.tsMuon.Size = new System.Drawing.Size(249, 22);
            this.tsMuon.Text = "Thống kê danh sách mượn";
            this.tsMuon.Click += new System.EventHandler(this.thốngKêDanhSáchMượnToolStripMenuItem_Click);
            // 
            // tsTra
            // 
            this.tsTra.Name = "tsTra";
            this.tsTra.Size = new System.Drawing.Size(249, 22);
            this.tsTra.Text = "Thống kê danh sách trả";
            this.tsTra.Click += new System.EventHandler(this.thốngKêDanhSáchTrảToolStripMenuItem_Click);
            // 
            // tsTraQuaHan
            // 
            this.tsTraQuaHan.Name = "tsTraQuaHan";
            this.tsTraQuaHan.Size = new System.Drawing.Size(249, 22);
            this.tsTraQuaHan.Text = "Thống kê danh sách trả sách quá hạn";
            this.tsTraQuaHan.Click += new System.EventHandler(this.thốngKêDanhSáchTrảSáchQuáHạnToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 636);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ SÁCH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSach;
        private System.Windows.Forms.ToolStripMenuItem tsLoai;
        private System.Windows.Forms.ToolStripMenuItem tsDocGia;
        private System.Windows.Forms.ToolStripMenuItem tsTacGia;
        private System.Windows.Forms.ToolStripMenuItem tsNXB;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tsTKSach;
        private System.Windows.Forms.ToolStripMenuItem tsTKSYEAR;
        private System.Windows.Forms.ToolStripMenuItem tsDoiMK;
        private System.Windows.Forms.ToolStripMenuItem tsCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem tsMuon;
        private System.Windows.Forms.ToolStripMenuItem tsTra;
        private System.Windows.Forms.ToolStripMenuItem tsTraQuaHan;
    }
}