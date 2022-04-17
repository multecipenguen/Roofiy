using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class InvalidUserStateException : RoofiyException
{
    public string State { get; }

    public InvalidUserStateException(string state) : base($"User state is invalid: '{state}'.")
    {
        State = state;
    }
}