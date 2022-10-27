using System;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class autoresDTO
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidos { get; set; }
    }
}

