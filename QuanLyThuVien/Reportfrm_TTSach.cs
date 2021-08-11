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
    public partial class Reportfrm_TTSach : Form
    {
        public Reportfrm_TTSach()
        {
            InitializeComponent();
        }

        private void Reportfrm_TTSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_THUVIENDataSet4.SACHP' table. You can move, or remove it, as needed.
            this.SACHPTableAdapter.Fill(this.QL_THUVIENDataSet4.SACHP);

            this.reportViewer1.RefreshReport();
        }
    }
}
