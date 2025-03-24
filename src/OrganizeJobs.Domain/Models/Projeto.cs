namespace OrganizeJobs.Domain.Models;

public sealed class Projeto
{
    public Projeto(string nomeProjeto, string? descricao, string? projetoLink, bool statusProjeto, decimal remuneracao, DateTime dataInicio, DateTime? dataFim, Guid empresaId)
    {
        NomeProjeto = nomeProjeto;
        Descricao = descricao;
        ProjetoLink = projetoLink;
        StatusProjeto = statusProjeto;
        Remuneracao = remuneracao;
        DataInicio = dataInicio;
        DataFim = dataFim;
        EmpresaId = empresaId;
    }

    public Guid Id { get; set; }
    public string NomeProjeto { get; set; }
    public string? Descricao { get; set; }
    public string? ProjetoLink { get; set; }
    public bool StatusProjeto { get; set; }
    public decimal Remuneracao { get; set; }

    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }

    public Guid EmpresaId { get; set; }
    public Empresa Empresa { get; set; }

    public Tarefa[] Tarefas { get; set; }
}
