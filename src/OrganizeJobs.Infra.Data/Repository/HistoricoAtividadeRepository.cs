using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Infra.Data.Repository;

internal class HistoricoAtividadeRepository : IHistoricoAtividadeRespository
{
    public Task<HistoricoAtividade> AtualizarHistoricoAtividade(HistoricoAtividade historicoAtividade)
    {
        throw new NotImplementedException();
    }

    public Task<HistoricoAtividade> CriarHistorico(HistoricoAtividade historicoAtividade)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletarHistoricoAtividade(HistoricoAtividade historicoAtividadeId)
    {
        throw new NotImplementedException();
    }

    public Task<HistoricoAtividade> ObterDetalheHistoricoAtividadePorId(Guid historicoAtividadeId)
    {
        throw new NotImplementedException();
    }

    public Task<HistoricoAtividade[]> ObterTodosPorId(Guid taskId)
    {
        throw new NotImplementedException();
    }
}
