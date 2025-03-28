using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.ConfigEntity;

internal class ProjetoConfig : IEntityTypeConfiguration<Projeto>
{
    public void Configure(EntityTypeBuilder<Projeto> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NomeProjeto).HasMaxLength(40)
                                            .IsRequired();
        builder.Property(x => x.Descricao).HasMaxLength(150);
        builder.Property(x => x.ProjetoLink).HasMaxLength(255);
        builder.Property(x => x.StatusProjeto).HasDefaultValue(true);
        builder.Property(x => x.Remuneracao).HasPrecision(18, 2);
        builder.Property(x => x.DataInicio).IsRequired(false);
        builder.Property(x => x.DataFim).IsRequired(false);

        builder.HasOne(x => x.Empresa)
               .WithMany(x => x.Projeto)
               .HasForeignKey(x => x.EmpresaId);
    }
}
