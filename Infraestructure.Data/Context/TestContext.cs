using System;
using Infraestructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            :base(options)
        {
        }
        public DbSet<autores> autores { get; set; }
        public DbSet<autores_has_libros> autores_has_libros { get; set; }
        public DbSet<libros> libros { get; set; }
        public DbSet<editoriales> editoriales { get; set; }
    }
}

