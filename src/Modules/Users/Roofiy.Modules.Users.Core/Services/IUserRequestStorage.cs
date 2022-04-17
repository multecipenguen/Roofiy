using System;
using Roofiy.Shared.Abstractions.Auth;

namespace Roofiy.Modules.Users.Core.Services;

internal interface IUserRequestStorage
{
    void SetToken(Guid commandId, JsonWebToken jwt);
    JsonWebToken GetToken(Guid commandId);
}