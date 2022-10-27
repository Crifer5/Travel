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
    public class autoresController : Controller
    {
        IautoresService _service;
        public autoresController(IautoresService service)
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
            var data = _service.GetAllAutores();
            return Ok(data);
        }
        /// <summary>
        /// Gets all books
        /// </summary>
        /// <returns>list of books</returns>
        [HttpGet]
        public ActionResult GetById(int id)
        {
            var data = _service.GetAutores(id);
            return Ok(data);
        }
    }
}

