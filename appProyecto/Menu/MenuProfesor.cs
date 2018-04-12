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
        List<Usuario> listaGrupos = null;
        List<Asistencia> listaAsistencia = null;

        public MenuProfesor()
        {
            InitializeComponent();
            asistenciaLogica = new AsistenciaLogica();
            grupoLogica = new GrupoLogica();
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {

            listaAsistencia = new AsistenciaLogica().SeleccionarTodos();

        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                listaGrupos = new GrupoLogica().SeleccionarTodosEstudiantes(Convert.ToInt32(textBox1.Text));

                List<Usuario> Ausentes = new List<Usuario>();
                foreach (Usuario estudiante in listaGrupos)
                {
                    foreach (Asistencia presente in listaAsistencia)
                    {
                        if (estudiante.ID != presente.IDestudiante.ID)
                        {
                            Ausentes.Add(estudiante);
                        }

                    }
                }

                dataGridView1.DataSource = Ausentes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void butEnviarCorreo_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)dataGridView1.SelectedRows[0].DataBoundItem;

            if (grupoLogica.enviar_correo(usuario.CorreoPadre) == true)
            {
                MessageBox.Show("Mensaje Enviado");
            }
            else
            {
                MessageBox.Show("Mensaje NO Enviado");
            }

        }

    }
}
