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
    public partial class MantenimientoGrupo : Form
    {
        GrupoLogica logica = null;
        public MantenimientoGrupo()
        {
            InitializeComponent();
            logica = new GrupoLogica();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           

            try
            {
                Grupo mat = new Grupo()
                {
                    ID = Convert.ToInt32(this.textNombre.Text),
                    cantidad = Convert.ToInt32(this.textCantidad.Text),
                    IDAula = (Aula)comboAula.SelectedItem,
                    IDHorario = (Horario)comboFecha.SelectedItem,
                    Guia = Convert.ToBoolean(comboGuia.SelectedIndex == 0),
                    IDUsuarioProfesor = comboProfesor.SelectedItem as Profesor
            };
               
                logica.guardar(mat);
                Refrescar();
                MessageBox.Show("Aula guardada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
       

        private void Refrescar()
        {
            dataGridView1.DataSource = logica.SeleccionarTodos();
        }


        public UsuarioLogica buscarProfe()
        {

            UsuarioLogica logica = new UsuarioLogica();
            logica.ObtenerPorId(Convert.ToInt32(comboProfesor.SelectedItem));

            return logica;
        }

        

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.textNombre.Text.Equals(" "))
            {
                MessageBox.Show("No hay Categorias para Eliminar", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", "Ventana", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    logica.Eliminar(Convert.ToInt32(this.textNombre.Text));
                    MessageBox.Show("Categoria eliminada con Exito", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenimientoGrupo_Load(object sender, EventArgs e)
        {
            comboAula.DataSource = new AulaLogica().SeleccionarTodos();
            comboAula.DisplayMember = "nombre";
            comboAula.ValueMember = "ID";

            comboFecha.DataSource = new HorarioLogica().SeleccionarTodos();
            comboFecha.DisplayMember = "Hora";
            comboFecha.ValueMember = "ID";

            comboProfesor.DataSource = new UsuarioLogica().ObtenerTodosProfesores();      
            comboProfesor.ValueMember = "ID";

            comboGuia.Items.Add("Si");
            comboGuia.Items.Add("No");
            comboGuia.SelectedIndex = 1;
            try
            {
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Grupo mat = (Grupo)dataGridView1.SelectedRows[0].DataBoundItem;
                this.textNombre.Text = mat.ID.ToString();
                this.textCantidad.Text =  mat.cantidad.ToString();
                this.comboAula.Text = mat.IDAula.ID.ToString();
                this.comboFecha.Text = mat.IDHorario.ID.ToString();
                this.comboProfesor.Text = mat.IDUsuarioProfesor.ID.ToString();
                this.comboGuia.Text = mat.Guia.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
