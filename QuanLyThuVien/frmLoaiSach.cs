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
    public partial class frmLoaiSach : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
            
        string maloaisach;
        public frmLoaiSach()
        {
            InitializeComponent();
            loadDataToGridView_LoaiSach();

        }


        private void SetEnglish()
        {


            //quản lý loại sách
            this.Text = "Book Type Management";
            lbl_BookType.Text = "Book Type";
            btnAdd4.Text = "Add";
            btnCancel4.Text = "Cancel";
            btnDelete4.Text = "Delete";
            btnEdit4.Text = "Edit";
            dataGridView4.Columns[0].HeaderText = "Type Code";
            dataGridView4.Columns[1].HeaderText = "Book Type";
            


        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEdit4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            resetForm();
        }


        private void resetForm()
        {

            //loai sach
            btnCancel4.Enabled = false;
            btnEdit4.Enabled = false;
            btnDelete4.Enabled = false;
            btnAdd4.Enabled = true;

            txt_BookType.Clear();

        }

        private void loadDataToGridView_LoaiSach()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                dataGridView4.DataSource = db.LOAISACHes.Select(sv => new { MALOAI = sv.MALOAI, TENLOAI = sv.TENLOAI });
            }
        }

        public void thietLapButton(string lenh, bool them)
        {
            //loai sach
            if (lenh.CompareTo("loaisach") == 0 && them == false)
            {
                btnCancel4.Enabled = true;
                btnEdit4.Enabled = true;
                btnDelete4.Enabled = true;
                btnAdd4.Enabled = false;
            }

            if (lenh.CompareTo("loaisach") == 0 && them == true)
            {
                btnCancel4.Enabled = false;
                btnEdit4.Enabled = false;
                btnDelete4.Enabled = false;
                btnAdd4.Enabled = true;
            }

 
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thietLapButton("loaisach", false);
            LOAISACH sv = dataGridView4.CurrentRow.DataBoundItem as LOAISACH;
            maloaisach = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            try
            {

                txt_BookType.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                SetEnglish();
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            if (txt_BookType.Text.Length == 0)
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

                LOAISACH sv = new LOAISACH
                {

                    TENLOAI = txt_BookType.Text,
                };

                var kiemtraTrung = db.LOAISACHes.Where(r => r.MALOAI == sv.MALOAI)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This book type already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Loại sách này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.LOAISACHes.InsertOnSubmit(sv);
                db.SubmitChanges();
                loadDataToGridView_LoaiSach();
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

        private void btnDelete4_Click_1(object sender, EventArgs e)
        {
            thietLapButton("loaisach", true);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                LOAISACH sv = db.LOAISACHes.Where(r => r.MALOAI.Equals(maloaisach)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Book type does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Loại sách không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }

                try
                {
                    db.LOAISACHes.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    loadDataToGridView_LoaiSach();
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
                        MessageBox.Show("This book type cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khóa ngoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit4_Click_1(object sender, EventArgs e)
        {
            thietLapButton("loaisach", true);
            if (txt_BookType.Text.Length == 0)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Please enter enough information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                LOAISACH sv = db.LOAISACHes.Where(r => r.MALOAI.Equals(maloaisach)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Book type does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Loại sách không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                sv.TENLOAI = txt_BookType.Text;
                db.SubmitChanges();
                loadDataToGridView_LoaiSach();
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

        private void btnCancel4_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
