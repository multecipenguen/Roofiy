using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class InvalidFullNameException : RoofiyException
{
    public string FullName { get; }

    public InvalidFullNameException(string fullName) : base($"Full name: '{fullName}' is invalid.")
    {
        FullName = fullName;
    }
}