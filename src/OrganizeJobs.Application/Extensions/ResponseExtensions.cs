using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.Extensions;

public static class ResponseExtensions
{
    public static EmpresaResponseDto ToEmpresaReponseDto(this Empresa empresa)
    {
        return new EmpresaResponseDto
        {
            Id = empresa.Id,
            NomeEmpresa = empresa.NomeEmpresa
        };
    }

    public static EmpresaResponseDto[] ToEmpresaListResponseDto(this Empresa[] empresa)
    {
        return empresa.Select(dto => new EmpresaResponseDto()
        {
            Id = dto.Id,
            NomeEmpresa = dto.NomeEmpresa
        }).ToArray();
    }
}
