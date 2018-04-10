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
    public partial class MantenimientoAula : Form
    {
        AulaLogica Logica = null;
        public MantenimientoAula()
        {
            InitializeComponent();
            Logica = new AulaLogica();
        }

        private void Refrescar()
        {
            dataGridView1.DataSource = Logica.SeleccionarTodos();
        }


        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Aula mat = (Aula)dataGridView1.SelectedRows[0].DataBoundItem;
                this.textBox1.Text = mat.ID.ToString();
                this.textBox2.Text = mat.Nombre;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Aula mat = new Aula()
                {
                    ID = Convert.ToInt32(this.textBox1.Text),
                    Nombre = this.textBox2.Text
                };
                Logica.guardar(mat);
                Refrescar();
                MessageBox.Show("Aula guardada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(" "))
            {
                MessageBox.Show("No hay Categorias para Eliminar", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", "Ventana", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(this.textBox1.Text));
                    MessageBox.Show("Categoira eliminada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenimientoAula_Load(object sender, EventArgs e)
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

