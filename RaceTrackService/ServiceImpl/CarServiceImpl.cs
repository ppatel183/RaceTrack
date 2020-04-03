using RaceTrackDAL.DBConfiguration;
using RaceTrackDAL.Models;
using RaceTrackService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackService.ServiceImpl
{
    public class CarServiceImpl : ICar
    {
        private readonly RaceTrackDbContext trackDbContext;

        public CarServiceImpl(RaceTrackDbContext dbContext) 
        { 
            trackDbContext = dbContext; 
        }

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
