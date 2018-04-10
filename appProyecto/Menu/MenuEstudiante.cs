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
    public partial class MenuEstudiante : Form
    {
       
        public MenuEstudiante()
        {
            InitializeComponent();
          
        }

        private void MenuEstudiante_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            login1 lo = new login1();
            
            //dataGridView1.DataSource = Logica.ObtenerPorId(Convert.ToInt32( lo.ObtenerEstudiante().ToString()));//se cae aki
            MessageBox.Show("No se cae");
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Usuario mat = (Estudiante)dataGridView1.SelectedRows[0].DataBoundItem;
                
            }

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
