namespace OrganizeJobs.Domain.Models;

public sealed class Empresa(string nomeEmpresa)
{
    public Guid Id { get; set; }
    public string NomeEmpresa { get; set; } = nomeEmpresa;

    public Projeto[]? Projeto { get; set; }
}
