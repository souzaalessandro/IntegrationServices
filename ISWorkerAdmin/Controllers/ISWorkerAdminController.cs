using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISWorkerAdmin.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ISWorker.Dao;

namespace ISWorkerAdmin.Controllers
{
    public class ISWorkerAdminController : Controller
    {
        private readonly IServiceCollection services;

        public ISWorkerAdminController(IServiceCollection services)
        {
            this.services = services;
        }
        public IActionResult TestConfiguration([FromBody] ConfigurationModel model)
        {
            
            return View();
        }

        public IActionResult SaveConfigurationAndRestart([FromBody] ConfigurationModel model)
        {            
            return View();
        }
    }
}