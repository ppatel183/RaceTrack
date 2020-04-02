using RaceTrackDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackDAL.DBConfiguration
{
    public class RaceTrackDbContext : DbContext
    {
        public RaceTrackDbContext() : base("name=RaceTrackDbContext")
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<OnTrackCar> OnTrackCars { get; set; }

    }
}
