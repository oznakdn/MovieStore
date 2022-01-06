﻿using FluentValidation;
using MovieStore.WebApi.Models.ViewModels.DirectorViewModels;

namespace MovieStore.WebApi.Business.Validations.DirectorValidations
{
    public class CreateDirectorValidator:AbstractValidator<CreateDirectorModel>
    {
        public CreateDirectorValidator()
        {
            RuleFor(x => x.FirstName).NotNull().MinimumLength(2).MaximumLength(20);
            RuleFor(x => x.LastName).NotNull().MinimumLength(2).MaximumLength(30);
        }
    }
}
