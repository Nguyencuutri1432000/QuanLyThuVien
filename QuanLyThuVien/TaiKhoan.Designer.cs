namespace QuanLyThuVien
{
    partial class TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.lbl_NewPass = new System.Windows.Forms.Label();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmPass = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_Usename = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(67, 156);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(43, 15);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Họ tên";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(205, 153);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(205, 194);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(216, 20);
            this.txt_Pass.TabIndex = 3;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(67, 197);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(100, 15);
            this.lbl_Pass.TabIndex = 2;
            this.lbl_Pass.Text = "Mật khẩu hiện tại";
            // 
            // txt_newPass
            // 
            this.txt_newPass.Location = new System.Drawing.Point(205, 233);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(216, 20);
            this.txt_newPass.TabIndex = 5;
            // 
            // lbl_NewPass
            // 
            this.lbl_NewPass.AutoSize = true;
            this.lbl_NewPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPass.Location = new System.Drawing.Point(67, 236);
            this.lbl_NewPass.Name = "lbl_NewPass";
            this.lbl_NewPass.Size = new System.Drawing.Size(80, 15);
            this.lbl_NewPass.TabIndex = 4;
            this.lbl_NewPass.Text = "Mật khẩu mới";
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Location = new System.Drawing.Point(205, 275);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.Size = new System.Drawing.Size(216, 20);
            this.txt_Confirm.TabIndex = 7;
            // 
            // lbl_ConfirmPass
            // 
            this.lbl_ConfirmPass.AutoSize = true;
            this.lbl_ConfirmPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmPass.Location = new System.Drawing.Point(67, 278);
            this.lbl_ConfirmPass.Name = "lbl_ConfirmPass";
            this.lbl_ConfirmPass.Size = new System.Drawing.Size(124, 15);
            this.lbl_ConfirmPass.TabIndex = 6;
            this.lbl_ConfirmPass.Text = "Nhập lại mật khẩu mới";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(330, 325);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(70, 36);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(224, 325);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 36);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(205, 114);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(216, 20);
            this.txt_User.TabIndex = 28;
            // 
            // lbl_Usename
            // 
            this.lbl_Usename.AutoSize = true;
            this.lbl_Usename.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usename.Location = new System.Drawing.Point(67, 121);
            this.lbl_Usename.Name = "lbl_Usename";
            this.lbl_Usename.Size = new System.Drawing.Size(60, 15);
            this.lbl_Usename.TabIndex = 27;
            this.lbl_Usename.Text = "Tài khoản";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(205, 78);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(216, 20);
            this.txt_ID.TabIndex = 30;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(67, 81);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(20, 15);
            this.lbl_ID.TabIndex = 29;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(190, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 31);
            this.lbl_title.TabIndex = 31;
            this.lbl_title.Text = "TÀI KHOẢN";
            this.lbl_title.Click += new System.EventHandler(this.label25_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_Usename);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Confirm);
            this.Controls.Add(this.lbl_ConfirmPass);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.lbl_NewPass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.Label lbl_NewPass;
        private System.Windows.Forms.TextBox txt_Confirm;
        private System.Windows.Forms.Label lbl_ConfirmPass;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_Usename;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_title;
    }
}