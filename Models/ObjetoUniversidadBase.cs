using System;

namespace Universidad_Curso.Models
{
    public abstract class ObjetoUniversidadBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoUniversidadBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}