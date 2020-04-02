namespace RaceTrackDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        Model = c.String(),
                        TowStrap = c.Boolean(nullable: false),
                        GroundHeight = c.Double(nullable: false),
                        TireWear = c.Int(nullable: false),
                        OnTrackCar_TrackID = c.Int(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.OnTrackCars", t => t.OnTrackCar_TrackID)
                .Index(t => t.OnTrackCar_TrackID);
            
            CreateTable(
                "dbo.OnTrackCars",
                c => new
                    {
                        TrackID = c.Int(nullable: false, identity: true),
                        TrackName = c.String(),
                    })
                .PrimaryKey(t => t.TrackID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "OnTrackCar_TrackID", "dbo.OnTrackCars");
            DropIndex("dbo.Cars", new[] { "OnTrackCar_TrackID" });
            DropTable("dbo.OnTrackCars");
            DropTable("dbo.Cars");
        }
    }
}
