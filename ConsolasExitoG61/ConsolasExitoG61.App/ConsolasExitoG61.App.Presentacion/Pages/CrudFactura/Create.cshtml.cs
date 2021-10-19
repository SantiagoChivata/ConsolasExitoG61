using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConsolasExitoG61.App.Dominio.Entidades;
using ConsolasExitoG61.App.Persistencia;

namespace ConsolasExitoG61.App.Presentacion.Pages.CrudFactura
{
    public class CreateModel : PageModel
    {
        public SelectList ClienteFront;
        public int ClienteId{get; set;}
        public SelectList EmpleadoFront;
        public int EmpleadoId{get; set;}
        public SelectList ConsolaFront;
        public int ConsolaId{get; set;}
        public SelectList ControlFront;
        public int ControlId{get; set;}
        public SelectList VideoJuegoFront;
        public int VideoJuegoId{get; set;}
        private readonly ConsolasExitoG61.App.Persistencia.Conexion _context;

        public CreateModel(ConsolasExitoG61.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            List<Cliente> listaCliente = _context.cliente.ToList();
            ClienteFront = new SelectList(listaCliente, nameof(Cliente.Id),nameof(Cliente.Nombres));

            List<Empleado> listaEmpleados = _context.empleado.ToList();
            EmpleadoFront = new SelectList(listaEmpleados, nameof(Empleado.Id),nameof(Empleado.Nombres));

            List<Consola> listaConsolas = _context.consola.ToList();
            ConsolaFront = new SelectList(listaConsolas, nameof(Consola.Id),nameof(Consola.Nombre));

            List<Control> listaControles = _context.control.ToList();
            ControlFront = new SelectList(listaControles, nameof(Control.Id),nameof(Control.Nombre));

            List<VideoJuego> listaVideoJuego = _context.videoJuego.ToList();
            VideoJuegoFront = new SelectList(listaVideoJuego, nameof(VideoJuego.Id),nameof(VideoJuego.Nombre));
            return Page();
        }

        [BindProperty]
        public Factura Factura { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
                Cliente cliente = _context.cliente.FirstOrDefault(c => c.Id == ClienteId);
                Factura.Cliente = cliente; 
                Empleado empleado = _context.empleado.FirstOrDefault(e => e.Id == EmpleadoId);
                Factura.Vendedor = empleado;           
                Consola consola = _context.consola.FirstOrDefault(c => c.Id == ConsolaId);
                Factura.Consola = consola;
                Control control = _context.control.FirstOrDefault(c => c.Id == ControlId);
                Factura.Control = control;
                VideoJuego videoJuego = _context.videoJuego.FirstOrDefault(v => v.Id == ControlId);
                Factura.VideoJuego = videoJuego;
                
                _context.factura.Add(Factura);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
        }
    }
}
