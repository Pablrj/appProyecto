using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        public DateTime ID { get; set; }

        public Grupo IDGrupo { get; set; }//IDGrupo
        public Usuario IDestudiante { get; set; }//IDUsuarioEstudiante
        public bool Presente { get; set; }

        public override string ToString()
        {
            return "Codigo: "+this.ID + "\r\nGrupo: "+this.IDGrupo +
                "\r\nCedula Hijo: " + this.IDestudiante.ID + "\r\nAsistencia: " + this.Presente;
        }
    }
}
