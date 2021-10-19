namespace ConsolasExitoG61.App.Dominio.Entidades
{
    public class Consola
    {
        public int Id {get; set;}
        public string Nombre{get; set;}
        public string Referencia{get;set;}
        public string Marca{get;set;}
        public string Version{get;set;}
        public string Fabricante{get;set;}
        public string TipoDisco{get;set;}
        public string Almacenamiento{get;set;}
        public string MemoriaRam{get;set;}
        public double PrecioCompra{get;set;}
        public string PrecioVenta {get;set;}
        public Proveedor Proveedor {get;set;}
    }
}