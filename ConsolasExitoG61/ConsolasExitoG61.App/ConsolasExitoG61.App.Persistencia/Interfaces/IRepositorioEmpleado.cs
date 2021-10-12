using System.Collections.Generic;
using ConsolasExitoG61.App.Dominio.Entidades;

namespace ConsolasExitoG61.App.Persistencia.Interfaces
{
    public interface IRepositorioEmpleado
    {
        public void guardarEmpleado(Empleado empleado);

        public void eliminarEmpleado(int id);

        public void actualizarEmpleado(Empleado empleado);

        public Empleado consultarEmpleado(Empleado empleado);
    }
}