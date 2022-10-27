using System;
using Services.DTO;

namespace Services.Interfaces
{
    public interface IeditorialesService
    {
        /// <summary>
        /// Obtiene todas las editoriales
        /// </summary>
        /// <returns></returns>
        List<editorialesDTO> GetAllEditoriales();
        /// <summary>
        /// Obtiene una editorial
        /// </summary>
        /// <returns></returns>
        editorialesDTO GetEditorial(int id);
    }

}

