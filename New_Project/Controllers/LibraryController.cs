using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace New_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly IData _data;

        public LibraryController(IData data)
        {
            _data = data;
        }

        [HttpGet]

        public ActionResult GetBooks()
        {
            return Ok(_data.GetBooks());
        }
    }
}