using System;

namespace ConsolasExitoG61.App.Dominio.Entidades
{
    public class Factura
    {
        public int Id{get;set;}
        public Cliente Cliente{get; set;}
        public Empleado Vendedor{get; set;}
        public DateTime Fecha {get; set;}
        public Consola Consola{get; set;}
        public Control Control{get; set;}
        public VideoJuego VideoJuego{get; set;}
        public int Cantidad{get; set;}
        public double ValorUnitario {get; set;}
        public double ValorTotal {get; set;}
    }
}