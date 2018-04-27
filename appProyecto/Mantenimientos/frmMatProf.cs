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
    public partial class frmMatProf : Form
    {
        UsuarioLogica Logica = null;
        MatProfLogica Logica_MatProf = null;
        public frmMatProf()
        {
            InitializeComponent();
            Logica = new UsuarioLogica();
            Logica_MatProf = new MatProfLogica();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = (Usuario)lstProf.SelectedItem;
                Mantenimientos.frmBuscarMat ofrm = new frmBuscarMat();
                ofrm.ShowDialog();

                Materia mat = ofrm.Mat;

                if (usuario != null && mat != null)
                {

                    Logica_MatProf.guardar(usuario, mat);

                    Refrescar();
                    MessageBox.Show("Se Agrego un Profesor a la Materia seleccionado");

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
                lstProf.DataSource = Logica.ObtenerTodosProfesores();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmMatProf_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void lstProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProf.SelectedItem != null)
            {
                lstProf.DisplayMember = "Nombre";
                Usuario ususario = (Usuario)lstProf.SelectedItem;

                lstMat.DataSource = Logica_MatProf.SeleccionarTodos(ususario.ID);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario enUsus = (Usuario)lstProf.SelectedItem;
                Materia mate = (Materia)lstMat.SelectedItem;
                Logica_MatProf.Eliminar(enUsus, mate);
                Refrescar();
                MessageBox.Show("Se Elimono un Materia al profesor seleccionado");
            }
            catch (Exception)
            {

                throw;
            }
            


        }

       
    }


}

