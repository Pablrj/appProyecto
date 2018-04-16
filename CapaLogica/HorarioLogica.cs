using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
   public  class HorarioLogica
    {
        private HorarioDatos datos = new HorarioDatos();

        public void guardar(Horario cat)
        {
            if (String.IsNullOrWhiteSpace(cat.Hora.ToString()))
            {
                throw new ApplicationException("El nombre es requerido");
            }

            if (datos.SeleccionarPorID(cat.ID) == null)
                datos.Insertar(cat);
            else
                datos.Actualizar(cat);
        }

        public List<Horario> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }
        public Horario SeleccionarMateriaPorId(int Id)
        {
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            datos.Eliminar(Id);
        }
    }
}

