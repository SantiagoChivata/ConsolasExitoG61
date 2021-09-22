namespace ConsolasExitoG61.App.Dominio
{
    public class Empleado : Persona
    {
        public int CodEmpleado {get; set;}
        public NombreCargo Cargo {get; set;}
        public Sucursal Sucursal{get;set;}
        
    }
}