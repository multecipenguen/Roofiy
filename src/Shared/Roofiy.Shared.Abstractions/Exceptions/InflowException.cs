using System;

namespace Roofiy.Shared.Abstractions.Exceptions;

public abstract class RoofiyException : Exception
{
    protected RoofiyException(string message) : base(message)
    {
    }
}