namespace RaceTrackAssessment.Migrations
{
    using RaceTrackAssessment.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RaceTrackAssessment.DBConfiguration.RaceTrackDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RaceTrackAssessment.DBConfiguration.RaceTrackDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            List<Car> Cars = new List<Car>();

            OnTrackCar onTrack = new OnTrackCar
            {
                TrackName = "FirstTrack"
            };

            context.OnTrackCars.Add(onTrack);
            context.SaveChanges();

            Cars.Add(new Car() { CarName = "Car Name 1", Model = "111", GroundHeight = 4.8, TowStrap = true, TireWear = 86, OnTrackCar = onTrack });
            Cars.Add(new Car() { CarName = "Car Name 2", Model = "222", GroundHeight = 4.7, TowStrap = true, TireWear = 86, OnTrackCar = onTrack });
            Cars.Add(new Car() { CarName = "Car Name 3", Model = "333", GroundHeight = 4.9, TowStrap = true, TireWear = 86, OnTrackCar = onTrack });
            Cars.Add(new Car() { CarName = "Car Name 4", Model = "444", GroundHeight = 4.2, TowStrap = true, TireWear = 86, OnTrackCar = onTrack });


            context.Cars.AddRange(Cars);
            onTrack.Cars = Cars;
           
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
