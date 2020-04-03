


using RaceTrackService;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace RaceTrackAssessment
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			IUnityContainer container = new UnityContainer();
            //receives the registered services
            container = ServiceConfiguration.AddServices(container);
          
           
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}