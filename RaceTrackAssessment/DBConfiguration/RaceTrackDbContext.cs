using RaceTrackAssessment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RaceTrackAssessment.DBConfiguration
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