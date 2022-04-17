using System.Threading;
using System.Threading.Tasks;
using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Shared.Infrastructure.Messaging.Dispatchers;

public interface IAsyncMessageDispatcher
{
    Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken = default)
        where TMessage : class, IMessage;
}