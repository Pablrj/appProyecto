namespace appProyecto.Reportes
{
    partial class frmReporteNivel
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
            this.proyectoProgra3DBDataSet4 = new appProyecto.ProyectoProgra3DBDataSet4();
            this.spReporteNivelesSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteNiveles_SelectAllTableAdapter = new appProyecto.ProyectoProgra3DBDataSet4TableAdapters.Sp_ReporteNiveles_SelectAllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteNivelesSelectAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReportNivel";
            reportDataSource1.Value = this.spReporteNivelesSelectAllBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Reportes.ReportNivelSeccion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 388);
            this.reportViewer1.TabIndex = 0;
            // 
            // proyectoProgra3DBDataSet4
            // 
            this.proyectoProgra3DBDataSet4.DataSetName = "ProyectoProgra3DBDataSet4";
            this.proyectoProgra3DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteNivelesSelectAllBindingSource
            // 
            this.spReporteNivelesSelectAllBindingSource.DataMember = "Sp_ReporteNiveles_SelectAll";
            this.spReporteNivelesSelectAllBindingSource.DataSource = this.proyectoProgra3DBDataSet4;
            // 
            // sp_ReporteNiveles_SelectAllTableAdapter
            // 
            this.sp_ReporteNiveles_SelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 388);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteNivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteNivel";
            this.Load += new System.EventHandler(this.frmReporteNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteNivelesSelectAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProyectoProgra3DBDataSet4 proyectoProgra3DBDataSet4;
        private System.Windows.Forms.BindingSource spReporteNivelesSelectAllBindingSource;
        private ProyectoProgra3DBDataSet4TableAdapters.Sp_ReporteNiveles_SelectAllTableAdapter sp_ReporteNiveles_SelectAllTableAdapter;
    }
}