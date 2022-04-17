using System.Threading;
using System.Threading.Tasks;
using Roofiy.Shared.Abstractions.Commands;
using Roofiy.Shared.Abstractions.Events;
using Roofiy.Shared.Abstractions.Queries;

namespace Roofiy.Shared.Abstractions.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}