namespace OrganizeJobs.Domain.Models;

public class Perfil
{
    public Perfil(string nomeCompleto, string perfilUrlImage, decimal? salarioBruto, bool salarioSincronizado)
    {
        NomeCompleto = nomeCompleto;
        PerfilUrlImage = perfilUrlImage;
        SalarioBruto = salarioBruto;
        SalarioSincronizado = salarioSincronizado;
    }

    public Guid Id { get; private set; }
    public string NomeCompleto { get; private set; }
    public string PerfilUrlImage { get; private set; }
    public decimal? SalarioBruto { get; private set; }
    public bool SalarioSincronizado { get; private set; }

    public void SincronizarSalarioBruto(decimal[] salario)
    {
        if (!SalarioSincronizado)
        {
            SalarioBruto = 0;
            SalarioBruto += salario.Sum();
        }
    }

    public void AtualizarFotoPerfil(string novaUrl)
    {
        if (!string.IsNullOrWhiteSpace(novaUrl))
            PerfilUrlImage = novaUrl;
    }
}
