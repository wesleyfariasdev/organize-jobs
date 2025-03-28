namespace OrganizeJobs.Domain.Models;

public sealed class Projeto(string nomeProjeto, string? descricao, string? projetoLink, bool statusProjeto, decimal remuneracao, DateTime dataInicio, DateTime? dataFim, Guid empresaId)
{
    public Guid Id { get; set; }
    public string NomeProjeto { get; set; } = nomeProjeto;
    public string? Descricao { get; set; } = descricao;
    public string? ProjetoLink { get; set; } = projetoLink;
    public bool StatusProjeto { get; set; } = statusProjeto;
    public decimal Remuneracao { get; set; } = remuneracao;

    public DateTime DataInicio { get; set; } = dataInicio;
    public DateTime? DataFim { get; set; } = dataFim;

    public Guid EmpresaId { get; set; } = empresaId;
    public Empresa? Empresa { get; set; }

    public Tarefa[]? Tarefas { get; set; }
}
