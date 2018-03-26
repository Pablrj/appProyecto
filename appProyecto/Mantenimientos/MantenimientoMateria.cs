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
    public partial class MantenimientoMateria : Form
    {
        public MantenimientoMateria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Materia mat = new Materia()
                {
                    ID = int.Parse(text),
                    Nombre = txtCateg.Text
                };
                Logica.guardar(mat);
                Refrescar();
                MessageBox.Show("Materia guardada con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
