namespace OrganizeJobs.Application.Dto.Request;

public sealed record ProjetoRequestDto(
    string NomeProjeto,
    string? Descricao,
    string? ProjetoLink,
    bool StatusProjeto,
    decimal Remuneracao,
    DateTime DataInicio,
    DateTime? DataFim,
    Guid EmpresaId
);
