using System;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class librosDTO
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

