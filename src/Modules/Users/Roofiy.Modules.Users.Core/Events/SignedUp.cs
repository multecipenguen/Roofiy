using System;
using Roofiy.Shared.Abstractions.Events;

namespace Roofiy.Modules.Users.Core.Events;

internal record SignedUp(Guid UserId, string Email, string Role) : IEvent;