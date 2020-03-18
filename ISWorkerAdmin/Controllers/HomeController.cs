using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ISWorkerAdmin.Models;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using ISWorkerAdmin.Data;

namespace ISWorkerAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseConfiguration _configDataBase;

        public HomeController(ILogger<HomeController> logger, IOptions<DataBaseConfiguration> configdatabase)
        {
            _logger = logger;
            _configDataBase = configdatabase.Value ?? throw new ArgumentException(nameof(DataBaseConfiguration));   
        }

        
        public IActionResult Index()
        {         
            if ( string.IsNullOrEmpty(_configDataBase.DataBaseName))  
            {
                return RedirectToAction("Index","ConfigWorker");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
