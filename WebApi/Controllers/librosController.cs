using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class librosController : Controller
    {
        IlibrosService _service;
        public librosController(IlibrosService service)
        {
            _service = service;
        }
        /// <summary>
        /// Gets all books
        /// </summary>
        /// <returns>list of books</returns>
        [HttpGet]
        public ActionResult Get()
        {
            var data = _service.GetAllLibros();
            return Ok(data);
        }
        /// <summary>
        /// Gets all books of autor
        /// </summary>
        /// <returns>list of books</returns>
        [HttpGet]
        [Route("Autor/")]
        public ActionResult GetByAutor(int autor)
        {
            var data = _service.GetAllLibrosByAutor(autor);
            return Ok(data);
        }
        /// <summary>
        /// Gets all books of editorial
        /// </summary>
        /// <returns>list of books</returns>
        [HttpGet]
        [Route("editorial/")]
        public ActionResult GetByEditorial(int editorial)
        {
            var data = _service.GetAllLibrosByEditorial(editorial);
            return Ok(data);
        }
        /// <summary>
        /// Gets book by ISBN
        /// </summary>
        /// <returns>book</returns>
        [HttpGet]
        [Route("ISBN/")]
        public ActionResult GetByISBN(int id)
        {
            var data = _service.GetLibros(id);
            return Ok(data);
        }
    }
}

