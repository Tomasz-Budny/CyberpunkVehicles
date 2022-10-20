using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CyberpunkVehicles.Models
{
    public class CreateVehicleDto
    {
        [Required]
        public IFormFile VehicleImage { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Group { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public int DrivetrainId { get; set; }
        [Required]
        public int BodyId { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int HorsePower { get; set; }
        [Required]
        public int TopSpeed { get; set; }
        [Required]
        public int Year { get; set; }
    }
}