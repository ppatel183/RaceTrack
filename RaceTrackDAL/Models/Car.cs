using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackDAL.Models
{
    public class Car
    {

        [Key]
        public int CarId { get; set; }

        public string CarName { get; set; }

        public string Model { get; set; }

        public bool TowStrap { get; set; }

        public double GroundHeight { get; set; }

        public int TireWear { get; set; }
        public OnTrackCar OnTrackCar { get; set; }

        
        public Car() { }

        public Car(string carName, string model, bool towStrap, double groundHeight, int tireWear)
        {
            CarName = carName;
            Model = model;
            TowStrap = towStrap;
            GroundHeight = groundHeight;
            TireWear = tireWear;
        }
    }
}
