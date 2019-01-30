using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarRent.Services
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    OrderDate = DateTime.Now,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    TotalPrice = 10000
                }
            );
        }
    }
}
