using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Roofiy.Modules.Users.Core;
using Roofiy.Modules.Users.Core.DTO;
using Roofiy.Modules.Users.Core.Queries;
using Roofiy.Shared.Abstractions.Modules;
using Roofiy.Shared.Abstractions.Queries;
using Roofiy.Shared.Infrastructure.Modules;

namespace Roofiy.Modules.Users.Api;

internal class UsersModule : IModule
{
    public string Name { get; } = "Users";
        
    public IEnumerable<string> Policies { get; } = new[]
    {
        "users"
    };

    public void Register(IServiceCollection services)
    {
        services.AddCore();
    }
        
    public void Use(IApplicationBuilder app)
    {
        app.UseModuleRequests()
            .Subscribe<GetUserByEmail, UserDetailsDto>("users/get",
                (query, serviceProvider, cancellationToken) =>
                    serviceProvider.GetRequiredService<IQueryDispatcher>().QueryAsync(query, cancellationToken));
    }
}