namespace OrganizeJobs.Application.Dto.Request;

public sealed record TarefaRequestDto(
    string NomeTarefa,
    string? DescricaoTarefa,
    DateTime DataInicio,
    DateTime? Prazo,
    bool Concluida,
    Guid ProjetoId
);
