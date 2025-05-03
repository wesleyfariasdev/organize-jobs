using AutoMapper;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.Service;

public class ProjetoServices(IProjetoRepository projetoRepository, IMapper mapper) : IProjetoServices
{
    public async Task<ProjetoResponseDto> AtualizarProjeto(ProjetoRequestDto projeto)
    {
        var projetoMapper = mapper.Map<Projeto>(projeto);
        var atualizarProjeto = await projetoRepository.AtualizarProjeto(projetoMapper);
        return mapper.Map<ProjetoResponseDto>(atualizarProjeto);
    }

    public async Task<ProjetoResponseDto> CriarProjeto(ProjetoRequestDto projeto)
    {
        var projetoMapper = mapper.Map<Projeto>(projeto);
        var novoProjeto = await projetoRepository.CriarProjeto(projetoMapper);
        return mapper.Map<ProjetoResponseDto>(novoProjeto);
    }

    public async Task<bool> DeletarProjeto(Guid id) =>
           await projetoRepository.DeletarProjeto(id);

    public async Task<ProjetoResponseDto> ObterProjetoPorId(Guid id)
    {
        var obterProjeto = await projetoRepository.ObterProjetoPorId(id);
        return mapper.Map<ProjetoResponseDto>(obterProjeto);
    }

    public async Task<ProjetoResponseDto[]> ObterTodosProjetos()
    {
        var obterProjeto = await projetoRepository.ObterTodosProjetos();
        return mapper.Map<ProjetoResponseDto[]>(obterProjeto);
    }
}
