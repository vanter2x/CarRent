using System;
using CarRent.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace CarRent.Services.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cars.Any())
            {
                context.Cars.Add(new Car
                {
                    Color = "green",
                    Model = "Opel",
                    NumberOfDoors = 5,
                    ProductionDate = DateTime.Now
                });
            }

            context.SaveChanges();
        }
    }
}