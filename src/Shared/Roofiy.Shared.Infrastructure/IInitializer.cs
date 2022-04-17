using System.Threading.Tasks;

namespace Roofiy.Shared.Infrastructure;

public interface IInitializer
{
    Task InitAsync();
}