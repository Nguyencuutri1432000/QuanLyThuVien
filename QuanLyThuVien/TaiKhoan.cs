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
    public partial class TaiKhoan : Form
    {
        private string caption,message;
        public TaiKhoan(int idlogin)
        {
            InitializeComponent();
            txt_Pass.Text = "";
            
            txt_Pass.PasswordChar = '*';
            
            txt_Pass.MaxLength = 14;

            txt_newPass.Text = "";
            
            txt_newPass.PasswordChar = '*';
            
            txt_newPass.MaxLength = 14;

            txt_Confirm.Text = "";
            
            txt_Confirm.PasswordChar = '*';
            


            txt_Confirm.MaxLength = 14;
            txt_User.Enabled = false;
            txt_ID.Enabled = false;
            txt_ID.Text = idlogin.ToString();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                TAIKHOAN sv = db.TAIKHOANs.Where(r => r.ID == idlogin).FirstOrDefault();
                txt_User.Text = sv.TENTK;
                txt_Name.Text = sv.HOTEN;
                //textBox2.Text = sv.MATKHAU;

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
                
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = txt_newPass.Text;
            string re_pass = txt_Confirm.Text;
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
            if (pass.Length == 0 || re_pass.Length == 0)
            {
                
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
                int nid=int.Parse(txt_ID.Text.Trim());
                string mkhientai = txt_Pass.Text.Trim();
                string mkmoi = txt_newPass.Text.Trim();
                string nhaplaimkmoi = txt_Confirm.Text.Trim();
                TAIKHOAN sv = db.TAIKHOANs.Where(r => r.ID == nid).FirstOrDefault();

                if(mkhientai.CompareTo(sv.MATKHAU)!=0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                
                }
                if(mkmoi.CompareTo(nhaplaimkmoi)!=0)
                {
                    if (Program.Language == "English")
                    {
                        MessageBox.Show("Those passwords didn’t match.Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Mật khẩu mới và nhập lại không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sv.HOTEN = txt_Name.Text.Trim();
                if (mkmoi.Length > 0)
                {
                    sv.MATKHAU = mkmoi;
                }
                
                db.SubmitChanges();
                txt_Pass.Text = "";
                txt_newPass.Text = "";
                txt_Confirm.Text = "";
                if (Program.Language == "English")
                {
                    MessageBox.Show("Successfully!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                this.Text = "Account";
                lbl_Usename.Text = "Usename";
                lbl_Name.Text = "Name";
                lbl_NewPass.Text = "NewPass";
                lbl_Pass.Text = "Pass";
                lbl_ConfirmPass.Text = "Confirm";
                lbl_title.Text = "Account";
                btn_Save.Text = "Save";
                btn_Exit.Text = "Exit";
            }
        }

    }
}
