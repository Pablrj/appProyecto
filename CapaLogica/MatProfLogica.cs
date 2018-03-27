using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MatProfLogica
    {
        MatProfDatos datos = new MatProfDatos();
        public void guardar(Usuario idMat, Materia idUsu)
        {
            if (String.IsNullOrWhiteSpace(idMat.ToString()))
            {
                throw new ApplicationException("El Codigo del libro es requerido");
            }

            if (String.IsNullOrWhiteSpace(idUsu.ToString()))
            {
                throw new ApplicationException("El Codigo del Autor es requerido");
            }

            datos.Insertar(idMat, idUsu);

        }

        public void Eliminar(Usuario usuario, Materia mat)
        {
           
            datos.Eliminar(usuario, mat);
        }

        public List<Materia> SeleccionarTodos(int id)
        {
            
            return datos.SeleccionarMatPorProf(id);
        }
    }
}
