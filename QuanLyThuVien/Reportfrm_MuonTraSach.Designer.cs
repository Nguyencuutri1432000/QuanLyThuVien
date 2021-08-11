namespace QuanLyThuVien
{
    partial class Reportfrm_MuonTraSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_THUVIENDataSet2 = new QuanLyThuVien.QL_THUVIENDataSet2();
            this.MUONTRASACHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MUONTRASACHPTableAdapter = new QuanLyThuVien.QL_THUVIENDataSet2TableAdapters.MUONTRASACHPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_THUVIENDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUONTRASACHPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MUONTRASACHPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report_MuonTraSachs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(726, 383);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_THUVIENDataSet2
            // 
            this.QL_THUVIENDataSet2.DataSetName = "QL_THUVIENDataSet2";
            this.QL_THUVIENDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MUONTRASACHPBindingSource
            // 
            this.MUONTRASACHPBindingSource.DataMember = "MUONTRASACHP";
            this.MUONTRASACHPBindingSource.DataSource = this.QL_THUVIENDataSet2;
            // 
            // MUONTRASACHPTableAdapter
            // 
            this.MUONTRASACHPTableAdapter.ClearBeforeFill = true;
            // 
            // Reportfrm_MuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 383);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportfrm_MuonTraSach";
            this.Text = "Thống kê mượn trả sách";
            this.Load += new System.EventHandler(this.Reportfrm_MuonTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_THUVIENDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUONTRASACHPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MUONTRASACHPBindingSource;
        private QL_THUVIENDataSet2 QL_THUVIENDataSet2;
        private QL_THUVIENDataSet2TableAdapters.MUONTRASACHPTableAdapter MUONTRASACHPTableAdapter;
    }
}