using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Grupo
    {
        public int ID { get; set; }
        public int IDUsuarioProfesor { get; set; }
        public Usuario Profesor { get; set; }//IDUsuarioProfesor
        public int IDHorario { get; set; }
        public Horario Horario { get; set; }//IDHorario
        public int IDAula { get; set; }
        public Aula Aula { get; set; }//IDAula
        public bool Guia { get; set; }

    }
}
