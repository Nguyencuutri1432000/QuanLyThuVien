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
    public partial class frmDangNhap : Form
    {
        private string caption, message;
        public frmDangNhap()
        {
            InitializeComponent();
            try
            {
                frmMuonTraSach.ActiveForm.Hide();
            }
            catch
            {

            }




            textBox2.Text = "";
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string tentk = textBox1.Text;
                string matkhau = textBox2.Text;

                if (tentk.Length == 0 || matkhau.Length == 0)
                {
                    if (Program.Language == "English")
                    {
                        caption = "Error";
                        message = "Invalid or blank Username and/or Password.";
                    }
                    else
                    {
                        caption = "Lỗi";
                        message = "Tên đăng nhập hoặc mật khẩu là trống hoặc không hợp lệ.";
                    }
                    MessageBox.Show(message, caption);
                    return;
                }


                TAIKHOAN sv = db.TAIKHOANs.Where(r => r.TENTK == tentk && r.MATKHAU == matkhau).FirstOrDefault();
                if (sv == null)
                {
                    if (Program.Language == "English")
                    {
                        caption = "Information";
                        message = "Username or password is incorrect.";
                    }
                    else
                    {
                        caption = "Thông báo";
                        message = "Tên đăng nhập hoặc mật khẩu không đúng.";
                    }
                    MessageBox.Show(message, caption);

                }
                else
                {
                    if (Program.Language == "English")
                    {
                        caption = "Information";
                        message = "Login Successfully";
                    }
                    else
                    {
                        caption = "Thông báo";
                        message = "Đăng nhập thành công.";
                    }
                    MessageBox.Show(message, caption);
                    int idlogin = sv.ID;
                    Main f2 = new Main(idlogin);

                    f2.ShowDialog(); // Shows Form2
                }
            }
        }
    

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(Program.Language=="English")
            {
                DialogResult rs = MessageBox.Show("Do you want exit?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
          
        }

        private void Đăng_nhập_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void cbo_NgonNgu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Program.Language = cbo_NgonNgu.SelectedItem.ToString();
            if (cbo_NgonNgu.SelectedItem.ToString() == "English")
            {
                if (Program.Language == "English")
                {
                    btnDangNhap.Text = "Login";
                    lbl_usename.Text = "UseName";
                    lbl_pass.Text = "Password";
                    lbl_NgonNgu.Text = "Language";
                    btnExit.Text = "Exit";
                    lbl_title.Text = "SOFTWARE MANAGEMENT LIBRARY";
                    //btn_TaoTaiKhoan.Text = "Create Account";
                    this.Text = "Login";
                    label3.Text = "Hours of operation | Details";
                    label1.Text = "HO CHI MINH CITY  UNIVERSITY OF FOOD INDUSTRY";
                    label2.Text = "LIBRARY - INFORMATION";
                }
            }
            else
            {
                lbl_usename.Text = "Đăng nhập";
                lbl_pass.Text = "Mật khẩu";
                lbl_NgonNgu.Text = "Ngôn ngữ";
                btnDangNhap.Text = "Đăng nhập";
                lbl_title.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
                label3.Text = "Giờ hoạt động | Chi Tiết";
                label1.Text = "ĐẠI HỌC CÔNG NGHIỆP THỰC PHẦM TP.HCM";
                label2.Text = "TRUNG TÂM THÔNG TIN - THƯ VIỆN";
                //btn_TaoTaiKhoan.Text = "Tạo tài khoản";
            }
        }

        private void Đăng_nhập_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Đăng_nhập_Load(object sender, EventArgs e)
        {
            cbo_NgonNgu.SelectedIndex = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Information fr = new Information();
            fr.Show();
            this.Hide();
        }
    }
}
