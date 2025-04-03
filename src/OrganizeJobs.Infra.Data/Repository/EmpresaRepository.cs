using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

internal class EmpresaRepository : IEmpresaRepository
{
    private readonly OrganizeJobsContext _context;

    public EmpresaRepository(OrganizeJobsContext context)
    {
        _context = context;
    }

    public async Task<Empresa[]> ObterTodasEmpresas()
    {
        return await _context.Empresas
            .Include(e => e.Projeto)
            .OrderBy(e => e.NomeEmpresa)
            .ToArrayAsync();
    }

    public async Task<Empresa> ObterEmpresaPorId(Guid id)
    {
        return await _context.Empresas
            .Include(e => e.Projeto)
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<Empresa> CraiarEmpresa(Empresa empresa)
    {
        await _context.Empresas.AddAsync(empresa);
        await _context.SaveChangesAsync();
        return empresa;
    }

    public async Task<Empresa> AtualizarEmpresa(Empresa empresa)
    {
        _context.Empresas.Update(empresa);
        await _context.SaveChangesAsync();
        return empresa;
    }

    public async Task<bool> DeletarEmpresa(Guid id)
    {
        var empresa = await ObterEmpresaPorId(id);
        if (empresa == null) return false;

        await _context.SaveChangesAsync();
        return true;
    }
}
