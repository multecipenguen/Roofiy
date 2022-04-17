using Roofiy.Shared.Abstractions.Exceptions;

namespace Roofiy.Modules.Users.Core.Exceptions;

internal class SignUpDisabledException : RoofiyException
{
    public SignUpDisabledException() : base("Sign up is disabled.")
    {
    }
}