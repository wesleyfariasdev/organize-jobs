using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.ConfigEntity;

internal class EmpresaConfig : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NomeEmpresa).HasMaxLength(25)
                                            .IsRequired();
    }
}
