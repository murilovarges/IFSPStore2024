using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Bson;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Grupo> Grupos { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Venda> Vendas { get; set; }
            public DbSet<VendaItem> VendaItens { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "ifsp2024";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]

        public void TestInsertCidades()
        {
            using (var context = new MyDbContext())
            {

                var cidade = new Cidade
                {
                    Nome = "Birigui",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                cidade = new Cidade
                {
                    Nome = "Araçatuba",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCidades()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cidade in context.Cidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }

        [TestMethod]
        public void TestInsertClientes()
        {
            using (var context = new MyDbContext())
            {

                var cidade = context.Cidades.FirstOrDefault(c => c.Id == 1);
                var cliente = new Cliente
                {
                    Nome = "Murilo Varges",
                    Cidade = cidade,
                    Documento = "123.123.123-87",
                    Endereco = "Rua Cussy de Almeida, 158",
                    Bairro = "Centro"
                };
                context.Clientes.Add(cliente);

                cidade = context.Cidades.FirstOrDefault(c => c.Id == 2);
                cliente = new Cliente
                {
                    Nome = "João Dias",
                    Cidade = cidade,
                    Documento = "123.123.123-87",
                    Endereco = "Rua Saudaes, 154448",
                    Bairro = "Centro"
                };
                context.Clientes.Add(cliente);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListClientes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Clientes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestInsertGrupos()
        {
            using (var context = new MyDbContext())
            {
                var grupo = new Grupo
                {
                    Nome = "Carnes"
                };
                context.Grupos.Add(grupo);

                grupo = new Grupo
                {
                    Nome = "Bebidas"
                };
                context.Grupos.Add(grupo);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListGrupos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var grupo in context.Grupos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(grupo));
                }
            }
        }

        [TestMethod]
        public void TestInsertProdutos()
        {
            using (var context = new MyDbContext())
            {

                var grupo = context.Grupos.FirstOrDefault(c => c.Id == 1);
                var produto = new Produto
                {
                    Nome = "Carne moida",
                    Grupo = grupo,
                    DataCompra = new DateTime(2024, 10, 01),
                    Preco = 10.50f,
                    Quantidade = 50,
                    UnidadeVenda = "Kg"
                };
                context.Produtos.Add(produto);

                grupo = context.Grupos.FirstOrDefault(c => c.Id == 2);
                produto = new Produto
                {
                    Nome = "Coca cola",
                    Grupo = grupo,
                    DataCompra = new DateTime(2024, 10, 01),
                    Preco = 8.33f,
                    Quantidade = 155,
                    UnidadeVenda = "UN"
                };
                context.Produtos.Add(produto);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProdutos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var produto in context.Produtos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }


    }
}
