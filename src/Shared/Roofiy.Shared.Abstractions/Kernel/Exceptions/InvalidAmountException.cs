using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Shared.Abstractions.Kernel.Exceptions;

public class InvalidAmountException : RoofiyException
{
    public decimal Amount { get; }

    public InvalidAmountException(decimal amount) : base($"Amount: '{amount}' is invalid.")
    {
        Amount = amount;
    }
}