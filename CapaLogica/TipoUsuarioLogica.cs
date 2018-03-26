using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class TipoUsuarioLogica
    {
        private TipoUsuarioDatos datos = new TipoUsuarioDatos();


        public List<TipoUsuario> ObtenerTodos()
        {
            return datos.SeleccionarTodos();
        }
        public TipoUsuario ObtenerPorId(int id)
        {
            return datos.SeleccionarporId(id);
        }
    }
}
