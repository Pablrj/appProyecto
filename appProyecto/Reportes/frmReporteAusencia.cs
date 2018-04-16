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
    public partial class frmReporteAusencia : Form
    {
        public frmReporteAusencia()
        {
            InitializeComponent();
        }

        private void frmReporteAusencia_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
