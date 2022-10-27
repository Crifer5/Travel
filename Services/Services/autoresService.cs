using System;
using Infraestructure.Data.Context;
using Services.DTO;
using Services.Interfaces;

namespace Services.Services
{
    public class autoresService:IautoresService
    {
        #region Constructor
        private DataBaseContext _context;
        public autoresService(DataBaseContext context)
        {
            _context = context;
        }
        #endregion
        #region Métodos
        public List<autoresDTO> GetAllAutores()
        {
            var query = (from e in _context.autores
                         select new autoresDTO
                         {
                             id = e.id,
                             nombre = e.nombre,
                             apellidos = e.apellidos
                         });
            return query.ToList();
        }

        public autoresDTO GetAutores(int id)
        {
            var query = (from e in _context.autores
                         where e.id==id
                         select new autoresDTO
                         {
                             id = e.id,
                             nombre = e.nombre,
                             apellidos = e.apellidos
                         });
            return query.FirstOrDefault();
        }
        #endregion
    }
}

