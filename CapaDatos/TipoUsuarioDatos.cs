
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
   public class TipoUsuarioDatos
    {
        public List<TipoUsuario> SeleccionarTodos()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            //Paso 1:
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Paso 2:
                string sql = "Sp_TipoUsuario_SelectAll";
                //Paso 3:
                SqlCommand comando = new SqlCommand(sql);
                comando.CommandType = CommandType.StoredProcedure;
                IDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoUsuario tipo = new TipoUsuario()
                    {
                        ID = (int)reader["ID"],
                        Descripcion = reader["Nombre"].ToString()
                    };
                    lista.Add(tipo);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

        public TipoUsuario SeleccionarporId(int id)
        {
            //Paso 1:
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Paso 2:
                string sql = "Sp_TipoUsuario_SelectRow";
                //Paso 3:
                SqlCommand comando = new SqlCommand(sql);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                //Paso 4: ejecutar el comando
                IDataReader reader = comando.ExecuteReader();
                //paso 5: convertir los datos del DataReader a objetos categoria
                while (reader.Read())
                {
                    TipoUsuario tipo = new TipoUsuario()
                    {
                        ID = (int)reader["ID"],
                        Descripcion = reader["Nombre"].ToString()
                    };
                    return tipo;//retorna la categoria encontrada
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
