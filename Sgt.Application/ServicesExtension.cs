using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Sgt.Application.Repository;

using System.Reflection;

namespace Sgt.Application;

public static class ServicesExtension
{
    public static void ConfigureApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
     
    }
}
