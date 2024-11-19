using IFSPStore.App.Cadastros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de dados
            // Configura Banco na Injeção de dependencia
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>,BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            #endregion

            #region Formulários
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            #endregion
            
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
