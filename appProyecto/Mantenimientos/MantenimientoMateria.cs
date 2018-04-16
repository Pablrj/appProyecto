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
    public partial class MantenimientoMateria : Form
    {
        MateriaLogica Logica = null;
        public MantenimientoMateria()
        {
            InitializeComponent();
            Logica = new MateriaLogica();
        }

        private void toolAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Materia mat = new Materia()
                {
                    ID = Convert.ToInt32(textID.Text),
                    Nombre = textDescripcion.Text
                };
                
             
                Logica.guardar(mat);
                Refrescar();
                MessageBox.Show("Materia guardada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenimientoMateria_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            dataGridView1.DataSource = Logica.SeleccionarTodos();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Materia mat = (Materia)dataGridView1.SelectedRows[0].DataBoundItem;
                textID.Text = mat.ID.ToString();
                textDescripcion.Text = mat.Nombre;
            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (textID.Text.Equals(" "))
            {
                MessageBox.Show("No hay Categorias para Eliminar", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", "Ventana", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(textID.Text));
                    MessageBox.Show("Categoira eliminada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
