using AutoMapper;
using IFSPStore.App.Cadastros;
using IFSPStore.App.Models;
using IFSPStore.App.Outros;
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
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            Services.AddScoped<IBaseRepository<VendaItem>, BaseRepository<VendaItem>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();
            Services.AddScoped<IBaseService<VendaItem>, BaseService<VendaItem>>();
            #endregion

            #region Formulários
            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroGrupo, CadastroGrupo>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroVenda, CadastroVenda>();
            #endregion


            #region Mappings
            // Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Grupo, Grupo>();
                config.CreateMap<Produto, ProdutoModel>()
                    .ForMember(d => d.Grupo, d => d.MapFrom(x => x.Grupo!.Nome))
                    .ForMember(d => d.IdGrupo, d => d.MapFrom(x => x.Grupo!.Id));
                config.CreateMap<Venda, VendaModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                config.CreateMap<VendaItem, VendaItemModel>()
                    .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));

            }).CreateMapper());

            #endregion
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
