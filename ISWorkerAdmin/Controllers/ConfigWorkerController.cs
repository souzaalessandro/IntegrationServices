using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISWorkerAdmin.Data;

namespace ISWorkerAdmin.Controllers
{
    public class ConfigWorkerController : Controller
    {
        public IActionResult Index()
        {
            return View("ConfigDataBase");
        }

        [HttpGet]
        public IActionResult TestConfig([FromBody]DataBaseConfiguration form)
        {
            
            return Ok(Json("Sucess"));

        }
    }
}