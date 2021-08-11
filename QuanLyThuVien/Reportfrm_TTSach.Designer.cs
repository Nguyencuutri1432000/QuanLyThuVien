namespace QuanLyThuVien
{
    partial class Reportfrm_TTSach
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportfrm_TTSach));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_THUVIENDataSet4 = new QuanLyThuVien.QL_THUVIENDataSet4();
            this.SACHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SACHPTableAdapter = new QuanLyThuVien.QL_THUVIENDataSet4TableAdapters.SACHPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_THUVIENDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SACHPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1102, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_THUVIENDataSet4
            // 
            this.QL_THUVIENDataSet4.DataSetName = "QL_THUVIENDataSet4";
            this.QL_THUVIENDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SACHPBindingSource
            // 
            this.SACHPBindingSource.DataMember = "SACHP";
            this.SACHPBindingSource.DataSource = this.QL_THUVIENDataSet4;
            // 
            // SACHPTableAdapter
            // 
            this.SACHPTableAdapter.ClearBeforeFill = true;
            // 
            // Reportfrm_TTSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 510);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportfrm_TTSach";
            this.Text = "Thống kê danh sách thông tin sách";
            this.Load += new System.EventHandler(this.Reportfrm_TTSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_THUVIENDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SACHPBindingSource;
        private QL_THUVIENDataSet4 QL_THUVIENDataSet4;
        private QL_THUVIENDataSet4TableAdapters.SACHPTableAdapter SACHPTableAdapter;
    }
}