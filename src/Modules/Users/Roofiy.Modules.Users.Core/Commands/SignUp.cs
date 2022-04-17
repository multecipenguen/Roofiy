using System;
using System.ComponentModel.DataAnnotations;
using Roofiy.Shared.Abstractions.Commands;

namespace Roofiy.Modules.Users.Core.Commands;

internal record SignUp([Required] [EmailAddress] string Email, [Required] string Password, string Role) : ICommand
{
    public Guid UserId { get; init; } = Guid.NewGuid();
}