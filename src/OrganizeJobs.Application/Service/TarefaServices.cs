using AutoMapper;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.Service;

public class TarefaServices(ITarefaRepository tarefaRepository, IMapper mapper) : ITarefaServices
{
    public async Task<TarefaResponseDto> AtualizarTarefa(TarefaRequestDto tarefa)
    {
        var tarefaMap = mapper.Map<Tarefa>(tarefa);
        var novaTarefa = await tarefaRepository.AtualizarTarefa(tarefaMap);
        return mapper.Map<TarefaResponseDto>(novaTarefa);
    }

    public async Task<TarefaResponseDto> CriarTarefa(TarefaRequestDto tarefa)
    {
        var tarefaMap = mapper.Map<Tarefa>(tarefa);
        var novaTarefa = await tarefaRepository.CriarTarefa(tarefaMap);
        return mapper.Map<TarefaResponseDto>(novaTarefa);

    }

    public async Task<bool> DeletarPorId(Guid id) =>
           await tarefaRepository.DeletarPorId(id);

    public async Task<TarefaResponseDto> ObterTarefaPorId(Guid id)
    {
        var tarefa = await tarefaRepository.ObterTarefaPorId(id);
        return mapper.Map<TarefaResponseDto>(tarefa);
    }

    public async Task<TarefaResponseDto[]> ObterTodasTarefas()
    {
        var tarefas = await tarefaRepository.ObterTodasTarefas();
        return mapper.Map<TarefaResponseDto[]>(tarefas);
    }
}
