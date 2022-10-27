using System;
using Infraestructure.Data.Context;
using Services.DTO;
using Services.Interfaces;

namespace Services.Services
{
    public class editorialesService:IeditorialesService
    {
        #region Constructor
        private DataBaseContext _context;
        public editorialesService(DataBaseContext context)
        {
            _context = context;
        }
        #endregion
        #region Métodos
        public List<editorialesDTO> GetAllEditoriales()
        {
            var query = (from e in _context.editoriales
                         select new editorialesDTO
                         {
                             id = e.id,
                             nombre = e.nombre,
                             sede = e.sede
                         });
            return query.ToList();
        }

      

        public editorialesDTO GetEditorial(int id)
        {
            var query = (from e in _context.editoriales
                         where e.id == id
                         select new editorialesDTO
                         {
                             id = e.id,
                             nombre = e.nombre,
                             sede = e.sede
                         });
            return query.FirstOrDefault();
        }
        #endregion
    }
}

