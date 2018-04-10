using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GrupoEstudianteDatos
    {
        public void Insertar(Grupo usuario, Usuario mat)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "Sp_GrupoEstudiante_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@IDGrupo", usuario.ID);
                comando.Parameters.AddWithValue("@iDUsuarioEstudiante", mat.ID);

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
        public void Eliminar(Grupo usuario, Usuario mat)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "Sp_GrupoEstudiante_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@IDGrupo", usuario.ID);
                comando.Parameters.AddWithValue("@iDUsuarioEstudiante", mat.ID);

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


        public List<Usuario> SeleccionarGrupoEstudiante(int idProf)
        {
            Usuario mat = null;
            List<Usuario> lista = new List<Usuario>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Grupo_Por_EstudianteID";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", idProf);

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    mat = new Estudiante
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        NombreCompleto= reader["NombreCompleto"].ToString()
                       
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
