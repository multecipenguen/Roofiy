﻿using System.Threading;
using System.Threading.Tasks;

namespace Roofiy.Shared.Abstractions.Kernel;

public interface IDomainEventHandler<in TEvent> where TEvent : class, IDomainEvent
{
    Task HandleAsync(TEvent @event, CancellationToken cancellationToken = default);
}