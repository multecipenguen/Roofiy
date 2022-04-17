﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Roofiy.Modules.Users.Core.Entities;
using Roofiy.Shared.Abstractions.Kernel.ValueObjects;

namespace Roofiy.Modules.Users.Core.DAL.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.Email).IsRequired().HasMaxLength(100)
            .HasConversion(x => x.Value, x => new Email(x));
        builder.Property(x => x.Password).IsRequired().HasMaxLength(500);
    }
}