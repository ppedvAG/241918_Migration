﻿using CarManager.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CarManager.Data.EfCore
{
    public class EfContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public EfContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlazorCars;Trusted_Connection=true");
        }
    }
}
