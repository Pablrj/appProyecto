using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 /// <summary>
/// Esta clase se encarga de crear los horarios
/// </summary>
    public class Horario
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier./ </summary>
        ///Codigo unico del horario
        /// <value> The identifier. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public int ID { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the hora. </summary>
        ///
        /// <value> The hora. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime Hora { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Devuelve una cadena que representa el objeto actual. </summary>
        ///
        /// <remarks>   José Pablo, 20/04/2018. </remarks>
        ///
        /// <returns>   Cadena que representa el objeto actual. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
