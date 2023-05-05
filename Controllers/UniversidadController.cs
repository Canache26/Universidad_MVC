using System;
using Microsoft.AspNetCore.Mvc;
using Universidad_Curso.Models;

namespace Universidad_Curso.Controllers
{
    public class UniversidadController : Controller
    {
        public IActionResult Index()
        {
            var universidad = new Universidad();
            universidad.AñoDeCreación = 2005;
            universidad.UniqueId = Guid.NewGuid().ToString();
            universidad.Nombre = "Alejandro de Humboldt";
            universidad.Ciudad = "Caracas";
            universidad.Pais = "Venezuela";
            universidad.Dirección = "Av. Romulo Gallego";
            universidad.TipoUniversidad = TiposUniversidad.Introductorio;

            ViewBag.CosaDinamica = "Stable diffusion";

            return View(universidad);
        }
    }
}