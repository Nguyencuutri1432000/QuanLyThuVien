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
    public partial class frmDangKy : Form
    {
        private string caption, message;
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = txt_Pass.Text;
            string re_pass = txt_rePass.Text;
            if (pass != re_pass)
            {
                if (Program.Language == "English")
                {
                    message = "Those passwords didn’t match. Try again.";
                    caption = "Information";
                }
                else
                {
                    message = "Mật khẩu và xác nhận mật khẩu không khớp.";
                    caption = "Thông báo";
                }
                MessageBox.Show(message, caption);
                return;
            }
            if (pass.Length == 0|| re_pass.Length == 0)
            {
                button1.Enabled = false;
                if (Program.Language == "English")
                {
                    message = "Enter a password.Try again.";
                    caption = "Information";
                }
                else
                {
                    message = "Xin vui lòng nhập mật khẩu.";
                    caption = "Thông báo";
                }
                MessageBox.Show(message, caption);
                return;
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                TAIKHOAN sv = new TAIKHOAN
                {
                    TENTK = txt_useName.Text.Trim(),
                    HOTEN = txt_Name.Text.Trim(),
                    MATKHAU = txt_Pass.Text.Trim(),
                };

                var kiemtraTrung = db.TAIKHOANs.Where(r => r.TENTK == sv.TENTK)
                    .Count();
                if (kiemtraTrung > 0)
                {
                    if (Program.Language == "English")
                    {
                        caption = "Information";
                        message = "Account already exists.Create new account failed.";
                    }
                    else
                    {
                        caption = "Thông báo";
                        message = "Tạo tài khoản thất bại.";
                    }
                    MessageBox.Show(message, caption);
                    return;
                }

                db.TAIKHOANs.InsertOnSubmit(sv);
                db.SubmitChanges();
                if (Program.Language == "English")
                {
                    caption = "Information";
                    message = "Create Successfully";
                }
                else
                {
                    caption = "Thông báo";
                    message = "Tạo tài khoản thành công.";
                }
                MessageBox.Show(message, caption);
                txt_Name.Text = txt_Pass.Text = txt_rePass.Text = txt_useName.Text = "";
                
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                caption = "Confirm exit";
                message = "Are you sure you want to exit ?";
            }
            else
            {
                caption = "Xác nhận thoát";
                message = "Bạn có chắc muốn thoát ứng dụng ?";
            }
            DialogResult dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Program.LoginFrm.Show();
                Program.RegisterFrm.Hide();
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                this.Text = "Register";
                lbl_TK.Text = "UseName";
                lbl_HoTen.Text = "Name";
                lbl_MK.Text = "PassWord";
                lbl_NhapLaiMK.Text = "Confirm";
                button1.Text = "Save";
                button4.Text = "Cancel";
                lbl_title.Text = "Create Account";
            }
            button1.Enabled = false;
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void txt_rePass_TextChanged(object sender, EventArgs e)
        {
            if (txt_Pass.Text != "")
            {
                if (txt_rePass.Text != "")
                    button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void txt_rePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
