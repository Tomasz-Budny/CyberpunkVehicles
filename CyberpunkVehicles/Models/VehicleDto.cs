namespace CyberpunkVehicles.Models
{
    public class VehicleDto
    {
        public int Id { get; set; }

        public string ImageRelativePath { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public string Drivetrain { get; set; }
        public string Body { get; set; }
        public int Weight { get; set; }
        public int HorsePower { get; set; }
        public string TopSpeed { get; set; }
        public int Year { get; set; }
    }
}