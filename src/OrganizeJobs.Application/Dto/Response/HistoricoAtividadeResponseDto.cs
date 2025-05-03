namespace OrganizeJobs.Application.Dto.Response;

public class HistoricoAtividadeResponseDto
{
    public Guid Id { get; set; }
    public DateTime InicioAtividade { get; set; }
    public DateTime? FimAtividade { get; set; }
    public Guid TarefaId { get; set; }
}
