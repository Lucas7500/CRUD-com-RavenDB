using ControleAlunos.Infraestrutura.Interfaces;
using ControleAlunos.Infraestrutura.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ControleAlunos.InteracaoUsuarioForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var builder = CriaHostBuilder();
            using var build = builder.Build();
            var servicesProvider = build.Services;
            var form = servicesProvider.GetRequiredService<ListagemAlunos>();

            Application.Run(form);
        }

        private static IHostBuilder CriaHostBuilder()
        {
            return Host
                .CreateDefaultBuilder()
                .ConfigureContainer<IServiceCollection>((context, services) =>
                {
                    services.AddScoped<ListagemAlunos>();
                    services.AddScoped<IRepositorio, RepositorioRavenDB>();
                });
        }
    }
}