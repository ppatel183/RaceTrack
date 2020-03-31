using RaceTrackAssessment.DBConfiguration;
using RaceTrackAssessment.Models;
using RaceTrackAssessment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace RaceTrackAssessment.ServiceImp
{
    public class OnTrackCarServiceImpl : IOnTrackCar
    {
        private readonly RaceTrackDbContext trackDbContext;
        public OnTrackCarServiceImpl(RaceTrackDbContext dbContext) { trackDbContext = dbContext; }

        public ResponceData AddCarOnTrack(Car car)
        {
            ResponceData rData = new ResponceData
            {
                IsSuccess = false
            };

            if (car.TireWear < 85) { rData.Message = "Car Should have tire wear more than 85 %"; }
            else if (car.TowStrap == false) { rData.Message = "Car Should have tow strap"; }
            else if (TotalCarsOnTrack() >= 5) { rData.Message = "Can not add more then 5 cars on track"; }
            else
            {
                OnTrackCar track = trackDbContext.OnTrackCars.Find(1);
                car.OnTrackCar = track;
                trackDbContext.Cars.Add(car);
                //track.Cars.Add(car);
                trackDbContext.SaveChanges();
                rData.IsSuccess = true;
                rData.Message = "The data has been processed!";
            }
           
            return rData;
        }
        public List<Car> GetOnTrackCars()
        {
            return trackDbContext.Cars.Where(x => x.OnTrackCar.TrackID == 1).ToList();
        }

        private int TotalCarsOnTrack()
        {
           return trackDbContext.Cars.Where(x => x.OnTrackCar.TrackID == 1).Count();
        }
    }
}