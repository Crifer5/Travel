using System;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Data.Entities
{
    public class libros
    {
        public int ISBN { get; set; }
        public int editoriales_id { get; set; }
        [Required]
        public string titulo { get; set; }
        [Required]
        public string sinopsis { get; set; }
        [Required]
        public string n_paginas { get; set; }
    }
}

