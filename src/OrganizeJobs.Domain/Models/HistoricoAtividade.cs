namespace OrganizeJobs.Domain.Models;

public sealed class HistoricoAtividade(DateTime inicioAtividade, DateTime? fimAtividade, Guid tarefaId)
{
    public Guid Id { get; private set; }
    public DateTime InicioAtividade { get; private set; } = inicioAtividade;
    public DateTime? FimAtividade { get; private set; } = fimAtividade;

    public Guid TarefaId { get; private set; } = tarefaId;
    public Tarefa? Tarefa { get; private set; }
}