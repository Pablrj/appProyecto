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
    public class NivelDatos
    {
        public List<Nivel> SeleccionarTodos()
        {
            List<Nivel> lista = new List<Nivel>();
            //Paso 1:
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Paso 2:
                string sql = "Sp_Nivel_SelectAll";
                //Paso 3:
                SqlCommand comando = new SqlCommand(sql,conexion);
                comando.CommandType = CommandType.StoredProcedure;
                IDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Nivel tipo = new Nivel()
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString()
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

        public Nivel SeleccionarporId(int id)
        {
            //Paso 1:
            SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadena());
            try
            {
                conexion.Open();
                //Paso 2:
                string sql = "Sp_Nivel_SelectRow";
                //Paso 3:
                SqlCommand comando = new SqlCommand(sql);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                //Paso 4: ejecutar el comando
                IDataReader reader = comando.ExecuteReader();
                //paso 5: convertir los datos del DataReader a objetos categoria
                while (reader.Read())
                {
                    Nivel tipo = new Nivel()
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString()
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

