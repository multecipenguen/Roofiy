using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedCurrencyException : RoofiyException
{
    public string Currency { get; }

    public UnsupportedCurrencyException(string currency) : base($"Currency: '{currency}' is unsupported.")
    {
        Currency = currency;
    }
}