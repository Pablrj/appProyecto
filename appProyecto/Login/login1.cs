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
    public partial class login1 : Form
    {
        public Usuario usProf { get; set; }
        public login1()
        {
            usuarioLogica = new UsuarioLogica();
            InitializeComponent();
        }

        UsuarioLogica usuarioLogica;

        private void butCancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void butRegistrarse_Click(object sender, EventArgs e)
        {
            login2 lo = new login2();
            lo.Show();
            this.Visible = false;

        }

        public int ObtenerUsuario()
        {
            List<Usuario> lista = usuarioLogica.ObtenerTodos();

            int usuario = 0;

            foreach (Usuario usu in lista)
            {
                if (usu.ID == Convert.ToInt32(textIdentificacion.Text) && usu.Contraseña.Trim().Equals(textContraseña.Text))
                {
                    usuario = usu.IDTipoUsuario.ID;
                    usProf = usu;
                }
            }
            return usuario;
        }


        private void butAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textIdentificacion.Text.Trim() == "")
                {
                    throw new Exception("Debe digitar el usuario ");
                }
                if (this.textContraseña.Text.Trim() == "")
                {
                    throw new Exception("Debe digita la contraseña");
                }

                if (ObtenerUsuario() == 1)
                {
                    MenuAdministrador frm = new MenuAdministrador();
                    frm.ShowDialog();
                }
                if (ObtenerUsuario() == 2)
                {
                    MenuProfesor frm = new MenuProfesor();
                    frm.usuario = usProf;
                    frm.ShowDialog();
                }
                if (ObtenerUsuario() == 3)
                {
                    MenuEstudiante frm = new MenuEstudiante();
                    frm.ShowDialog();
                }

                if (ObtenerUsuario() == 4)//padre
                {
                    MenuPadre frm = new MenuPadre();
                    frm.ShowDialog();
                }
                this.textContraseña.Text = "";
                this.textIdentificacion.Text = "";


            }
            catch (Exception ex)
            {
                LogManager.LogException(ex, 01);
               
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrador f = new MenuAdministrador();
            f.Show();
        }


    }
}

