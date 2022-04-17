using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedNationalityException : RoofiyException
{
    public string Nationality { get; }

    public UnsupportedNationalityException(string nationality) : base($"Nationality: '{nationality}' is unsupported.")
    {
        Nationality = nationality;
    }
}