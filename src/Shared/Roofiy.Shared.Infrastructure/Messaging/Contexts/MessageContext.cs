using System;
using Roofiy.Shared.Abstractions.Contexts;
using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Shared.Infrastructure.Messaging.Contexts;

public class MessageContext : IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }

    public MessageContext(Guid messageId, IContext context)
    {
        MessageId = messageId;
        Context = context;
    }
}