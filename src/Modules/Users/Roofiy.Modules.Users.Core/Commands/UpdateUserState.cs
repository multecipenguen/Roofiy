using System;
using Roofiy.Shared.Abstractions.Commands;

namespace Roofiy.Modules.Users.Core.Commands;

internal record UpdateUserState(Guid UserId, string State) : ICommand;