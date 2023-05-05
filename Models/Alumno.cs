using System;
using System.Collections.Generic;

namespace Universidad_Curso.Models
{
    public class Alumno: ObjetoUniversidadBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}