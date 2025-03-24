using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

internal class EmpresaRepository(OrganizeJobsContext context) : IEmpresaRepository
{
    public Task<Empresa> AtualizarEmpresa(Empresa empresa)
    {
        throw new NotImplementedException();
    }

    public Task<Empresa> CraiarEmpresa(Empresa empresa)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletarEmpresa(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Empresa> ObterEmpresaPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Empresa[]> ObterTodasEmpresas()
    {
        throw new NotImplementedException();
    }
}
