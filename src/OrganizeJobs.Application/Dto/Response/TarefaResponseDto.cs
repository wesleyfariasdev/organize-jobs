namespace OrganizeJobs.Application.Dto.Response;

public class TarefaResponseDto
{
    public Guid Id { get; set; }
    public string NomeTarefa { get; set; }
    public string? DescricaoTarefa { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? Prazo { get; set; }
    public bool Concluida { get; set; }

    public Guid ProjetoId { get; set; }
}
