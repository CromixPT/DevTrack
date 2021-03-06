using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DevTrack.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}