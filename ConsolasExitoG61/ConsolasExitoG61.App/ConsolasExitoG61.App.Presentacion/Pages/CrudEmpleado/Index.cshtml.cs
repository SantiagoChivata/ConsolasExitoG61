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
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public IndexModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; }

        public async Task OnGetAsync()
        {
            
            Empleado = await _context.empleado.ToListAsync();
        }
    }
}
