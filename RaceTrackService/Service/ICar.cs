using RaceTrackDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackService.Service
{
    public interface ICar
    {
        List<Car> GetCars();
        Car GetCar(int id);

    }
}
