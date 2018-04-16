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
            this.proyectoProgra3DBDataSet1 = new appProyecto.ProyectoProgra3DBDataSet1();
            this.asistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asistenciaTableAdapter = new appProyecto.ProyectoProgra3DBDataSet1TableAdapters.AsistenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.asistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Reportes.ReporteAsistencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(567, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // proyectoProgra3DBDataSet1
            // 
            this.proyectoProgra3DBDataSet1.DataSetName = "ProyectoProgra3DBDataSet1";
            this.proyectoProgra3DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistenciaBindingSource
            // 
            this.asistenciaBindingSource.DataMember = "Asistencia";
            this.asistenciaBindingSource.DataSource = this.proyectoProgra3DBDataSet1;
            // 
            // asistenciaTableAdapter
            // 
            this.asistenciaTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProyectoProgra3DBDataSet1 proyectoProgra3DBDataSet1;
        private System.Windows.Forms.BindingSource asistenciaBindingSource;
        private ProyectoProgra3DBDataSet1TableAdapters.AsistenciaTableAdapter asistenciaTableAdapter;
    }
}