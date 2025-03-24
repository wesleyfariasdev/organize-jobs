using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Domain.Interface;

public interface ITarefaRepository
{
    Task<Tarefa[]> ObterTodasTarefas();
    Task<Tarefa> ObterTarefaPorId(Guid id);
    Task<Tarefa> CriarTarefa(Tarefa tarefa);
    Task<Tarefa> AtualizarTarefa(Tarefa tarefa);
    Task<bool> DeletarPorId(Guid id);
}
