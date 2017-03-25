using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace fluentValidation_test
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Age)
                .Must(x => x >= 18 && x <= 100)
                .WithMessage("Age must be between 18 and 100");
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name cannot be empty");
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("This is not a valid email!");
        }
    }
}