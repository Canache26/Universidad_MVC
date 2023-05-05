using System;
using Microsoft.AspNetCore.Mvc;
using Universidad_Curso.Models;

namespace Universidad_Curso.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View(new Asignatura{Nombre="Programación",UniqueId=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAsignatura()
        {
            var ListaAsignatura = new List<Asignatura>(){
                new Asignatura{Nombre="Programación",UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Estructura de Datos",UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Redes",UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Sistemas Operativos",UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Sistemas Distribuidos",UniqueId=Guid.NewGuid().ToString()},
            };


            ViewBag.CosaDinamica = "Stable diffusion";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura",ListaAsignatura);
        }
    }
}