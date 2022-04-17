using System.Collections.Generic;
using Roofiy.Shared.Infrastructure.Logging.Options;

namespace Roofiy.Shared.Infrastructure.Logging;

public class LoggerOptions
{
    public string Level { get; set; }
    public ConsoleOptions Console { get; set; }
    public Options.FileOptions File { get; set; }
    public SeqOptions Seq { get; set; }
    public IDictionary<string, string> Overrides { get; set; }
    public IEnumerable<string> ExcludePaths { get; set; }
    public IEnumerable<string> ExcludeProperties { get; set; }
    public IDictionary<string, object> Tags { get; set; }
}