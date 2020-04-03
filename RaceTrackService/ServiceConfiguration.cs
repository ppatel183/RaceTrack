using RaceTrackService.Service;
using RaceTrackService.ServiceImpl;
using Unity;
using Unity.Extension;

namespace RaceTrackService
{
    public static class ServiceConfiguration 
    {
        // registering dependencies for service layer
        public static IUnityContainer AddServices(IUnityContainer Container) 
        {
            Container.RegisterType<ICar, CarServiceImpl>();
            Container.RegisterType<IOnTrackCar, OnTrackCarServiceImpl>();
            return Container;
        }
    }
}
