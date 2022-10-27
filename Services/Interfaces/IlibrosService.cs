using System;
using Services.DTO;

namespace Services.Interfaces
{
    public interface IlibrosService
    {
        /// <summary>
        /// Obtiene todos los libros
        /// </summary>
        /// <returns></returns>
        List<librosDTO> GetAllLibros();
        /// <summary>
        /// Obtiene un libro
        /// </summary>
        /// <returns></returns>
        librosDTO GetLibros(int ISBN);
        /// <summary>
        /// Obtiene todos los libros de un autor
        /// </summary>
        /// <param name="autores_id">id del autor</param>
        /// <returns></returns>
        List<librosDTO> GetAllLibrosByAutor(int autores_id);
        /// <summary>
        /// Obtiene todos los libros de una editorial
        /// </summary>
        /// <param name="editoriales_id"> id de la editorial</param>
        /// <returns></returns>
        List<librosDTO> GetAllLibrosByEditorial(int editoriales_id);

    }
}

