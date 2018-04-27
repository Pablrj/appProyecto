using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
   public  class GrupoLogica
    {
        private GrupoDatos datos = new GrupoDatos();


        public void guardar(Grupo cat)
        {
            if (String.IsNullOrWhiteSpace(cat.ID.ToString()))
            {
                throw new ApplicationException("El nombre es requerido");
            }

            if (datos.SeleccionarPorIDGrupo(cat.ID) == null)
                datos.Insertar(cat);
            else
                datos.Actualizar(cat);
        }
        public List<Grupo> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }
        public Grupo SeleccionarGrupoPorId(int Id)
        {
            

            return datos.SeleccionarPorID(Id);////Sp_OptGrupo_EstudianteID
        }
        public void Eliminar(int Id)
        {
            datos.Eliminar(Id);
        }
        public List<Usuario> SeleccionarTodosEstudiantes(int id)
        {
            return datos.SeleccionarTodosEstudiantes(id);

        }
        public Boolean enviar_correo(string correo1)
        {
            bool estado = false;

            try
            {
                string host = "smtp-mail.outlook.com";
                int puerto = 587;
                string remitente = "pmora0813@hotmail.com";
                string contraseña = "Pabl0m0ra0813";
                string nombre = "Pablo";

                string destinatarios = correo1;
                string cc = "";
                string asunto = "Invitacion al Evento";
                string adjuntos = "";
                string cuerpo = "Falto su hijo a clases";


                SmtpClient cliente = new SmtpClient(host, puerto);
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(remitente, nombre);
                correo.Body = cuerpo;
                correo.Subject = asunto;
                if (destinatarios == "") { }
                else
                {
                    string[] cadena = destinatarios.Split();
                    foreach (string word in cadena)
                        correo.To.Add(word.Trim());
                }
                if (cc == "") { }
               else
                {
                    string[] cadena1 = cc.Split();
                    foreach (string word in cadena1) correo.CC.Add(word.Trim());
                }
                if (adjuntos == "") { }
                else
                {
                    string[] cadena2 = adjuntos.Split();
                   foreach (string word in cadena2) correo.Attachments.Add(new Attachment(word));
                }
                cliente.Credentials = new NetworkCredential(remitente, contraseña);
                cliente.EnableSsl = true;
                cliente.Send(correo);
                estado = true;

            }
            catch
            {
                throw;
            }

            return estado;


        }

        public List<Usuario> SeleccionarTodosEstudiantesProf(int id, int idGrupo)
        {
            return datos.SeleccionarEstudiantesGrupoProf(id, idGrupo);

        }

       
    }
}
