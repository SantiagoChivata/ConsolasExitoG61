namespace ConsolasExitoG61.App.Dominio
{
    public class VideoJuego
    {
        public int id {get; set;}
        public string Nombre{get; set;}
        public string Multiplataforma{get;set;}
        public string Version{get;set;}
        public string Fabricante{get;set;}
        public double PrecioCompra{get;set;}
        public string PrecioVenta {get;set;}
        public Proveedor Proveedor {get;set;}
        
    }
}