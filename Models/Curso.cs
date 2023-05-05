using System;
using System.Collections.Generic;


namespace Universidad_Curso.Models
{
    public class Curso:ObjetoUniversidadBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }

    }
}