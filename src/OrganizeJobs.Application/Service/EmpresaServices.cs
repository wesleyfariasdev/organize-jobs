using AutoMapper;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.Service;

public class EmpresaServices(IEmpresaRepository empresaRepository, IMapper mapper) : IEmpresaServices
{
    public async Task<EmpresaResponseDto> AtualizarEmpresa(Guid id, EmpresaRequestDto empresa)
    {
        var empresaMapper = mapper.Map<Empresa>(empresa);
        var obterEmpresa = await empresaRepository.AtualizarEmpresa(id, empresaMapper);
        return mapper.Map<EmpresaResponseDto>(obterEmpresa);
    }

    public async Task<EmpresaResponseDto> CriarEmpresa(EmpresaRequestDto empresa)
    {
        var empresaMapper = mapper.Map<Empresa>(empresa);
        var obterEmpresa = await empresaRepository.CraiarEmpresa(empresaMapper);
        return mapper.Map<EmpresaResponseDto>(obterEmpresa);
    }

    public async Task<bool> DeletarEmpresa(Guid id) =>
           await empresaRepository.DeletarEmpresa(id);

    public async Task<EmpresaResponseDto> ObterEmpresaPorId(Guid id)
    {
        var obterEmpresa = await empresaRepository.ObterEmpresaPorId(id);
        return mapper.Map<EmpresaResponseDto>(obterEmpresa);
    }

    public async Task<EmpresaResponseDto[]> ObterTodasEmpresas()
    {
        var obterEmpresa = await empresaRepository.ObterTodasEmpresas();
        return mapper.Map<EmpresaResponseDto[]>(obterEmpresa);
    }
}
