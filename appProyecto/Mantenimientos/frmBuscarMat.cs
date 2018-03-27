using CapaLogica;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyecto.Mantenimientos
{
    public partial class frmBuscarMat : Form
    {
        public Materia Mat {get; set;}
        MateriaLogica Logica = null;
        public frmBuscarMat()
        {
            InitializeComponent();
            Logica = new MateriaLogica();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstMat.SelectedItem != null)
            {
                this.Mat = (Materia)lstMat.SelectedItem;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un materia");
            }
        }

        private void frmBuscarMat_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                lstMat.DataSource = Logica.SeleccionarTodos();
                lstMat.DisplayMember = "Nombre";
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
