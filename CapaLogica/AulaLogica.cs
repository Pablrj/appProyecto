using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class AulaLogica
    {
        private AulaDatos datos = new AulaDatos();

        public void guardar(Aula cat)
        {
            if (String.IsNullOrWhiteSpace(cat.Nombre))
            {
                throw new ApplicationException("El nombre es requerido");
            }

            if (datos.SeleccionarPorID(cat.ID) == null)
                datos.Insertar(cat);
            else
                datos.Actualizar(cat);
        }

        public List<Aula> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }
        public Aula SeleccionarMateriaPorId(int Id)
        {
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            datos.Eliminar(Id);
        }
    
}
}
