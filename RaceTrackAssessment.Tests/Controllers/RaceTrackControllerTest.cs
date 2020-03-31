using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceTrackAssessment;
using RaceTrackAssessment.Controllers;
using RaceTrackAssessment.DBConfiguration;
using RaceTrackAssessment.Models;
using RaceTrackAssessment.Service;
using RaceTrackAssessment.ServiceImp;

namespace RaceTrackAssessment.Tests.Controllers
{
    [TestClass]
    public class RaceTrackControllerTest
    {
        RaceTrackDbContext DBContext = new RaceTrackDbContext();

          [TestMethod]
        public void AddCarwithHighHeight()
        {
            IOnTrackCar _ITrack = new OnTrackCarServiceImpl(DBContext);
            Car c = new Car
            {
                CarName = "Test 1",
                Model = "965",
                TowStrap = true,
                GroundHeight = 5.6,
                TireWear = 86
            };

            ResponceData result = _ITrack.AddCarOnTrack(c);

            Assert.IsTrue(result.IsSuccess == false);
        }
        [TestMethod]
        public void AddCarwithLessTireWear()
        {
            IOnTrackCar _ITrack = new OnTrackCarServiceImpl(DBContext);
            Car c = new Car
            {
                CarName = "Test 1",
                Model = "965",
                TowStrap = true,
                GroundHeight = 4.6,
                TireWear = 80
            };

            ResponceData result = _ITrack.AddCarOnTrack(c);

            Assert.IsTrue(result.IsSuccess == false);
        }
        public void AddCarwithNoTowStrap()
        {
            IOnTrackCar _ITrack = new OnTrackCarServiceImpl(DBContext);
            Car c = new Car
            {
                CarName = "Test 1",
                Model = "965",
                TowStrap = false,
                GroundHeight = 4.6,
                TireWear = 80
            };

            ResponceData result = _ITrack.AddCarOnTrack(c);

            Assert.IsTrue(result.IsSuccess == false);
        }
    }
}
