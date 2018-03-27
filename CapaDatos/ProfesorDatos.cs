using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProfesorDatos
    {
        /// <summary>
        /// Insertamos un Autor en la Tabla
        /// de la BD
        /// </summary>
        /// <param name="mat"></param>
        public void Insertar(Profesor mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "Sp_Usuario_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", mat.ID);
                comando.Parameters.AddWithValue("@NombreCompleto", mat.NombreCompleto);

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
        public void Actualizar(Profesor mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Usuario_Update";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", mat.ID);
                comando.Parameters.AddWithValue("@NombreCompleto", mat.NombreCompleto);

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
                string sql = "Sp_Usuario_DeleteRow";

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
        public Profesor SeleccionarPorID(int Id)
        {
            Profesor mat = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Usuario_SelectRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    mat = new Profesor
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        NombreCompleto = reader["NombreCompleto"].ToString()
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
        public List<Profesor> SeleccionarTodos()
        {
            List<Profesor> lista = new List<Profesor>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Usuario_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Profesor cat = new Profesor
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        NombreCompleto = reader["NombreCompleto"].ToString()
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
