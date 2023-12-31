﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace eShopSolution.ViewModel.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required").MinimumLength(6).WithMessage("Password is at least 6 characters");
        }
    }
}