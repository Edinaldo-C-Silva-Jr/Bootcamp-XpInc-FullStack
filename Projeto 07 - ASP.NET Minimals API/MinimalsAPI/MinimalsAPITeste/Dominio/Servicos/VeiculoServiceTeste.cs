using Microsoft.Extensions.Configuration;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPITeste.Dominio.Servicos
{
    /// <summary>
    /// Classe de teste para os métodos da classe VeiculoService.
    /// </summary>
    [TestClass]
    public class VeiculoServiceTeste
    {
        /// <summary>
        /// Cria o contexto de banco de dados para ser usado nos testes.
        /// </summary>
        /// <returns>Um contexto para ser usado em testes.</returns>
        private MinimalsAPIContexto CriarContextoTeste()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();

            return new MinimalsAPIContexto(configuration);
        }

        /// <summary>
        /// Testa o método AdicionarVeiculo, criando um Veiculo para salvar no banco de dados.
        /// </summary>
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

        /// <summary>
        /// Testa o método RetornarPorId, criando um Veiculo para salvar no banco de dados e depois buscando pelo Id.
        /// </summary>
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

        /// <summary>
        /// Testa o método RetornarTodos. Verifica se esse método retorna um máximo de 10 Veiculos por página.
        /// Para isso, são criados 15 Veiculos no banco de dados.
        /// </summary>
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

        /// <summary>
        /// Testa o método AtualizarVeiculo, verificando se a alteração é realizada.
        /// Para isso, primeiro é criado um Veiculo no banco de dados, depois ele é atualizado, e então é feita a busca por Id para verificar os dados..
        /// </summary>
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

        /// <summary>
        /// Testa o método DeletarVeiculo.
        /// Para isso, um Veiculo é criado no banco de dados, e depois deletado. Então é feita uma busca para verificar se ainda há registros no banco.
        /// </summary>
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
