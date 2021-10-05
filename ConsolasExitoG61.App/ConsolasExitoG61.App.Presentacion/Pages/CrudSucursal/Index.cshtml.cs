using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExitoG61.App.Dominio.Entidades;
using ConsolasExitoG61.App.Persistencia;

namespace ConsolasExitoG61.App.Presentacion.Pages.CrudSucursal
{
    public class IndexModel : PageModel
    {
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public IndexModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Sucursal> Sucursal { get;set; }

        public async Task OnGetAsync()
        {
            Sucursal = await _context.sucursal.ToListAsync();
        }
    }
}
