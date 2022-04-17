﻿using System;
using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class UserStateCannotBeChangedException : RoofiyException
{
    public string State { get; }
    public Guid UserId { get; }

    public UserStateCannotBeChangedException(string state, Guid userId)
        : base($"User state cannot be changed to: '{state}' for user with ID: '{userId}'.")
    {
        State = state;
        UserId = userId;
    }
}