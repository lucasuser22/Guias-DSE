using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace MVCPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET : /HelloWorld/
        private static int contador = 0;

        public IActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            contador++;
            ViewData["nombre"] = nombre;
            ViewData["apellido"] = apellido;
            ViewData["numVeces"] = numVeces;
            ViewData["contador"] = contador;

            return View();
        }
    }
}
