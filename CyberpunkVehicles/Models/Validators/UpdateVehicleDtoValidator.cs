using FluentValidation;

namespace CyberpunkVehicles.Models.Validators
{
    public class UpdateVehicleDtoValidator: AbstractValidator<UpdateVehicleDto>
    {
        public UpdateVehicleDtoValidator()
        {
            RuleFor(x => x.DrivetrainId)
                .NotEmpty();
            
            RuleFor(x => x.BodyId)
                .NotEmpty();

            RuleFor(x => x.Weight)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.HorsePower)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);
            
            RuleFor(x => x.TopSpeed)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);
            
            RuleFor(x => x.Year)
                .NotEmpty()
                .GreaterThanOrEqualTo(1);
        }
    }
}