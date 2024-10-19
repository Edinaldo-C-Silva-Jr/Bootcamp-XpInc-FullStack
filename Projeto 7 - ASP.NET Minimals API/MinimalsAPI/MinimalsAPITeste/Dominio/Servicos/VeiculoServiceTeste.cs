using Microsoft.Extensions.Configuration;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPITeste.Dominio.Servicos
{
    [TestClass]
    public class VeiculoServiceTeste
    {
        private MinimalsAPIContexto CriarContextoTeste()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();

            return new MinimalsAPIContexto(configuration);
        }

        [TestMethod]
        public void TestandoSalvarVeiculo()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            VeiculoService service = new(context);

            Veiculo veiculo = new()
            {
                Nome = "Carro",
                Marca = "Marca de Carro",
                Ano = 1980
            };

            // Act
            service.AdicionarVeiculo(veiculo);

            // Assert
            Assert.AreEqual(1, service.RetornarTodos(1).Count);
            Assert.AreEqual("Carro", veiculo.Nome);
            Assert.AreEqual("Marca de Carro", veiculo.Marca);
        }

        [TestMethod]
        public void TestandoRetornarPorId()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            VeiculoService service = new(context);

            Veiculo veiculo = new()
            {
                Nome = "Carro",
                Marca = "Marca de Carro",
                Ano = 1980
            };

            // Act
            service.AdicionarVeiculo(veiculo);
            Veiculo? veiculoDoBanco= service.RetornaPorId(veiculo.Id);

            // Assert
            Assert.IsNotNull(veiculoDoBanco);
            Assert.AreEqual(1, veiculoDoBanco.Id);
        }

        [TestMethod]
        public void TestandoRetornarDezVeiculosPorPagina()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            VeiculoService service = new(context);

            // Act
            for (int i = 0; i < 15; i++)
            {
                Veiculo veiculo = new()
                {
                    Nome = "Carro",
                    Marca = "Marca de Carro",
                    Ano = 1980
                };

                service.AdicionarVeiculo(veiculo);
            }

            // Assert
            Assert.AreEqual(10, service.RetornarTodos(1).Count);
        }

        [TestMethod]
        public void TestandoAtualizarVeiculo()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            VeiculoService service = new(context);

            Veiculo veiculo = new()
            {
                Nome = "Carro",
                Marca = "Marca de Carro",
                Ano = 1980
            };
            service.AdicionarVeiculo(veiculo);

            VeiculoDTO veiculoDTO = new()
            {
                Nome = "Moto",
                Marca = "Marca de Moto",
                Ano = 2010
            };

            // Act
            Veiculo? veiculoDoBanco = service.RetornaPorId(1);
            if (veiculoDoBanco is not null)
            {
                veiculoDoBanco.Nome = veiculoDTO.Nome;
                veiculoDoBanco.Marca= veiculoDTO.Marca;
                veiculoDoBanco.Ano = veiculoDTO.Ano;

                service.AtualizarVeiculo(veiculoDoBanco);
            }

            Veiculo? veiculoAtualizado = service.RetornaPorId(1);

            // Assert
            Assert.IsNotNull(veiculoAtualizado);
            Assert.AreEqual(1, veiculoAtualizado.Id);
            Assert.AreEqual("Moto", veiculoAtualizado.Nome);
            Assert.AreEqual("Marca de Moto", veiculoAtualizado.Marca);
            Assert.AreEqual(2010, veiculoAtualizado.Ano);
        }

        [TestMethod]
        public void TestandoDeletar()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            VeiculoService service = new(context);

            Veiculo veiculo = new()
            {
                Nome = "Carro",
                Marca = "Marca de Carro",
                Ano = 1980
            };
            service.AdicionarVeiculo(veiculo);

            // Act
            Veiculo? veiculoDoBanco = service.RetornaPorId(1);
            if (veiculoDoBanco is not null)
            {
                service.DeletarVeiculo(veiculoDoBanco);
            }

            // Assert
            Assert.AreEqual(0, service.RetornarTodos().Count);
        }
    }
}
