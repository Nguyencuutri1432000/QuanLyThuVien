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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();


        }
        string maloaisach, masach, madocgia, matacgia, manxb;

        private void loadDataToGridView_Sach()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                dataGridView5.DataSource = db.SACHes.Select(sv => new { 
                    MASH = sv.MASH, TENSH = sv.TENSH, MATG = sv.MATG, 
                    NAMXB = sv.NAMXB, MANXB = sv.MANXB, 
                    MALOAI = sv.MALOAI,
                    SOLUONG = sv.SOLUONG,
                    SOLUONGCON  = sv.SOLUONGCON
                });
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            frmSach.ActiveForm.Close();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetEnglish()
        {
            //quản lý sách
            lbl_Author.Text = "Author";
            lbl_BookName.Text = "BookName";
            lbl_Pulisher.Text = "Pulisher";
            //lbl_Title.Text = "BOOK MANAGEMENT";
            lbl_Type.Text = "Type";
            lbl_Year.Text = "Year";
            btnAdd.Text = "Add";
            btnCancel.Text = "Cancel";
            btnDelete.Text = "Delete";
            btnEdit.Text = "Edit";
            //btnSearch.Text = "Search";
            colBookID.HeaderText = "Book Code";
            colBookName.HeaderText = "Book Name";
            colAuthorID1.HeaderText = "Author Code";
            colTypeID1.HeaderText = "Type Code";
            colPulisherID1.HeaderText = "Pulisher Code";
            colYear.HeaderText = "Year";
            label1.Text = "Amount";
            label2.Text = "The Remaining Amount";
            colAmount.HeaderText = "Amount";
            colTheRemainingAmount.HeaderText = "The Remaining Amount";
            btn_In.Text = "Print";
            groupBox1.Text = "Book Information";
            groupBox2.Text = "Search";
            rd_BookName.Text = "Search By Book Name";
            rd_Year.Text = "Search By Year";
            btnSearch.Text = "Search";
            this.Text = "Book Management";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                this.Text = "Library Management";
                SetEnglish();

            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                cbo_Pulisher.DataSource = db.NHAXUATBANs.ToList();
                cbo_Pulisher.DisplayMember = "TENNXB";
                cbo_Pulisher.ValueMember = "MANXB";

                cbo_Author.DataSource = db.TACGIAs.ToList();
                cbo_Author.DisplayMember = "TENTG";
                cbo_Author.ValueMember = "MATG";

                cbo_Type.DataSource = db.LOAISACHes.ToList();
                cbo_Type.DisplayMember = "TENLOAI";
                cbo_Type.ValueMember = "MALOAI";

                int yearnow = DateTime.Now.Year;
                for (int i = yearnow; i >= 1; i--)
                {
                    cbo_Year.Items.Add(i);
                }
                cbo_Year.SelectedIndex = 0;


            }



            loadDataToGridView_Sach();


            resetForm();

        }
        private void loadDataToGridView_Sach(string tensh, int nam)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int dem = 0;
                if (nam < 0)
                {
                    dataGridView5.DataSource = db.SACHes.Where(r => r.TENSH.Contains(tensh)).Select(sv => new
                    {
                        MASH = sv.MASH,
                        TENSH = sv.TENSH,
                        MATG = sv.MATG,
                        NAMXB = sv.NAMXB,
                        MANXB = sv.MANXB,
                        MALOAI = sv.MALOAI,
                        SOLUONG=sv.SOLUONG,
                        SOLUONGCON=sv.SOLUONGCON

                    });
                    dem = int.Parse(dataGridView5.Rows.Count.ToString());

                }
                else
                {

                    dataGridView5.DataSource = db.SACHes.Where(r => r.NAMXB == nam).Select(sv => new
                    {
                        MASH = sv.MASH,
                        TENSH = sv.TENSH,
                        MATG = sv.MATG,
                        NAMXB = sv.NAMXB,
                        MANXB = sv.MANXB,
                        MALOAI = sv.MALOAI,
                        SOLUONG=sv.SOLUONG,
                        SOLUONGCON=sv.SOLUONGCON
                    });
                    dem = int.Parse(dataGridView5.Rows.Count.ToString());
                }
                if (Program.Language == "English")
                {
                    label4.Text = "Total books found:" + dem + " book";
                }
                else
                {
                    label4.Text = "Tổng số sách tìm được:" + dem + " sách";
                }
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void resetForm()
        {

            txt_SoLuong.Clear();
            txt_BookName.Clear();
            txt_SoLuongCon.Clear();

            cbo_Year.SelectedIndex = 0;
            cbo_Pulisher.SelectedIndex = 0;
            cbo_Type.SelectedIndex = 0;

            //comboBox5.SelectedIndex = 0;
            cbo_Author.SelectedIndex = 0;

            //sach
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;



        }






        private void button17_Click(object sender, EventArgs e)
        {
            thietLapButton("sach", true);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                SACH sv = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sách này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                try
                {
                    db.SACHes.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    loadDataToGridView_Sach();
                    resetForm();
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khóa ngoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }



        private void button18_Click(object sender, EventArgs e)
        {

            if (txt_BookName.Text.Length == 0)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Please enter book type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                SACH sv = new SACH
                {
                    TENSH = txt_BookName.Text,
                    MATG = ((TACGIA)cbo_Author.SelectedItem).MATG,
                    NAMXB = int.Parse(cbo_Year.SelectedItem.ToString()),
                    MANXB = ((NHAXUATBAN)cbo_Pulisher.SelectedItem).MANXB,
                    MALOAI = ((LOAISACH)cbo_Type.SelectedItem).MALOAI,
                    SOLUONG = int.Parse(txt_SoLuong.Text),
                    SOLUONGCON = int.Parse(txt_SoLuong.Text),


                };

                var kiemtraTrung = db.SACHes.Where(r => r.MASH == sv.MASH)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Book code already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mã sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.SACHes.InsertOnSubmit(sv);
                db.SubmitChanges();
                loadDataToGridView_Sach();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Add successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resetForm();
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thietLapButton("sach", false);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                SACH sv = dataGridView5.CurrentRow.DataBoundItem as SACH;
                masach = dataGridView5.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    txt_BookName.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
                    string temp_tg = dataGridView5.CurrentRow.Cells[2].Value.ToString();
                    string temp_namnxb = dataGridView5.CurrentRow.Cells[3].Value.ToString();
                    string temp_nxb = dataGridView5.CurrentRow.Cells[4].Value.ToString().Trim();
                    string temp_loai = dataGridView5.CurrentRow.Cells[5].Value.ToString();

                    TACGIA tg1 = db.TACGIAs.Where(r => r.MATG.Equals(temp_tg)).FirstOrDefault();
                    NHAXUATBAN nxb1 = db.NHAXUATBANs.Where(r => r.MANXB.Equals(temp_nxb)).FirstOrDefault();
                    LOAISACH loai1 = db.LOAISACHes.Where(r => r.MALOAI.Equals(temp_loai)).FirstOrDefault();

                    cbo_Author.SelectedIndex = cbo_Author.FindString(tg1.TENTG.Trim());
                    cbo_Year.SelectedIndex = cbo_Year.FindString(temp_namnxb.Trim());

                    cbo_Pulisher.SelectedIndex = cbo_Pulisher.FindString(nxb1.TENNXB);

                    cbo_Type.SelectedIndex = cbo_Type.FindString(loai1.TENLOAI.Trim());
                    
                    txt_SoLuong.Text = dataGridView5.CurrentRow.Cells[6].Value.ToString();
                    txt_SoLuongCon.Text = dataGridView5.CurrentRow.Cells[7].Value.ToString();

                }
                catch { }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            thietLapButton("sach", true);
            if (txt_BookName.Text.Length == 0)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Please enter book type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                SACH sv = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sách này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                sv.TENSH = txt_BookName.Text;
                sv.MALOAI = int.Parse(cbo_Type.SelectedValue.ToString());
                sv.MANXB = int.Parse(cbo_Pulisher.SelectedValue.ToString());
                sv.MATG = int.Parse(cbo_Author.SelectedValue.ToString());
                sv.NAMXB = int.Parse(cbo_Year.SelectedItem.ToString());
                sv.SOLUONG = int.Parse(txt_SoLuong.Text);
                db.SubmitChanges();
                loadDataToGridView_Sach();
                resetForm();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }



        public void thietLapButton(string lenh, bool them)
        {

            //sach
            if (lenh.CompareTo("sach") == 0 && them == true)
            {
                btnCancel.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }



            if (lenh.CompareTo("sach") == 0 && them == false)
            {
                btnCancel.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }


        }

        private void button_huy_5_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoLuongCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbo_Author_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rd_BookName.Checked)
            {
                string ndtim = txt_Search.Text.Trim();
                loadDataToGridView_Sach(ndtim, -1);
            }
            if (rd_Year.Checked)
            {
                int ndtim = int.Parse(txt_Search.Text.Trim());
                loadDataToGridView_Sach(null, ndtim);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            Reportfrm_TTSach sach = new Reportfrm_TTSach();
            sach.Show();
        }

        private void txt_SoLuongCon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rd_BookName_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void rd_Year_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rd_Year.Checked)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txt_BookName.Text.Length == 0 || txt_SoLuong.Text.Length==0)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Please enter book type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                SACH sv = new SACH
                {
                    TENSH = txt_BookName.Text,
                    MATG = ((TACGIA)cbo_Author.SelectedItem).MATG,
                    NAMXB = int.Parse(cbo_Year.SelectedItem.ToString()),
                    MANXB = ((NHAXUATBAN)cbo_Pulisher.SelectedItem).MANXB,
                    MALOAI = ((LOAISACH)cbo_Type.SelectedItem).MALOAI,
                    SOLUONG = int.Parse(txt_SoLuong.Text),
                    SOLUONGCON = int.Parse(txt_SoLuong.Text),


                };

                var kiemtraTrung = db.SACHes.Where(r => r.MASH == sv.MASH)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Book code already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mã sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.SACHes.InsertOnSubmit(sv);
                db.SubmitChanges();
                loadDataToGridView_Sach();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Add successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resetForm();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            thietLapButton("sach", true);
            if (txt_BookName.Text.Length == 0)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Please enter book type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                SACH sv = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sách này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                sv.TENSH = txt_BookName.Text;
                sv.MALOAI = int.Parse(cbo_Type.SelectedValue.ToString());
                sv.MANXB = int.Parse(cbo_Pulisher.SelectedValue.ToString());
                sv.MATG = int.Parse(cbo_Author.SelectedValue.ToString());
                sv.NAMXB = int.Parse(cbo_Year.SelectedItem.ToString());
                sv.SOLUONG = int.Parse(txt_SoLuong.Text);
                sv.SOLUONGCON = int.Parse(txt_SoLuong.Text);
                db.SubmitChanges();
                loadDataToGridView_Sach();
                resetForm();
                if (Program.Language == "English")
                {
                    MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            thietLapButton("sach", true);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                SACH sv = db.SACHes.Where(r => r.MASH.Equals(masach)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sách này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                try
                {
                    db.SACHes.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    loadDataToGridView_Sach();
                    resetForm();
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khóa ngoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }





    }
}
