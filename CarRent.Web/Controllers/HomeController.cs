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

            return View(cars);
        }

        public IActionResult Find()
        {
            var car = _carService.FindBy(x => x.Model == "Ford").Select(x => new CarVm(x)).AsQueryable();
            return View(car);
        }

        public IActionResult AddCar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCar(CarVm carVm)
        {
            if (!ModelState.IsValid)
            {
                return View(carVm);
            }

            Car car = new Car
            {
                Model = carVm.Model,
                Color = carVm.Color,
                NumberOfDoors = carVm.NumberOfDoors,
                ProductionDate = carVm  .ProductionDate
            };

            _carService.Add(car);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCar()
        {
            return View();
        }
    }
}
