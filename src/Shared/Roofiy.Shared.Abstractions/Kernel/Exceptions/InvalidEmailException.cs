using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class InvalidEmailException : RoofiyException
{
    public string Email { get; }

    public InvalidEmailException(string email) : base($"Email: '{email}' is invalid.")
    {
        Email = email;
    }
}