
using RaceTrackAssessment.ViewModels;
using RaceTrackDAL.Models;
using RaceTrackService.Service;
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
        //public JsonResult LoadCars()
        //{
             
        //    return Json(new RaceTrackCarViewModel(_ICar.GetCars()), JsonRequestBehavior.AllowGet);
        //}

        public JsonResult LoadTracks()
        {
           return Json(new RaceTrackCarViewModel(_ITrack.GetOnTrackCars()), JsonRequestBehavior.AllowGet);
           // return Json(_ITrack.GetOnTrackCars(), JsonRequestBehavior.AllowGet);
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
