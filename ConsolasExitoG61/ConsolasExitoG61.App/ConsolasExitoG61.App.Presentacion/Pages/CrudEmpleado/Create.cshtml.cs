using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConsolasExitoG61.App.Dominio.Entidades;
using ConsolasExitoG61.App.Persistencia;

namespace ConsolasExitoG61.App.Presentacion.Pages.CrudEmpleado
{
    public class CreateModel : PageModel
    {
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public SelectList SucursalesFront;

        public int SucuralId{get; set;}

        public string usuarioExistente{get; set;}

        public CreateModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            List<Sucursal> listaSucursales = _context.sucursal.ToList();
            SucursalesFront = new SelectList(listaSucursales, nameof(Sucursal.Id),nameof(Sucursal.Nombre));
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; }
        public Cargo Cargo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Empleado verificarUsuario = _context.empleado.FirstOrDefault(e => e.Usuario == Empleado.Usuario);
            if (verificarUsuario != null)
            {
                 usuarioExistente ="El nombre de usuario ya esta en uso";
                 return Page();
            }else{
                Sucursal sucursal = _context.sucursal.FirstOrDefault(s => s.Id == SucuralId);
                Empleado.Sucursal = sucursal;
                Empleado.primerIngreso = true;
                _context.empleado.Add(Empleado);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");

            }
            
        }
    }
}
