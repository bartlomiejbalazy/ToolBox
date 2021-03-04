using Microsoft.Extensions.DependencyInjection;
using ToolBox.Application.Models;
using ToolBox.Application.Services;

namespace ToolBox.Application
{
    public static class ApplicationsInstaller
    {
        public static void InstallApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IToolService, ToolService>();
        }
    }
}