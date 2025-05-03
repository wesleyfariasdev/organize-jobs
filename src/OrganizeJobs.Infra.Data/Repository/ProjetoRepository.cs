using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

public class ProjetoRepository : IProjetoRepository
{
    private readonly OrganizeJobsContext _context;

    public ProjetoRepository(OrganizeJobsContext context)
    {
        _context = context;
    }

    public async Task<Projeto[]> ObterTodosProjetos()
    {
        return await _context.Projetos
            .Include(p => p.Empresa)
            .Include(p => p.Tarefas)
            .OrderByDescending(p => p.DataInicio)
            .ToArrayAsync();
    }

    public async Task<Projeto> ObterProjetoPorId(Guid id)
    {
        return await _context.Projetos
            .Include(p => p.Empresa)
            .Include(p => p.Tarefas)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Projeto> CriarProjeto(Projeto projeto)
    {
        await _context.Projetos.AddAsync(projeto);
        await _context.SaveChangesAsync();
        return projeto;
    }

    public async Task<Projeto> AtualizarProjeto(Projeto projeto)
    {
        _context.Projetos.Update(projeto);
        await _context.SaveChangesAsync();
        return projeto;
    }

    public async Task<bool> DeletarProjeto(Guid id)
    {
        var projetoExistente = await ObterProjetoPorId(id);
        if (projetoExistente == null) return false;

        await _context.SaveChangesAsync();
        return true;
    }
}
