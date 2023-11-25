using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace eShopSolution.ViewModel.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Firstname is required")
                .MaximumLength(200).WithMessage("Firstname cannot over 200 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lastname is required")
                .MaximumLength(200).WithMessage("Lastname cannot over 200 characters");
            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot be greater than 100 years old");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email format not match");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");
            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.ConfirmPassword != request.Password)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
        }
    }
}