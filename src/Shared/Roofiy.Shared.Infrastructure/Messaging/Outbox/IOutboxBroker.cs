using System.Threading.Tasks;
using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Shared.Infrastructure.Messaging.Outbox;

public interface IOutboxBroker
{
    bool Enabled { get; }
    Task SendAsync(params IMessage[] messages);
}