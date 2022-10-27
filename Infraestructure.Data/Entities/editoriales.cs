using System;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Data.Entities
{
    public class editoriales
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string sede { get; set; }
    }
}

