using CapaLogica;
using Entidades;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyecto
{
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }

        UsuarioLogica usuarioLogica = new UsuarioLogica();

        private void login2_Load(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.comboGenero.Items.Add("Hombre");
            this.comboGenero.Items.Add("Mujer");
            comboNivel.DataSource = new CapaLogica.NivelLogica().SeleccionarTodos();
            comboNivel.DisplayMember = "nombre";
            comboNivel.ValueMember = "ID";
        
        }

      

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (this.radioEstudiante.Checked)
            {
                try
                {
                    if (this.textIdentificacion.Text.Length > 9)
                    {
                        throw new Exception("Debe digitar un numero de cedula valida");
                    }

                    if (this.textNombreCompleto.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar un nombre de usuario");
                    }

                    if (this.comboNivel.SelectedIndex == -1)
                    {
                        throw new Exception("Debe digitar el nivel");
                    }

                    if (this.comboGenero.SelectedIndex == -1)
                    {
                        throw new Exception("Debe seleccionar el genero");
                    }

                    if (!this.dateTimePicker1.Checked)
                    {
                        throw new Exception("Debe seleccionar la fecha de nacimiento");
                    }

                    if (!UsuarioLogica.ComprobarFormatoEmail(this.textCorreoPadre.Text))
                    {
                        throw new Exception("Debe digitar un correo valido");
                    }
                    if (this.textTelefonoPadre.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar al menos un numero de teléfono");
                    }

                    if (this.textContraseña.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna");
                    }
                    if (this.textRepeContraEstu.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna 2");

                    }
                    int iden = Convert.ToInt32(this.textIdentificacion.Text);
                    if (usuarioLogica.ObtenerPorId(iden) == null)
                    {

                        Usuario usuario = new Estudiante()
                        {
                            ID = Convert.ToInt32(this.textIdentificacion.Text),
                            NombreCompleto = this.textNombreCompleto.Text,
                            Genero = this.comboGenero.ToString(),
                            IDNivel = (Nivel)this.comboNivel.SelectedItem,
                            IDTipoUsuario = new TipoUsuario() {ID=3,Descripcion="Estudiante"},
                            FechaNacimiento = Convert.ToDateTime(this.dateTimePicker1.ToString()),
                            CorreoPadre = this.textCorreoPadre.Text,
                            TelefonoPadre = this.textTelefonoPadre.Text,
                                                     
                        };
                        QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                        QrCode qrCode = new QrCode();
                        qrEncoder.TryEncode(textIdentificacion.Text, out qrCode);

                        GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                        MemoryStream ms = new MemoryStream();

                        renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                        var imageTemporal = new Bitmap(ms);
                        var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
                       // QR.BackgroundImage = imagen;

                        usuario.QR=imagen.ToString();
                        if (this.textContraseña.Text != this.textRepeContraEstu.Text)
                        {
                            MessageBox.Show("Las contraseñs deben de ser iguales");
                            return;
                        }
                        usuario.Contraseña = UsuarioLogica.SHA1Encrypt(textContraseña.Text);

                        usuarioLogica.Guardar(usuario);

                        MessageBox.Show("Usuario creado con exito");
                        this.Dispose();
                    }
                    else
                    {
                        throw new Exception("El usuario ya existe");
                    }
                }
                catch (Exception ex)
                {
                    LogManager.LogException(ex, 23);
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                login1 lo = new login1();
                lo.Show();
                lo.Visible = true;
                this.Close();
            }
            if (this.radioPadre.Checked)
            {
                try
                {
                    if (this.textIdentificacionPadre.Text.Length > 9)
                    {
                        throw new Exception("Debe digitar un numero de cedula valida");
                    }
             
                    if (this.textContrasennaPadre.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna 2");

                    }

                    if (this.textRepetirContraPadre.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna 2");

                    }
                    int iden = Convert.ToInt32(this.textIdentificacionPadre.Text);
                    if (usuarioLogica.ObtenerPorId(iden) == null)
                    {
                        Usuario usuario = new Padre()
                        {
                            ID = Convert.ToInt32(this.textIdentificacionPadre.Text),
                            NombreCompleto = " ",
                            IDTipoUsuario = new TipoUsuario() { ID = 4, Descripcion = "Padre" },
                            FechaNacimiento = (DateTime)dateTimePicker1.Value,
                            Genero = "",
                            IDNivel = (Nivel)this.comboNivel.SelectedItem,
                            CorreoPadre = "",
                            TelefonoPadre = "",
                            QR = "",
                            Estado=false,
                           
                        


                        };
                        if (this.textContrasennaPadre.Text != this.textRepetirContraPadre.Text)
                        {
                            MessageBox.Show("Las contraseñs deben de ser iguales");
                            return;
                        }
                        usuario.Contraseña = UsuarioLogica.SHA1Encrypt(textContrasennaPadre.Text);
                        usuarioLogica.Guardar(usuario);

                        MessageBox.Show("Usuario creado con exito");
                        this.Dispose();
                    }
                    else
                    {
                        throw new Exception("El usuario ya existe");
                    }
                }
                catch (Exception ex)
                {
                    LogManager.LogException(ex, 23);
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                login1 lo = new login1();
                lo.Show();
                lo.Visible = true;
                this.Close();
            }

            if (radioProfesor.Checked)
            {
                try
                {

                    if (this.textIdentificacionProfesor.Text.Length > 9)
                    {
                        throw new Exception("Debe digitar un numero de cedula valida");
                    }
                 
                    if (this.textcContrasennaProfesor.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna");
                    }
                    if (this.textRepetirContra.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna 2");
                    }
                    int iden = Convert.ToInt32(this.textIdentificacionProfesor.Text);
                    if (usuarioLogica.ObtenerPorId(iden) == null)
                    {

                        Usuario usuario = new Profesor()
                        {
                            ID = Convert.ToInt32(this.textIdentificacionProfesor.Text),                           
                            IDTipoUsuario = new TipoUsuario() { ID = 2, Descripcion = "Profesor" },  
                                                  
                        };
                        if (this.textcContrasennaProfesor.Text != this.textRepetirContraPadre.Text)
                        {
                            MessageBox.Show("Las contraseñs deben de ser iguales");
                            return;
                        }
                        usuario.Contraseña = UsuarioLogica.SHA1Encrypt(textcContrasennaProfesor.Text);
                        usuarioLogica.Guardar(usuario);
                        MessageBox.Show("Usuario creado con exito");
                        this.Dispose();
                    }
                    else
                    {
                        throw new Exception("El usuario ya existe");
                    }
                }
                catch (Exception ex)
                {
                    LogManager.LogException(ex, 23);
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                login1 lo = new login1();
                lo.Show();
                lo.Visible = true;
                this.Close();
            }

           
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login1 lo = new login1();
            lo.Visible = true;
        }

        private void radioEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioEstudiante.Checked)
            {
                this.groupBox1.Visible = true;
                this.groupBox2.Visible = false;
                this.groupBox3.Visible = false;
            }                          
        }

        private void radioProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioProfesor.Checked)
            {
                this.groupBox1.Visible = false;
                this.groupBox2.Visible = true;
                this.groupBox3.Visible = false;
            }
        }

        private void radioPadre_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioPadre.Checked)
            {
                this.groupBox1.Visible = false;
                this.groupBox2.Visible = false;
                this.groupBox3.Visible = true;
            }
        }
    }
}
