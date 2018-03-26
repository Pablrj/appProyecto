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
        public login1()
        {
            InitializeComponent();
        }

        UsuarioLogica usuarioLogica = new UsuarioLogica();

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butRegistrarse_Click(object sender, EventArgs e)
        {
            login2 lo = new login2();
            lo.Show();
            this.Visible = false;


            //MenuAdministrador frm = new MenuAdministrador();
            //frm.ShowDialog();
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

                if (usuarioLogica.ObtenerPorId(Convert.ToInt32( this.textIdentificacion.Text)) != null && UsuarioLogica.SHA1Encrypt(this.textContraseña.Text) == usuarioLogica.ObtenerPorId(Convert.ToInt32(this.textIdentificacion.Text)).Contraseña)
                {
                    Usuario usuario = usuarioLogica.ObtenerPorId(Convert.ToInt32(this.textIdentificacion.Text));
                    if (usuario.IDTipoUsuario.ID==1)
                    {
                        MenuAdministrador frm = new MenuAdministrador();
                        frm.ShowDialog();
                    }
                    if (usuario.IDTipoUsuario.ID == 2)
                    {
                        MenuProfesor frm = new MenuProfesor();
                        frm.ShowDialog();
                    }
                    if (usuario.IDTipoUsuario.ID == 3)
                    {
                        MenuEstudiante frm = new MenuEstudiante();
                        frm.ShowDialog();
                    }
                    if (usuario.IDTipoUsuario.ID == 4)
                    {
                        MenuPadre frm = new MenuPadre();
                        frm.ShowDialog();
                    }
                    this.textContraseña.Text = "";
                    this.textIdentificacion.Text = "";

                }
                else
                {
                    throw new Exception("Usuario o Contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                LogManager.LogException(ex, 01);
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void linkLblNuevaCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // FrmCrearUsuario frm = new FrmCrearUsuario();
         //   frm.ShowDialog();
        }


       
        }
    }

