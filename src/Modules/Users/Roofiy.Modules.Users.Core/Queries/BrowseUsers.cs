using Roofiy.Modules.Users.Core.DTO;
using Roofiy.Shared.Abstractions.Queries;

namespace Roofiy.Modules.Users.Core.Queries;

internal class BrowseUsers : PagedQuery<UserDto>
{
    public string Email { get; set; }
    public string Role { get; set; }
    public string State { get; set; }
}