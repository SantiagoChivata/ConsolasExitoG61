using ConsolasExitoG61.App.Persistencia;
using ConsolasExitoG61.App.Dominio.Entidades;
using System.Linq;
using System;

namespace ConsolasExitoG61.App.Consola
{
    class Program
    {
        Conexion conexion = new Conexion();
        static void Main(string[] args)
        {
            //crearSucursal();
            buscarSucursal();
            //crearEmpleado();
        }

        public static void crearSucursal()
        {
            RepositorioSucursal repositorioSucursal = new RepositorioSucursal();
            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = "Manizales";
            sucursal.Direccion = "Cra 90 # 12-28";
            sucursal.Telefono = "2604865";
            sucursal.Email = "sucursalmanizales@exito.com";
            repositorioSucursal.guardarSucursal(sucursal);
        }

        public static void buscarSucursal()
        {
            RepositorioSucursal repositorioSucursal = new RepositorioSucursal();
            var buscarSucursal = repositorioSucursal.consultarSucursal(1);
            Console.WriteLine(buscarSucursal.Id + " "+buscarSucursal.Nombre);

        }
        public static void crearEmpleado()
        {
            RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();
            Empleado empleado = new Empleado();
            empleado.Nombres = "Juan";
            empleado.Apellidos = "Rodriguez";
            empleado.Edad = 29;
            empleado.Cedula = "1056384567";
            empleado.Direccion = "Cra 4 # 56-98";
            empleado.Usuario = "jrodriguez";
            empleado.Clave = "jrodriguez";
            empleado.Email = "jrodriguez@exito.com";
            empleado.CodEmpleado = 1;
            empleado.accesoReportes = true;
            empleado.Cargo = Cargo.ADMINISTRADOR_SISTEMA;
            //empleado.Sucursal = "1".ToString();
           
            repositorioEmpleado.guardarEmpleado(empleado);
        }
        
    }
}
