using System;
using Api.Domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace CrossCutting
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}
