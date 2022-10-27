using System;
using Services.DTO;

namespace Services.Interfaces
{
    public interface IautoresService
    {
        /// <summary>
        /// Obtiene todos los autores
        /// </summary>
        /// <returns></returns>
        List<autoresDTO> GetAllAutores();
        /// <summary>
        /// Obtiene los datos de un autor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        autoresDTO GetAutores(int id);
    }
}

