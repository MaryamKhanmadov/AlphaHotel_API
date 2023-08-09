using AlphaHotel_API.Service.DTOs.Partner;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaHotel_API.Service.Validators.Partners
{
    public class CreatePartnerValidator : AbstractValidator<PartnerCreateDto>
    {
        public CreatePartnerValidator()
        {
            RuleFor(m => m.Name).NotEmpty().NotNull().MaximumLength(50).MinimumLength(10)
                .WithMessage("Please, enter the room name between 10 and 50 characters.");
            RuleFor(m => m.Descreption).NotEmpty().NotNull().MaximumLength(1000).MinimumLength(200)
                .WithMessage("Please, enter the room name between 200 and 1000 characters.");
            RuleFor(m => m.LogoUrl).NotEmpty().NotNull().MaximumLength(100).MinimumLength(10)
                .WithMessage("Please, enter the room name between 10 and 100 characters.");
        }
    }
}
