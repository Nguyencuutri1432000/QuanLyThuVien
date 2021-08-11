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
    public partial class Main : Form
    {
        private string caption, message;
        int nid = 0;
        public Main(int idlogin)
        {
            nid = idlogin;
            InitializeComponent();
            try
            {

                frmDangNhap.ActiveForm.Hide();

            }

            catch { }
            
        }

        private void tsSach_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.MdiParent = this;
            frm.Name = "Quản lý sách trong thư viện";
            frm.Show();
        }

        
        private void Main_Load(object sender, EventArgs e)
        {
           
            
            if(Program.Language=="English")
            {
                setEngLish();
            }
        }
        private void setEngLish()
        {
            this.Text = "SOFTWARE MANAGEMENT LIBRARY";
            quảnLýThôngTinToolStripMenuItem.Text = "Information Management";
            quảnLýMượnTrảSáchToolStripMenuItem.Text = "Borrow - Return Management";
            tsDangXuat.Text = "Log Out";
            tsDocGia.Text = "Reader Management";
            tsLoai.Text = "Book Type Management";
            tsNXB.Text = "Pulisher Management";
            tsSach.Text = "Book Management";
            tsTacGia.Text = "Author Management";
            traCứuThốngKêToolStripMenuItem.Text = "Lookup - Statistics";
            tsTaiKhoan.Text = "Acount Management";
            tsCreateAccount.Text = "Create Account";
            tsDoiMK.Text = "Account";
            tsTKSach.Text = "Book Information Statistics";
            tsTKSYEAR.Text = "Reader Information Statistics";
            tsMuon.Text = "Statistical List of Borrowing Information";
            tsTra.Text = "Statistical List of Returns Information";
            tsTraQuaHan.Text = "Statistics List of Overdue Returns Information";
        }
        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            if (Program.Language == "English")
            {
                caption = "Confirm exit";
                message = "Do you want to sign out?";
            }
            else
            {
                caption = "Xác nhận thoát";
                message = "Bạn có chắc muốn đăng xuất?";
            }
            DialogResult dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Program.LoginFrm.Show();
                this.Hide();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsTKSach_Click(object sender, EventArgs e)
        {
            Reportfrm_TTSach rp = new Reportfrm_TTSach();
            rp.MdiParent = this;
            rp.Show();
        }

        private void tsDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia dg = new frmDocGia();
            dg.MdiParent = this;
            dg.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia dg = new frmTacGia();
            dg.MdiParent = this;
            dg.Show();
        }

        private void tsNXB_Click(object sender, EventArgs e)
        {
            frmNXB dg = new frmNXB();
            dg.MdiParent = this;
            dg.Show();
        }

        private void tsTaiKhoan_Click(object sender, EventArgs e)
        {
          
        }

        private void tsLoai_Click(object sender, EventArgs e)
        {
            frmLoaiSach dg = new frmLoaiSach();
            dg.MdiParent = this;
            dg.Show();
        }

        private void quảnLýMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonTraSach dg = new frmMuonTraSach(nid);
            dg.MdiParent = this;
            dg.Show();
        }

        private void tsTKSYEAR_Click(object sender, EventArgs e)
        {
            Reportfrm_DocGia dg = new Reportfrm_DocGia();
            dg.MdiParent = this;
            dg.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(nid);
            tk.MdiParent = this;
            tk.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy dg = new frmDangKy();
            dg.MdiParent = this;
            dg.Show();
        }

        private void thốngKêDanhSáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportfrm_MuonTraSach dg = new Reportfrm_MuonTraSach(0);
            dg.MdiParent = this;
            dg.Show();
        }

        private void thốngKêDanhSáchTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportfrm_MuonTraSach dg = new Reportfrm_MuonTraSach(1);
            dg.MdiParent = this;
            dg.Show();
        }

        private void thốngKêDanhSáchTrảSáchQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportfrm_MuonTraSach dg = new Reportfrm_MuonTraSach(2);
            dg.MdiParent = this;
            dg.Show();
        }
    }
}
