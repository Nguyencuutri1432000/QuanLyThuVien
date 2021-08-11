namespace QuanLyThuVien
{
    partial class frmNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNXB));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colPulisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPulisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPulisherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_PPhone = new System.Windows.Forms.TextBox();
            this.txt_PulisherName = new System.Windows.Forms.TextBox();
            this.txt_PAddress = new System.Windows.Forms.TextBox();
            this.lbl_PulisherPhone = new System.Windows.Forms.Label();
            this.lbl_PulisherName = new System.Windows.Forms.Label();
            this.lbl_PulisherAddress = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rd_Phone = new System.Windows.Forms.RadioButton();
            this.rd_PulisherName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPulisherID,
            this.colPulisherName,
            this.colAddress,
            this.colPulisherPhone});
            this.dataGridView2.Location = new System.Drawing.Point(389, 134);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(508, 305);
            this.dataGridView2.TabIndex = 39;
            // 
            // colPulisherID
            // 
            this.colPulisherID.DataPropertyName = "MANXB";
            this.colPulisherID.HeaderText = "Mã Nhà Xuất Bản";
            this.colPulisherID.Name = "colPulisherID";
            this.colPulisherID.ReadOnly = true;
            this.colPulisherID.Width = 120;
            // 
            // colPulisherName
            // 
            this.colPulisherName.DataPropertyName = "TENNXB";
            this.colPulisherName.HeaderText = "Tên Nhà Xuất bản";
            this.colPulisherName.Name = "colPulisherName";
            this.colPulisherName.ReadOnly = true;
            this.colPulisherName.Width = 120;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "DCNXB";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colPulisherPhone
            // 
            this.colPulisherPhone.DataPropertyName = "DTNXB";
            this.colPulisherPhone.HeaderText = "Điện Thoại";
            this.colPulisherPhone.Name = "colPulisherPhone";
            this.colPulisherPhone.ReadOnly = true;
            this.colPulisherPhone.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_PPhone);
            this.groupBox1.Controls.Add(this.txt_PulisherName);
            this.groupBox1.Controls.Add(this.txt_PAddress);
            this.groupBox1.Controls.Add(this.lbl_PulisherPhone);
            this.groupBox1.Controls.Add(this.lbl_PulisherName);
            this.groupBox1.Controls.Add(this.lbl_PulisherAddress);
            this.groupBox1.Controls.Add(this.btnCancel2);
            this.groupBox1.Controls.Add(this.btnEdit2);
            this.groupBox1.Controls.Add(this.btnDelete2);
            this.groupBox1.Controls.Add(this.btnAdd2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 427);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tác giả";
            // 
            // txt_PPhone
            // 
            this.txt_PPhone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PPhone.Location = new System.Drawing.Point(182, 136);
            this.txt_PPhone.Name = "txt_PPhone";
            this.txt_PPhone.Size = new System.Drawing.Size(144, 22);
            this.txt_PPhone.TabIndex = 55;
            // 
            // txt_PulisherName
            // 
            this.txt_PulisherName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PulisherName.Location = new System.Drawing.Point(182, 62);
            this.txt_PulisherName.Name = "txt_PulisherName";
            this.txt_PulisherName.Size = new System.Drawing.Size(144, 22);
            this.txt_PulisherName.TabIndex = 56;
            // 
            // txt_PAddress
            // 
            this.txt_PAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PAddress.Location = new System.Drawing.Point(182, 100);
            this.txt_PAddress.Name = "txt_PAddress";
            this.txt_PAddress.Size = new System.Drawing.Size(144, 22);
            this.txt_PAddress.TabIndex = 57;
            // 
            // lbl_PulisherPhone
            // 
            this.lbl_PulisherPhone.AutoSize = true;
            this.lbl_PulisherPhone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PulisherPhone.ForeColor = System.Drawing.Color.Black;
            this.lbl_PulisherPhone.Location = new System.Drawing.Point(46, 136);
            this.lbl_PulisherPhone.Name = "lbl_PulisherPhone";
            this.lbl_PulisherPhone.Size = new System.Drawing.Size(67, 15);
            this.lbl_PulisherPhone.TabIndex = 52;
            this.lbl_PulisherPhone.Text = "Điện thoại:";
            // 
            // lbl_PulisherName
            // 
            this.lbl_PulisherName.AutoSize = true;
            this.lbl_PulisherName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PulisherName.ForeColor = System.Drawing.Color.Black;
            this.lbl_PulisherName.Location = new System.Drawing.Point(46, 62);
            this.lbl_PulisherName.Name = "lbl_PulisherName";
            this.lbl_PulisherName.Size = new System.Drawing.Size(103, 15);
            this.lbl_PulisherName.TabIndex = 53;
            this.lbl_PulisherName.Text = "Tên nhà xuất bản:";
            // 
            // lbl_PulisherAddress
            // 
            this.lbl_PulisherAddress.AutoSize = true;
            this.lbl_PulisherAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PulisherAddress.ForeColor = System.Drawing.Color.Black;
            this.lbl_PulisherAddress.Location = new System.Drawing.Point(46, 100);
            this.lbl_PulisherAddress.Name = "lbl_PulisherAddress";
            this.lbl_PulisherAddress.Size = new System.Drawing.Size(50, 15);
            this.lbl_PulisherAddress.TabIndex = 54;
            this.lbl_PulisherAddress.Text = "Địa chỉ:";
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.White;
            this.btnCancel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel2.Image")));
            this.btnCancel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel2.Location = new System.Drawing.Point(208, 270);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(89, 40);
            this.btnCancel2.TabIndex = 51;
            this.btnCancel2.Text = "Tạo Mới";
            this.btnCancel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click_1);
            // 
            // btnEdit2
            // 
            this.btnEdit2.BackColor = System.Drawing.Color.White;
            this.btnEdit2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit2.ForeColor = System.Drawing.Color.Black;
            this.btnEdit2.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit2.Image")));
            this.btnEdit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit2.Location = new System.Drawing.Point(208, 200);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(89, 42);
            this.btnEdit2.TabIndex = 45;
            this.btnEdit2.Text = "Sửa";
            this.btnEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit2.UseVisualStyleBackColor = false;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click_1);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.White;
            this.btnDelete2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.ForeColor = System.Drawing.Color.Black;
            this.btnDelete2.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete2.Image")));
            this.btnDelete2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete2.Location = new System.Drawing.Point(83, 267);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(75, 43);
            this.btnDelete2.TabIndex = 46;
            this.btnDelete2.Text = "Xóa";
            this.btnDelete2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click_1);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.White;
            this.btnAdd2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd2.Image")));
            this.btnAdd2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd2.Location = new System.Drawing.Point(83, 199);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 43);
            this.btnAdd2.TabIndex = 47;
            this.btnAdd2.Text = "Thêm";
            this.btnAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Controls.Add(this.rd_Phone);
            this.groupBox2.Controls.Add(this.rd_PulisherName);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(389, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 116);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 36;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(333, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 29);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(85, 56);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(242, 22);
            this.txt_Search.TabIndex = 34;
            // 
            // rd_Phone
            // 
            this.rd_Phone.AutoSize = true;
            this.rd_Phone.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Phone.ForeColor = System.Drawing.Color.Black;
            this.rd_Phone.Location = new System.Drawing.Point(286, 27);
            this.rd_Phone.Name = "rd_Phone";
            this.rd_Phone.Size = new System.Drawing.Size(153, 19);
            this.rd_Phone.TabIndex = 33;
            this.rd_Phone.Text = "Tìm theo Số Điện Thoại";
            this.rd_Phone.UseVisualStyleBackColor = true;
            // 
            // rd_PulisherName
            // 
            this.rd_PulisherName.AutoSize = true;
            this.rd_PulisherName.Checked = true;
            this.rd_PulisherName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_PulisherName.ForeColor = System.Drawing.Color.Black;
            this.rd_PulisherName.Location = new System.Drawing.Point(85, 27);
            this.rd_PulisherName.Name = "rd_PulisherName";
            this.rd_PulisherName.Size = new System.Drawing.Size(176, 19);
            this.rd_PulisherName.TabIndex = 32;
            this.rd_PulisherName.TabStop = true;
            this.rd_PulisherName.Text = "Tìm theo Tên Nhà Xuất Bản";
            this.rd_PulisherName.UseVisualStyleBackColor = true;
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhà xuất bản";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPulisherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPulisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPulisherPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_PPhone;
        private System.Windows.Forms.TextBox txt_PulisherName;
        private System.Windows.Forms.TextBox txt_PAddress;
        private System.Windows.Forms.Label lbl_PulisherPhone;
        private System.Windows.Forms.Label lbl_PulisherName;
        private System.Windows.Forms.Label lbl_PulisherAddress;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rd_Phone;
        private System.Windows.Forms.RadioButton rd_PulisherName;

    }
}