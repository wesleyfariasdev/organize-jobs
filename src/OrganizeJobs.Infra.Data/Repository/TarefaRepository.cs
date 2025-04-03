using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

internal class TarefaRepository : ITarefaRepository
{
    private readonly OrganizeJobsContext _context;

    public TarefaRepository(OrganizeJobsContext context)
    {
        _context = context;
    }

    public async Task<Tarefa[]> ObterTodasTarefas()
    {
        return await _context.Tarefas
            .Include(t => t.Projeto)
            .Include(t => t.HistoricoAtividade)
            .OrderByDescending(t => t.DataInicio)
            .ToArrayAsync();
    }

    public async Task<Tarefa> ObterTarefaPorId(Guid id)
    {
        return await _context.Tarefas
            .Include(t => t.Projeto)
            .Include(t => t.HistoricoAtividade)
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<Tarefa> CriarTarefa(Tarefa tarefa)
    {
        await _context.Tarefas.AddAsync(tarefa);
        await _context.SaveChangesAsync();
        return tarefa;
    }

    public async Task<Tarefa> AtualizarTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Update(tarefa);
        await _context.SaveChangesAsync();
        return tarefa;
    }

    public async Task<bool> DeletarPorId(Guid id)
    {
        var tarefa = await ObterTarefaPorId(id);
        if (tarefa == null) return false;

        await _context.SaveChangesAsync();
        return true;
    }
}
