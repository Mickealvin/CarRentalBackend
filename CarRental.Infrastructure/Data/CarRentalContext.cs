using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data
{
    public class CarRentalContext: DbContext
    {
        public IConfiguration Configuration { get; }
        public CarRentalContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("CarRentalDB"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
