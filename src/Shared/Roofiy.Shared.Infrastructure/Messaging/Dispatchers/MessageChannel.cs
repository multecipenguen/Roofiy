﻿using System.Threading.Channels;

namespace Roofiy.Shared.Infrastructure.Messaging.Dispatchers;

internal sealed class MessageChannel : IMessageChannel
{
    private readonly Channel<MessageEnvelope> _messages = Channel.CreateUnbounded<MessageEnvelope>();

    public ChannelReader<MessageEnvelope> Reader => _messages.Reader;
    public ChannelWriter<MessageEnvelope> Writer => _messages.Writer;
}