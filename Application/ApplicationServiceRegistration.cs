using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace $safeprojectname$;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationSerivices(this IServiceCollection services)
    {
        var mapsterConfig = TypeAdapterConfig.GlobalSettings;

        services.AddSingleton(mapsterConfig);
        services.AddScoped<IMapper, ServiceMapper>();
        services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
