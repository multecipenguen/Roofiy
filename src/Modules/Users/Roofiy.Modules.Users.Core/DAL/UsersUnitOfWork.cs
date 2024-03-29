﻿using Roofiy.Shared.Infrastructure.Postgres;

namespace Roofiy.Modules.Users.Core.DAL;

internal class UsersUnitOfWork : PostgresUnitOfWork<UsersDbContext>
{
    public UsersUnitOfWork(UsersDbContext dbContext) : base(dbContext)
    {
    }
}