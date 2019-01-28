﻿using CarRent.Models;
using CarRent.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Web.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>, IDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
         
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Worker> Workers { get; set; }  
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}