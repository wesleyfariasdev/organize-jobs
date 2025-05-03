using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;

namespace OrganizeJobs.Application.Service.IServices;

public interface ITarefaServices
{

    Task<TarefaResponseDto[]> ObterTodasTarefas();
    Task<TarefaResponseDto> ObterTarefaPorId(Guid id);
    Task<TarefaResponseDto> CriarTarefa(TarefaRequestDto tarefa);
    Task<TarefaResponseDto> AtualizarTarefa(TarefaRequestDto tarefa);
    Task<bool> DeletarPorId(Guid id);
}
