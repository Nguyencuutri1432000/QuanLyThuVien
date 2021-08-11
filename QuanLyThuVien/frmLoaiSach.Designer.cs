namespace QuanLyThuVien
{
    partial class frmLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSach));
            this.txt_BookType = new System.Windows.Forms.TextBox();
            this.lbl_BookType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.btnEdit4 = new System.Windows.Forms.Button();
            this.btnDelete4 = new System.Windows.Forms.Button();
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.colTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BookType
            // 
            this.txt_BookType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookType.Location = new System.Drawing.Point(256, 34);
            this.txt_BookType.Name = "txt_BookType";
            this.txt_BookType.Size = new System.Drawing.Size(137, 22);
            this.txt_BookType.TabIndex = 31;
            // 
            // lbl_BookType
            // 
            this.lbl_BookType.AutoSize = true;
            this.lbl_BookType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookType.ForeColor = System.Drawing.Color.Black;
            this.lbl_BookType.Location = new System.Drawing.Point(149, 34);
            this.lbl_BookType.Name = "lbl_BookType";
            this.lbl_BookType.Size = new System.Drawing.Size(83, 15);
            this.lbl_BookType.TabIndex = 30;
            this.lbl_BookType.Text = "Tên loại sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnCancel4);
            this.groupBox1.Controls.Add(this.btnEdit4);
            this.groupBox1.Controls.Add(this.btnDelete4);
            this.groupBox1.Controls.Add(this.btnAdd4);
            this.groupBox1.Controls.Add(this.lbl_BookType);
            this.groupBox1.Controls.Add(this.txt_BookType);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 134);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tác giả";
            // 
            // btnCancel4
            // 
            this.btnCancel4.BackColor = System.Drawing.Color.White;
            this.btnCancel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel4.ForeColor = System.Drawing.Color.Black;
            this.btnCancel4.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel4.Image")));
            this.btnCancel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel4.Location = new System.Drawing.Point(411, 79);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(89, 40);
            this.btnCancel4.TabIndex = 51;
            this.btnCancel4.Text = "Tạo Mới";
            this.btnCancel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel4.UseVisualStyleBackColor = false;
            this.btnCancel4.Click += new System.EventHandler(this.btnCancel4_Click_1);
            // 
            // btnEdit4
            // 
            this.btnEdit4.BackColor = System.Drawing.Color.White;
            this.btnEdit4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit4.ForeColor = System.Drawing.Color.Black;
            this.btnEdit4.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit4.Image")));
            this.btnEdit4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit4.Location = new System.Drawing.Point(184, 76);
            this.btnEdit4.Name = "btnEdit4";
            this.btnEdit4.Size = new System.Drawing.Size(81, 42);
            this.btnEdit4.TabIndex = 45;
            this.btnEdit4.Text = "Sửa";
            this.btnEdit4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit4.UseVisualStyleBackColor = false;
            this.btnEdit4.Click += new System.EventHandler(this.btnEdit4_Click_1);
            // 
            // btnDelete4
            // 
            this.btnDelete4.BackColor = System.Drawing.Color.White;
            this.btnDelete4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete4.ForeColor = System.Drawing.Color.Black;
            this.btnDelete4.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete4.Image")));
            this.btnDelete4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete4.Location = new System.Drawing.Point(302, 76);
            this.btnDelete4.Name = "btnDelete4";
            this.btnDelete4.Size = new System.Drawing.Size(75, 43);
            this.btnDelete4.TabIndex = 46;
            this.btnDelete4.Text = "Xóa";
            this.btnDelete4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete4.UseVisualStyleBackColor = false;
            this.btnDelete4.Click += new System.EventHandler(this.btnDelete4_Click_1);
            // 
            // btnAdd4
            // 
            this.btnAdd4.BackColor = System.Drawing.Color.White;
            this.btnAdd4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd4.ForeColor = System.Drawing.Color.Black;
            this.btnAdd4.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd4.Image")));
            this.btnAdd4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd4.Location = new System.Drawing.Point(79, 75);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(75, 43);
            this.btnAdd4.TabIndex = 47;
            this.btnAdd4.Text = "Thêm";
            this.btnAdd4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd4.UseVisualStyleBackColor = false;
            this.btnAdd4.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTypeID,
            this.colBookType});
            this.dataGridView4.Location = new System.Drawing.Point(3, 152);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(529, 219);
            this.dataGridView4.TabIndex = 37;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // colTypeID
            // 
            this.colTypeID.DataPropertyName = "MALOAI";
            this.colTypeID.HeaderText = "Mã loại sách";
            this.colTypeID.Name = "colTypeID";
            this.colTypeID.ReadOnly = true;
            // 
            // colBookType
            // 
            this.colBookType.DataPropertyName = "TENLOAI";
            this.colBookType.HeaderText = "Tên loại sách";
            this.colBookType.Name = "colBookType";
            this.colBookType.ReadOnly = true;
            this.colBookType.Width = 500;
            // 
            // frmLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 378);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý loại sách";
            this.Load += new System.EventHandler(this.frmLoaiSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BookType;
        private System.Windows.Forms.Label lbl_BookType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel4;
        private System.Windows.Forms.Button btnEdit4;
        private System.Windows.Forms.Button btnDelete4;
        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookType;
    }
}