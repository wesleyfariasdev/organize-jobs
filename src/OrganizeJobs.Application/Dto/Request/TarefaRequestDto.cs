namespace OrganizeJobs.Application.Dto.Request;

internal record TarefaRequestDto(
    string NomeTarefa,
    string? DescricaoTarefa,
    DateTime DataInicio,
    DateTime? Prazo,
    bool Concluida,
    Guid ProjetoId
);
