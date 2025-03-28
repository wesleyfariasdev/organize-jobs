namespace OrganizeJobs.Domain.Models;

public sealed class HistoricoAtividade(DateTime inicioAtividade, DateTime? fimAtividade, Guid tarefaId)
{
    public Guid Id { get; set; }
    public DateTime InicioAtividade { get; set; } = inicioAtividade;
    public DateTime? FimAtividade { get; set; } = fimAtividade;

    public Guid TarefaId { get; set; } = tarefaId;
    public Tarefa? Tarefa { get; set; }
}