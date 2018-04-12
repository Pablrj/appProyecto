using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AsistenciaDatos
    {
        public void Insertar(Asistencia asistencia)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "Sp_Asistencia_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", asistencia.ID);
                comando.Parameters.AddWithValue("@IDGrupo", asistencia.IDGrupo.ID);
                comando.Parameters.AddWithValue("@Presente", asistencia.Presente);
                comando.Parameters.AddWithValue("@IDUsuarioEstudiante", asistencia.IDestudiante.ID);

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
        public void Actualizar(Asistencia mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Asistencia_Update";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", mat.ID);
                comando.Parameters.AddWithValue("@IDGrupo", mat.IDGrupo.ID);
                comando.Parameters.AddWithValue("@Presente", mat.Presente);
                comando.Parameters.AddWithValue("@IDUsuarioEstudiante", mat.IDestudiante.ID);

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
        public void Eliminar(DateTime Id)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Asistencia_DeleteRow";

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
        //public Asistencia SeleccionarPorID(DateTime Id)
        //{
        //    Asistencia mat = null;

        //    //Paso 1: conexion BD
        //    SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

        //    try
        //    {
        //        //Abrir la conexion
        //        conexion.Open();
        //        //Paso 2: Instruccion
        //        string sql = "Sp_Asistencia_SelectRow";

        //        //Paso 3: Comando para ejecutar el paso 2
        //        SqlCommand comando = new SqlCommand(sql, conexion);

        //        comando.Parameters.AddWithValue("@Id", Id);

        //        //Paso 4.1: Usar el Procedimineto Almacenado
        //        comando.CommandType = System.Data.CommandType.StoredProcedure;

        //        //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
        //        SqlDataReader reader = comando.ExecuteReader();
        //        while (reader.Read())
        //        {

        //            mat = new Asistencia
        //            {
        //                ID = Convert.ToDateTime(reader["Id"]),
        //                IDGrupo =new GrupoDatos().SeleccionarPorID( Convert.ToInt32(reader["IDGrupo"])),
        //                IDestudiante=new UsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["IDUsuarioEstudiante"])),
        //                Presente=Convert.ToBoolean( reader["Presente"])
        //            };


        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }

        //    return mat;

        //}
        /// <summary>
        /// Optenemos una lista con todos los Autores
        /// que se encuentran en la BD
        /// </summary>
        /// <returns></returns>
        public List<Asistencia> SeleccionarTodos()
        {
            List<Asistencia> lista = new List<Asistencia>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Asistencia_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Asistencia cat = new Asistencia
                    {
                        ID = DateTime.Parse(reader["Id"].ToString()),
                        IDGrupo = new GrupoDatos().SeleccionarPorID(Convert.ToInt32(reader["IDUsuarioEstudiante"])),
                        IDestudiante = new UsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["IDUsuarioEstudiante"])),                   
                        Presente = Convert.ToBoolean(reader["Presente"])
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

        public Asistencia SeleccionarPorFecha(DateTime Id)
        {
            Asistencia mat = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Asistencia_SelectRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    mat = new Asistencia
                    {
                        ID = DateTime.Parse(reader["Id"].ToString()),
                        IDGrupo = new GrupoDatos().SeleccionarPorID(Convert.ToInt32(reader["IDGrupo"])),
                        IDestudiante = new UsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["IDUsuarioEstudiante"])),
                        Presente = Convert.ToBoolean(reader["Presente"])
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
        public Asistencia SeleccionarPorID(int Id)
        {
            Asistencia mat = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_Asistencia_SelectRowID";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    mat = new Asistencia
                    {
                        ID = DateTime.Parse(reader["Id"].ToString()),
                        IDGrupo = new GrupoDatos().SeleccionarPorID(Convert.ToInt32(reader["IDUsuarioEstudiante"])),
                        IDestudiante = new UsuarioDatos().SeleccionarporId(Convert.ToInt32(reader["IDUsuarioEstudiante"])),
                        Presente = Convert.ToBoolean(reader["Presente"])
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



    }
}
