using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Roofiy.Modules.Users.Core.DAL;
using Roofiy.Modules.Users.Core.DAL.Repositories;
using Roofiy.Modules.Users.Core.Entities;
using Roofiy.Modules.Users.Core.Repositories;
using Roofiy.Modules.Users.Core.Services;
using Roofiy.Shared.Infrastructure;
using Roofiy.Shared.Infrastructure.Messaging.Outbox;
using Roofiy.Shared.Infrastructure.Postgres;

[assembly: InternalsVisibleTo("Roofiy.Modules.Users.Api")]
[assembly: InternalsVisibleTo("Roofiy.Modules.Users.Tests.Integration")]
[assembly: InternalsVisibleTo("Roofiy.Modules.Users.Tests.Unit")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]


namespace Roofiy.Modules.Users.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        var registrationOptions = services.GetOptions<RegistrationOptions>("users:registration");
        services.AddSingleton(registrationOptions);

        return services
            .AddSingleton<IUserRequestStorage, UserRequestStorage>()
            .AddScoped<IRoleRepository, RoleRepository>()
            .AddScoped<IUserRepository, UserRepository>()
            .AddSingleton<IPasswordHasher<User>, PasswordHasher<User>>()
            .AddPostgres<UsersDbContext>()
            .AddOutbox<UsersDbContext>()
            .AddUnitOfWork<UsersUnitOfWork>()
            .AddInitializer<UsersInitializer>();
    }
}