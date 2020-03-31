using RaceTrackAssessment.Models;
using RaceTrackAssessment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaceTrackAssessment.Controllers
{
    public class RaceTrackController : Controller
    {
        private readonly ICar _ICar;
        private readonly IOnTrackCar _ITrack;

        public RaceTrackController(ICar CarRepo,IOnTrackCar OnTrack) { _ICar = CarRepo; _ITrack = OnTrack; }

        // GET: RaceTrack
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult LoadCars()
        {
            return Json(_ICar.GetCars(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult LoadTracks()
        {
            return Json(_ITrack.GetOnTrackCars(), JsonRequestBehavior.AllowGet);
        }
        // GET: RaceTrack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RaceTrack/Create
        [HttpPost]
        public ActionResult Create(Car car)
        {
           return Json(_ITrack.AddCarOnTrack(car));
        }
    }
}
