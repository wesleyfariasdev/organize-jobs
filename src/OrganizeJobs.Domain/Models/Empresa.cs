namespace OrganizeJobs.Domain.Models;

public sealed class Empresa(string nomeEmpresa)
{
    public Guid Id { get; private set; }
    public string NomeEmpresa { get; private set; } = nomeEmpresa;

    public Projeto[]? Projeto { get; private set; }

    public void AtualizarNome(string nomeEmpresa) => NomeEmpresa = nomeEmpresa;
}
