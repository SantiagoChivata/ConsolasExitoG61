using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExitoG61.App.Dominio.Entidades;
using ConsolasExitoG61.App.Persistencia;

namespace ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado
{
    public class IndexModel : PageModel
    {
        public String NombreSort {get; set;}
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public IndexModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; }

        public void OnGet(string sortOrder)
        {
            NombreSort = String.IsNullOrEmpty(sortOrder) ? "nombre_sort": "";
            List<Empleado> consoleOrder = _context.empleado.Include(s => s.Sucursal).ToList();
            if (NombreSort != null && NombreSort.Equals("nombre_sort"))
            {
                consoleOrder = consoleOrder.OrderBy(e => e.Nombres).ToList();
            }
            Empleado = consoleOrder.ToList();
        }
    }
}
