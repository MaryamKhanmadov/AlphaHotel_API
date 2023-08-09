using AlphaHotel_API.Service.DTOs.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaHotel_API.Service.Validators.Rooms
{
    public class CreateRoomValidator : AbstractValidator<RoomCreateDto>
    {
        public CreateRoomValidator() 
        {
            RuleFor(m => m.Name).NotEmpty().NotNull().MaximumLength(30).MinimumLength(5)
                .WithMessage("Please, enter the room name between 5 and 150 characters.");
            RuleFor(m => m.Descreption).NotNull().NotEmpty().MinimumLength(10).MaximumLength(700)
                .WithMessage("Please, enter the descreption between 10 and 700 characters.");
            RuleFor(m => m.AdultPrice).NotNull().NotEmpty().InclusiveBetween(10.00, 500.00)
                .WithMessage("Please, enter the AdultPrice between 10 and 500.");
            RuleFor(m => m.ChildPrice).NotNull().NotEmpty().InclusiveBetween(10.00, 500.00)
                .WithMessage("Please, enter the ChildPrice between 10 and 500.");
        }
    }
}
