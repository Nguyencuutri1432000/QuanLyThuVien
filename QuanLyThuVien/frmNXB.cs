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
    public partial class frmNXB : Form
    {
        string manxb;
        public frmNXB()
        {
            InitializeComponent();
            loadDataToGridView_NXB();
        }

        private void resetForm()
        {
            //nxb
            btnCancel2.Enabled = false;
            btnDelete2.Enabled = false;
            btnEdit2.Enabled = false;
            btnAdd2.Enabled = true;

            txt_PAddress.Clear();
            txt_PPhone.Clear();
            txt_PulisherName.Clear();
        }
        
        private void btnAdd2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            
        }



        private void loadDataToGridView_NXB()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                dataGridView2.DataSource = db.NHAXUATBANs.Select(sv => new { MANXB = sv.MANXB, TENNXB = sv.TENNXB, DCNXB = sv.DCNXB, DTNXB = sv.DTNXB });
            }
        }


        public void thietLapButton(string lenh, bool them)
        {
            //nxb
            if (lenh.CompareTo("nxb") == 0 && them == true)
            {
                btnCancel2.Enabled = false;
                btnDelete2.Enabled = false;
                btnEdit2.Enabled = false;
                btnAdd2.Enabled = true;
            }




            //nxb
            if (lenh.CompareTo("nxb") == 0 && them == false)
            {
                btnCancel2.Enabled = true;
                btnDelete2.Enabled = true;
                btnEdit2.Enabled = true;
                btnAdd2.Enabled = false;
            }

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thietLapButton("nxb", false);
            NHAXUATBAN sv = dataGridView2.CurrentRow.DataBoundItem as NHAXUATBAN;
            manxb = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            try
            {
                txt_PulisherName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_PAddress.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString().Trim();
                txt_PPhone.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString().Trim();
            }
            catch { }
        }
        private void SetEnglish()
        {
           
            //quản lý nxb  
            this.Text = "Pulisher Management";
            groupBox1.Text = "Type Book Information";
            groupBox2.Text = "Search";
            rd_PulisherName.Text = "Search By Pulisher Name";
            rd_Phone.Text = "Search By Pulisher Phone";
            btnSearch.Text = "Search";
            lbl_PulisherName.Text = "Pulisher Name";
            lbl_PulisherAddress.Text = "Address";
            lbl_PulisherPhone.Text = "Phone";
            btnAdd2.Text = "Add";
            btnCancel2.Text = "Cancel";
            btnDelete2.Text = "Delete";
            btnEdit2.Text = "Edit";
            dataGridView2.Columns[0].HeaderText = "Pulisher Code";
            dataGridView2.Columns[1].HeaderText = "Pulisher Name";
            dataGridView2.Columns[3].HeaderText = "Pulisher Phone";
            dataGridView2.Columns[2].HeaderText = "Address";
           
           


        }
        private void frmNXB_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                SetEnglish();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd2_Click_1(object sender, EventArgs e)
        {
            if (txt_PPhone.Text.Length == 0 || txt_PulisherName.Text.Length == 0 || txt_PAddress.Text.Length == 0)
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

                NHAXUATBAN sv = new NHAXUATBAN
                {
                    TENNXB = txt_PulisherName.Text,
                    DCNXB = txt_PAddress.Text,
                    DTNXB = txt_PPhone.Text,
                };

                var kiemtraTrung = db.TACGIAs.Where(r => r.MATG == sv.MANXB)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This pulisher already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nhà xuất bản này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                db.NHAXUATBANs.InsertOnSubmit(sv);
                db.SubmitChanges();
                loadDataToGridView_NXB();
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

        private void btnDelete2_Click_1(object sender, EventArgs e)
        {
            thietLapButton("nxb", true);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                NHAXUATBAN sv = db.NHAXUATBANs.Where(r => r.MANXB.Equals(manxb)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This pulisher does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nhà xuất bản này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                try
                {
                    db.NHAXUATBANs.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    loadDataToGridView_NXB();
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
                        MessageBox.Show("This pulisher cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khóa ngoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEdit2_Click_1(object sender, EventArgs e)
        {
            thietLapButton("nxb", true);
            if (txt_PPhone.Text.Length == 0 || txt_PulisherName.Text.Length == 0 || txt_PAddress.Text.Length == 0)
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
                NHAXUATBAN sv = db.NHAXUATBANs.Where(r => r.MANXB.Equals(manxb)).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("This pulisher does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("nhà xuất bản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;

                }
                sv.TENNXB = txt_PulisherName.Text;
                sv.DCNXB = txt_PAddress.Text;
                sv.DTNXB = txt_PPhone.Text;
                db.SubmitChanges();
                loadDataToGridView_NXB();
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

        private void btnCancel2_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rd_PulisherName.Checked)
            {
                string ndtim = txt_Search.Text.Trim();
                TimKiemTenNXB(ndtim);
            }
            if (rd_Phone.Checked)
            {
                string ndtim = txt_Search.Text.Trim();
                TimKiemSDTNXB(ndtim);
            }
        }
        private void TimKiemSDTNXB(string sdt)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {


                dataGridView2.DataSource = db.NHAXUATBANs.Where(r => r.DTNXB.Contains(sdt)).Select(sv => new
                {
                    MANXB = sv.MANXB,
                    TENNXB = sv.TENNXB,
                    DCNXB = sv.DCNXB,
                    DTNXB = sv.DTNXB
                });
            }
        }
        private void TimKiemTenNXB(string tennxb)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {


                dataGridView2.DataSource = db.NHAXUATBANs.Where(r => r.TENNXB.Contains(tennxb)).Select(sv => new
                    {
                        MANXB=sv.MANXB,
                        TENNXB=sv.TENNXB,
                        DCNXB = sv.DCNXB,
                        DTNXB = sv.DTNXB
                    });          
            }
        }
    }
}
