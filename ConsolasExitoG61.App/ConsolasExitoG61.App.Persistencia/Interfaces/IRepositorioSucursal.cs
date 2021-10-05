using System.Collections.Generic;
using ConsolasExitoG61.App.Dominio.Entidades;

namespace ConsolasExitoG61.App.Persistencia.Interfaces
{
    public interface IRepositorioSucursal
    {
        public void guardarSucursal(Sucursal sucursal);

        public void eliminarSucursal(int id);

        public void actualizarSucursal(Sucursal sucursal);

        public Sucursal consultarSucursal(int Id);
    }
}