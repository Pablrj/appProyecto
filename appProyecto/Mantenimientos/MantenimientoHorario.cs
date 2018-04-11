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
    public partial class MantenimientoHorario : Form
    {
        HorarioLogica Logica = null;
        public MantenimientoHorario()
        {
            InitializeComponent();
            Logica = new HorarioLogica();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Horario mat = (Horario)dataGridView1.SelectedRows[0].DataBoundItem;
                this.textDato.Text = mat.ID.ToString();
                this.dateTimePicker1.Text = mat.horario.ToString();
            }
        }
  

        private void Refrescar()
        {
            dataGridView1.DataSource = Logica.SeleccionarTodos();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Horario mat = new Horario()
                {
                    ID = Convert.ToInt32(this.textDato.Text),
                    horario = (DateTime)dateTimePicker1.Value
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

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            if (this.textDato.Text.Equals(" "))
            {
                MessageBox.Show("No hay Categorias para Eliminar", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", "Ventana", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(this.textDato.Text));
                    MessageBox.Show("Categoira eliminada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenimientoHorario_Load(object sender, EventArgs e)
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
