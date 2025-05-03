namespace OrganizeJobs.Application.Dto.Response;

public class ProjetoResponseDto
{
    public Guid Id { get; set; }
    public string NomeProjeto { get; set; } = default!;
    public string? Descricao { get; set; }
    public string? ProjetoLink { get; set; }
    public bool StatusProjeto { get; set; }
    public decimal Remuneracao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public Guid EmpresaId { get; set; }
}
