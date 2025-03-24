namespace OrganizeJobs.Application.Dto.Request;

internal record ProjetoRequestDto(
    string NomeProjeto,
    string? Descricao,
    string? ProjetoLink,
    bool StatusProjeto,
    decimal Remuneracao,
    DateTime DataInicio,
    DateTime? DataFim,
    Guid EmpresaId
);
