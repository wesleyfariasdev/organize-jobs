using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;

namespace OrganizeJobs.Application.Service.IServices;

public interface IProjetoServices
{
    Task<ProjetoResponseDto[]> ObterTodosProjetos();
    Task<ProjetoResponseDto> ObterProjetoPorId(Guid id);
    Task<ProjetoResponseDto> CriarProjeto(ProjetoRequestDto projeto);
    Task<ProjetoResponseDto> AtualizarProjeto(ProjetoRequestDto projeto);
    Task<bool> DeletarProjeto(Guid id);
}
