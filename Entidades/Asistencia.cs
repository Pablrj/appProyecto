using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        public int IDGrupo { get; set; }
        public Grupo Grupo { get; set; }//IDGrupo
        public int UsuarioEstudiante { get; set; }
        public Usuario estudiante { get; set; }//IDUsuarioEstudiante
        public bool Presente { get; set; }
        public int UsuarioPadre { get; set; }
        public Usuario Padre { get; set; }//IDUsuarioPadre
    }
}
