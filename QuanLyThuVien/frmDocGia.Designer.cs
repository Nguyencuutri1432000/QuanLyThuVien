namespace QuanLyThuVien
{
    partial class frmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfRenewals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_In = new System.Windows.Forms.Button();
            this.txt_GiaHan = new System.Windows.Forms.TextBox();
            this.lblNumberOfRenewals = new System.Windows.Forms.Label();
            this.comboBox_DoiTuong = new System.Windows.Forms.ComboBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.comboBox_Quyen = new System.Windows.Forms.ComboBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.txt_DaMuon = new System.Windows.Forms.TextBox();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.txt_DangMuon = new System.Windows.Forms.TextBox();
            this.lblBorrowing = new System.Windows.Forms.Label();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.cbo_Sex = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_ReaderName = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_ReaderName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_ReaderID = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rd_ReaderName = new System.Windows.Forms.RadioButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReaderID,
            this.colReaderName,
            this.colBirthday,
            this.colSex,
            this.colPhone,
            this.colBorrowing,
            this.colBorrowed,
            this.colActive,
            this.colObject,
            this.colNumberOfRenewals});
            this.dataGridView1.Location = new System.Drawing.Point(5, 272);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 293);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colReaderID
            // 
            this.colReaderID.DataPropertyName = "MADG";
            this.colReaderID.HeaderText = "Mã Độc Giả";
            this.colReaderID.Name = "colReaderID";
            this.colReaderID.ReadOnly = true;
            // 
            // colReaderName
            // 
            this.colReaderName.DataPropertyName = "TENDG";
            this.colReaderName.HeaderText = "Tên Độc Giả";
            this.colReaderName.Name = "colReaderName";
            this.colReaderName.ReadOnly = true;
            // 
            // colBirthday
            // 
            this.colBirthday.DataPropertyName = "NGAYSINH";
            this.colBirthday.HeaderText = "Ngày Sinh";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "GIOITINH";
            this.colSex.HeaderText = "Giới Tính";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "LIENHE";
            this.colPhone.HeaderText = "Liên Hệ";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 180;
            // 
            // colBorrowing
            // 
            this.colBorrowing.DataPropertyName = "MUON";
            this.colBorrowing.HeaderText = "Đang mượn";
            this.colBorrowing.Name = "colBorrowing";
            this.colBorrowing.ReadOnly = true;
            // 
            // colBorrowed
            // 
            this.colBorrowed.DataPropertyName = "TRA";
            this.colBorrowed.HeaderText = "Đã mượn";
            this.colBorrowed.Name = "colBorrowed";
            this.colBorrowed.ReadOnly = true;
            // 
            // colActive
            // 
            this.colActive.DataPropertyName = "QUYEN";
            this.colActive.HeaderText = "Hoạt động";
            this.colActive.Name = "colActive";
            this.colActive.ReadOnly = true;
            // 
            // colObject
            // 
            this.colObject.DataPropertyName = "DOITUONG";
            this.colObject.HeaderText = "Đối tượng";
            this.colObject.Name = "colObject";
            this.colObject.ReadOnly = true;
            // 
            // colNumberOfRenewals
            // 
            this.colNumberOfRenewals.DataPropertyName = "SOGIAHAN";
            this.colNumberOfRenewals.HeaderText = "Số  lần gia hạn";
            this.colNumberOfRenewals.Name = "colNumberOfRenewals";
            this.colNumberOfRenewals.ReadOnly = true;
            this.colNumberOfRenewals.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_In);
            this.groupBox1.Controls.Add(this.txt_GiaHan);
            this.groupBox1.Controls.Add(this.lblNumberOfRenewals);
            this.groupBox1.Controls.Add(this.comboBox_DoiTuong);
            this.groupBox1.Controls.Add(this.lblObject);
            this.groupBox1.Controls.Add(this.comboBox_Quyen);
            this.groupBox1.Controls.Add(this.lblActive);
            this.groupBox1.Controls.Add(this.txt_DaMuon);
            this.groupBox1.Controls.Add(this.lblBorrowed);
            this.groupBox1.Controls.Add(this.txt_DangMuon);
            this.groupBox1.Controls.Add(this.lblBorrowing);
            this.groupBox1.Controls.Add(this.btnCancel1);
            this.groupBox1.Controls.Add(this.cbo_Sex);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnEdit1);
            this.groupBox1.Controls.Add(this.btnDelete1);
            this.groupBox1.Controls.Add(this.btnAdd1);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.txt_ReaderName);
            this.groupBox1.Controls.Add(this.lbl_Phone);
            this.groupBox1.Controls.Add(this.lbl_Sex);
            this.groupBox1.Controls.Add(this.lbl_Birthday);
            this.groupBox1.Controls.Add(this.lbl_ReaderName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 254);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Độc Giả";
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.White;
            this.btn_In.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.Black;
            this.btn_In.Image = ((System.Drawing.Image)(resources.GetObject("btn_In.Image")));
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(769, 165);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(72, 46);
            this.btn_In.TabIndex = 75;
            this.btn_In.Text = "In";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // txt_GiaHan
            // 
            this.txt_GiaHan.Enabled = false;
            this.txt_GiaHan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaHan.Location = new System.Drawing.Point(701, 122);
            this.txt_GiaHan.Name = "txt_GiaHan";
            this.txt_GiaHan.Size = new System.Drawing.Size(140, 22);
            this.txt_GiaHan.TabIndex = 74;
            this.txt_GiaHan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaHan_KeyPress);
            // 
            // lblNumberOfRenewals
            // 
            this.lblNumberOfRenewals.AutoSize = true;
            this.lblNumberOfRenewals.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRenewals.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRenewals.Location = new System.Drawing.Point(568, 125);
            this.lblNumberOfRenewals.Name = "lblNumberOfRenewals";
            this.lblNumberOfRenewals.Size = new System.Drawing.Size(71, 15);
            this.lblNumberOfRenewals.TabIndex = 73;
            this.lblNumberOfRenewals.Text = "Lần gia hạn";
            // 
            // comboBox_DoiTuong
            // 
            this.comboBox_DoiTuong.BackColor = System.Drawing.Color.White;
            this.comboBox_DoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DoiTuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DoiTuong.FormattingEnabled = true;
            this.comboBox_DoiTuong.Location = new System.Drawing.Point(701, 82);
            this.comboBox_DoiTuong.Name = "comboBox_DoiTuong";
            this.comboBox_DoiTuong.Size = new System.Drawing.Size(140, 23);
            this.comboBox_DoiTuong.TabIndex = 72;
            this.comboBox_DoiTuong.SelectedIndexChanged += new System.EventHandler(this.comboBox_DoiTuong_SelectedIndexChanged_1);
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.ForeColor = System.Drawing.Color.Black;
            this.lblObject.Location = new System.Drawing.Point(568, 82);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(62, 15);
            this.lblObject.TabIndex = 71;
            this.lblObject.Text = "Đối tượng";
            // 
            // comboBox_Quyen
            // 
            this.comboBox_Quyen.BackColor = System.Drawing.Color.White;
            this.comboBox_Quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Quyen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Quyen.FormattingEnabled = true;
            this.comboBox_Quyen.Location = new System.Drawing.Point(701, 40);
            this.comboBox_Quyen.Name = "comboBox_Quyen";
            this.comboBox_Quyen.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Quyen.TabIndex = 70;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.Black;
            this.lblActive.Location = new System.Drawing.Point(568, 44);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(61, 15);
            this.lblActive.TabIndex = 69;
            this.lblActive.Text = "Hoạt động";
            // 
            // txt_DaMuon
            // 
            this.txt_DaMuon.Enabled = false;
            this.txt_DaMuon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DaMuon.Location = new System.Drawing.Point(374, 78);
            this.txt_DaMuon.Name = "txt_DaMuon";
            this.txt_DaMuon.Size = new System.Drawing.Size(140, 22);
            this.txt_DaMuon.TabIndex = 68;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowed.Location = new System.Drawing.Point(295, 78);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(57, 15);
            this.lblBorrowed.TabIndex = 67;
            this.lblBorrowed.Text = "Đã mượn";
            // 
            // txt_DangMuon
            // 
            this.txt_DangMuon.Enabled = false;
            this.txt_DangMuon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DangMuon.Location = new System.Drawing.Point(374, 40);
            this.txt_DangMuon.Name = "txt_DangMuon";
            this.txt_DangMuon.Size = new System.Drawing.Size(140, 22);
            this.txt_DangMuon.TabIndex = 66;
            // 
            // lblBorrowing
            // 
            this.lblBorrowing.AutoSize = true;
            this.lblBorrowing.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowing.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowing.Location = new System.Drawing.Point(295, 40);
            this.lblBorrowing.Name = "lblBorrowing";
            this.lblBorrowing.Size = new System.Drawing.Size(71, 15);
            this.lblBorrowing.TabIndex = 65;
            this.lblBorrowing.Text = "Đang mượn";
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.White;
            this.btnCancel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.Black;
            this.btnCancel1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel1.Image")));
            this.btnCancel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel1.Location = new System.Drawing.Point(596, 166);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(105, 45);
            this.btnCancel1.TabIndex = 64;
            this.btnCancel1.Text = "Tạo mới";
            this.btnCancel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click_1);
            // 
            // cbo_Sex
            // 
            this.cbo_Sex.BackColor = System.Drawing.Color.White;
            this.cbo_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sex.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Sex.FormattingEnabled = true;
            this.cbo_Sex.Location = new System.Drawing.Point(111, 81);
            this.cbo_Sex.Name = "cbo_Sex";
            this.cbo_Sex.Size = new System.Drawing.Size(140, 23);
            this.cbo_Sex.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // btnEdit1
            // 
            this.btnEdit1.BackColor = System.Drawing.Color.White;
            this.btnEdit1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit1.ForeColor = System.Drawing.Color.Black;
            this.btnEdit1.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit1.Image")));
            this.btnEdit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit1.Location = new System.Drawing.Point(430, 166);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(84, 45);
            this.btnEdit1.TabIndex = 59;
            this.btnEdit1.Text = "Sửa";
            this.btnEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit1.UseVisualStyleBackColor = false;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click_1);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.White;
            this.btnDelete1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.Color.Black;
            this.btnDelete1.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete1.Image")));
            this.btnDelete1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete1.Location = new System.Drawing.Point(262, 166);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(90, 45);
            this.btnDelete1.TabIndex = 60;
            this.btnDelete1.Text = "Xóa";
            this.btnDelete1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click_1);
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.White;
            this.btnAdd1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.Color.Black;
            this.btnAdd1.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd1.Image")));
            this.btnAdd1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd1.Location = new System.Drawing.Point(111, 163);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(85, 48);
            this.btnAdd1.TabIndex = 61;
            this.btnAdd1.Text = "Thêm";
            this.btnAdd1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click_1);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(374, 118);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(140, 22);
            this.txt_Phone.TabIndex = 57;
            // 
            // txt_ReaderName
            // 
            this.txt_ReaderName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReaderName.Location = new System.Drawing.Point(111, 40);
            this.txt_ReaderName.Name = "txt_ReaderName";
            this.txt_ReaderName.Size = new System.Drawing.Size(140, 22);
            this.txt_ReaderName.TabIndex = 58;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_Phone.Location = new System.Drawing.Point(295, 118);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(50, 15);
            this.lbl_Phone.TabIndex = 53;
            this.lbl_Phone.Text = "Liên Hệ";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sex.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sex.Location = new System.Drawing.Point(18, 81);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(60, 15);
            this.lbl_Sex.TabIndex = 54;
            this.lbl_Sex.Text = "Giới Tính";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.ForeColor = System.Drawing.Color.Black;
            this.lbl_Birthday.Location = new System.Drawing.Point(18, 118);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(64, 15);
            this.lbl_Birthday.TabIndex = 55;
            this.lbl_Birthday.Text = "Ngày Sinh";
            // 
            // lbl_ReaderName
            // 
            this.lbl_ReaderName.AutoSize = true;
            this.lbl_ReaderName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReaderName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ReaderName.Location = new System.Drawing.Point(18, 43);
            this.lbl_ReaderName.Name = "lbl_ReaderName";
            this.lbl_ReaderName.Size = new System.Drawing.Size(74, 15);
            this.lbl_ReaderName.TabIndex = 56;
            this.lbl_ReaderName.Text = "Tên Độc Giả";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rd_ReaderID);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rd_ReaderName);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(900, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 254);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // rd_ReaderID
            // 
            this.rd_ReaderID.AutoSize = true;
            this.rd_ReaderID.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_ReaderID.ForeColor = System.Drawing.Color.Black;
            this.rd_ReaderID.Location = new System.Drawing.Point(6, 85);
            this.rd_ReaderID.Name = "rd_ReaderID";
            this.rd_ReaderID.Size = new System.Drawing.Size(139, 19);
            this.rd_ReaderID.TabIndex = 42;
            this.rd_ReaderID.Text = "Tìm theo Mã Độc Giả";
            this.rd_ReaderID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(126, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 29);
            this.btnSearch.TabIndex = 79;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rd_ReaderName
            // 
            this.rd_ReaderName.AutoSize = true;
            this.rd_ReaderName.Checked = true;
            this.rd_ReaderName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_ReaderName.ForeColor = System.Drawing.Color.Black;
            this.rd_ReaderName.Location = new System.Drawing.Point(6, 44);
            this.rd_ReaderName.Name = "rd_ReaderName";
            this.rd_ReaderName.Size = new System.Drawing.Size(143, 19);
            this.rd_ReaderName.TabIndex = 41;
            this.rd_ReaderName.TabStop = true;
            this.rd_ReaderName.Text = "Tìm theo Tên Độc Giả";
            this.rd_ReaderName.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(6, 122);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(237, 26);
            this.txt_Search.TabIndex = 78;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin độc giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.TextBox txt_GiaHan;
        private System.Windows.Forms.Label lblNumberOfRenewals;
        private System.Windows.Forms.ComboBox comboBox_DoiTuong;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.ComboBox comboBox_Quyen;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox txt_DaMuon;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.TextBox txt_DangMuon;
        private System.Windows.Forms.Label lblBorrowing;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.ComboBox cbo_Sex;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_ReaderName;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_ReaderName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rd_ReaderID;
        private System.Windows.Forms.RadioButton rd_ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfRenewals;
    }
}