using System;
using System.Collections.Generic;


namespace Universidad_Curso.Models
{
    public class Universidad : ObjetoUniversidadBase
    {
        public int AñoDeCreación { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string Dirección { get; set; }

        public TiposUniversidad TipoUniversidad { get; set; }
        public List<Curso> Cursos { get; set; }

        public Universidad(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

        public Universidad(string nombre, int año,
                       TiposUniversidad tipo,
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, AñoDeCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public Universidad()
        {

        }
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoUniversidad} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}
