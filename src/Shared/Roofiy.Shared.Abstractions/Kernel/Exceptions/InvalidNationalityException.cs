using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class InvalidNationalityException : RoofiyException
{
    public string Nationality { get; }

    public InvalidNationalityException(string nationality) : base($"Nationality: '{nationality}' is invalid.")
    {
        Nationality = nationality;
    }
}