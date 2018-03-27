using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class UsuarioLogica
    {

        private UsuarioDatos datos = new UsuarioDatos();

        public void Guardar(Usuario usuario)
        {
            if (String.IsNullOrWhiteSpace(usuario.ID.ToString()))
            {
                throw new ApplicationException("El Identificacion es requerido");
            }

            if (datos.SeleccionarporId(usuario.ID) == null)
            {
                datos.Insertar(usuario);
            }
            else
            {
                datos.Actualizar(usuario);
            }
        }

        public List<Usuario> ObtenerTodos()
        {
            return datos.SeleccionarTodos();
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }

        public Usuario ObtenerPorId(int id)
        {
            return datos.SeleccionarporId(id);
        }

        public static bool ComprobarFormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string SHA1Encrypt(string password)
        {
            System.Security.Cryptography.HashAlgorithm hashValue = new
            System.Security.Cryptography.SHA1CryptoServiceProvider();

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);

            byte[] byteHash = hashValue.ComputeHash(bytes);

            hashValue.Clear();

            return (Convert.ToBase64String(byteHash));


        }
    }
}
