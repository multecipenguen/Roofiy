using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class EmailInUseException : RoofiyException
{
    public EmailInUseException() : base("Email is already in use.")
    {
    }
}