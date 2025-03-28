using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Domain.Interface;

public interface IHistoricoAtividadeRespository
{
    Task<HistoricoAtividade[]> ObterTodosPorId(Guid taskId);
    Task<HistoricoAtividade> ObterDetalheHistoricoAtividadePorId(Guid historicoAtividadeId);
    Task<HistoricoAtividade> CriarHistorico(HistoricoAtividade historicoAtividade);
    Task<HistoricoAtividade> AtualizarHistoricoAtividade(HistoricoAtividade historicoAtividade);
    Task<bool> DeletarHistoricoAtividade(HistoricoAtividade historicoAtividadeId);
}
