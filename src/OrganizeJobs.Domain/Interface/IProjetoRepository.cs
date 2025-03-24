using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Domain.Interface;

public interface IProjetoRepository
{
    Task<Projeto[]> ObterTodosProjetos();
    Task<Projeto> ObterProjetoPorId(Guid id);
    Task<Projeto> CriarProjeto(Projeto projeto);
    Task<Projeto> AtualizarProjeto(Projeto projeto);
    Task<bool> DeletarProjeto(Projeto projeto);
}
