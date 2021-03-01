using AutoAdvert.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Advert> Adverts { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<FirstRegistration> FirstRegistration { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>()
            //    .HasMany(c => c.Advert)
            //    .WithOne(e => e.Car);

            modelBuilder.Entity<Brand>()
                .HasMany(c => c.Models)
                .WithOne(e => e.Brand);

            modelBuilder.Entity<Car>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Car>().HasData(
                new Car()
                {
                    Id = 1,
                    Name = "Audi",
                    Model = "A4",
                    FuelType = "Dyzelinas",
                    WheelPosition = "Priekiniai",
                    City = "Vilnius",
                    Gear = "Automatas",
                    Wheels = "Priekiniai",
                    BodyType = "Sedanas",
                    Color = "Blue",
                    FirstRegistration = "Vokietija",
                    Description = "Katik nuo tralo, sedi ir vaziuoji",
                    Price = 2596,
                    Power = 250,
                    Miles = 230040,
                    Year = 2003,
                    Volume = 20,
                    Seats = 6,
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
