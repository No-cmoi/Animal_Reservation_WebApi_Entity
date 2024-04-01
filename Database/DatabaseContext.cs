using System;
using Animalerie_MVC.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Animalerie_MVC.Web.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Reservation> Reservations { get; set; }



        protected readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connexionString = _configuration.GetConnectionString("AnimalsReservation");
            optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));

        }
    }
}
