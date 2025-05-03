using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly OrganizeJobsContext _context;

    public EmpresaRepository(OrganizeJobsContext context)
    {
        _context = context;
    }

    public async Task<Empresa[]> ObterTodasEmpresas()
    {
        return await _context.Empresas
                             .ToArrayAsync();
    }

    public async Task<Empresa> ObterEmpresaPorId(Guid id)
    {
        return await _context.Empresas
                             .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<Empresa> CraiarEmpresa(Empresa empresa)
    {
        await _context.Empresas.AddAsync(empresa);
        await _context.SaveChangesAsync();
        return empresa;
    }

    public async Task<Empresa> AtualizarEmpresa(Guid id, Empresa empresa)
    {
        var empresaExist = await _context.Empresas.Where(x => x.Id == id)
                                                  .FirstOrDefaultAsync();

        if (empresaExist == null)
            throw new Exception();

        empresaExist.AtualizarNome(empresa.NomeEmpresa);
        _context.Empresas.Update(empresaExist);
        await _context.SaveChangesAsync();
        return empresaExist;
    }

    public async Task<bool> DeletarEmpresa(Guid id)
    {
        var empresa = await ObterEmpresaPorId(id);
        if (empresa == null) return false;

        await _context.SaveChangesAsync();
        return true;
    }
}
