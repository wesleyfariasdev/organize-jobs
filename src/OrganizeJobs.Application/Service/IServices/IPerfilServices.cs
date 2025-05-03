using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;

namespace OrganizeJobs.Application.Service.IServices;

public interface IPerfilServices
{
    Task<PerfilResponseDto[]> ObterTodosPerfil();
    Task<PerfilResponseDto> ObterPerfilPorId(Guid id);
    Task<PerfilResponseDto> CriarPerfil(PerfilRequestDto perfil);
    Task<PerfilResponseDto> AtualizarPerfil(Guid id, PerfilRequestDto perfil);
    Task<bool> DeletarPerfil(Guid id);
}
