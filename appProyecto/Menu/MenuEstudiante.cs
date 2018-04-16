using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using BarcodeLib;
using BarcodeLib.BarcodeReader;
using Entidades;
using CapaLogica;

namespace appProyecto
{
    public partial class MenuEstudiante : Form
    {
        public AsistenciaLogica logica = null;
        public MenuEstudiante()
        {
            InitializeComponent();
            logica = new AsistenciaLogica();
        }


        private FilterInfoCollection DISPOSITIVOS;

        private VideoCaptureDevice FUENTEDEVIDEO;

        private void Form1_Load(object sender, EventArgs e)
        {

            DISPOSITIVOS = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo X in DISPOSITIVOS)
            {
                comboBox1.Items.Add(X.Name);
            }
            comboBox1.SelectedIndex = 0;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            FUENTEDEVIDEO = new VideoCaptureDevice(DISPOSITIVOS[this.comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = FUENTEDEVIDEO;
            videoSourcePlayer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoSourcePlayer1.SignalToStop();
            listBox1.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
                Bitmap IMG = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                //UTILIZAR LA LIBRERIA Y LEER EL CÓDIGO
                string[] RESULTADOS = BarcodeReader.read(IMG, BarcodeReader.QRCODE);
                //QUITAR LA IMAGEN DE MEMORIA
                IMG.Dispose();
                //OBTENER LAS LECTURAS CUANDO SE LEA ALGO

                if (RESULTADOS != null && RESULTADOS.Count() > 0)
                {
                    //AGREGAR EL TEXTO OBTENIDO A LA LISTA
                    // string codigo = RESULTADOS.ToString().Substring(1, RESULTADOS.ToString().Length);
                    string codigo = RESULTADOS[0];
                    this.listBox1.Items.Add(codigo.Substring(0, 9));


                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Asistencia mat = (Asistencia)dataGridView1.SelectedRows[0].DataBoundItem;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Debe de seleccionar una opcion de la lista");
                return;
            }

            Usuario usuario = new CapaLogica.UsuarioLogica().ObtenerPorId(Convert.ToInt32(this.listBox1.SelectedItem));

            Grupo grupo = new CapaLogica.GrupoLogica().SeleccionarMateriaPorId(usuario.ID);

            try
            {
                Asistencia asis = new Asistencia()
                {
                    ID = DateTime.Now,
                    IDestudiante = usuario,
                    IDGrupo = grupo,
                    Presente = true
                };

                logica.guardar(asis);
            }
            catch (Exception)
            {

                throw;
            }

            Refrescar();

        }

        private void Refrescar()
        {
            try
            {
                dataGridView1.DataSource = new CapaLogica.AsistenciaLogica().SeleccionarTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

