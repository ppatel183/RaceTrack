﻿using RaceTrackDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackService.Service
{
    public interface IOnTrackCar
    {
        List<Car> GetOnTrackCars();
        ResponceData AddCarOnTrack(Car car);
    }
}
