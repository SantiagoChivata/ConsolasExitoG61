using Microsoft.EntityFrameworkCore;
using ConsolasExitoG61.App.Dominio;
namespace ConsolasExitoG61.App.Persistencia.AppRepositories
{
    public class Conexion : DbContext
    {
        DbSet<Sucursal> sucursal {get;set;}
        DbSet<Proveedor> proveedor {get;set;}
        DbSet<Control> control {get;set;}
        DbSet<VideoJuego> videoJuego {get;set;}
        DbSet<Consola> consola {get;set;}
        DbSet<Persona> persona {get;set;}
        DbSet<Empleado> empleado {get;set;}
        DbSet<Cliente> cliente {get;set;}
        DbSet<Factura> factura {get;set;}
        
        
        

        protected override void OnConfiguring(DbContextOptionsBuilder conexion){
            if(!conexion.IsConfigured){
                conexion.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ConsolasExitoG61Data");
            }
        }
    }
}