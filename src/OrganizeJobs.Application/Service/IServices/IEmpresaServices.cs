using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;

namespace OrganizeJobs.Application.Service.IServices;

public interface IEmpresaServices
{
    Task<EmpresaResponseDto[]> ObterTodasEmpresas();
    Task<EmpresaResponseDto> ObterEmpresaPorId(Guid id);
    Task<EmpresaResponseDto> CriarEmpresa(EmpresaRequestDto empresa);
    Task<EmpresaResponseDto> AtualizarEmpresa(Guid id, EmpresaRequestDto empresa);
    Task<bool> DeletarEmpresa(Guid id);
}