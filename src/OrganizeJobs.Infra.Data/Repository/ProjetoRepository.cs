using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.Data.Repository;

internal class ProjetoRepository(OrganizeJobsContext context) : IProjetoRepository
{
    public Task<Projeto> AtualizarProjeto(Projeto projeto)
    {
        throw new NotImplementedException();
    }

    public Task<Projeto> CriarProjeto(Projeto projeto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletarProjeto(Projeto projeto)
    {
        throw new NotImplementedException();
    }

    public Task<Projeto> ObterProjetoPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Projeto[]> ObterTodosProjetos()
    {
        throw new NotImplementedException();
    }
}
