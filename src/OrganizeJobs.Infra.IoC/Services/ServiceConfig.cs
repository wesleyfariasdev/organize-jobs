using Microsoft.Extensions.DependencyInjection;

namespace OrganizeJobs.Infra.IoC.Services;

internal static class ServiceConfig
{
    public static IServiceCollection AddService(this IServiceCollection service)
    {
        return service;
    }
}
