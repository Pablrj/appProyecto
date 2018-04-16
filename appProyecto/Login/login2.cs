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

        UsuarioLogica usuarioLogica = null;
        public login2()
        {
            InitializeComponent();
            usuarioLogica = new UsuarioLogica();
        }        
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

            comboGenero.SelectedIndex = 0;
          
        
        }
        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (this.radioEstudiante.Checked)
            {
               
                try
                {
                    if (this.textIdentificacion.Text.Length ==0)
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
                            Genero = this.comboGenero.SelectedItem.ToString(),
                            IDNivel = (Nivel)this.comboNivel.SelectedItem,
                            IDTipoUsuario = new TipoUsuario() { ID = 3, Descripcion = "Estudiante" },
                            FechaNacimiento = (DateTime)dateTimePicker1.Value,
                            CorreoPadre = this.textCorreoPadre.Text,
                            TelefonoPadre = this.textTelefonoPadre.Text,
                            Contraseña = this.textContraseña.Text,                                               
                        };
                        QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                        QrCode qrCode = new QrCode();
                        qrEncoder.TryEncode(textIdentificacion.Text, out qrCode);
                        GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
                        MemoryStream ms = new MemoryStream();
                        renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                        var imageTemporal = new Bitmap(ms);
                        var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
                      

                        usuario.QR=imagen.ToString();
                        //guardar el QR en una carpeta
                        string folderName = @"C:\Users\José Pablo\Desktop\Codigo";
                        string pathString = System.IO.Path.Combine(folderName);


                        if (System.IO.Directory.Exists(pathString) != true)
                        {
                            System.IO.Directory.CreateDirectory(pathString);
                            imagen.Save("C:\\Users\\José Pablo\\Desktop\\Codigo\\" + this.textIdentificacion.Text + ".png", ImageFormat.Png);
                          

                        }
                        else
                        {
                            imagen.Save("C:\\Users\\José Pablo\\Desktop\\Codigo\\" + this.textIdentificacion.Text + ".png", ImageFormat.Png);
                         
                        }



                        if (this.textContraseña.Text != this.textRepeContraEstu.Text)
                        {
                            MessageBox.Show("Las contraseñs deben de ser iguales");
                            return;
                        }
                        
                        usuarioLogica.Guardar(usuario);
                        MessageBox.Show("Usuario creado con exito");
                        this.Dispose();
                        login1 lo = new login1();
                        lo.Show();
                        lo.Visible = true;
                        
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
               
            }
            if (this.radioPadre.Checked)
            {
                try
                {
                    if (this.textIdentificacionPadre.Text.Length ==0)
                    {
                        throw new Exception("Debe digitar un numero de cedula valida");
                    }
             
                    if (this.textContrasennaPadre.Text.Trim().Equals(""))
                    {
                        throw new Exception("Debe digitar la contrasenna ");
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
                            Contraseña=this.textContrasennaPadre.Text,                       
                        };
                        if (this.textContrasennaPadre.Text != this.textRepetirContraPadre.Text)
                        {
                            MessageBox.Show("Las contraseñs deben de ser iguales");
                            return;
                        }
                        
                        usuarioLogica.Guardar(usuario);
                        login1 lo = new login1();
                        lo.Show();
                        lo.Visible = true;
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
              
            }

            if (radioProfesor.Checked)
            {
                try
                {
                    if (this.textIdentificacionProfesor.Text.Length ==0)
                    {
                        throw new Exception("Debe digitar un numero de cedula valida");
                    }
                    if (this.textNombreProfesor.Text.Equals(""))
                    {
                        throw new Exception("Debe digitar Nombre ");
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
                            FechaNacimiento = (DateTime)dateTimePicker1.Value,
                            NombreCompleto = this.textNombreProfesor.Text,
                            Genero = "",
                            IDNivel = (Nivel)this.comboNivel.SelectedItem,
                            CorreoPadre = "",
                            TelefonoPadre = "",
                            QR = "",
                            Estado = false,
                            Contraseña=this.textcContrasennaProfesor.Text,

                        };
                        if (this.textcContrasennaProfesor.Text != this.textRepetirContra.Text)
                        {
                            MessageBox.Show("Las contraseñs deben de ser iguales");
                            return;
                        }
                        
                        usuarioLogica.Guardar(usuario);
                        login1 lo = new login1();
                        lo.Show();
                        lo.Visible = true;
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
                comboNivel.SelectedIndex = 1;
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
