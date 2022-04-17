using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Roofiy.Modules.Users.Core.Entities;
using Roofiy.Modules.Users.Core.Events;
using Roofiy.Modules.Users.Core.Exceptions;
using Roofiy.Modules.Users.Core.Repositories;
using Roofiy.Shared.Abstractions;
using Roofiy.Shared.Abstractions.Commands;
using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Modules.Users.Core.Commands.Handlers;

internal sealed class UpdateUserStateHandler : ICommandHandler<UpdateUserState>
{
    private readonly IUserRepository _userRepository;
    private readonly IMessageBroker _messageBroker;
    private readonly ILogger<UpdateUserStateHandler> _logger;

    public UpdateUserStateHandler(IUserRepository userRepository, IMessageBroker messageBroker,
        ILogger<UpdateUserStateHandler> logger)
    {
        _userRepository = userRepository;
        _messageBroker = messageBroker;
        _logger = logger;
    }

    public async Task HandleAsync(UpdateUserState command, CancellationToken cancellationToken = default)
    {
        if (!Enum.TryParse<UserState>(command.State, true, out var state))
        {
            throw new InvalidUserStateException(command.State);
        }

        var user = await _userRepository.GetAsync(command.UserId)
            .NotNull(() => new UserNotFoundException(command.UserId));

        var previousState = user.State;
        if (previousState == state)
        {
            return;
        }
            
        if (user.RoleId == Role.Admin)
        {
            throw new UserStateCannotBeChangedException(command.State, command.UserId);
        }

        user.State = state;
        await _userRepository.UpdateAsync(user);
        await _messageBroker.PublishAsync(new UserStateUpdated(user.Id, state.ToString().ToLowerInvariant()), cancellationToken);
        _logger.LogInformation($"Updated state for user with ID: '{user.Id}', '{previousState}' -> '{user.State}'.");
    }
}