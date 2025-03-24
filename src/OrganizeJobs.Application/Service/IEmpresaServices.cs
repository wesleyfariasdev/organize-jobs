using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;

namespace OrganizeJobs.Application.Service;

public interface IEmpresaServices
{
    Task<EmpresaResponseDto[]> ObterTodasEmpresas();
    Task<EmpresaResponseDto> ObterEmpresaPorId(Guid id);
    Task<EmpresaResponseDto> CraiarEmpresa(EmpresaRequestDto empresa);
    Task<EmpresaResponseDto> AtualizarEmpresa(EmpresaRequestDto empresa);
    Task<bool> DeletarEmpresa(Guid id);
}