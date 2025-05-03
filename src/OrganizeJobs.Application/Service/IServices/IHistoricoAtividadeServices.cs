using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;

namespace OrganizeJobs.Application.Service.IServices;

public interface IHistoricoAtividadeServices
{
    Task<HistoricoAtividadeResponseDto[]> ObterTodosPorId(Guid taskId);
    Task<HistoricoAtividadeResponseDto> ObterDetalheHistoricoAtividadePorId(Guid historicoAtividadeId);
    Task<HistoricoAtividadeResponseDto> CriarHistorico(HistoricoAtividadeResquestDto historicoAtividade);
    Task<HistoricoAtividadeResponseDto> AtualizarHistoricoAtividade(HistoricoAtividadeResquestDto historicoAtividade);
    Task<bool> DeletarHistoricoAtividade(Guid id);
}
