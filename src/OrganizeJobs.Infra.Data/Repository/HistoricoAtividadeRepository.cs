using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

public class HistoricoAtividadeRepository : IHistoricoAtividadeRespository
{
    private readonly OrganizeJobsContext _context;

    public HistoricoAtividadeRepository(OrganizeJobsContext context)
    {
        _context = context;
    }

    public async Task<HistoricoAtividade[]> ObterTodosPorId(Guid taskId)
    {
        return await _context.HistoricoAtividades
            .Include(h => h.Tarefa)
            .OrderByDescending(h => h.InicioAtividade)
            .ToArrayAsync();
    }

    public async Task<HistoricoAtividade> ObterDetalheHistoricoAtividadePorId(Guid historicoAtividadeId)
    {
        return await _context.HistoricoAtividades
            .Include(h => h.Tarefa)
            .FirstOrDefaultAsync(h => h.Id == historicoAtividadeId);
    }

    public async Task<HistoricoAtividade> CriarHistorico(HistoricoAtividade historicoAtividade)
    {
        await _context.HistoricoAtividades.AddAsync(historicoAtividade);
        await _context.SaveChangesAsync();
        return historicoAtividade;
    }

    public async Task<HistoricoAtividade> AtualizarHistoricoAtividade(HistoricoAtividade historicoAtividade)
    {
        _context.HistoricoAtividades.Update(historicoAtividade);
        await _context.SaveChangesAsync();
        return historicoAtividade;
    }

    public async Task<bool> DeletarHistoricoAtividade(Guid id)
    {
        var historicoExistente = await ObterDetalheHistoricoAtividadePorId(id);
        if (historicoExistente == null) return false;

        await _context.SaveChangesAsync();
        return true;
    }
}
