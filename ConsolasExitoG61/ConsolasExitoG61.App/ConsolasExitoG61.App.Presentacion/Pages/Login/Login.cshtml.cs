using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsolasExitoG61.App.Persistencia;
using ConsolasExitoG61.App.Dominio.Entidades;
using Microsoft.AspNetCore.Http;

namespace ConsolasExitoG61.App.Presentacion.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public bool UsuarioAutenticado{get; set;}
 
        [BindProperty]
        public string Clave { get; set; }
        [BindProperty]
        public string MensajeUsuario { get; set; }
        [BindProperty]
        public string MensajeClave { get; set; }
        public void OnGet()
        {
            var usuarioAutenticado = HttpContext.Session.GetString("usuarioAutenticado");
            if(usuarioAutenticado != null){
                UsuarioAutenticado = true;
            }else{
                UsuarioAutenticado = false;
            }
        }
        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            Empleado empleado = conexion.empleado.FirstOrDefault(e => e.Usuario == Usuario);
            

            if (empleado != null)
            {
                if(empleado.Clave.Equals(Clave))
                {
                    if (empleado.primerIngreso){
                    HttpContext.Session.SetString("username", Usuario);
                    return RedirectToPage("../CambioClave/CambioClave");

                    }

                HttpContext.Session.SetString("usuarioAutenticado", "Autenticado");

                switch(empleado.Cargo){
                    case Cargo.ADMIISTRADOR_COMPRAS:
                        return RedirectToPage("../CrudConsola/Index");
                    case Cargo.ADMINISTRADOR_VENTAS:
                        return RedirectToPage("../CrudProveedor/Index");
                    case Cargo.ADMINISTRADOR_SISTEMA:
                        return RedirectToPage("../CrudEmpleado/Index");
                    case Cargo.VENDEDOR:
                        return RedirectToPage("../CrudVideoJuego/Index");
                    default:
                    return RedirectToPage("../Index");
                    }
                 
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
