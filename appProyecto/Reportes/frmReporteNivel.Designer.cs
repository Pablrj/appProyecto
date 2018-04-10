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
            this.proyectoProgra3DBDataSet = new appProyecto.ProyectoProgra3DBDataSet();
            this.nivelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivelTableAdapter = new appProyecto.ProyectoProgra3DBDataSetTableAdapters.NivelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nivelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appProyecto.Reportes.ReportNivel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // proyectoProgra3DBDataSet
            // 
            this.proyectoProgra3DBDataSet.DataSetName = "ProyectoProgra3DBDataSet";
            this.proyectoProgra3DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nivelBindingSource
            // 
            this.nivelBindingSource.DataMember = "Nivel";
            this.nivelBindingSource.DataSource = this.proyectoProgra3DBDataSet;
            // 
            // nivelTableAdapter
            // 
            this.nivelTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteNivel";
            this.Text = "frmReporteNivel";
            this.Load += new System.EventHandler(this.frmReporteNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra3DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProyectoProgra3DBDataSet proyectoProgra3DBDataSet;
        private System.Windows.Forms.BindingSource nivelBindingSource;
        private ProyectoProgra3DBDataSetTableAdapters.NivelTableAdapter nivelTableAdapter;
    }
}