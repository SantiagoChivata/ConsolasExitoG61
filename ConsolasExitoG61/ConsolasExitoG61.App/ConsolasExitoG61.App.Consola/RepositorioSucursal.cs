using ConsolasExitoG61.App.Persistencia.Interfaces;
using ConsolasExitoG61.App.Persistencia;
using ConsolasExitoG61.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ConsolasExitoG61.App.Consola
{
    public class RepositorioSucursal : IRepositorioSucursal
    {
        Conexion conexion = new Conexion();


        public void guardarSucursal(Sucursal sucursal){
            conexion.sucursal.Add(sucursal);
            conexion.SaveChanges();
        }

        public void eliminarSucursal(int id){
            var sucursal = conexion.sucursal.First(s => s.Id == id);
            conexion.sucursal.Remove(sucursal);
            conexion.SaveChanges();
        }

        public void actualizarSucursal(Sucursal sucursal){
            var sucursalBusqueda = conexion.sucursal.First(s => s.Id == sucursal.Id);
            sucursalBusqueda.Nombre = sucursal.Nombre;
            sucursalBusqueda.Direccion = sucursal.Direccion;
            sucursalBusqueda.Telefono = sucursal.Telefono;
            sucursalBusqueda.Email = sucursal.Email;
        }

        public Sucursal consultarSucursal(int Id){
            var sucursalBusqueda = conexion.sucursal.First(s => s.Id == Id);
            return sucursalBusqueda;
            }
    }
}