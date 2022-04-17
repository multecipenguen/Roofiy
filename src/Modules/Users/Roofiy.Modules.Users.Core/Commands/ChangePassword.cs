using System;
using Roofiy.Shared.Abstractions.Commands;

namespace Roofiy.Modules.Users.Core.Commands;

internal record ChangePassword(Guid UserId, string CurrentPassword, string NewPassword) : ICommand;