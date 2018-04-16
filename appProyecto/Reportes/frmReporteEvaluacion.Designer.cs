namespace appProyecto.Reportes
{
    partial class frmReporteEvaluacion
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
            this.proyectoProgra3DBDataSet2 = new appProyecto.ProyectoProgra3DBDataSet2();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new appProyecto.ProyectoProgra3DBDataSet2TableAdapters.NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.notasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Reportes.ReporteEvaluacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // proyectoProgra3DBDataSet2
            // 
            this.proyectoProgra3DBDataSet2.DataSetName = "ProyectoProgra3DBDataSet2";
            this.proyectoProgra3DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.proyectoProgra3DBDataSet2;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 379);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteEvaluacion";
            this.Text = "frmReporteEvaluacion";
            this.Load += new System.EventHandler(this.frmReporteEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProyectoProgra3DBDataSet2 proyectoProgra3DBDataSet2;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private ProyectoProgra3DBDataSet2TableAdapters.NotasTableAdapter notasTableAdapter;
    }
}