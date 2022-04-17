using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class InvalidEmailException : RoofiyException
{
    public string Email { get; }

    public InvalidEmailException(string email) : base($"State is invalid: '{email}'.")
    {
        Email = email;
    }
}