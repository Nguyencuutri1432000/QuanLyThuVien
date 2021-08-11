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
    public partial class frmTacGia : Form
    {
        string matacgia;

        public frmTacGia()
        {
            InitializeComponent();
            loadDataToGridView_TacGia();

        }

        public void thietLapButton(string lenh, bool them)
        {
            //tac gia
            if (lenh.CompareTo("tacgia") == 0 && them == true)
            {
                btnCancel3.Enabled = false;
                btnDelete3.Enabled = false;
                btnEdit3.Enabled = false;
                btnAdd3.Enabled = true;
            }



            if (lenh.CompareTo("tacgia") == 0 && them == false)
            {
                btnCancel3.Enabled = true;
                btnDelete3.Enabled = true;
                btnEdit3.Enabled = true;
                btnAdd3.Enabled = false;
            }

        }
        private void resetForm()
        {
            //tac gia
            btnCancel3.Enabled = false;
            btnDelete3.Enabled = false;
            btnEdit3.Enabled = false;
            btnAdd3.Enabled = true;

            txt_Address.Clear();
            txt_AuthorName.Clear();

        }



        private void SetEnglish()
        {

            //quản lý tác giả  
            this.Text = "Author Management";
            lbl_AuthorName.Text = "Author Name";
            lbl_Address.Text = "Address";
            btnAdd3.Text = "Add";
            btnCancel3.Text = "Cancel";
            btnDelete3.Text = "Delete";
            btnEdit3.Text = "Edit";
            groupBox1.Text = "Author Information";
            groupBox2.Text = "Search";
            rd_AuthorName.Text = "Search By Author Name";
            rd_AuthorID.Text = "Search By Author ID";
            btnSearch.Text = "Search";
            dataGridView3.Columns[0].HeaderText = "Author Code";
            dataGridView3.Columns[1].HeaderText = "Author Name";
            dataGridView3.Columns[2].HeaderText = "Author Address";
            //lbl_AuthorManagement.Text = "AUTHOR MANAGEMENT";


        }


        private void loadDataToGridView_TacGia()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                dataGridView3.DataSource = db.TACGIAs.Select(sv => new { MATG = sv.MATG, TENTG = sv.TENTG, DIACHI = sv.DIACHI });
            }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thietLapButton("tacgia", false);
            TACGIA sv = dataGridView3.CurrentRow.DataBoundItem as TACGIA;
            matacgia = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            try
            {
                txt_AuthorName.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_Address.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            catch { }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {

            if (txt_AuthorName.Text.Length == 0 || txt_Address.Text.Length == 0)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Please enter author's name and address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                TACGIA sv = new TACGIA
                {

                    TENTG = txt_AuthorName.Text,
                    DIACHI = txt_Address.Text,
                };

                var kiemtraTrung = db.TACGIAs.Where(r => r.MATG == sv.MATG)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This author already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Tác giả này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.TACGIAs.InsertOnSubmit(sv);
                db.SubmitChanges();
                loadDataToGridView_TacGia();
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

        private void btnEdit3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                SetEnglish();
            }
        }

        private void btnCancel3_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rd_AuthorName.Checked)
            {
                string ndtim = txt_Search.Text.Trim();
                TimKiemTacGia(ndtim, -1);
            }
            if (rd_AuthorID.Checked)
            {
                int ndtim = int.Parse(txt_Search.Text.Trim());
                TimKiemTacGia(null, ndtim);
            }
        }
        private void TimKiemTacGia(string tentg, int matg)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                if (matg < 0)
                {
                    dataGridView3.DataSource = db.TACGIAs.Where(r => r.TENTG.Contains(tentg)).Select(sv => new
                    {
                        MATG=sv.MATG,
                        TENTG=sv.TENTG,
                        DIACHI=sv.DIACHI
                    });


                }
                else
                {

                    dataGridView3.DataSource = db.TACGIAs.Where(r => r.MATG == matg).Select(sv => new
                    {
                        MATG = sv.MATG,
                        TENTG = sv.TENTG,
                        DIACHI = sv.DIACHI
                    });

                }
            }
        }

        private void btnDelete3_Click_1(object sender, EventArgs e)
        {
            thietLapButton("tacgia", true);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                TACGIA sv = db.TACGIAs.Where(r => r.MATG.Equals(matacgia)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This author does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("tác giả này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                try
                {
                    db.TACGIAs.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    loadDataToGridView_TacGia();
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
                        MessageBox.Show("This author cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khóa ngoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEdit3_Click_1(object sender, EventArgs e)
        {
            thietLapButton("tacgia", true);
            if (txt_AuthorName.Text.Length == 0 || txt_Address.Text.Length == 0)
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
                TACGIA sv = db.TACGIAs.Where(r => r.MATG.Equals(matacgia)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Author does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Tác giả không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                sv.TENTG = txt_AuthorName.Text;
                sv.DIACHI = txt_Address.Text;
                db.SubmitChanges();
                loadDataToGridView_TacGia();
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

    }
}
