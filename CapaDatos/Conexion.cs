using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        //Retorrna la cadena de conexion configurado en el appConfig de la capaUI
        public static string ObtenerCadena()
        {
            //Para conectarnos con appConfig se utiliza la clase ConfigurationManager
            //Esta clase necesita hacer referencia al ensamblado System.Configuratin
            return System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        }
    }
}
