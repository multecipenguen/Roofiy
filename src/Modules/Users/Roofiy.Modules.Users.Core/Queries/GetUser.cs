using System;
using Roofiy.Modules.Users.Core.DTO;
using Roofiy.Shared.Abstractions.Queries;

namespace Roofiy.Modules.Users.Core.Queries;

internal class GetUser : IQuery<UserDetailsDto>
{
    public Guid UserId { get; set; }
}