using CarDealership.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarDealership.DataAccessEF
{
    public class CarDealershipDbContext : DbContext
    {
        public CarDealershipDbContext(DbContextOptions dbContextOptions) :
            base(dbContextOptions)
        {

        }

        public DbSet<Car> Cars { get; set; }

        //public DbSet<Color> Colors { get; set; }

        //public DbSet<Make> Makes { get; set; }
    }
}
