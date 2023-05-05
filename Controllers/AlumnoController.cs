using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Universidad_Curso.Models;

namespace Universidad_Curso.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(new Alumno{Nombre="Herbert Díaz",UniqueId=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAlumno()
        {
            var ListaAlumnos = GenerarAlumnosAlAzar();


            ViewBag.CosaDinamica = "Stable diffusion";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno",ListaAlumnos);
        }

        public List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = {"Jose", "Pedro", "Teofilo", "Valentina", "Stephanie"};
            string[] apellido = {"Gutierrez", "Gonzalez", "Velasquez", "Rodriguez"};
            string[] nombre2 = {"Eliana", "Luis", "Betzabeth", "Alvaro", "Carlos"};

            var ListaAlumno = from n1 in nombre1
                              from n2 in nombre2
                              from a1 in apellido
                              select new Alumno {Nombre = $"{n1} {n2} {a1}"};

            return ListaAlumno.OrderBy((a1) => a1.UniqueId).ToList();
        }
    }
}