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
    public partial class frmDocGia : Form
    {
        string madocgia;
        public frmDocGia()
        {
            InitializeComponent();
            loadDataToGridView_DocGia();
        }
        private void resetForm()
        {
            //docgia
            btnCancel1.Enabled = false;
            btnEdit1.Enabled = false;
            btnDelete1.Enabled = false;
            btnAdd1.Enabled = true;

            txt_DaMuon.Clear();
            txt_DangMuon.Clear();
            txt_GiaHan.Clear();
            txt_Phone.Clear();
            txt_ReaderName.Clear();


        }
        private void loadDataToGridView_DocGia()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                dataGridView1.DataSource = db.DOCGIAs.Select(sv => new
                {
                    MADG = sv.MADG,
                    TENDG = sv.TENDG,
                    NGAYSINH = sv.NGAYSINH,
                    GIOITINH = sv.GIOITINH,
                    LIENHE = sv.LIENHE,
                    MUON = sv.MUON,
                    TRA = sv.TRA,
                    QUYEN = sv.QUYEN,
                    DOITUONG = sv.DOITUONG,
                    SOGIAHAN = sv.SOGIAHAN
                });
            }
        }



        public void thietLapButton(string lenh, bool them)
        {



            //docgia
            if (lenh.CompareTo("docgia") == 0 && them == true)
            {
                btnCancel1.Enabled = false;
                btnEdit1.Enabled = false;
                btnDelete1.Enabled = false;
                btnAdd1.Enabled = true;
            }

            //docgia
            if (lenh.CompareTo("docgia") == 0 && them == false)
            {
                btnCancel1.Enabled = true;
                btnEdit1.Enabled = true;
                btnDelete1.Enabled = true;
                btnAdd1.Enabled = false;
            }


        }

        private void SetEnglish()
        {

            //quản lý độc giả
            lbl_ReaderName.Text = "Reader Name";
            lbl_Birthday.Text = "Birthday";
            lbl_Sex.Text = "Sex";
            lbl_Phone.Text = "Phone";
            btnAdd1.Text = "Add";
            btnCancel1.Text = "Cancel";
            btnDelete1.Text = "Delete";
            btnEdit1.Text = "Edit";
            colReaderID.HeaderText = "Reader Code";
            colReaderName.HeaderText = "Reader Name";
            colBirthday.HeaderText = "Birthday";
            colPhone.HeaderText = "Phone";

        }


        private void btnAdd1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void TimKiemDocGia(string tendg, int madg)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                if (madg < 0)
                {
                    dataGridView1.DataSource = db.DOCGIAs.Where(r => r.TENDG.Contains(tendg)).Select(sv => new
                    {
                        MADG = sv.MADG,
                        TENDG = sv.TENDG,
                        NGAYSINH = sv.NGAYSINH,
                        GIOITINH = sv.GIOITINH,
                        LIENHE = sv.LIENHE,
                        MUON = sv.MUON,
                        TRA = sv.TRA,
                        QUYEN = sv.QUYEN,
                        DOITUONG = sv.DOITUONG,
                        SOGIAHAN = sv.SOGIAHAN

                    });


                }
                else
                {

                    dataGridView1.DataSource = db.DOCGIAs.Where(r => r.MADG == madg).Select(sv => new
                    {
                        MADG = sv.MADG,
                        TENDG = sv.TENDG,
                        NGAYSINH = sv.NGAYSINH,
                        GIOITINH = sv.GIOITINH,
                        LIENHE = sv.LIENHE,
                        MUON = sv.MUON,
                        TRA = sv.TRA,
                        QUYEN = sv.QUYEN,
                        DOITUONG = sv.DOITUONG,
                        SOGIAHAN = sv.SOGIAHAN
                    });

                }
            }
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                this.Text = "Reader Management";
                SetEnglish();
                cbo_Sex.Items.Add("Male");
                cbo_Sex.Items.Add("Female");
                comboBox_DoiTuong.Items.Add("User Out Of School");
                comboBox_DoiTuong.Items.Add("The Student");
                comboBox_DoiTuong.Items.Add("Lecturers");
                comboBox_DoiTuong.Items.Add("Officials");
                comboBox_Quyen.Items.Add("Active");
                comboBox_Quyen.Items.Add("Stop");
                groupBox1.Text = "Reader Information";
                groupBox2.Text = "Search";
                rd_ReaderID.Text = "Search By Reader ID";
                rd_ReaderName.Text = "Search By Reader Name";
                btnSearch.Text = "Search";
                comboBox_DoiTuong.SelectedIndex = 0;
                lbl_Birthday.Text = "Birthday";
                lbl_Phone.Text = "Phone";
                lbl_ReaderName.Text = "ReaderName";
                lbl_Sex.Text = "Sex";
                lblActive.Text = "Active";
                lblBorrowed.Text = "Borrowed";
                lblBorrowing.Text = "Borrowing";
                lblNumberOfRenewals.Text = "Number Of Renewals";
                lblObject.Text = "Object";
                dataGridView1.Columns[0].HeaderText = "Reader ID";
                dataGridView1.Columns[1].HeaderText = "Reader Name";
                dataGridView1.Columns[2].HeaderText = "Birthday";
                dataGridView1.Columns[3].HeaderText = "Sex";
                dataGridView1.Columns[4].HeaderText = "Phone";
                dataGridView1.Columns[5].HeaderText = "Borrowing";
                dataGridView1.Columns[6].HeaderText = "Borrowed";
                dataGridView1.Columns[7].HeaderText = "Active";
                dataGridView1.Columns[8].HeaderText = "Object";
                dataGridView1.Columns[9].HeaderText = "Number Of Renewals";
                btn_In.Text = "Print";
                comboBox_Quyen.DisplayMember = "Text";
                comboBox_Quyen.ValueMember = "Value";
                var itemsQuyen = new[] { 
                    new { Text = "Active", Value = "1" }, 
                    new { Text = "Stop", Value = "0" }, 
                    
                };
                comboBox_Quyen.DataSource = itemsQuyen;
                comboBox_Quyen.SelectedIndex = 0;


                comboBox_DoiTuong.DisplayMember = "Text";
                comboBox_DoiTuong.ValueMember = "Value";

                var items = new[] { 
                    new { Text = "User Out Of School", Value = "0" }, 
                    new { Text = "The Student", Value = "1" }, 
                    new { Text = "Lecturers", Value = "2" },
                    new { Text = "Officials", Value = "3" },
                };
                comboBox_DoiTuong.DataSource = items;
            }
            else
            {
                cbo_Sex.Items.Add("Nam");
                cbo_Sex.Items.Add("Nữ");

                comboBox_Quyen.DisplayMember = "Text";
                comboBox_Quyen.ValueMember = "Value";

                var itemsQuyen = new[] { 
                    new { Text = "Hoạt động", Value = "1" }, 
                    new { Text = "Tạm dừng", Value = "0" }, 
                    
                };

                comboBox_Quyen.DataSource = itemsQuyen;
                comboBox_Quyen.SelectedIndex = 0;


                comboBox_DoiTuong.DisplayMember = "Text";
                comboBox_DoiTuong.ValueMember = "Value";

                var items = new[] { 
                    new { Text = "Người sử dụng ngoài trường", Value = "0" }, 
                    new { Text = "Sinh viên, học viên", Value = "1" }, 
                    new { Text = "Giảng viên thỉnh giảng", Value = "2" },
                    new { Text = "Giảng viên, viên chức", Value = "3" },
                };

                comboBox_DoiTuong.DataSource = items;

            }

            cbo_Sex.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thietLapButton("docgia", false);
            DOCGIA sv = dataGridView1.CurrentRow.DataBoundItem as DOCGIA;
            madocgia = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                txt_ReaderName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                string gt = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string quyen = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                string doituong = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                string muon = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string tra = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string sogiahan = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                cbo_Sex.SelectedIndex = cbo_Sex.FindString(gt.Trim());
                comboBox_Quyen.SelectedValue = quyen.Trim();


                comboBox_DoiTuong.SelectedIndex = int.Parse(doituong);
                txt_DaMuon.Text = tra;
                txt_DangMuon.Text = muon;
                txt_GiaHan.Text = sogiahan;

                txt_Phone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            catch { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DaMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DangMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_DoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int giatri = int.Parse(comboBox_DoiTuong.SelectedValue.ToString());
                if (giatri == 0 || giatri == 3)
                {
                    txt_GiaHan.Text = '0'.ToString();

                }
                else
                {
                    txt_GiaHan.Text = '1'.ToString();
                }

            }
            catch
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rd_ReaderName.Checked)
            {
                string ndtim = txt_Search.Text.Trim();
                TimKiemDocGia(ndtim, -1);
            }
            if (rd_ReaderID.Checked)
            {
                int ndtim = int.Parse(txt_Search.Text.Trim());
                TimKiemDocGia(null, ndtim);
            }
        }

        //lấy tuổi
        public int GetAge( DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        private void btnAdd1_Click_1(object sender, EventArgs e)
        {
            if (txt_ReaderName.Text.Length == 0 || txt_Phone.Text.Length == 0)
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

            //YÊU CẦU 18 TUỔI
            if (GetAge(dateTimePicker1.Value)<18)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Age must be more than 18!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tuổi phải lớn hơn 18!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


            //bắt đầu thêm

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                DOCGIA sv = new DOCGIA
                {
                    TENDG = txt_ReaderName.Text,
                    NGAYSINH = dateTimePicker1.Value,
                    GIOITINH = cbo_Sex.SelectedItem.ToString(),
                    LIENHE = txt_Phone.Text,
                    QUYEN = int.Parse(comboBox_Quyen.SelectedValue.ToString()),
                    DOITUONG = int.Parse(comboBox_DoiTuong.SelectedValue.ToString()),
                    SOGIAHAN = int.Parse(txt_GiaHan.Text),
                    MUON = 0,
                    TRA = 0
                };

                var kiemtraTrung = db.DOCGIAs.Where(r => r.MADG == sv.MADG)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This reader already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Tác giả đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.DOCGIAs.InsertOnSubmit(sv);
                db.SubmitChanges();
                loadDataToGridView_DocGia();

                //thông báo thành công
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

        private void btnDelete1_Click_1(object sender, EventArgs e)
        {
            thietLapButton("docgia", true);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                DOCGIA sv = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This reader does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Độc giả này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                try
                {
                    db.DOCGIAs.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    loadDataToGridView_DocGia();
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
                        MessageBox.Show("This reader cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khóa ngoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEdit1_Click_1(object sender, EventArgs e)
        {
            thietLapButton("docgia", true);
            if (txt_ReaderName.Text.Length == 0 || txt_Phone.Text.Length == 0)
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
            if (GetAge(dateTimePicker1.Value) < 18)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("Age must be more than 18!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tuổi phải lớn hơn 18!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            if (cbo_Sex.SelectedItem == null)
            {
                if (Program.Language == "English")
                {
                    MessageBox.Show("You haven't chosen a gender yet!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;

            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                DOCGIA sv = db.DOCGIAs.Where(r => r.MADG.Equals(madocgia)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This reader does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Độc giả này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }

                sv.TENDG = txt_ReaderName.Text;
                sv.LIENHE = txt_Phone.Text;
                sv.GIOITINH = cbo_Sex.SelectedItem.ToString();
                sv.NGAYSINH = dateTimePicker1.Value;
                sv.QUYEN = int.Parse(comboBox_Quyen.SelectedValue.ToString());
                sv.DOITUONG = int.Parse(comboBox_DoiTuong.SelectedValue.ToString());
                sv.SOGIAHAN = int.Parse(txt_GiaHan.Text);
                db.SubmitChanges();
                loadDataToGridView_DocGia();
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

        private void btnCancel1_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            Reportfrm_DocGia dg = new Reportfrm_DocGia();

            dg.Show();
        }

        private void txt_GiaHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_DoiTuong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                int giatri = int.Parse(comboBox_DoiTuong.SelectedValue.ToString());
                if (giatri == 0 || giatri == 3)
                {
                    txt_GiaHan.Text = '0'.ToString();

                }
                else
                {
                    txt_GiaHan.Text = '1'.ToString();
                }

            }
            catch
            {

            }
        }
    }

}