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
    public class DetailsModel : PageModel
    {
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public DetailsModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public Sucursal Sucursal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sucursal = await _context.sucursal.FirstOrDefaultAsync(m => m.Id == id);

            if (Sucursal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
