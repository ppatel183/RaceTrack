
using RaceTrackAssessment.ViewModels;
using RaceTrackDAL.Models;
using RaceTrackService.Service;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RaceTrackAssessment.Controllers
{
    public class RaceTrackController : Controller
    {
        private readonly ICar _ICar;
        private readonly IOnTrackCar _ITrack;

        public RaceTrackController(ICar CarRepo,IOnTrackCar OnTrack) 
        { 
            _ICar = CarRepo; 
            _ITrack = OnTrack; 
        }

        // GET: RaceTrack
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult LoadTracks()
        {
            List<Car> TrackCar = _ITrack.GetOnTrackCars();
            List<RaceTrackCarViewModel> TrackView = new List<RaceTrackCarViewModel>();

            foreach (Car c in TrackCar) 
            {
                TrackView.Add(new RaceTrackCarViewModel(c.CarId,c.CarName,c.Model,c.TowStrap,c.GroundHeight,c.TireWear));
            }

           return Json(TrackView, JsonRequestBehavior.AllowGet);
        }
        //// GET: RaceTrack/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: RaceTrack/Create
        [HttpPost]
        public ActionResult Create(RaceTrackCarViewModel car)
        {
           return Json(_ITrack.AddCarOnTrack(new Car(car.CarName, car.Model, car.TowStrap, car.GroundHeight, car.TireWear)));
        }
    }
}
