using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarRent.Web.Models;
using CarRent.Services;
using CarRent.Models;
using Serilog;
using System;

namespace CarRent.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryService<Car> _carRepository;
        private readonly IRepositoryService<Order> _orderRepository;

        private readonly ILogger _log;

        public HomeController
        (
            IRepositoryService<Car> carRepository,
            IRepositoryService<Order> orderRepository,
            ILogger log
        )
        {
            _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));

            _log = log ?? throw new ArgumentNullException(nameof(log));
        }

        public IActionResult Index()
        {
            Car car = new Car() { Color = "Black", Model = "Opel" };
            _carRepository.Add(car);
            //return View();

            Log.Information("Car Added");

            return Ok(_carRepository.GetAll());
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
