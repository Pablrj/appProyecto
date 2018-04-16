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
    public partial class frmReporteNota : Form
    {
        public frmReporteNota()
        {
            InitializeComponent();
        }

        private void frmReporteNota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra3DBDataSet2.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.proyectoProgra3DBDataSet2.Notas);

            this.reportViewer1.RefreshReport();
        }
    }
}
