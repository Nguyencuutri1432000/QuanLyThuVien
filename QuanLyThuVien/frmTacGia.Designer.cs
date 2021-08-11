namespace QuanLyThuVien
{
    partial class frmTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.colAuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_AuthorName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.btnEdit3 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.lbl_AuthorName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rd_AuthorID = new System.Windows.Forms.RadioButton();
            this.rd_AuthorName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthorID,
            this.colAuthorName1,
            this.colAuthorAddress});
            this.dataGridView3.Location = new System.Drawing.Point(412, 145);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(444, 308);
            this.dataGridView3.TabIndex = 32;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // colAuthorID
            // 
            this.colAuthorID.DataPropertyName = "MATG";
            this.colAuthorID.HeaderText = "Mã Tác Giả";
            this.colAuthorID.Name = "colAuthorID";
            this.colAuthorID.ReadOnly = true;
            // 
            // colAuthorName1
            // 
            this.colAuthorName1.DataPropertyName = "TENTG";
            this.colAuthorName1.HeaderText = "Tên Tác Giả";
            this.colAuthorName1.Name = "colAuthorName1";
            this.colAuthorName1.ReadOnly = true;
            // 
            // colAuthorAddress
            // 
            this.colAuthorAddress.DataPropertyName = "DIACHI";
            this.colAuthorAddress.HeaderText = "Địa chỉ";
            this.colAuthorAddress.Name = "colAuthorAddress";
            this.colAuthorAddress.ReadOnly = true;
            this.colAuthorAddress.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnCancel3);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_AuthorName);
            this.groupBox1.Controls.Add(this.lbl_Address);
            this.groupBox1.Controls.Add(this.btnEdit3);
            this.groupBox1.Controls.Add(this.btnDelete3);
            this.groupBox1.Controls.Add(this.btnAdd3);
            this.groupBox1.Controls.Add(this.lbl_AuthorName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 430);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tác giả";
            // 
            // btnCancel3
            // 
            this.btnCancel3.BackColor = System.Drawing.Color.White;
            this.btnCancel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel3.ForeColor = System.Drawing.Color.Black;
            this.btnCancel3.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel3.Image")));
            this.btnCancel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel3.Location = new System.Drawing.Point(250, 290);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(89, 40);
            this.btnCancel3.TabIndex = 51;
            this.btnCancel3.Text = "Tạo Mới";
            this.btnCancel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel3.UseVisualStyleBackColor = false;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click_1);
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(149, 143);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(181, 22);
            this.txt_Address.TabIndex = 50;
            // 
            // txt_AuthorName
            // 
            this.txt_AuthorName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AuthorName.Location = new System.Drawing.Point(149, 77);
            this.txt_AuthorName.Name = "txt_AuthorName";
            this.txt_AuthorName.Size = new System.Drawing.Size(181, 22);
            this.txt_AuthorName.TabIndex = 48;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Address.Location = new System.Drawing.Point(31, 134);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(50, 15);
            this.lbl_Address.TabIndex = 49;
            this.lbl_Address.Text = "Địa chỉ:";
            // 
            // btnEdit3
            // 
            this.btnEdit3.BackColor = System.Drawing.Color.White;
            this.btnEdit3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit3.ForeColor = System.Drawing.Color.Black;
            this.btnEdit3.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit3.Image")));
            this.btnEdit3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit3.Location = new System.Drawing.Point(250, 220);
            this.btnEdit3.Name = "btnEdit3";
            this.btnEdit3.Size = new System.Drawing.Size(89, 42);
            this.btnEdit3.TabIndex = 45;
            this.btnEdit3.Text = "Sửa";
            this.btnEdit3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit3.UseVisualStyleBackColor = false;
            this.btnEdit3.Click += new System.EventHandler(this.btnEdit3_Click_1);
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.Color.White;
            this.btnDelete3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete3.ForeColor = System.Drawing.Color.Black;
            this.btnDelete3.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete3.Image")));
            this.btnDelete3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete3.Location = new System.Drawing.Point(149, 287);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(75, 43);
            this.btnDelete3.TabIndex = 46;
            this.btnDelete3.Text = "Xóa";
            this.btnDelete3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete3.UseVisualStyleBackColor = false;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click_1);
            // 
            // btnAdd3
            // 
            this.btnAdd3.BackColor = System.Drawing.Color.White;
            this.btnAdd3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd3.ForeColor = System.Drawing.Color.Black;
            this.btnAdd3.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd3.Image")));
            this.btnAdd3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd3.Location = new System.Drawing.Point(149, 219);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(75, 43);
            this.btnAdd3.TabIndex = 47;
            this.btnAdd3.Text = "Thêm";
            this.btnAdd3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd3.UseVisualStyleBackColor = false;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // lbl_AuthorName
            // 
            this.lbl_AuthorName.AutoSize = true;
            this.lbl_AuthorName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AuthorName.ForeColor = System.Drawing.Color.Black;
            this.lbl_AuthorName.Location = new System.Drawing.Point(31, 77);
            this.lbl_AuthorName.Name = "lbl_AuthorName";
            this.lbl_AuthorName.Size = new System.Drawing.Size(71, 15);
            this.lbl_AuthorName.TabIndex = 44;
            this.lbl_AuthorName.Text = "Tên tác giả:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Controls.Add(this.rd_AuthorID);
            this.groupBox2.Controls.Add(this.rd_AuthorName);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(412, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 116);
            this.groupBox2.TabIndex = 34;
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
            this.btnSearch.Location = new System.Drawing.Point(292, 53);
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
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(85, 56);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(201, 26);
            this.txt_Search.TabIndex = 34;
            // 
            // rd_AuthorID
            // 
            this.rd_AuthorID.AutoSize = true;
            this.rd_AuthorID.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_AuthorID.ForeColor = System.Drawing.Color.Black;
            this.rd_AuthorID.Location = new System.Drawing.Point(239, 27);
            this.rd_AuthorID.Name = "rd_AuthorID";
            this.rd_AuthorID.Size = new System.Drawing.Size(138, 19);
            this.rd_AuthorID.TabIndex = 33;
            this.rd_AuthorID.Text = "Tìm theo Mã Tác Giả\r\n";
            this.rd_AuthorID.UseVisualStyleBackColor = true;
            // 
            // rd_AuthorName
            // 
            this.rd_AuthorName.AutoSize = true;
            this.rd_AuthorName.Checked = true;
            this.rd_AuthorName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_AuthorName.ForeColor = System.Drawing.Color.Black;
            this.rd_AuthorName.Location = new System.Drawing.Point(85, 27);
            this.rd_AuthorName.Name = "rd_AuthorName";
            this.rd_AuthorName.Size = new System.Drawing.Size(142, 19);
            this.rd_AuthorName.TabIndex = 32;
            this.rd_AuthorName.TabStop = true;
            this.rd_AuthorName.Text = "Tìm theo Tên Tác Giả";
            this.rd_AuthorName.UseVisualStyleBackColor = true;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin tác giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_AuthorName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Button btnEdit3;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Label lbl_AuthorName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rd_AuthorID;
        private System.Windows.Forms.RadioButton rd_AuthorName;
    }
}