using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class InvalidCredentialsException : RoofiyException
{
    public InvalidCredentialsException() : base("Invalid credentials.")
    {
    }
}