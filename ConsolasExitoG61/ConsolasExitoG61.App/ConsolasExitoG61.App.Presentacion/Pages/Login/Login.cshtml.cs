using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsolasExitoG61.App.Persistencia;
using ConsolasExitoG61.App.Dominio.Entidades;

namespace ConsolasExitoG61.App.Presentacion.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }
        [BindProperty]
        public string Clave { get; set; }
        [BindProperty]
        public string MensajeUsuario { get; set; }
        [BindProperty]
        public string MensajeClave { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            Persona persona = conexion.persona.FirstOrDefault(p => p.Usuario == Usuario);

            if (persona != null)
            {
                if (persona.Clave.Equals(Clave))
                {
                    return RedirectToPage("../Index");
                }
                else
                {
                    MensajeClave = "La clave no coinscide";
                    return Page();
                }

            }
            else
            {
                MensajeUsuario = "No se encontro el Usuario";
                return Page();
            }
        }
    }
}
