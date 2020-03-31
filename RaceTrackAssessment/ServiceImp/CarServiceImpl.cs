using RaceTrackAssessment.DBConfiguration;
using RaceTrackAssessment.Models;
using RaceTrackAssessment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrackAssessment.ServiceImp
{
    public class CarServiceImpl : ICar
    {
        private readonly RaceTrackDbContext trackDbContext;


        public CarServiceImpl(RaceTrackDbContext dbContext) { trackDbContext = dbContext; }

        public Car GetCar(int id)
        {
            return trackDbContext.Cars.Find(id);
        }

        public List<Car> GetCars()
        {
            return trackDbContext.Cars.ToList();
        }

      
    }
}