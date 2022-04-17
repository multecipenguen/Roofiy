using System;
using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class UserNotFoundException : RoofiyException
{
    public string Email { get; }
    public Guid UserId { get; }

    public UserNotFoundException(Guid userId) : base($"User with ID: '{userId}' was not found.")
    {
        UserId = userId;
    }
        
    public UserNotFoundException(string email) : base($"User with email: '{email}' was not found.")
    {
        Email = email;
    }
}