using System;
using Roofiy.Shared.Abstractions.Commands;

namespace Roofiy.Modules.Users.Core.Commands;

internal record SignOut(Guid UserId) : ICommand;