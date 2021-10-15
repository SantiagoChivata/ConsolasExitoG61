using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsolasExitoG61.App.Dominio.Entidades;
using ConsolasExitoG61.App.Persistencia;
using Microsoft.AspNetCore.Http;

namespace ConsolasExitoG61.App.Presentacion.Pages
{
    public class CambioClaveModel : PageModel
    {
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string RepeatPassword { get; set; }
        [BindProperty]
        public string MensajeClave { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            Conexion conexion = new Conexion();
            string Username = HttpContext.Session.GetString("username");
            HttpContext.Session.Remove("username");
            Empleado empleado = conexion.empleado.FirstOrDefault(e => e.Usuario == Username);
            if (!Password.Equals(RepeatPassword))
            {
                MensajeClave = "La clave no coinside";
            }
            else
            {
                empleado.Clave = Password;
                empleado.primerIngreso = false;
                conexion.SaveChanges();
                Response.Redirect("../Index");
            }
        }
    }
}
