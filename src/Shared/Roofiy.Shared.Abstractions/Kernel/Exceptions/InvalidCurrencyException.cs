using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class InvalidCurrencyException : RoofiyException
{
    public string Currency { get; }

    public InvalidCurrencyException(string currency) : base($"Currency: '{currency}' is invalid.")
    {
        Currency = currency;
    }
}