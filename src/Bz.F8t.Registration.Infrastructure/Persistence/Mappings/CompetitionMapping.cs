﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Bz.F8t.Registration.Domain.CompetitionIntegration;

namespace Bz.F8t.Registration.Infrastructure.Persistence.Mappings;

internal class CompetitionMapping : IEntityTypeConfiguration<Competition>
{
    public void Configure(EntityTypeBuilder<Competition> builder)
    {
        builder.ToTable(name: "competitions");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
            .HasColumnName("id")
            .HasConversion(entityId => entityId.Value, dbId => new CompetitionId(dbId));;

        builder.Property(e => e.MaxCompetitors).HasColumnName("maxCompetitors");
        builder.Property(e => e.IsRegistrationOpen).HasColumnName("isRegistrationOpen");
    }
}
