using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class GrupoEstudianteLogica
    {
        GrupoEstudianteDatos datos = new GrupoEstudianteDatos();
        public void guardar(Usuario idMat, Grupo idUsu)
        {
            if (String.IsNullOrWhiteSpace(idMat.ToString()))
            {
                throw new ApplicationException("El Codigo del libro es requerido");
            }

            if (String.IsNullOrWhiteSpace(idUsu.ToString()))
            {
                throw new ApplicationException("El Codigo del Autor es requerido");
            }

            datos.Insertar(idUsu, idMat);

        }

        public void Eliminar(Usuario usuario, Grupo mat)
        {

            datos.Eliminar(mat, usuario);
        }

        public List<Usuario> SeleccionarTodos(int id)
        {

            return datos.SeleccionarGrupoEstudiante(id);
        }
    }
}
