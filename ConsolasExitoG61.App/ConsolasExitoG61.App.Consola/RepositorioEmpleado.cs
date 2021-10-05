using ConsolasExitoG61.App.Persistencia.Interfaces;
using ConsolasExitoG61.App.Persistencia;
using ConsolasExitoG61.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ConsolasExitoG61.App.Consola
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        Conexion conexion = new Conexion();


        public void guardarEmpleado(Empleado empleado){
            conexion.empleado.Add(empleado);
            conexion.SaveChanges();
        }

        public void eliminarEmpleado(int id){
            var empleado = conexion.empleado.First(e => e.Id == id);
            conexion.empleado.Remove(empleado);
            conexion.SaveChanges();
        }

        public void actualizarEmpleado(Empleado empleado){
            var empleadoBusqueda = conexion.empleado.First(e => e.Id == empleado.Id);
            empleadoBusqueda.Nombres = empleado.Nombres;
            empleadoBusqueda.Apellidos = empleado.Apellidos;
            empleadoBusqueda.Edad = empleado.Edad;
            empleadoBusqueda.Cedula = empleado.Cedula;
            empleadoBusqueda.Direccion = empleado.Direccion;
            empleadoBusqueda.Usuario = empleado.Usuario;
            empleadoBusqueda.Clave = empleado.Clave;
            empleadoBusqueda.Email = empleado.Email;
            empleadoBusqueda.CodEmpleado = empleado.CodEmpleado;
            empleadoBusqueda.Cargo = empleado.Cargo;
            empleadoBusqueda.accesoReportes = empleado.accesoReportes;
            empleadoBusqueda.Sucursal = empleado.Sucursal;
 
        }

        public Empleado consultarEmpleado(Empleado empleado){
            var empleadoBusqueda = conexion.empleado.First(e => e.Nombres == empleado.Nombres);
            return empleadoBusqueda;
        }
    }
}