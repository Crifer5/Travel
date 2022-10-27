using System;
using Infraestructure.Data.Context;
using Services.DTO;
using Services.Interfaces;

namespace Services.Services
{
    public class librosService:IlibrosService
    {
        #region Constructor
        private DataBaseContext _context;
        public librosService(DataBaseContext context)
        {
            _context = context;
        }
        #endregion
        #region métodos
        public List<librosDTO> GetAllLibros()
        {            var query = (from a in _context.libros
                         select new librosDTO
                         {
                             ISBN = a.ISBN,
                             editoriales_id = a.editoriales_id,
                             titulo=a.titulo,
                             sinopsis=a.sinopsis,
                             n_paginas=a.n_paginas
                         }) ;
            return query.ToList();
        }

        public List<librosDTO> GetAllLibrosByAutor(int autores_id)
        {
            var query = (from a in _context.libros
                         join b in _context.autores_has_libros on a.ISBN equals b.libros_ISBN
                         where b.autores_id==autores_id
                         select new librosDTO
                         {
                             ISBN = a.ISBN,
                             editoriales_id = a.editoriales_id,
                             titulo = a.titulo,
                             sinopsis = a.sinopsis,
                             n_paginas = a.n_paginas
                         });
            return query.ToList();
        }

        public List<librosDTO> GetAllLibrosByEditorial(int editoriales_id)
        {
            var query = (from a in _context.libros
                         where a.editoriales_id == editoriales_id
                         select new librosDTO
                         {
                             ISBN = a.ISBN,
                             editoriales_id = a.editoriales_id,
                             titulo = a.titulo,
                             sinopsis = a.sinopsis,
                             n_paginas = a.n_paginas
                         });
            return query.ToList();
        }

        public librosDTO GetLibros(int ISBN)
        {
            var query = (from a in _context.libros
                         where a.ISBN == ISBN
                         select new librosDTO
                         {
                             ISBN = a.ISBN,
                             editoriales_id = a.editoriales_id,
                             titulo = a.titulo,
                             sinopsis = a.sinopsis,
                             n_paginas = a.n_paginas
                         });
            return query.FirstOrDefault();
        }
        #endregion
    }
}

