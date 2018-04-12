using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GrupoDatos
    {
        /// <summary>
        /// Insertamos un Autor en la Tabla
        /// de la BD
        /// </summary>
        /// <param name="mat"></param>
        public void Insertar(Grupo mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "Sp_Grupo_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", mat.ID);
                comando.Parameters.AddWithValue("@IDUsuarioProfesor", mat.IDUsuarioProfesor.ID);
                comando.Parameters.AddWithValue("@IDHorario", mat.IDHorario.ID);
                comando.Parameters.AddWithValue("@IDAula", mat.IDAula.ID);
                comando.Parameters.AddWithValue("@Guia", mat.Guia);
                comando.Parameters.AddWithValue("@Cantidad", mat.cantidad);


                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando
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
        /// <summary>
        /// Actualizamos un registro en la tabla Autor
        /// en la BD
        /// </summary>
        /// <param name="mat"></param>
        public void Actualizar(Grupo mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Grupo_Update";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", mat.ID);
                comando.Parameters.AddWithValue("@IDUsuarioProfesor", mat.IDUsuarioProfesor.ID);
                comando.Parameters.AddWithValue("@IDHorario", mat.IDHorario.ID);
                comando.Parameters.AddWithValue("@IDAula", mat.IDAula.ID);
                comando.Parameters.AddWithValue("@Guia", mat.Guia);
                comando.Parameters.AddWithValue("@Cantidad", mat.cantidad);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando
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
        /// <summary>
        /// Eliminamos un Registro de la Tabla
        /// en la BD por el id 
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int Id)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Grupo_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", Id);
                //comando.Parameters.AddWithValue("@Nombre", cat.Nombre);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando
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

        /// <summary>
        /// Optenemos un Autor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Grupo SeleccionarPorID(int Id)
        {
            Grupo mat = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_OptGrupo_EstudianteID";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID_Estudiante", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    mat = new Grupo
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        IDUsuarioProfesor =new UsuarioDatos().SeleccionarporId(Convert.ToInt32( reader["idUsuarioProfesor"])),
                        IDHorario=new HorarioDatos().SeleccionarPorID( Convert.ToInt32(reader["IDHorario"])),
                        cantidad=Convert.ToInt32( reader["Cantidad"].ToString()),
                        IDAula=new AulaDatos().SeleccionarPorID(Convert.ToInt32(reader["IDAula"])),
                        Guia= Convert.ToBoolean(reader["Guia"])


                    };


                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return mat;

        }
        /// <summary>
        /// Optenemos una lista con todos los Autores
        /// que se encuentran en la BD
        /// </summary>
        /// <returns></returns>
        public List<Grupo> SeleccionarTodos()
        {
            List<Grupo> lista = new List<Grupo>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Grupo_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Grupo cat = new Grupo
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        IDUsuarioProfesor = new UsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["idUsuarioProfesor"])),
                        IDHorario = new HorarioDatos().SeleccionarPorID(Convert.ToInt32(reader["IDHorario"])),
                        cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                        IDAula = new AulaDatos().SeleccionarPorID(Convert.ToInt32(reader["IDAula"])),
                        Guia = Convert.ToBoolean(reader["Guia"])
                    };

                    lista.Add(cat);

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return lista;
        }
    }
}
