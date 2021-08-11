namespace QuanLyThuVien
{
    partial class frmMuonTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTraSach));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colReaderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_MuonTra = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rd_Sach = new System.Windows.Forms.RadioButton();
            this.rd_DocGia = new System.Windows.Forms.RadioButton();
            this.Groupbox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LanMuon = new System.Windows.Forms.TextBox();
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_Tra = new System.Windows.Forms.Button();
            this.btn_GiaHan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbo_Book = new System.Windows.Forms.ComboBox();
            this.cbo_Author = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_ReturnDate = new System.Windows.Forms.Label();
            this.lbl_BorrowingDate = new System.Windows.Forms.Label();
            this.lbl_Book = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReaderCode,
            this.colBookCode,
            this.colBorrowedDate,
            this.colReturnDate,
            this.Column2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(314, 188);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 365);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // colReaderCode
            // 
            this.colReaderCode.DataPropertyName = "MADG";
            this.colReaderCode.HeaderText = "Mã Độc Giả";
            this.colReaderCode.Name = "colReaderCode";
            this.colReaderCode.ReadOnly = true;
            // 
            // colBookCode
            // 
            this.colBookCode.DataPropertyName = "MASH";
            this.colBookCode.HeaderText = "Mã Sách";
            this.colBookCode.Name = "colBookCode";
            this.colBookCode.ReadOnly = true;
            // 
            // colBorrowedDate
            // 
            this.colBorrowedDate.DataPropertyName = "NGAYMUON";
            this.colBorrowedDate.HeaderText = "Ngày Mượn";
            this.colBorrowedDate.Name = "colBorrowedDate";
            this.colBorrowedDate.ReadOnly = true;
            this.colBorrowedDate.Width = 150;
            // 
            // colReturnDate
            // 
            this.colReturnDate.DataPropertyName = "NGAYTRA";
            this.colReturnDate.HeaderText = "Ngày trả";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DATRA";
            this.Column2.HeaderText = "Đã  trả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LANMUON";
            this.Column1.HeaderText = "Lần mượn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // comboBox_MuonTra
            // 
            this.comboBox_MuonTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MuonTra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MuonTra.FormattingEnabled = true;
            this.comboBox_MuonTra.Location = new System.Drawing.Point(171, 117);
            this.comboBox_MuonTra.Name = "comboBox_MuonTra";
            this.comboBox_MuonTra.Size = new System.Drawing.Size(253, 23);
            this.comboBox_MuonTra.TabIndex = 31;
            this.comboBox_MuonTra.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.comboBox_MuonTra);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.rd_Sach);
            this.groupBox1.Controls.Add(this.rd_DocGia);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(314, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 170);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lọc theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(308, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 34);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(101, 65);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(201, 29);
            this.txt_Search.TabIndex = 37;
            // 
            // rd_Sach
            // 
            this.rd_Sach.AutoSize = true;
            this.rd_Sach.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Sach.ForeColor = System.Drawing.Color.Black;
            this.rd_Sach.Location = new System.Drawing.Point(297, 33);
            this.rd_Sach.Name = "rd_Sach";
            this.rd_Sach.Size = new System.Drawing.Size(127, 19);
            this.rd_Sach.TabIndex = 1;
            this.rd_Sach.Text = "Tìm theo Tên Sách";
            this.rd_Sach.UseVisualStyleBackColor = true;
            // 
            // rd_DocGia
            // 
            this.rd_DocGia.AutoSize = true;
            this.rd_DocGia.Checked = true;
            this.rd_DocGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_DocGia.ForeColor = System.Drawing.Color.Black;
            this.rd_DocGia.Location = new System.Drawing.Point(101, 33);
            this.rd_DocGia.Name = "rd_DocGia";
            this.rd_DocGia.Size = new System.Drawing.Size(143, 19);
            this.rd_DocGia.TabIndex = 0;
            this.rd_DocGia.TabStop = true;
            this.rd_DocGia.Text = "Tìm theo Tên Độc Giả";
            this.rd_DocGia.UseVisualStyleBackColor = true;
            // 
            // Groupbox2
            // 
            this.Groupbox2.BackColor = System.Drawing.Color.White;
            this.Groupbox2.Controls.Add(this.label2);
            this.Groupbox2.Controls.Add(this.txt_LanMuon);
            this.Groupbox2.Controls.Add(this.btn_In);
            this.Groupbox2.Controls.Add(this.btn_Tra);
            this.Groupbox2.Controls.Add(this.btn_GiaHan);
            this.Groupbox2.Controls.Add(this.btnCancel);
            this.Groupbox2.Controls.Add(this.btnEdit);
            this.Groupbox2.Controls.Add(this.btnDelete);
            this.Groupbox2.Controls.Add(this.btnAdd);
            this.Groupbox2.Controls.Add(this.cbo_Book);
            this.Groupbox2.Controls.Add(this.cbo_Author);
            this.Groupbox2.Controls.Add(this.dateTimePicker2);
            this.Groupbox2.Controls.Add(this.dateTimePicker1);
            this.Groupbox2.Controls.Add(this.lbl_ReturnDate);
            this.Groupbox2.Controls.Add(this.lbl_BorrowingDate);
            this.Groupbox2.Controls.Add(this.lbl_Book);
            this.Groupbox2.Controls.Add(this.lbl_Author);
            this.Groupbox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupbox2.ForeColor = System.Drawing.Color.Red;
            this.Groupbox2.Location = new System.Drawing.Point(3, 12);
            this.Groupbox2.Name = "Groupbox2";
            this.Groupbox2.Size = new System.Drawing.Size(296, 541);
            this.Groupbox2.TabIndex = 58;
            this.Groupbox2.TabStop = false;
            this.Groupbox2.Text = "Thông tin mượn trả sách";
            this.Groupbox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Lần mượn";
            // 
            // txt_LanMuon
            // 
            this.txt_LanMuon.Enabled = false;
            this.txt_LanMuon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LanMuon.Location = new System.Drawing.Point(122, 208);
            this.txt_LanMuon.Name = "txt_LanMuon";
            this.txt_LanMuon.Size = new System.Drawing.Size(150, 22);
            this.txt_LanMuon.TabIndex = 73;
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.White;
            this.btn_In.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.Black;
            this.btn_In.Image = ((System.Drawing.Image)(resources.GetObject("btn_In.Image")));
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(161, 410);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(82, 43);
            this.btn_In.TabIndex = 72;
            this.btn_In.Text = "In";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click_1);
            // 
            // btn_Tra
            // 
            this.btn_Tra.BackColor = System.Drawing.Color.White;
            this.btn_Tra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tra.ForeColor = System.Drawing.Color.Black;
            this.btn_Tra.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tra.Image")));
            this.btn_Tra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tra.Location = new System.Drawing.Point(37, 410);
            this.btn_Tra.Name = "btn_Tra";
            this.btn_Tra.Size = new System.Drawing.Size(82, 43);
            this.btn_Tra.TabIndex = 71;
            this.btn_Tra.Text = "Trả";
            this.btn_Tra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tra.UseVisualStyleBackColor = false;
            this.btn_Tra.Click += new System.EventHandler(this.btn_Tra_Click_1);
            // 
            // btn_GiaHan
            // 
            this.btn_GiaHan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_GiaHan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiaHan.ForeColor = System.Drawing.Color.Black;
            this.btn_GiaHan.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_GiaHan.Location = new System.Drawing.Point(81, 484);
            this.btn_GiaHan.Name = "btn_GiaHan";
            this.btn_GiaHan.Size = new System.Drawing.Size(121, 43);
            this.btn_GiaHan.TabIndex = 70;
            this.btn_GiaHan.Text = "Gia hạn";
            this.btn_GiaHan.UseVisualStyleBackColor = false;
            this.btn_GiaHan.Click += new System.EventHandler(this.btn_GiaHan_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(161, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 43);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(159, 263);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 43);
            this.btnEdit.TabIndex = 66;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(37, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 43);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(37, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 43);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbo_Book
            // 
            this.cbo_Book.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Book.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Book.FormattingEnabled = true;
            this.cbo_Book.Location = new System.Drawing.Point(122, 35);
            this.cbo_Book.Name = "cbo_Book";
            this.cbo_Book.Size = new System.Drawing.Size(150, 23);
            this.cbo_Book.TabIndex = 65;
            // 
            // cbo_Author
            // 
            this.cbo_Author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Author.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Author.FormattingEnabled = true;
            this.cbo_Author.Location = new System.Drawing.Point(122, 77);
            this.cbo_Author.Name = "cbo_Author";
            this.cbo_Author.Size = new System.Drawing.Size(150, 23);
            this.cbo_Author.TabIndex = 64;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 164);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_ReturnDate
            // 
            this.lbl_ReturnDate.AutoSize = true;
            this.lbl_ReturnDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_ReturnDate.Location = new System.Drawing.Point(17, 170);
            this.lbl_ReturnDate.Name = "lbl_ReturnDate";
            this.lbl_ReturnDate.Size = new System.Drawing.Size(56, 16);
            this.lbl_ReturnDate.TabIndex = 61;
            this.lbl_ReturnDate.Text = "Ngày trả";
            // 
            // lbl_BorrowingDate
            // 
            this.lbl_BorrowingDate.AutoSize = true;
            this.lbl_BorrowingDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BorrowingDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_BorrowingDate.Location = new System.Drawing.Point(17, 126);
            this.lbl_BorrowingDate.Name = "lbl_BorrowingDate";
            this.lbl_BorrowingDate.Size = new System.Drawing.Size(72, 16);
            this.lbl_BorrowingDate.TabIndex = 60;
            this.lbl_BorrowingDate.Text = "Ngày mượn";
            // 
            // lbl_Book
            // 
            this.lbl_Book.AutoSize = true;
            this.lbl_Book.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book.ForeColor = System.Drawing.Color.Black;
            this.lbl_Book.Location = new System.Drawing.Point(17, 38);
            this.lbl_Book.Name = "lbl_Book";
            this.lbl_Book.Size = new System.Drawing.Size(35, 16);
            this.lbl_Book.TabIndex = 59;
            this.lbl_Book.Text = "Sách";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.ForeColor = System.Drawing.Color.Black;
            this.lbl_Author.Location = new System.Drawing.Point(17, 80);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(51, 16);
            this.lbl_Author.TabIndex = 58;
            this.lbl_Author.Text = "Độc giả";
            // 
            // frmMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 557);
            this.Controls.Add(this.Groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMuonTraSach";
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.MuonTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Groupbox2.ResumeLayout(false);
            this.Groupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_MuonTra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_Sach;
        private System.Windows.Forms.RadioButton rd_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReaderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox Groupbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LanMuon;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button btn_Tra;
        private System.Windows.Forms.Button btn_GiaHan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbo_Book;
        private System.Windows.Forms.ComboBox cbo_Author;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_ReturnDate;
        private System.Windows.Forms.Label lbl_BorrowingDate;
        private System.Windows.Forms.Label lbl_Book;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
    }
}