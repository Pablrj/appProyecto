using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class NivelLogica
    {
        private NivelDatos datos = new NivelDatos();
        public List<Nivel> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }
        public Nivel SeleccionarMateriaPorId(int Id)
        {
            return datos.SeleccionarporId(Id);
        }

    }
}
