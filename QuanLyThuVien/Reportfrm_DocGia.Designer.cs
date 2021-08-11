namespace QuanLyThuVien
{
    partial class Reportfrm_DocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportfrm_DocGia));
            this.DOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_THUVIENDataSet1 = new QuanLyThuVien.QL_THUVIENDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DOCGIATableAdapter = new QuanLyThuVien.QL_THUVIENDataSet1TableAdapters.DOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_THUVIENDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DOCGIABindingSource
            // 
            this.DOCGIABindingSource.DataMember = "DOCGIA";
            this.DOCGIABindingSource.DataSource = this.QL_THUVIENDataSet1;
            // 
            // QL_THUVIENDataSet1
            // 
            this.QL_THUVIENDataSet1.DataSetName = "QL_THUVIENDataSet1";
            this.QL_THUVIENDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DOCGIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report_Docgias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(827, 432);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DOCGIATableAdapter
            // 
            this.DOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // Reportfrm_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 432);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportfrm_DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê danh sách thông tin độc giả";
            this.Load += new System.EventHandler(this.ReportDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_THUVIENDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOCGIABindingSource;
        private QL_THUVIENDataSet1 QL_THUVIENDataSet1;
        private QL_THUVIENDataSet1TableAdapters.DOCGIATableAdapter DOCGIATableAdapter;
    }
}