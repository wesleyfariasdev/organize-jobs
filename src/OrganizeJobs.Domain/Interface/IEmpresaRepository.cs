using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Domain.Interface;

public interface IEmpresaRepository
{
    Task<Empresa[]> ObterTodasEmpresas();
    Task<Empresa> ObterEmpresaPorId(Guid id);
    Task<Empresa> CraiarEmpresa(Empresa empresa);
    Task<Empresa> AtualizarEmpresa(Guid id, Empresa empresa);
    Task<bool> DeletarEmpresa(Guid id);
}
