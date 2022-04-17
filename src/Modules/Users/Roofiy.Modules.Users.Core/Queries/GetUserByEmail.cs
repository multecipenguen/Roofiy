using Roofiy.Modules.Users.Core.DTO;
using Roofiy.Shared.Abstractions.Queries;

namespace Roofiy.Modules.Users.Core.Queries;

internal class GetUserByEmail : IQuery<UserDetailsDto>
{
    public string Email { get; set; }
}