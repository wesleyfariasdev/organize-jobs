namespace OrganizeJobs.Domain.Models;

public sealed class HistoricoAtividade
{
    public HistoricoAtividade(DateTime inicioAtividade, DateTime? fimAtividade, Guid tarefaId)
    {
        InicioAtividade = inicioAtividade;
        FimAtividade = fimAtividade;
        TarefaId = tarefaId;
    }

    public Guid Id { get; set; }
    public DateTime InicioAtividade { get; set; }
    public DateTime? FimAtividade { get; set; }

    public Guid TarefaId { get; set; }
    public Tarefa Tarefa { get; set; }
}