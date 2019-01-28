using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Services;
using Microsoft.AspNetCore.Mvc;
using CarRent.Web.Models;
using CarRent.Models;

namespace CarRent.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryService<Car> _carService;

        public HomeController(IRepositoryService<Car> carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var cars = _carService.GetAll();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
