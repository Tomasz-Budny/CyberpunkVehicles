using System.Collections.Generic;
using System.Linq;
using CyberpunkVehicles.Entities;

namespace CyberpunkVehicles
{
    public class VehiclesSeeder
    {
        private readonly VehicleDbContext _dbContext;

        public VehiclesSeeder(VehicleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Drivetrains.Any())
                {
                    var drivetrains = GetDrivetrains();
                    _dbContext.Drivetrains.AddRange(drivetrains);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.Bodies.Any())
                {
                    var bodies = GetBodies();
                    _dbContext.Bodies.AddRange(bodies);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.Vehicles.Any())
                {
                    var vehicle = GetVehicle();
                    _dbContext.Vehicles.Add(vehicle);
                    _dbContext.SaveChanges();
                }
            }
        }

        private List<Drivetrain> GetDrivetrains()
        {
            var drivetrains = new List<Drivetrain>()
            {
                new()
                {
                    Type = "RWD"
                },
                new()
                {
                    Type = "FWD"
                },
                new()
                {
                    Type = "AWD"
                }
            };
            return drivetrains;
        }
        private List<Body> GetBodies()
        {
            var bodies = new List<Body>()
            {
                new()
                {
                    Type = "Sedan"
                },
                new()
                {
                    Type = "Coupe"
                },
                new()
                {
                    Type = "Hatchback"
                }
            };
            return bodies;
        }

        private Vehicle GetVehicle()
        {
            var vehicle = new Vehicle()
            {
                ImageRelativePath = "/Images/quadra.jpg",
                Name = "Quadra Turbo-R V-Tech",
                Group = "Sports Car",
                Description =
                    "The Quadra Turbo-R was introduced as America's response to Japanese sports car manufactures. It was designed and built in Detroit, instantly becoming a star in the tuner scene when it was released in the mid 2050s.",
                DrivetrainId = 1,
                BodyId = 2,
                Weight = 3131,
                HorsePower = 740,
                TopSpeed = "187 MPH",
                Year = 2058
            };

            return vehicle;
        }
    }
}