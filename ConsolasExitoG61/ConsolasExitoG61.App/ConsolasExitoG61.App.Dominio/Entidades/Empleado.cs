namespace ConsolasExitoG61.App.Dominio.Entidades
{
    public class Empleado : Persona
    {
       public int CodEmpleado {get; set;}
        public Cargo Cargo {get; set;}
        public bool accesoReportes{get; set;}
        public Sucursal Sucursal{get;set;} 
    }
}