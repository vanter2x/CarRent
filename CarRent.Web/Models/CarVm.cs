using System;
using CarRent.Models;

namespace CarRent.Web.Models
{
    public class CarVm
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }


        public CarVm()
        {
        }

        public CarVm(Car car)
        {
            Id = car.Id;
            Model = car.Model;
            ProductionDate = car.ProductionDate;
            Color = car.Color;
            NumberOfDoors = car.NumberOfDoors;
        }
    }


}