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
        public Usuario IDUsuarioProfesor { get; set; }
        public Horario IDHorario { get; set; }        
        public Aula IDAula { get; set; }       
        public bool Guia { get; set; }
        public int cantidad { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }

    }
}
