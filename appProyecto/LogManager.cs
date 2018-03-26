using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyecto
{
    class LogManager
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Guarda los datos de un excepcion en bitacora
        /// </summary>
        /// <param name="ex">Informacion de la excepcion</param>
        /// <param name="errorCode">Opcional codigo de error</param>
        public static void LogException(Exception ex, int errorCode = 0)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
            msg.AppendFormat("Source {0}\n", ex.Source);
            msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
            msg.AppendFormat("Data {0}\n", ex.Data);
            msg.AppendFormat("ErrorCode {0}\n", errorCode);//Permite identificar donde se genero el error


            _MyLogControlEventos.Error(msg.ToString());
        }

        public static void LogInfo(string info)
        {
            _MyLogControlEventos.Info(info);
        }
    }
}
