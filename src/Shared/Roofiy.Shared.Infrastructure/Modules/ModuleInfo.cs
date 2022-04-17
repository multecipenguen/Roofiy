using System.Collections.Generic;

namespace Roofiy.Shared.Infrastructure.Modules;

internal record ModuleInfo(string Name, IEnumerable<string> Policies);