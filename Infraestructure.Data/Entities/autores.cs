using System;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Data.Entities
{
    public class autores
    {
        public int id { get; set; }
        [Required]
        public string nombre {get;set;}
        [Required]
        public string apellidos { get; set; }
    }
}

