using System;
using System.ComponentModel.DataAnnotations;
using Roofiy.Shared.Abstractions.Commands;

namespace Roofiy.Modules.Users.Core.Commands;

internal record SignIn([Required] [EmailAddress] string Email, [Required] string Password) : ICommand
{
    public Guid Id { get; init; } = Guid.NewGuid();
}