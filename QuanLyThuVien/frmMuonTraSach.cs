using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuVien
{
    public partial class frmMuonTraSach : Form
    {
        int nid = 0;
        public frmMuonTraSach(int idlogin)
        {
            nid = idlogin;
            InitializeComponent();

            if(Program.Language=="English")
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    cbo_Author.DataSource = db.DOCGIAs.ToList();
                    cbo_Author.DisplayMember = "TENDG";
                    cbo_Author.ValueMember = "MADG";

                    cbo_Book.DataSource = db.SACHes.ToList();
                    cbo_Book.DisplayMember = "TENSH";
                    cbo_Book.ValueMember = "MASH";

                    comboBox_MuonTra.DisplayMember = "Text";
                    comboBox_MuonTra.ValueMember = "Value";
                    var items = new[] { 
                    new { Text = "Borrowing List", Value = "0" }, 
                    new { Text = "Returning List", Value = "1" }, 
                    new { Text = "Return Overdue Books", Value = "2" }, 
                    };
                    comboBox_MuonTra.DataSource = items;
                    comboBox_MuonTra.SelectedIndex = 0;
                }
            }
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    cbo_Author.DataSource = db.DOCGIAs.ToList();
                    cbo_Author.DisplayMember = "TENDG";
                    cbo_Author.ValueMember = "MADG";

                    cbo_Book.DataSource = db.SACHes.ToList();
                    cbo_Book.DisplayMember = "TENSH";
                    cbo_Book.ValueMember = "MASH";

                    comboBox_MuonTra.DisplayMember = "Text";
                    comboBox_MuonTra.ValueMember = "Value";
                    var items = new[] { 
                    new { Text = "Danh sách mượn sách", Value = "0" }, 
                    new { Text = "Danh sách trả sách", Value = "1" }, 
                    new { Text = "Danh sách trả sách quá hạn", Value = "2" }, 
                };

                    comboBox_MuonTra.DataSource = items;
                    comboBox_MuonTra.SelectedIndex = 0;
                }
            }
           

            loadDataToGridView_MuonTraSach(null, null);
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(10);
        }

        string masach, madocgia;
        DateTime ngaymuon = DateTime.Today;
        DateTime homnay = DateTime.Today;



        private void loadTheoComboBox_MuonTra()
        {
            if (comboBox_MuonTra.SelectedIndex == 0)
            {
                loadDataToGridView_MuonTraSach(null, null);
            }

            if (comboBox_MuonTra.SelectedIndex == 1)
            {
                loadDataToGridView_MuonTraSach_Datra(null, null);
            }
            if (comboBox_MuonTra.SelectedIndex == 2)
            {
                loadDataToGridView_MuonTraSach_Tre(null, null);
            }
        }





        private void loadDataToGridView_MuonTraSach_Tre(string ndtim, string loaitim)
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                if (ndtim == null) //thông thường
                {
                    var data =
                            from sv in db.MUONTRASACHes
                            where (sv.DATRA == false) && (homnay.Date > sv.NGAYTRA)
                            select new
                             {
                                 MADG = sv.MADG,
                                 MASH = sv.MASH,
                                 NGAYMUON = sv.NGAYMUON,
                                 NGAYTRA = sv.NGAYTRA,
                                 DATRA = sv.DATRA,
                                 LANMUON = sv.LANMUON
                             };


                    dataGridView1.DataSource = data;

                }
                if (ndtim != null) //tìm kiếm
                {
                    if (loaitim == "sach") //tìm theo  tên sách
                    {
                        var data =
                           from sv in db.MUONTRASACHes
                           join dssach in db.SACHes on sv.MASH equals dssach.MASH
                           where (dssach.TENSH.Contains(ndtim)) && (sv.DATRA == false) && (homnay.Date > sv.NGAYTRA)
                           select new
                           {
                               MADG = sv.MADG,
                               MASH = sv.MASH,
                               NGAYMUON = sv.NGAYMUON,
                               NGAYTRA = sv.NGAYTRA,
                               DATRA = sv.DATRA,
                               LANMUON = sv.LANMUON
                           };
                        dataGridView1.DataSource = data;
                    }
                    else //tìm theo tên tác giả
                    {
                        var data =
                           from sv in db.MUONTRASACHes
                           join dsdocgia in db.DOCGIAs on sv.MADG equals dsdocgia.MADG
                           where (dsdocgia.TENDG.Contains(ndtim)) && (sv.DATRA == false) && (homnay.Date > sv.NGAYTRA)
                           select new
                           {
                               MADG = sv.MADG,
                               MASH = sv.MASH,
                               NGAYMUON = sv.NGAYMUON,
                               NGAYTRA = sv.NGAYTRA,
                               DATRA = sv.DATRA,
                               LANMUON = sv.LANMUON
                           };
                        dataGridView1.DataSource = data;
                    }

                }

                //DATRA LÀ FALSE
            }
        }




        private void loadDataToGridView_MuonTraSach(string ndtim, string loaitim)
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                if (ndtim == null) //thông thường
                {

                    dataGridView1.DataSource = db.MUONTRASACHes.Where(s => s.DATRA == false).Select(sv => new
                    {
                        MADG = sv.MADG,
                        MASH = sv.MASH,
                        NGAYMUON = sv.NGAYMUON,
                        NGAYTRA = sv.NGAYTRA,
                        DATRA = sv.DATRA,
                        LANMUON = sv.LANMUON
                    });

                }
                if (ndtim != null) //tìm kiếm
                {
                    if (loaitim == "sach") //tìm theo  tên sách
                    {
                        var data =
                           from sv in db.MUONTRASACHes
                           join dssach in db.SACHes on sv.MASH equals dssach.MASH
                           where (dssach.TENSH.Contains(ndtim)) && (sv.DATRA == false)
                           select new
                           {
                               MADG = sv.MADG,
                               MASH = sv.MASH,
                               NGAYMUON = sv.NGAYMUON,
                               NGAYTRA = sv.NGAYTRA,
                               DATRA = sv.DATRA,
                               LANMUON = sv.LANMUON
                           };
                        dataGridView1.DataSource = data;
                    }
                    else //tìm theo tên tác giả
                    {
                        var data =
                           from sv in db.MUONTRASACHes
                           join dsdocgia in db.DOCGIAs on sv.MADG equals dsdocgia.MADG
                           where (dsdocgia.TENDG.Contains(ndtim)) && (sv.DATRA == false)
                           select new
                           {
                               MADG = sv.MADG,
                               MASH = sv.MASH,
                               NGAYMUON = sv.NGAYMUON,
                               NGAYTRA = sv.NGAYTRA,
                               DATRA = sv.DATRA,
                               LANMUON = sv.LANMUON
                           };
                        dataGridView1.DataSource = data;
                    }

                }

                //DATRA LÀ FALSE
            }
        }

        private void loadDataToGridView_MuonTraSach_Datra(string ndtim, string loaitim)
        {
            if (Program.Language == "English")
            {

                //colBorrowedDate.HeaderText = "Borrowed Date";
                //colReturnDate.HeaderText = "Return Date";
                //colBookCode.HeaderText = "Book Code";
                //colReaderCode.HeaderText = "Reader Code";
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                if (ndtim == null) //thông thường
                {

                    dataGridView1.DataSource = db.MUONTRASACHes.Where(s => s.DATRA == true).Select(sv => new
                    {
                        MADG = sv.MADG,
                        MASH = sv.MASH,
                        NGAYMUON = sv.NGAYMUON,
                        NGAYTRA = sv.NGAYTRA,
                        DATRA = sv.DATRA,
                        LANMUON = sv.LANMUON
                    });

                }
                if (ndtim != null) //tìm kiếm
                {
                    if (loaitim == "sach") //tìm theo  tên sách
                    {
                        var data =
                           from sv in db.MUONTRASACHes
                           join dssach in db.SACHes on sv.MASH equals dssach.MASH
                           where (dssach.TENSH.Contains(ndtim)) && (sv.DATRA == true)
                           select new
                           {
                               MADG = sv.MADG,
                               MASH = sv.MASH,
                               NGAYMUON = sv.NGAYMUON,
                               NGAYTRA = sv.NGAYTRA,
                               DATRA = sv.DATRA,
                               LANMUON = sv.LANMUON
                           };
                        dataGridView1.DataSource = data;
                    }
                    else //tìm theo tên tác giả
                    {
                        var data =
                           from sv in db.MUONTRASACHes
                           join dsdocgia in db.DOCGIAs on sv.MADG equals dsdocgia.MADG
                           where (dsdocgia.TENDG.Contains(ndtim)) && (sv.DATRA == true)
                           select new
                           {
                               MADG = sv.MADG,
                               MASH = sv.MASH,
                               NGAYMUON = sv.NGAYMUON,
                               NGAYTRA = sv.NGAYTRA,
                               DATRA = sv.DATRA,
                               LANMUON = sv.LANMUON
                           };
                        dataGridView1.DataSource = data;
                    }

                }

                //DATRA LÀ FALSE
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void resetForm()
        {
            cbo_Author.SelectedIndex = 0;
            cbo_Book.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(10);

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btn_GiaHan.Enabled = false;
            btn_Tra.Enabled = false;

            cbo_Author.Enabled = true;
            cbo_Book.Enabled = true;
            txt_LanMuon.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
         

        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //huy
            resetForm();
        }


        private void MuonTraSach_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                this.Text = "Book rental management";
                setEnglish();

            }

            rd_DocGia.Checked = true;

            resetForm();
        }




        private void setEnglish()
        {
            dataGridView1.Columns[0].HeaderText = "Reader ID";
            dataGridView1.Columns[1].HeaderText = "Book ID";
            dataGridView1.Columns[2].HeaderText = "Borrowed Date";
            dataGridView1.Columns[3].HeaderText = "Return Date";
            btn_In.Text = "Print";
            lbl_Author.Text = "Reader";
            lbl_Book.Text = "Book";
            lbl_BorrowingDate.Text = "Borrowing Date";
            lbl_ReturnDate.Text = "Return Date";
          
            btnAdd.Text = "Add";
            btnDelete.Text = "Delete";
            btnEdit.Text = "Edit";
            btnCancel.Text = "Cancel";
            btn_GiaHan.Text = "Extend";
            btn_Tra.Text = "Return";
            groupBox1.Text = "Search By";
            Groupbox2.Text = "Borrowed - Returned Book Information";
            rd_DocGia.Text = "Reader";
            rd_Sach.Text = "Book";
            btnSearch.Text = "Seach";
            label2.Text = "Times Borrowed";



        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Tùy chọn hiển thị xem dânh sách: ĐANG ĐƯỢC MƯỢN, ĐÃ MƯỢN, CHƯA TRẢ ĐÚNG HẠN

            //mặc định hiển thị đang được mượn
            //đổi sang 

            if (comboBox_MuonTra.SelectedIndex == 0)
            {
                loadDataToGridView_MuonTraSach(null, null);
            }

            if (comboBox_MuonTra.SelectedIndex == 1)
            {
                loadDataToGridView_MuonTraSach_Datra(null, null);
            }
            if (comboBox_MuonTra.SelectedIndex == 2)
            {
                loadDataToGridView_MuonTraSach_Tre(null, null);
            }




        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_GiaHan_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MUONTRASACH sv = dataGridView1.CurrentRow.DataBoundItem as MUONTRASACH;

            madocgia = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            masach = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                DOCGIA dg1 = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault();
                SACH sh1 = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                cbo_Author.SelectedIndex = cbo_Author.FindString(dg1.TENDG.Trim());
                cbo_Book.SelectedIndex = cbo_Book.FindString(sh1.TENSH.Trim());

                try
                {
                    dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    ngaymuon = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    dateTimePicker2.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    txt_LanMuon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();

                }
                catch { }
            }

            cbo_Author.Enabled = false;
            cbo_Book.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;

            //button trả, gia hạn
            if (comboBox_MuonTra.SelectedIndex == 0)
            {

                btn_GiaHan.Enabled = true;
                btn_Tra.Enabled = true;
            }
            if (comboBox_MuonTra.SelectedIndex == 1)
            {

                btn_GiaHan.Enabled = false;
                btn_Tra.Enabled = false;
            }
            if (comboBox_MuonTra.SelectedIndex == 2)
            {
                btn_Tra.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    madocgia = cbo_Author.SelectedValue.ToString();
                    int doituongdocgia = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().DOITUONG;

                    if (doituongdocgia < 2)
                        dateTimePicker2.Value = dateTimePicker1.Value.AddDays(10);
                    if (doituongdocgia == 2)
                        dateTimePicker2.Value = dateTimePicker1.Value.AddDays(30);
                    if (doituongdocgia > 2)
                        dateTimePicker2.Value = dateTimePicker1.Value.AddDays(180);
                }
                catch { }
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_LanMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ndtim = txt_Search.Text.Trim();
            if (rd_DocGia.Checked)
            {

                if (comboBox_MuonTra.SelectedIndex == 0)
                {
                    loadDataToGridView_MuonTraSach(ndtim, "docgia");
                }
                if (comboBox_MuonTra.SelectedIndex == 1)
                {
                    loadDataToGridView_MuonTraSach_Datra(ndtim, "docgia");
                }
                if (comboBox_MuonTra.SelectedIndex == 2)
                {
                    loadDataToGridView_MuonTraSach_Tre(ndtim, "docgia");
                }
            }
            if (rd_Sach.Checked)
            {
                if (comboBox_MuonTra.SelectedIndex == 0)
                {
                    loadDataToGridView_MuonTraSach(ndtim, "sach");
                }
                if (comboBox_MuonTra.SelectedIndex == 1)
                {
                    loadDataToGridView_MuonTraSach_Datra(ndtim, "sach");
                }
                if (comboBox_MuonTra.SelectedIndex == 2)
                {
                    loadDataToGridView_MuonTraSach_Tre(ndtim, "sach");
                }


            }
        }

        private void btn_GiaHan_Click_1(object sender, EventArgs e)
        {
            //kiểm tra số lần  có thể gia hạn của độc giả
            //thêm ngày trả + 10 ngày
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int sogiahan = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().SOGIAHAN;

                if (sogiahan < 1)
                {
                    if(Program.Language=="English")
                    {
                        MessageBox.Show("Readers Have Expired Book Renewals", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Độc giả đã dùng hết số lần có thể gia hạn sấch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                  

                }
                //cập nhật gia hạn
                DateTime ngaytra = dateTimePicker2.Value; ;
                DateTime ngaytramoi = ngaytra.AddDays(10);

                int lanmuonh = int.Parse(txt_LanMuon.Text);

                MUONTRASACH sv = db.MUONTRASACHes.Where(r => r.MADG.Equals(madocgia) && r.MASH.Equals(masach)
                    && r.LANMUON == lanmuonh).FirstOrDefault();

                sv.NGAYTRA = ngaytramoi;
                db.SubmitChanges();
                //cập nhạt số lần có thể gia hahjn cua dg
                sogiahan--;

                DOCGIA k = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault();

                k.SOGIAHAN = sogiahan;
                db.SubmitChanges();
                resetForm();

                loadTheoComboBox_MuonTra();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Extend Successfully", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
           

            }
        }

        private void btn_Tra_Click_1(object sender, EventArgs e)
        {
            //thiết lập DATRA thanh true
            //load lại grid view

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                int lanmuonh = int.Parse(txt_LanMuon.Text);

                //cập nhật mượn trả sách
                MUONTRASACH sv = db.MUONTRASACHes.Where(r => r.MADG.Equals(madocgia) && r.MASH.Equals(masach)
                    && r.LANMUON == lanmuonh).FirstOrDefault();
                if (sv == null)
                {
                    MessageBox.Show("Trả thất bại vì mã mượn sách không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sv.DATRA = true;
                db.SubmitChanges();

                //cập nhật số lượng sách còn trong danh sách sách

                int soluongsachcon = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault().SOLUONGCON.GetValueOrDefault(0);
                SACH h = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                soluongsachcon++;
                h.SOLUONGCON = soluongsachcon;
                db.SubmitChanges();

                //cap nhat sach doc gia dang muon, tra
                int sachdocgiadangmuon = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().MUON;
                int sachdocgiadatra = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().TRA;

                sachdocgiadangmuon--;
                sachdocgiadatra++;

                DOCGIA k = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault();

                k.MUON = sachdocgiadangmuon;
                k.TRA = sachdocgiadatra;
                db.SubmitChanges();

                //data grid view
                resetForm();
                loadTheoComboBox_MuonTra();


                //thông báo
                MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                int lanmuonh = int.Parse(txt_LanMuon.Text);

                MUONTRASACH sv = db.MUONTRASACHes.Where(r => r.MADG.Equals(madocgia) && r.MASH.Equals(masach)
                    && r.LANMUON == lanmuonh).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Update failed because it doesn't exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại vì mã mượn sách không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;

                }


                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("The return date must be after the date the book is borrowed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ngày trả sách phải sau ngày mượn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }


                sv.NGAYMUON = dateTimePicker1.Value;
                sv.NGAYTRA = dateTimePicker2.Value;

                db.SubmitChanges();
                loadTheoComboBox_MuonTra();
                resetForm();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /////xoa
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                int lanmuonh = int.Parse(txt_LanMuon.Text);

                MUONTRASACH sv = db.MUONTRASACHes.Where(r => r.MADG.Equals(madocgia) && r.MASH.Equals(masach)
                    && r.LANMUON == lanmuonh).FirstOrDefault();

                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Delete failed because it doesn't exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại vì mã mượn sách không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                db.MUONTRASACHes.DeleteOnSubmit(sv);
                db.SubmitChanges();


                //cập nhật số lượng sách
                int soluongsachcon = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault().SOLUONGCON.GetValueOrDefault(0);
                SACH h = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                soluongsachcon++;
                h.SOLUONGCON = soluongsachcon;
                db.SubmitChanges();



                resetForm();

                loadTheoComboBox_MuonTra();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                //KIỂM TRA SỐ SÁCH HIỆN CÓ CỦA ĐỘC GIẢ, NẾU BẰNG MAX QUYỂN THÌ KHÔNG CHO MƯỢN
                //NẾU ĐỐI TƯỢNG  LÀ NGƯỜI NGOÀI TRƯỜNG THÌ MAX 1 QUYÊN
                //SV MAX 3
                //GV THỈNH GIẢNG 2
                //GIẢNG VIÊN 3

                //    var items = new[] { 
                //    new { Text = "Người sử dụng ngoài trường", Value = "0" }, 
                //    new { Text = "Sinh viên, học viên", Value = "1" }, 
                //    new { Text = "Giảng viên thỉnh giảng", Value = "2" },
                //    new { Text = "Giảng viên, viên chức", Value = "3" },
                //};
                //int madg = ((DOCGIA)cbo_Author.SelectedItem).MADG;

                //lấy  mã từ combobox
                madocgia = cbo_Author.SelectedValue.ToString();
                masach = cbo_Book.SelectedValue.ToString();

                //lây từ bảng sách
                int soluongsachcon = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault().SOLUONGCON.GetValueOrDefault(0);


                //lấy từ bảng DOCGIA
                int sachdocgiadangmuon = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().MUON;
                int doituongdocgia = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().DOITUONG;
                int quyendocgia = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault().QUYEN;

                if (soluongsachcon == 0) //kiểm tra số  lượng còn
                {
                    MessageBox.Show("Sách này đã cho mượn hết, nên không thể mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //

                //if (quyendocgia == 0)
                //{
                //    MessageBox.Show("Độc giả này chưa xét duyệt nên không thể mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (quyendocgia == 0)
                {
                    MessageBox.Show("Độc giả này đã bị tạm dừng sử dụng thử viện, nên không thể mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (sachdocgiadangmuon == 1 && doituongdocgia == 0)
                {

                    MessageBox.Show("Độc giả này đã đến giới hạn mượn sách, nên không thể mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((sachdocgiadangmuon == 3 && doituongdocgia == 1) || ((sachdocgiadangmuon == 3 && doituongdocgia == 3)))
                {

                    MessageBox.Show("Độc giả này đã đến giới hạn mượn sách, nên không thể mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (sachdocgiadangmuon == 2 && doituongdocgia == 2)
                {

                    MessageBox.Show("Độc giả này đã đến giới hạn mượn sách, nên không thể mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                /////them
                int tmadg = ((DOCGIA)cbo_Author.SelectedItem).MADG;
                int tmash = ((SACH)cbo_Book.SelectedItem).MASH;



                // lần mượn sách
                int lanmuon = 0;
                try
                {

                    lanmuon = int.Parse(db.MUONTRASACHes.Where(r => r.MASH == tmash && r.MADG == tmadg).Max(x => x.LANMUON).ToString());
                }
                catch { }
                lanmuon++;

                //thông tin sách
                MUONTRASACH sv = new MUONTRASACH
                {

                    MADG = tmadg,
                    MASH = tmash,
                    NGAYMUON = dateTimePicker1.Value,
                    NGAYTRA = dateTimePicker2.Value,
                    LANMUON = lanmuon

                };


                //kiểm tra độc giả có đang mượn sách
                var kiemtraTrung = db.MUONTRASACHes.Where(r => r.MASH == sv.MASH && r.MADG == sv.MADG && r.DATRA == false)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This reader has already borrowed the book!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Độc giả đã đang mượn sách này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                //kiểm tra ngày mượn hợp lệ


                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("The return date must be after the date the book is borrowed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ngày trả sách phải sau ngày mượn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.MUONTRASACHes.InsertOnSubmit(sv);
                db.SubmitChanges();

                //thôn báo thêm
                if (Program.Language == "English")
                {
                    MessageBox.Show("Add successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //cập nhật số lượng sách độc giả đang mượn 

                DOCGIA k = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault();
                sachdocgiadangmuon++;
                k.MUON = sachdocgiadangmuon;
                db.SubmitChanges();


                //cập nhật số lượng sách
                SACH h = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                soluongsachcon--;
                h.SOLUONGCON = soluongsachcon;
                db.SubmitChanges();

                //load data gridview
                resetForm();
                loadTheoComboBox_MuonTra();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btn_In_Click_1(object sender, EventArgs e)
        {
            if (comboBox_MuonTra.SelectedIndex == 0)
            {
                Reportfrm_MuonTraSach report = new Reportfrm_MuonTraSach(0);
                report.Show();
            }

            if (comboBox_MuonTra.SelectedIndex == 1)
            {
                Reportfrm_MuonTraSach report = new Reportfrm_MuonTraSach(1);
                report.Show();
            }
            if (comboBox_MuonTra.SelectedIndex == 2)
            {
                Reportfrm_MuonTraSach report = new Reportfrm_MuonTraSach(2);
                report.Show();
            }
        }
    }
}
