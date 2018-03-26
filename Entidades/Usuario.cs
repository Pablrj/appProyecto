using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {

        public abstract int ID { get; set; }
        public abstract string NombreCompleto { get; set; }
        public abstract TipoUsuario IDTipoUsuario { get; set; }      
        public abstract Nivel IDNivel { get; set; }
        public abstract string Genero { get; set; }
        public abstract DateTime FechaNacimiento { get; set; }               
        public abstract string CorreoPadre { get; set; }
        public abstract string TelefonoPadre { get; set; }
        public abstract string Contraseña { get; set; }
        public abstract bool Estado { get; set; }
        public abstract string QR { get; set; }
        public abstract bool Guia { get; set; }

    }
}
