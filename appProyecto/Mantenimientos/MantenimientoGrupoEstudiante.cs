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
    public partial class MantenimientoGrupoEstudiante : Form
    {
        GrupoLogica Logica = null;
        GrupoEstudianteLogica Logica_MatProf = null;

        public MantenimientoGrupoEstudiante()
        {
            Logica = new GrupoLogica();
            Logica_MatProf = new GrupoEstudianteLogica();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Grupo usuario = (Grupo)lstProf.SelectedItem;
                Mantenimientos.frmBuscarEstudiantes ofrm = new frmBuscarEstudiantes();
                ofrm.ShowDialog();

                Usuario mat = ofrm.Mat;

                if (usuario != null && mat != null)
                {

                    Logica_MatProf.guardar(mat, usuario);

                    Refrescar();
                    MessageBox.Show("Se Agrego un Autor al Libro seleccionado");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Refrescar()
        {
            try
            {
                lstProf.DisplayMember = "titulo";
                lstProf.DataSource = Logica.SeleccionarTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MantenimientoGrupoEstudiante_Load(object sender, EventArgs e)
        {
            this.Refrescar();
        }

        private void lstProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProf.SelectedItem != null)
            {
                lstProf.DisplayMember = "ID";
                Grupo grupo = (Grupo)lstProf.SelectedItem;

                lstMat.DataSource = Logica_MatProf.SeleccionarTodos(grupo.ID);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario enUsus = (Usuario)lstMat.SelectedItem;
                Grupo mate = (Grupo)lstProf.SelectedItem;
                Logica_MatProf.Eliminar(enUsus, mate);
                Refrescar();
                MessageBox.Show("Se Elimino un Estudiante al Grupo seleccionado");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
