namespace appProyecto.Reportes
{
    partial class frmReporteAsistencia
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
            this.proyectoProgra3DBDataSet6 = new appProyecto.ProyectoProgra3DBDataSet6();
            this.spReporteAsistenciaSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteAsistencia_SelectAllTableAdapter = new appProyecto.ProyectoProgra3DBDataSet6TableAdapters.Sp_ReporteAsistencia_SelectAllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteAsistenciaSelectAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAusencia";
            reportDataSource1.Value = this.spReporteAsistenciaSelectAllBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Reportes.RepAusencias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(567, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // proyectoProgra3DBDataSet6
            // 
            this.proyectoProgra3DBDataSet6.DataSetName = "ProyectoProgra3DBDataSet6";
            this.proyectoProgra3DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteAsistenciaSelectAllBindingSource
            // 
            this.spReporteAsistenciaSelectAllBindingSource.DataMember = "Sp_ReporteAsistencia_SelectAll";
            this.spReporteAsistenciaSelectAllBindingSource.DataSource = this.proyectoProgra3DBDataSet6;
            // 
            // sp_ReporteAsistencia_SelectAllTableAdapter
            // 
            this.sp_ReporteAsistencia_SelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 379);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteAsistencia";
            this.Text = "frmReporteAsistencia";
            this.Load += new System.EventHandler(this.frmReporteAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteAsistenciaSelectAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProyectoProgra3DBDataSet6 proyectoProgra3DBDataSet6;
        private System.Windows.Forms.BindingSource spReporteAsistenciaSelectAllBindingSource;
        private ProyectoProgra3DBDataSet6TableAdapters.Sp_ReporteAsistencia_SelectAllTableAdapter sp_ReporteAsistencia_SelectAllTableAdapter;
    }
}