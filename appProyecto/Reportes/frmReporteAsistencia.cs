using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyecto.Reportes
{
    public partial class frmReporteAsistencia : Form
    {
        public frmReporteAsistencia()
        {
            InitializeComponent();
        }

        private void frmReporteAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra3DBDataSet5.Sp_ReporteAsistencia_SelectAll' Puede moverla o quitarla según sea necesario.
            this.sp_ReporteAsistencia_SelectAllTableAdapter.Fill(this.proyectoProgra3DBDataSet5.Sp_ReporteAsistencia_SelectAll);
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra3DBDataSet1.Asistencia' Puede moverla o quitarla según sea necesario.
            //this.asistenciaTableAdapter.Fill(this.proyectoProgra3DBDataSet1.Asistencia);

            this.reportViewer1.RefreshReport();
        }
    }
}
