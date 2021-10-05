using Microsoft.EntityFrameworkCore;
using ConsolasExitoG61.App.Dominio.Entidades;


namespace ConsolasExitoG61.App.Persistencia
{
    public class Conexion : DbContext
    {
        public DbSet<Sucursal> sucursal {get;set;}
        public DbSet<Proveedor> proveedor {get;set;}
        public DbSet<Control> control {get;set;}
        public DbSet<VideoJuego> videoJuego {get;set;}
        public DbSet<Consola> consola {get;set;}
        public DbSet<Persona> persona {get;set;}
        public DbSet<Empleado> empleado {get;set;}
        public DbSet<Cliente> cliente {get;set;}
        public DbSet<Factura> factura {get;set;}
        
        
        

        protected override void OnConfiguring(DbContextOptionsBuilder connect){
            if(!connect.IsConfigured){
                connect.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ConsolasExitoG61Data");
            }
        }
    }
}