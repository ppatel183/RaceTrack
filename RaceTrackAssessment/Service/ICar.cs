using RaceTrackAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackAssessment.Service
{
    public interface ICar
    {
        List<Car> GetCars();
        Car GetCar(int id);
     
    }
}
