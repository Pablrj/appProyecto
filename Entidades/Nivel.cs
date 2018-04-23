﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A nivel. </summary>
    ///Se crea Nivel
    /// <remarks>   José Pablo, 22/04/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Nivel
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int ID { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the nombre. </summary>
        ///
        /// <value> The nombre. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Nombre { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Devuelve una cadena que representa el objeto actual. </summary>
        ///
        /// <remarks>   José Pablo, 22/04/2018. </remarks>
        ///
        /// <returns>   Cadena que representa el objeto actual. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            return Nombre;
        }
    }
}
