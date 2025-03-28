using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.ConfigEntity;

internal class TarefaConfig : IEntityTypeConfiguration<Tarefa>
{
    public void Configure(EntityTypeBuilder<Tarefa> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NomeTarefa).HasMaxLength(50)
                                           .IsRequired();

        builder.Property(x => x.DescricaoTarefa).HasMaxLength(150)
                                                .IsRequired(false);
        builder.Property(x => x.DataInicio).IsRequired();
        builder.Property(x => x.Prazo).IsRequired(false);
        builder.Property(x => x.Concluida).HasDefaultValue(false);

        builder.HasOne(x => x.Projeto)
               .WithMany(x => x.Tarefas)
               .HasForeignKey(x => x.ProjetoId);
    }
}
