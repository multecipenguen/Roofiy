using System.Collections.Generic;

namespace Roofiy.Modules.Users.Core.DTO;

public class UserDetailsDto : UserDto
{
    public IEnumerable<string> Permissions { get; set; }
}