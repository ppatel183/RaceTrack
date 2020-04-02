
using RaceTrackService.Service;
using RaceTrackService.ServiceImpl;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace RaceTrackAssessment
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICar, CarServiceImpl>();
            container.RegisterType<IOnTrackCar, OnTrackCarServiceImpl>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}