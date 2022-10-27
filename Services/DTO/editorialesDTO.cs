using System;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class editorialesDTO
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string sede { get; set; }
    }
}

