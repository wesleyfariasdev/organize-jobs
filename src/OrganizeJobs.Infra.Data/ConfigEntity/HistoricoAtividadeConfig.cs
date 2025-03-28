using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.ConfigEntity;

internal class HistoricoAtividadeConfig : IEntityTypeConfiguration<HistoricoAtividade>
{
    public void Configure(EntityTypeBuilder<HistoricoAtividade> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.InicioAtividade).IsRequired(true);
        builder.Property(x => x.InicioAtividade).IsRequired(false);

        builder.HasOne(x => x.Tarefa)
               .WithMany(x => x.HistoricoAtividade)
               .HasForeignKey(x => x.TarefaId);
    }
}
