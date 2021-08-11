namespace QuanLyThuVien
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.txt_useName = new System.Windows.Forms.TextBox();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_rePass = new System.Windows.Forms.TextBox();
            this.lbl_NhapLaiMK = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_useName
            // 
            this.txt_useName.Location = new System.Drawing.Point(237, 74);
            this.txt_useName.Name = "txt_useName";
            this.txt_useName.Size = new System.Drawing.Size(216, 20);
            this.txt_useName.TabIndex = 32;
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TK.Location = new System.Drawing.Point(99, 81);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(60, 15);
            this.lbl_TK.TabIndex = 31;
            this.lbl_TK.Text = "Tài khoản";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(237, 113);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 20);
            this.txt_Name.TabIndex = 30;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(99, 116);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(43, 15);
            this.lbl_HoTen.TabIndex = 29;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(211, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(235, 31);
            this.lbl_title.TabIndex = 33;
            this.lbl_title.Text = "TẠO TÀI KHOẢN";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(251, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Lưu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(362, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 38;
            this.button4.Text = "Đóng";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_rePass
            // 
            this.txt_rePass.Location = new System.Drawing.Point(237, 195);
            this.txt_rePass.Name = "txt_rePass";
            this.txt_rePass.PasswordChar = '*';
            this.txt_rePass.Size = new System.Drawing.Size(216, 20);
            this.txt_rePass.TabIndex = 37;
            this.txt_rePass.TextChanged += new System.EventHandler(this.txt_rePass_TextChanged);
            this.txt_rePass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rePass_KeyPress);
            // 
            // lbl_NhapLaiMK
            // 
            this.lbl_NhapLaiMK.AutoSize = true;
            this.lbl_NhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhapLaiMK.Location = new System.Drawing.Point(99, 198);
            this.lbl_NhapLaiMK.Name = "lbl_NhapLaiMK";
            this.lbl_NhapLaiMK.Size = new System.Drawing.Size(124, 15);
            this.lbl_NhapLaiMK.TabIndex = 36;
            this.lbl_NhapLaiMK.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(237, 153);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(216, 20);
            this.txt_Pass.TabIndex = 35;
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MK.Location = new System.Drawing.Point(99, 156);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(80, 15);
            this.lbl_MK.TabIndex = 34;
            this.lbl_MK.Text = "Mật khẩu mới";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(592, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_rePass);
            this.Controls.Add(this.lbl_NhapLaiMK);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_MK);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_useName);
            this.Controls.Add(this.lbl_TK);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_HoTen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangKy_FormClosing);
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_useName;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_rePass;
        private System.Windows.Forms.Label lbl_NhapLaiMK;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label lbl_MK;
    }
}