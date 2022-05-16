using LogginNLogLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LogginNLogLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            int value1 = 5;
            int value2 = 0;
            int result;
                try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, ex.Message);
            }

            _logger.LogInformation("Index sayfası başlamıştır...");
            _logger.LogWarning("Warning Hata.");
            _logger.LogError("Error Log...");
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
