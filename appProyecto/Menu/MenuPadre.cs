﻿using Entidades;
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
    public partial class MenuPadre : Form
    {
        
        public MenuPadre()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe de digitar la cedula del hijo");
                return;
            }

            Asistencia asistencia = 
            new CapaLogica.AsistenciaLogica().SeleccionarAsistenciaPorId(Convert.ToInt32(this.txtID.Text));
            textBox1.Text = asistencia.ToString();
        }

        private void MenuPadre_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            txtID.Text = " ";
        }
    }
}
