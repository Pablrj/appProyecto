
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
   public class UsuarioDatos
    {
        public void Insertar(Usuario usuario)
        {

            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                string sql = "Sp_Usuario_Insert";
                //Crea un comando con la conexion y el sql
                SqlCommand comando = new SqlCommand(sql,conexion);
                //Agregar los parametros necesarios en la conexion
                comando.Parameters.AddWithValue("@ID", usuario.ID);
                comando.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                comando.Parameters.AddWithValue("@IDNivel", usuario.IDNivel.ID);
                comando.Parameters.AddWithValue("@Genero", usuario.Genero);
                comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);         
                comando.Parameters.AddWithValue("@CorreoPadre", usuario.CorreoPadre);
                comando.Parameters.AddWithValue("@TelefonoPadre", usuario.TelefonoPadre);                         
                comando.Parameters.AddWithValue("@IDTipoUsuario", usuario.IDTipoUsuario.ID);
                comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                comando.Parameters.AddWithValue("@Estado", usuario.Estado);
                comando.Parameters.AddWithValue("@QR", usuario.QR);
             
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Usuario> SeleccionarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            //Paso 1:
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Paso 2:
                string sql = "Sp_Usuario_SelectAll";
                //Paso 3:
                SqlCommand comando = new SqlCommand(sql,conexion);

                comando.CommandType = CommandType.StoredProcedure;

                IDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int tipo = (int)reader["TipoUsuario_ID"];
                    Usuario usuario = null;
                    if (tipo == 1)
                    {
                        usuario = new Administrador();
                    }
                    if (tipo == 2)
                    {
                        usuario = new Profesor();
                    }
                    if (tipo == 3)
                    {
                        usuario = new Estudiante();
                    }
                    if (tipo == 4)
                    {
                        usuario = new Padre();
                    }

                    usuario.ID = Convert.ToInt32(reader["ID"].ToString());
                    usuario.NombreCompleto = reader["Nombre"].ToString();
                    usuario.IDNivel = new NivelDatos().SeleccionarporId( Convert.ToInt32(reader["IDNivel"]));
                    usuario.Genero = reader["Genero"].ToString();
                    usuario.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString());
                    usuario.CorreoPadre = reader["CorreoPadre"].ToString();
                    usuario.TelefonoPadre = reader["TelefonoPadre"].ToString();
                    usuario.Contraseña = reader["Contraseña"].ToString();
                    usuario.Estado = Convert.ToBoolean(reader["Estado"].ToString());
                    usuario.IDTipoUsuario = new TipoUsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["IDTipoUsuario"]));
                        
                    lista.Add(usuario);
                }
            }
            catch (Exception)
            {
                throw;
            }
           

            return lista;
        }

        public void Actualizar(Usuario usuario)
        {
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Crea el script para ejectuar el Update
                string sql = "Sp_Usuario_Update";
                //Crea un comando con la conexion y el sql
                SqlCommand comando = new SqlCommand(sql,conexion);

               
                //Agregar los parametros necesarios en la conexion
                comando.Parameters.AddWithValue("@ID", usuario.ID);
                comando.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                comando.Parameters.AddWithValue("@IDNivel", usuario.IDNivel);
                comando.Parameters.AddWithValue("@Genero", usuario.Genero);
                comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoPadre", usuario.CorreoPadre);
                comando.Parameters.AddWithValue("@TelefonoPadre", usuario.TelefonoPadre);
                comando.Parameters.AddWithValue("@IDTipoUsuario", usuario.IDTipoUsuario.ID);
                comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                comando.Parameters.AddWithValue("@Estado", usuario.Estado);

                comando.CommandType = CommandType.StoredProcedure;

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                string sql = "Sp_Usuario_DeleteRow";
                //Crea un comando con la conexion y el sql
                SqlCommand comando = new SqlCommand(sql,conexion);
                //Agregar los parametros necesarios en la conexion
                comando.Parameters.AddWithValue("@id", id);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Usuario SeleccionarporId(int id)
        {
            //Paso 1:
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Paso 2:
                string sql = "Sp_Usuario_SelectRow";
                //Paso 3:
                SqlCommand comando = new SqlCommand(sql,conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                //Paso 4: ejecutar el comando
                IDataReader reader = comando.ExecuteReader();
                //paso 5: convertir los datos del DataReader a objetos categoria
                while (reader.Read())
                {
                    int tipo = (int)reader["TipoUsuario_ID"];
                    Usuario usuario = null;
                    if (tipo == 1)
                    {
                        usuario = new Administrador();
                    }
                    if (tipo == 2)
                    {
                        usuario = new Profesor();
                    }
                    if (tipo == 3)
                    {
                        usuario = new Estudiante();
                    }
                    if (tipo == 4)
                    {
                        usuario = new Padre();
                    }
                    usuario.ID = Convert.ToInt32(reader["ID"].ToString());
                    usuario.NombreCompleto = reader["Nombre"].ToString();
                    usuario.IDNivel =new NivelDatos().SeleccionarporId( Convert.ToInt32(reader["IDNivel"].ToString()));
                    usuario.Genero = reader["Genero"].ToString();
                    usuario.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString());
                    usuario.CorreoPadre = reader["CorreoPadre"].ToString();
                    usuario.TelefonoPadre = reader["TelefonoPadre"].ToString();
                    usuario.Contraseña = reader["Contraseña"].ToString();
                    usuario.Estado = Convert.ToBoolean(reader["Estado"].ToString());
                    usuario.IDTipoUsuario = new TipoUsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["IDTipoUsuario"]));

                    return usuario;//retorna la categoria encontrada
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private class FactoryDatabase
        {
        }
    }
}
