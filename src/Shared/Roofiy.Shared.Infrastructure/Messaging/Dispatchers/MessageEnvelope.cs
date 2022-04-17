using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Shared.Infrastructure.Messaging.Dispatchers;

internal record MessageEnvelope(IMessage Message, IMessageContext MessageContext);