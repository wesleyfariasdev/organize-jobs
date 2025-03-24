namespace OrganizeJobs.Domain.Models;

public sealed class Tarefa
{
    public Tarefa(Guid id, string nomeTarefa, string? descricaoTarefa, DateTime dataInicio, DateTime? prazo, bool concluida, Guid projetoId)
    {
        Id = id;
        NomeTarefa = nomeTarefa;
        DescricaoTarefa = descricaoTarefa;
        DataInicio = dataInicio;
        Prazo = prazo;
        Concluida = concluida;
        ProjetoId = projetoId;
    }

    public Guid Id { get; set; }
    public string NomeTarefa { get; set; }
    public string? DescricaoTarefa { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? Prazo { get; set; }
    public bool Concluida { get; set; }

    public Guid ProjetoId { get; set; }
    public Projeto Projeto { get; set; }
}
