using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

internal class TarefaRepository(OrganizeJobsContext context) : ITarefaRepository
{
    public Task<Tarefa> AtualizarTarefa(Tarefa tarefa)
    {
        throw new NotImplementedException();
    }

    public Task<Tarefa> CriarTarefa(Tarefa tarefa)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Tarefa> ObterTarefaPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Tarefa[]> ObterTodasTarefas()
    {
        throw new NotImplementedException();
    }
}
