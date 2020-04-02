using RaceTrackDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrackAssessment.ViewModels
{
    public class RaceTrackCarViewModel
    {
    
        public List<Car> RaceTrackCars { get; set; }

        public RaceTrackCarViewModel(List<Car> raceTrackCars)
        {
            RaceTrackCars = raceTrackCars;
        }

    }
}