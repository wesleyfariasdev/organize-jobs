namespace OrganizeJobs.Application.Dto.Response;

public class PerfilResponseDto
{
    public Guid Id { get; set; }
    public string NomeCompleto { get; set; }
    public string PerfilUrlImage { get; set; }
    public decimal? SalarioBruto { get; set; }
    public bool SalarioSincronizado { get; set; }
}
