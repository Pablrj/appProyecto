using appProyecto.Mantenimientos;
using appProyecto.Reportes;
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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void butMateria_Click(object sender, EventArgs e)
        {
            MantenimientoMateria man = new MantenimientoMateria();
            man.Show();
        }

      

      

       

        private void butGrupo_Click(object sender, EventArgs e)
        {
            MantenimientoGrupo gru = new MantenimientoGrupo();
            gru.Show();
        }

        private void butAula_Click(object sender, EventArgs e)
        {
            Mantenimientos.MantenimientoAula a = new Mantenimientos.MantenimientoAula();
            a.Show();
        }

        private void butHorario_Click(object sender, EventArgs e)
        {
            MantenimientoHorario a = new MantenimientoHorario();
            a.Show();
        }

        private void butMateriaProfesor_Click(object sender, EventArgs e)
        {
            frmMatProf a = new frmMatProf();
            a.Show();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void butNiveles_Click(object sender, EventArgs e)
        {
            frmReporteNivel r = new frmReporteNivel();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoGrupoEstudiante f = new MantenimientoGrupoEstudiante();
            f.Show();
        }
    }
}
