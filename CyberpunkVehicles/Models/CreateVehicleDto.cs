using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CyberpunkVehicles.Models
{
    public class CreateVehicleDto
    {
        public IFormFile VehicleImage { get; set; }
        
        public string Name { get; set; }
        
        public string Group { get; set; }
        
        public string Description { get; set; }
        
        public int DrivetrainId { get; set; }
        
        public int BodyId { get; set; }
        
        public int Weight { get; set; }
        
        public int HorsePower { get; set; }
        
        public int TopSpeed { get; set; }
        
        public int Year { get; set; }
    }
}