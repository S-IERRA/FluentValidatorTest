using FluentValidation;

using ValidatorTest;

User customer = new() { Email = "testmail.com", Password = "test123", Username = "S-ERRA" };

var result = customer.Validate(customer);

Console.WriteLine(result.IsValid);

foreach(var error in result.Errors)
	Console.WriteLine(error.ErrorMessage);