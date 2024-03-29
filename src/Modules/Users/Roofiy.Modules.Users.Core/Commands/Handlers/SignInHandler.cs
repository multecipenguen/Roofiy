﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Roofiy.Modules.Users.Core.Entities;
using Roofiy.Modules.Users.Core.Events;
using Roofiy.Modules.Users.Core.Exceptions;
using Roofiy.Modules.Users.Core.Repositories;
using Roofiy.Modules.Users.Core.Services;
using Roofiy.Shared.Abstractions;
using Roofiy.Shared.Abstractions.Auth;
using Roofiy.Shared.Abstractions.Commands;
using Roofiy.Shared.Abstractions.Messaging;

namespace Roofiy.Modules.Users.Core.Commands.Handlers;

internal sealed class SignInHandler : ICommandHandler<SignIn>
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthManager _authManager;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly IUserRequestStorage _userRequestStorage;
    private readonly IMessageBroker _messageBroker;
    private readonly ILogger<SignInHandler> _logger;

    public SignInHandler(IUserRepository userRepository, IAuthManager authManager,
        IPasswordHasher<User> passwordHasher, IUserRequestStorage userRequestStorage, IMessageBroker messageBroker,
        ILogger<SignInHandler> logger)
    {
        _userRepository = userRepository;
        _authManager = authManager;
        _passwordHasher = passwordHasher;
        _userRequestStorage = userRequestStorage;
        _messageBroker = messageBroker;
        _logger = logger;
    }

    public async Task HandleAsync(SignIn command, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetAsync(command.Email.ToLowerInvariant())
            .NotNull(() => new InvalidCredentialsException());

        if (user.State != UserState.Active)
        {
            throw new UserNotActiveException(user.Id);
        }

        if (_passwordHasher.VerifyHashedPassword(default, user.Password, command.Password) ==
            PasswordVerificationResult.Failed)
        {
            throw new InvalidCredentialsException();
        }

        var claims = new Dictionary<string, IEnumerable<string>>
        {
            ["permissions"] = user.Role.Permissions
        };

        var jwt = _authManager.CreateToken(user.Id, user.Role.Name, claims: claims);
        jwt.Email = user.Email;
        await _messageBroker.PublishAsync(new SignedIn(user.Id), cancellationToken);
        _logger.LogInformation($"User with ID: '{user.Id}' has signed in.");
        _userRequestStorage.SetToken(command.Id, jwt);
    }
}