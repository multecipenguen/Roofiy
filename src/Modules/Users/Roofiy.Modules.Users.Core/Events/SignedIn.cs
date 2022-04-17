using System;
using Roofiy.Shared.Abstractions.Events;

namespace Roofiy.Modules.Users.Core.Events;

internal record SignedIn(Guid UserId) : IEvent;