namespace OrganizeJobs.Domain.Models;

public sealed class Tarefa(Guid id, string nomeTarefa, string? descricaoTarefa, DateTime dataInicio, DateTime? prazo, bool concluida, Guid projetoId)
{
    public Guid Id { get; set; } = id;
    public string NomeTarefa { get; set; } = nomeTarefa;
    public string? DescricaoTarefa { get; set; } = descricaoTarefa;
    public DateTime DataInicio { get; set; } = dataInicio;
    public DateTime? Prazo { get; set; } = prazo;
    public bool Concluida { get; set; } = concluida;

    public Guid ProjetoId { get; set; } = projetoId;
    public Projeto? Projeto { get; set; }

    public HistoricoAtividade[]? HistoricoAtividade { get; set; }
}
