using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class AsistenciaLogica
    {
        private AsistenciaDatos datos = new AsistenciaDatos();


        public void guardar(Asistencia asistencia)
        {
            if (String.IsNullOrWhiteSpace(asistencia.ID.ToString()))
            {
                throw new ApplicationException("El nombre es requerido");
            }

            if (datos.SeleccionarPorFecha(asistencia.ID) == null)
                datos.Insertar(asistencia);
            else
                datos.Actualizar(asistencia);
        }

        public List<Asistencia> SeleccionarTodos()
        {
            return datos.SeleccionarTodos();

        }

        public void Eliminar(DateTime Id)
        {
            datos.Eliminar(Id);
        }

        public Asistencia SeleccionarAsistenciaPorFecha(DateTime Id)
        {
            return datos.SeleccionarPorFecha(Id);
        }

        public Asistencia SeleccionarAsistenciaPorId(int Id)
        {
            return datos.SeleccionarPorID(Id);
        }

        public List<Usuario> listaUsuarioAusentes(int i)
        {
            List<Usuario> listaGrupos = null;
            List<Asistencia> listaAsistencia =  SeleccionarTodos();

            List<Usuario> Ausentes = new List<Usuario>();

            try
            {
                listaGrupos = new GrupoLogica().SeleccionarTodosEstudiantes(Convert.ToInt32(i));

                foreach (Usuario estudiante in listaGrupos)
                {
                    foreach (Asistencia presente in listaAsistencia)
                    {
                        if (estudiante.ID != presente.IDestudiante.ID)
                        {
                            Ausentes.Add(estudiante);
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Ausentes;
        }        


    }
}
