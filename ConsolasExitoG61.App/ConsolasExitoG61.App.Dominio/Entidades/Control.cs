namespace ConsolasExitoG61.App.Dominio.Entidades
{
    public class Control
    {
        public int id {get; set;}
        public string Nombre{get; set;}
        public string Tipo{get;set;}
        public double PrecioCompra{get;set;}
        public string PrecioVenta {get;set;}
        public Proveedor Proveedor {get;set;}
    }
}