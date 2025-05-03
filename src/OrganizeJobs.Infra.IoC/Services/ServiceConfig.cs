using Microsoft.Extensions.DependencyInjection;
using OrganizeJobs.Application.ProfileMapping;
using OrganizeJobs.Application.Service;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Infra.Data.Repository;

namespace OrganizeJobs.Infra.IoC.Services;

public static class ServiceConfig
{
    public static IServiceCollection AddService(this IServiceCollection service)
    {
        service.AddScoped<IEmpresaRepository, EmpresaRepository>();
        service.AddScoped<IHistoricoAtividadeRespository, HistoricoAtividadeRepository>();
        service.AddScoped<IProjetoRepository, ProjetoRepository>();
        service.AddScoped<ITarefaRepository, TarefaRepository>();

        service.AddScoped<IEmpresaServices, EmpresaServices>();
        service.AddScoped<IHistoricoAtividadeServices, HistoricoAtividadeService>();
        service.AddScoped<IPerfilServices, PerfilServices>();
        service.AddScoped<IProjetoServices, ProjetoServices>();
        service.AddScoped<ITarefaServices, TarefaServices>();

        service.AddAutoMapper(typeof(ProfileMap));

        return service;
    }
}
