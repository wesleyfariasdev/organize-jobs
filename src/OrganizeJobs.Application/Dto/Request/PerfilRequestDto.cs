namespace OrganizeJobs.Application.Dto.Request;

public sealed record PerfilRequestDto(
    string NomeCompleto,
    string PerfilUrlImage,
    decimal SalarioBruto,
    bool SalarioSincronizado
);
