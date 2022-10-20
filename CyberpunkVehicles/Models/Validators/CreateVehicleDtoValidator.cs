using CyberpunkVehicles.Entities;
using FluentValidation;

namespace CyberpunkVehicles.Models.Validators
{
    public class CreateVehicleDtoValidator: AbstractValidator<CreateVehicleDto>
    {
        public CreateVehicleDtoValidator(VehicleDbContext dbContext)
        {
            RuleFor(x => x.VehicleImage)
                .NotEmpty();
            
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(25);
            RuleFor(x => x.Group)
                .NotEmpty()
                .MaximumLength(20);
            
            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(250);
            
            RuleFor(x => x.Group)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.DrivetrainId)
                .NotEmpty();
            
            RuleFor(x => x.BodyId)
                .NotEmpty();

            RuleFor(x => x.Weight)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.HorsePower)
                .NotEmpty()
                .GreaterThanOrEqualTo(1)
                .WithMessage("źle jest");
            
            RuleFor(x => x.TopSpeed)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);
            
            RuleFor(x => x.Year)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);

        }
    }
}