using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Infra.IoC.DataBase;

public static class SQLServerConfig
{
    public static IServiceCollection AddDbConfig(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config["ConnectionStrings:DefaultConnection"];

        if (string.IsNullOrEmpty(connectionString))
            connectionString = config.GetConnectionString("DEV");

        services.AddDbContext<OrganizeJobsContext>(q => q.UseSqlServer(connectionString,
                                                   q => q.MigrationsAssembly(typeof(OrganizeJobsContext)
                                                         .Assembly.FullName)));

        return services;
    }
}
