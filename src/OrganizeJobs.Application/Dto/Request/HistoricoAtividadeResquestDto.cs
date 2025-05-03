namespace OrganizeJobs.Application.Dto.Request;

public sealed record HistoricoAtividadeResquestDto(
                        DateTime InicioAtividad,
                        DateTime? FimAtividade,
                        Guid TarefaId);
