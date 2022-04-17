using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Shared.Infrastructure.Messaging.Contexts;

public interface IMessageContextRegistry
{
    void Set(IMessage message, IMessageContext context);
}