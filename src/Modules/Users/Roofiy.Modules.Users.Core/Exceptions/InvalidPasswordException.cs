using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class InvalidPasswordException : RoofiyException
{
    public string Reason { get; }

    public InvalidPasswordException(string reason) : base($"Invalid password: {reason}.")
    {
        Reason = reason;
    }
}