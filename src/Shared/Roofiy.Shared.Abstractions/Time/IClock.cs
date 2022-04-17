using System;

namespace Roofiy.Shared.Abstractions.Time;

public interface IClock
{
    DateTime CurrentDate();
}