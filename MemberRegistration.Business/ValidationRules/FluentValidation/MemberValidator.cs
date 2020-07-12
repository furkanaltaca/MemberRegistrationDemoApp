using FluentValidation;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.DateOfBirth).NotEmpty();
            RuleFor(x => x.TcNo).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();

            RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now);

        }
    }
}
