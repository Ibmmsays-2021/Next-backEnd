using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Next.Platform.Application.Dtos;

namespace Next.Platform.Application.DtosValidator
{
   public class UserAuthenticationDtoValidator: AbstractValidator<UserAuthenticationDto>
    {
        public UserAuthenticationDtoValidator()
        {
            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty().WithMessage("PhoneNumber is required")
                .Matches(@"^01[0125][0-9]{8}$")
                .WithMessage(
                    "Phone Number should be like in Phone length is exactly 11 And Phone Prefix is with in allowed ones 010, 011, 012, 015");
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required")
                .Matches(@"^(?=.*[0-9]).{8,12}$").WithMessage("Password should be less than 8 characters  but no more than 12 and at at least one digit");

        }
    }
}
