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
    public partial class frmBuscarEstudiantes : Form
    {
        public Usuario Mat { get; set; }
        UsuarioLogica Logica = null;
        public frmBuscarEstudiantes()
        {
            InitializeComponent();
            Logica = new UsuarioLogica();
        }

        private void frmBuscarEstudiantes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        
        private void Refrescar()
        {
            try
            {
                lstMat.DataSource = Logica.ObtenerTodosEstudiantes();
                lstMat.DisplayMember = "Nombre";
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstMat.SelectedItem != null)
            {
                this.Mat = (Usuario)lstMat.SelectedItem;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estudiante");
            }
        }
    }
}
