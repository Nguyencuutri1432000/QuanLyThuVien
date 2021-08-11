using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    static class Program
    {
        public static frmDangKy RegisterFrm = null;
        public static frmDangNhap LoginFrm = null;
        
      

        public static string Language = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginFrm = new frmDangNhap(); 
    
            Application.Run(LoginFrm);
        }
    }
}
