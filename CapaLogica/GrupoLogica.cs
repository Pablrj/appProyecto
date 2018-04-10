using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
   public  class GrupoLogica
    {
        private GrupoDatos datos = new GrupoDatos();


        public void guardar(Grupo cat)
        {
            if (String.IsNullOrWhiteSpace(cat.ID.ToString()))
            {
                throw new ApplicationException("El nombre es requerido");
            }

            if (datos.SeleccionarPorID(cat.ID) == null)
                datos.Insertar(cat);
            else
                datos.Actualizar(cat);
        }

        public List<Grupo> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }
        public Grupo SeleccionarMateriaPorId(int Id)
        {
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            datos.Eliminar(Id);
        }
    }
}
