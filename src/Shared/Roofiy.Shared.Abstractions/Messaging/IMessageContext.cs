using System;
using Roofiy.Shared.Abstractions.Contexts;

namespace Roofiy.Shared.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}