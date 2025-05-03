namespace OrganizeJobs.Domain.Models;

public sealed class Projeto(string nomeProjeto, string? descricao, string? projetoLink, bool statusProjeto, decimal remuneracao, DateTime dataInicio, DateTime? dataFim, Guid empresaId)
{
    public Guid Id { get; private set; }
    public string NomeProjeto { get; private set; } = nomeProjeto;
    public string? Descricao { get; private set; } = descricao;
    public string? ProjetoLink { get; private set; } = projetoLink;
    public bool StatusProjeto { get; private set; } = statusProjeto;
    public decimal Remuneracao { get; private set; } = remuneracao;

    public DateTime DataInicio { get; private set; } = dataInicio;
    public DateTime? DataFim { get; private set; } = dataFim;

    public Guid EmpresaId { get; private set; } = empresaId;
    public Empresa? Empresa { get; private set; }

    public Tarefa[]? Tarefas { get; private set; }
}
