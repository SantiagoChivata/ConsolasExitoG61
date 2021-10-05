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
    public class DeleteModel : PageModel
    {
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public DeleteModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sucursal = await _context.sucursal.FindAsync(id);

            if (Sucursal != null)
            {
                _context.sucursal.Remove(Sucursal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
