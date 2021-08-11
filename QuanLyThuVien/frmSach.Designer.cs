namespace QuanLyThuVien
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPulisherID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheRemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_In = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoLuongCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Pulisher = new System.Windows.Forms.Label();
            this.cbo_Pulisher = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cbo_Author = new System.Windows.Forms.ComboBox();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.cbo_Year = new System.Windows.Forms.ComboBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rd_Year = new System.Windows.Forms.RadioButton();
            this.rd_BookName = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookID,
            this.colBookName,
            this.colAuthorID1,
            this.colYear,
            this.colPulisherID1,
            this.colTypeID1,
            this.colAmount,
            this.colTheRemainingAmount});
            this.dataGridView5.Location = new System.Drawing.Point(404, 134);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(570, 407);
            this.dataGridView5.TabIndex = 28;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // colBookID
            // 
            this.colBookID.DataPropertyName = "MASH";
            this.colBookID.HeaderText = "Mã Sách";
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            this.colBookID.Width = 80;
            // 
            // colBookName
            // 
            this.colBookName.DataPropertyName = "TENSH";
            this.colBookName.HeaderText = "Tên Sách";
            this.colBookName.Name = "colBookName";
            this.colBookName.ReadOnly = true;
            // 
            // colAuthorID1
            // 
            this.colAuthorID1.DataPropertyName = "MATG";
            this.colAuthorID1.HeaderText = "Mã Tác Giả";
            this.colAuthorID1.Name = "colAuthorID1";
            this.colAuthorID1.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.DataPropertyName = "NAMXB";
            this.colYear.HeaderText = "Năm Xuất Bản";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.Width = 120;
            // 
            // colPulisherID1
            // 
            this.colPulisherID1.DataPropertyName = "MANXB";
            this.colPulisherID1.HeaderText = "Mã Nhà Xuất Bản";
            this.colPulisherID1.Name = "colPulisherID1";
            this.colPulisherID1.ReadOnly = true;
            this.colPulisherID1.Width = 130;
            // 
            // colTypeID1
            // 
            this.colTypeID1.DataPropertyName = "MALOAI";
            this.colTypeID1.HeaderText = "Mã Loại Sách";
            this.colTypeID1.Name = "colTypeID1";
            this.colTypeID1.ReadOnly = true;
            this.colTypeID1.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "SOLUONG";
            this.colAmount.HeaderText = "Số lượng";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colTheRemainingAmount
            // 
            this.colTheRemainingAmount.DataPropertyName = "SOLUONGCON";
            this.colTheRemainingAmount.HeaderText = "Số lượng còn";
            this.colTheRemainingAmount.Name = "colTheRemainingAmount";
            this.colTheRemainingAmount.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_In);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SoLuongCon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lbl_BookName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbl_Year);
            this.groupBox1.Controls.Add(this.cbo_Type);
            this.groupBox1.Controls.Add(this.lbl_Pulisher);
            this.groupBox1.Controls.Add(this.cbo_Pulisher);
            this.groupBox1.Controls.Add(this.lbl_Type);
            this.groupBox1.Controls.Add(this.cbo_Author);
            this.groupBox1.Controls.Add(this.lbl_Author);
            this.groupBox1.Controls.Add(this.cbo_Year);
            this.groupBox1.Controls.Add(this.txt_BookName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 529);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.White;
            this.btn_In.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.Black;
            this.btn_In.Image = ((System.Drawing.Image)(resources.GetObject("btn_In.Image")));
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(22, 447);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(79, 43);
            this.btn_In.TabIndex = 76;
            this.btn_In.Text = "In";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Số lượng còn";
            // 
            // txt_SoLuongCon
            // 
            this.txt_SoLuongCon.Enabled = false;
            this.txt_SoLuongCon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongCon.Location = new System.Drawing.Point(175, 316);
            this.txt_SoLuongCon.Name = "txt_SoLuongCon";
            this.txt_SoLuongCon.Size = new System.Drawing.Size(156, 26);
            this.txt_SoLuongCon.TabIndex = 75;
            this.txt_SoLuongCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuongCon_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(175, 270);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(156, 26);
            this.txt_SoLuong.TabIndex = 73;
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(139, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Tạo mới";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(139, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 43);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(252, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 43);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.ForeColor = System.Drawing.Color.Black;
            this.lbl_BookName.Location = new System.Drawing.Point(17, 54);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(59, 16);
            this.lbl_BookName.TabIndex = 58;
            this.lbl_BookName.Text = "Tên Sách";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(20, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 43);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.ForeColor = System.Drawing.Color.Black;
            this.lbl_Year.Location = new System.Drawing.Point(19, 143);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(90, 16);
            this.lbl_Year.TabIndex = 59;
            this.lbl_Year.Text = "Năm Xuất Bản";
            // 
            // cbo_Type
            // 
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(175, 228);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(156, 27);
            this.cbo_Type.TabIndex = 66;
            // 
            // lbl_Pulisher
            // 
            this.lbl_Pulisher.AutoSize = true;
            this.lbl_Pulisher.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pulisher.ForeColor = System.Drawing.Color.Black;
            this.lbl_Pulisher.Location = new System.Drawing.Point(19, 190);
            this.lbl_Pulisher.Name = "lbl_Pulisher";
            this.lbl_Pulisher.Size = new System.Drawing.Size(87, 16);
            this.lbl_Pulisher.TabIndex = 60;
            this.lbl_Pulisher.Text = "Nhà Xuất Bản";
            // 
            // cbo_Pulisher
            // 
            this.cbo_Pulisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Pulisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Pulisher.FormattingEnabled = true;
            this.cbo_Pulisher.Location = new System.Drawing.Point(175, 183);
            this.cbo_Pulisher.Name = "cbo_Pulisher";
            this.cbo_Pulisher.Size = new System.Drawing.Size(156, 27);
            this.cbo_Pulisher.TabIndex = 67;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Type.Location = new System.Drawing.Point(19, 235);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(64, 16);
            this.lbl_Type.TabIndex = 61;
            this.lbl_Type.Text = "Loại Sách";
            // 
            // cbo_Author
            // 
            this.cbo_Author.BackColor = System.Drawing.Color.White;
            this.cbo_Author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Author.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Author.FormattingEnabled = true;
            this.cbo_Author.Location = new System.Drawing.Point(173, 89);
            this.cbo_Author.Name = "cbo_Author";
            this.cbo_Author.Size = new System.Drawing.Size(156, 27);
            this.cbo_Author.TabIndex = 65;
            this.cbo_Author.SelectedIndexChanged += new System.EventHandler(this.cbo_Author_SelectedIndexChanged);
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.ForeColor = System.Drawing.Color.Black;
            this.lbl_Author.Location = new System.Drawing.Point(17, 96);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(52, 16);
            this.lbl_Author.TabIndex = 62;
            this.lbl_Author.Text = "Tác Giả";
            // 
            // cbo_Year
            // 
            this.cbo_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Year.FormattingEnabled = true;
            this.cbo_Year.Location = new System.Drawing.Point(175, 136);
            this.cbo_Year.Name = "cbo_Year";
            this.cbo_Year.Size = new System.Drawing.Size(154, 27);
            this.cbo_Year.TabIndex = 64;
            this.cbo_Year.SelectedIndexChanged += new System.EventHandler(this.cbo_Year_SelectedIndexChanged);
            // 
            // txt_BookName
            // 
            this.txt_BookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(173, 47);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(156, 26);
            this.txt_BookName.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Controls.Add(this.rd_Year);
            this.groupBox2.Controls.Add(this.rd_BookName);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 116);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.btnSearch.Location = new System.Drawing.Point(240, 52);
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
            this.txt_Search.Location = new System.Drawing.Point(33, 54);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(201, 26);
            this.txt_Search.TabIndex = 34;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // rd_Year
            // 
            this.rd_Year.AutoSize = true;
            this.rd_Year.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Year.ForeColor = System.Drawing.Color.Black;
            this.rd_Year.Location = new System.Drawing.Point(187, 25);
            this.rd_Year.Name = "rd_Year";
            this.rd_Year.Size = new System.Drawing.Size(155, 19);
            this.rd_Year.TabIndex = 33;
            this.rd_Year.Text = "Tìm theo Năm Xuất Bản";
            this.rd_Year.UseVisualStyleBackColor = true;
            this.rd_Year.Click += new System.EventHandler(this.rd_Year_Click);
            // 
            // rd_BookName
            // 
            this.rd_BookName.AutoSize = true;
            this.rd_BookName.Checked = true;
            this.rd_BookName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_BookName.ForeColor = System.Drawing.Color.Black;
            this.rd_BookName.Location = new System.Drawing.Point(33, 25);
            this.rd_BookName.Name = "rd_BookName";
            this.rd_BookName.Size = new System.Drawing.Size(127, 19);
            this.rd_BookName.TabIndex = 32;
            this.rd_BookName.TabStop = true;
            this.rd_BookName.Text = "Tìm theo Tên Sách";
            this.rd_BookName.UseVisualStyleBackColor = true;
            this.rd_BookName.Click += new System.EventHandler(this.rd_BookName_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(771, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 116);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSach";
            this.Text = "Quản lý sách trong thư viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPulisherID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheRemainingAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoLuongCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label lbl_Pulisher;
        private System.Windows.Forms.ComboBox cbo_Pulisher;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.ComboBox cbo_Author;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.ComboBox cbo_Year;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rd_Year;
        private System.Windows.Forms.RadioButton rd_BookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

