using RaceTrackDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrackAssessment.ViewModels
{
    public class RaceTrackCarViewModel
    {
   
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Model { get; set; }
        public bool TowStrap { get; set; }
        public double GroundHeight { get; set; }
        public int TireWear { get; set; }

        public RaceTrackCarViewModel(int carId, string carName, string model, bool towStrap, double groundHeight, int tireWear)
        {
            CarId = carId;
            CarName = carName;
            Model = model;
            TowStrap = towStrap;
            GroundHeight = groundHeight;
            TireWear = tireWear;
        }
    }
}