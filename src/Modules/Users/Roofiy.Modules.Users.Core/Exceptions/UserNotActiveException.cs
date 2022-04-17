using System;
using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class UserNotActiveException : RoofiyException
{
    public Guid UserId { get; }

    public UserNotActiveException(Guid userId) : base($"User with ID: '{userId}' is not active.")
    {
        UserId = userId;
    }
}