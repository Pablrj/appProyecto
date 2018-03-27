using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MatProfDatos
    {
        public void Insertar(Usuario usuario, Materia mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "Sp_MatPro_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@ID_LIBRO", usuario.ID);
                comando.Parameters.AddWithValue("@ID_AUTOR", mat.ID);

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
        public void Eliminar(Usuario usuario, Materia mat)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_MatProf_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@ID_LIBRO", usuario.ID);
                comando.Parameters.AddWithValue("@ID_AUTOR", mat.ID);

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


        public List<Materia> SeleccionarMatPorProf(int idProf)
        {
            Materia mat = null;
            List<Materia> lista = new List<Materia>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Mat_Por_ProfID";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", idProf);

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    mat = new Materia
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString()
                    };

                    lista.Add(mat);

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