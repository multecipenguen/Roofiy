using System;
using Roofiy.Shared.Abstractions.Time;

namespace Roofiy.Shared.Infrastructure.Time;

public class UtcClock : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}