using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class NotaLogica
    {
        private NotaDatos datos = new NotaDatos();

        public void guardar(Nota cat)
        {

            if (datos.SeleccionarPorID(cat.idProfesor,cat.idEstudiante) == null)
                datos.Insertar(cat);
            else
                datos.Actualizar(cat);
        }

        public List<Nota> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }
        public Nota SeleccionarMateriaPorId(int IdPro,int estu)
        {
            return datos.SeleccionarPorID(IdPro,estu);
        }

        public void Eliminar(int Id,int i)
        {
            datos.Eliminar(Id,i);
        }
    }
}
