using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class RoleNotFoundException : RoofiyException
{
    public RoleNotFoundException(string role) : base($"Role: '{role}' was not found.")
    {
    }
}