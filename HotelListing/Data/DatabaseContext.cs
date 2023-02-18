using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country() { Id=1, Name="Georgia", ShortName="Saqartvelo"},
                new Country() { Id=2, Name="United States of america", ShortName="USD"},
                new Country() { Id = 3, Name = "Britan", ShortName = "UK" }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel() { Id = 1, Name = "Sandals resort and spa", Address="Negril",CountryId=1,Rating=4.5},
                new Hotel() { Id = 2, Name = "Comfort Suirs", Address = "George town", CountryId = 3, Rating = 4.3 },
                new Hotel() { Id = 3, Name = "Grand Palldium", Address = "Nannusa", CountryId = 2, Rating = 4 }
                );
        }


    }
}
