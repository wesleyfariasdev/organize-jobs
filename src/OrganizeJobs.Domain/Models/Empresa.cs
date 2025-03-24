namespace OrganizeJobs.Domain.Models;

public sealed class Empresa
{
    public Empresa(string nomeEmpresa)
    {
        NomeEmpresa = nomeEmpresa;
    }

    public Guid Id { get; set; }
    public string NomeEmpresa { get; set; }


}
