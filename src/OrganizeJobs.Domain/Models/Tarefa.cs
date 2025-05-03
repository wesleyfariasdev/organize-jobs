namespace OrganizeJobs.Domain.Models;

public sealed class Tarefa(string nomeTarefa, string? descricaoTarefa, DateTime dataInicio, DateTime? prazo, bool concluida, Guid projetoId)
{
    public Guid Id { get; private set; }
    public string NomeTarefa { get; private set; } = nomeTarefa;
    public string? DescricaoTarefa { get; private set; } = descricaoTarefa;
    public DateTime DataInicio { get; private set; } = dataInicio;
    public DateTime? Prazo { get; private set; } = prazo;
    public bool Concluida { get; private set; } = concluida;

    public Guid ProjetoId { get; private set; } = projetoId;
    public Projeto? Projeto { get; private set; }

    public HistoricoAtividade[]? HistoricoAtividade { get; private set; }

    public void AtualizarNomeTarefa(string nomeTarefa) => NomeTarefa = nomeTarefa;
}
