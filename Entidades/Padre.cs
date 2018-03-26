using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Padre : Usuario
    {
        public override string Contraseña { get; set; }
        public override string CorreoPadre { get; set; }
        public override DateTime FechaNacimiento { get; set; }
        public override string Genero { get; set; }
        public override int ID { get; set; }
        public override Nivel IDNivel { get; set; }
        public override TipoUsuario IDTipoUsuario { get; set; }
        public override string NombreCompleto { get; set; }
        public override string TelefonoPadre { get; set; }

        public override bool Estado { get; set; }

        public override string QR { get; set; }


        public override bool Guia { get; set; }

    }
}
