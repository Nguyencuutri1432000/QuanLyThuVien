using Microsoft.Reporting.WinForms;
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
    public partial class Reportfrm_MuonTraSach : Form
    {
        int loai = 0;
        public Reportfrm_MuonTraSach(int loai2)
        {
            loai = loai2;
            InitializeComponent();
        }

        private void Reportfrm_MuonTraSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_THUVIENDataSet2.MUONTRASACHP' table. You can move, or remove it, as needed.
            if (loai == 0)//đang mượn
            {
                string tempTieuDe = "THỐNG KÊ DANH SÁCH THÔNG TIN MƯỢN SÁCH";
                ReportParameter params1 = new ReportParameter();
                params1 = new ReportParameter("ReportParameter_TieuDe", tempTieuDe);

                this.MUONTRASACHPTableAdapter.FillByDangMuon(this.QL_THUVIENDataSet2.MUONTRASACHP);
                this.reportViewer1.LocalReport.SetParameters(params1);
                this.reportViewer1.RefreshReport();
            }
            if (loai == 1) //đã trả
            {
                string tempTieuDe = "THỐNG KÊ DANH SÁCH THÔNG TIN TRẢ SÁCH";
                ReportParameter params1 = new ReportParameter();
                params1 = new ReportParameter("ReportParameter_TieuDe", tempTieuDe);

                this.MUONTRASACHPTableAdapter.FillByDaTra(this.QL_THUVIENDataSet2.MUONTRASACHP);
                this.reportViewer1.LocalReport.SetParameters(params1);
                this.reportViewer1.RefreshReport();
            }
            if (loai == 2) //quá hạn
            {
                string tempTieuDe = "THỐNG KÊ DANH SÁCH THÔNG TIN MƯỢN SÁCH QUÁ HẠN";
                ReportParameter params1 = new ReportParameter();
                params1 = new ReportParameter("ReportParameter_TieuDe", tempTieuDe);

                this.MUONTRASACHPTableAdapter.FillByQuaHan(this.QL_THUVIENDataSet2.MUONTRASACHP);
                this.reportViewer1.LocalReport.SetParameters(params1);
                this.reportViewer1.RefreshReport();
            }

        }
    }
}
