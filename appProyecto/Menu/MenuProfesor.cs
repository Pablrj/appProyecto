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

namespace appProyecto
{
    public partial class MenuProfesor : Form
    {
        AsistenciaLogica asistenciaLogica = null;
        GrupoLogica grupoLogica = null;
        NotaLogica logica = null;
        public Usuario usuario { get; set; }

        public MenuProfesor()
        {
            InitializeComponent();
            asistenciaLogica = new AsistenciaLogica();
            grupoLogica = new GrupoLogica();
            logica = new NotaLogica();
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {
           
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                dtgAsistencia.DataSource = new GrupoLogica().SeleccionarTodosEstudiantesProf(usuario.ID, Convert.ToInt32(this.textBox1.Text));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void butEnviarCorreo_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar un grupo");
                return;
            }

            Usuario usuario = (Usuario)dtgAsistencia.SelectedRows[0].DataBoundItem;

            if (grupoLogica.enviar_correo(usuario.CorreoPadre) == true)
            {
                MessageBox.Show("Mensaje Enviado");
            }
            else
            {
                MessageBox.Show("Mensaje NO Enviado");
            }

        }


        private void butNota_Click(object sender, EventArgs e)
        {
            try
            {                             //dtgNotas
                int idUsuario = ((Usuario)dtgEstudiante.SelectedRows[0].DataBoundItem).ID;

                Nota mat = new Nota()
                {
                    
                };

                mat.idEstudiante = idUsuario;
                mat.idProfesor = usuario.ID;
                mat.nota1 = Convert.ToInt32(maskedNota1.Text);
                mat.nota2 = Convert.ToInt32(maskedNota2.Text);
                mat.nota3 = Convert.ToInt32(maskedNota3.Text);

                logica.guardar(mat);
                Refrescar();
                MessageBox.Show("Nota guardada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void Refrescar()
        {

            dtgNotas.DataSource = logica.SeleccionarTodos();
            if (txtGrupoID.Text.ToString().Equals(" "))
            {
                
                dtgNotas.DataSource = new GrupoLogica().SeleccionarTodosEstudiantesProf(usuario.ID, Convert.ToInt32(this.txtGrupoID.Text));

            }

        }



        private void btnBuscarNotas_Click(object sender, EventArgs e)
        {
            if (this.txtGrupoID.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar un grupo");
                return;
            }
            try
            {
                //dtgNotas
                dtgEstudiante.DataSource = new GrupoLogica().SeleccionarTodosEstudiantesProf
                    (usuario.ID,Convert.ToInt32(this.txtGrupoID.Text));
                dtgNotas.DataSource = logica.SeleccionarTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

       

        private void butRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();

        }
    }
}
