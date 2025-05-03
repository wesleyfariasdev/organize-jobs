using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.ConfigEntity;

internal class PerfilConfig : IEntityTypeConfiguration<Perfil>
{
    public void Configure(EntityTypeBuilder<Perfil> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.NomeCompleto).HasMaxLength(40);
        builder.Property(x => x.PerfilUrlImage).HasMaxLength(255);
        builder.Property(x => x.SalarioBruto).HasDefaultValue(0);
        builder.Property(x => x.SalarioSincronizado).HasDefaultValue(false);
    }
}
