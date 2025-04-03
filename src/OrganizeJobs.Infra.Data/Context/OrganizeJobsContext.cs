using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.Context;

public class OrganizeJobsContext : DbContext
{
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Projeto> Projetos { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<HistoricoAtividade> HistoricoAtividades { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
