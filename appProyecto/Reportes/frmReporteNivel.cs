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
    public partial class frmReporteNivel : Form
    {
        public frmReporteNivel()
        {
            InitializeComponent();
        }

        private void frmReporteNivel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra3DBDataSet.Nivel' Puede moverla o quitarla según sea necesario.
            this.nivelTableAdapter.Fill(this.proyectoProgra3DBDataSet.Nivel);
           
            this.reportViewer1.RefreshReport();
        }
    }
}
