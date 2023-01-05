using CoreDataBaseFirstApproach22.Models;
using FluentValidation;

namespace CoreDataBaseFirstApproach22.Validators
{
    public class UserValidation:AbstractValidator<UserLogin>
    {
        public UserValidation()
        {
            RuleFor(x=>x.FirstName).NotEmpty();
            RuleFor(x=>x.LastName).NotEmpty();
            RuleFor(x=>x.Username).NotEmpty();  
            RuleFor(x=>x.Password).Length(5,10);
        }
    }
}
