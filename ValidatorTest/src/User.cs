using FluentValidation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorTest
{
	public class User : AbstractValidator<User>
	{
		public required string Username { get; set; }
		public required string Email    { get; set; }
		public required string Password { get; set; }

		public User()
		{
			RuleFor(x => x.Username).Length(6, 27).WithMessage("Username must be between 6-27 chars long.");
			RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email address.");
		}
	}
}
