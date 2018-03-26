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

        private void butEstudiante_Click(object sender, EventArgs e)
        {
            MantenimientoEstudiante es = new MantenimientoEstudiante();
            es.Show();
        }

        private void butProfesor_Click(object sender, EventArgs e)
        {
            MantenimientoProfesor pro = new MantenimientoProfesor();
            pro.Show();
        }

        private void butPadre_Click(object sender, EventArgs e)
        {
            MantenimientoPadre pa = new MantenimientoPadre();
            pa.Show();
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
    }
}
