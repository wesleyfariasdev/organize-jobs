namespace OrganizeJobs.Application.Dto.Request;

public sealed record HistoriaAtividadeResquestDto(
                        DateTime InicioAtividad,
                        DateTime? FimAtividade,
                        Guid TarefaId);
