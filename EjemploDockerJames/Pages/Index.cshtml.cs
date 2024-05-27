using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MiProyecto.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnGetSaludar()
        {
            // Lógica para generar el saludo
            var horaActual = DateTime.Now.Hour;
            string saludo;

            if (horaActual < 12)
            {
                saludo = "¡Buenos días!";
            }
            else if (horaActual < 18)
            {
                saludo = "¡Buenas tardes!";
            }
            else
            {
                saludo = "¡Buenas noches!";
            }

            // Devolver el saludo como respuesta
            return Content(saludo);
        }
    }
}
