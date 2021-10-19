using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConsolasExitoG61.App.Dominio.Entidades;
using ConsolasExitoG61.App.Persistencia;

namespace ConsolasExitoG61.App.Presentacion.Pages.CrudControl
{
    public class EditModel : PageModel
    {
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public EditModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Control Control { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Control = await _context.control.FirstOrDefaultAsync(m => m.Id == id);

            if (Control == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Control).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ControlExists(Control.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ControlExists(int id)
        {
            return _context.control.Any(e => e.Id == id);
        }
    }
}
