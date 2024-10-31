using Microsoft.Extensions.Configuration;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPITeste.Dominio.Servicos
{
    [TestClass]
    public class AdministradorServiceTeste
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
        /// Testa o método AdicionarAdministrador, criando um Administrador para salvar no banco de dados.
        /// </summary>
        [TestMethod]
        public void TestandoSalvarAdministrador()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            AdministradorService service = new(context);

            Administrador administrador = new()
            {
                Email = "teste@teste.com",
                Senha = "Teste123",
                Perfil = "Admin"
            };

            // Act
            service.AdicionarAdministrador(administrador);

            // Assert
            Assert.AreEqual(1, service.RetornarTodos(1).Count);
            Assert.AreEqual("teste@teste.com", administrador.Email);
            Assert.AreEqual("Admin", administrador.Perfil);
        }

        /// <summary>
        /// Testa o método RetornarPorId, criando um Administrador para salvar no banco de dados e depois buscando pelo Id.
        /// </summary>
        [TestMethod]
        public void TestandoRetornarPorId()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            AdministradorService service = new(context); 
            
            Administrador administrador = new()
            {
                Email = "teste@teste.com",
                Senha = "Teste123",
                Perfil = "Admin"
            };

            // Act
            service.AdicionarAdministrador(administrador);
            Administrador? administradorDoBanco = service.RetornaPorId(administrador.Id);

            // Assert
            Assert.IsNotNull(administradorDoBanco);
            Assert.AreEqual(1, administradorDoBanco.Id);
        }

        /// <summary>
        /// Testa o método RetornarTodos. Verifica se esse método retorna um máximo de 10 Administradores por página.
        /// Para isso, são criados 15 Administradores no banco de dados.
        /// </summary>

        [TestMethod]
        public void TestandoRetornarDezAdministradoresPorPagina()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            AdministradorService service = new(context);

            // Act
            for (int i = 0; i < 15; i++)
            {
                Administrador administrador = new()
                {
                    Email = "teste@teste.com",
                    Senha = "Teste123",
                    Perfil = "Admin"
                };

                service.AdicionarAdministrador(administrador);
            }

            // Assert
            Assert.AreEqual(10, service.RetornarTodos(1).Count);
        }

        /// <summary>
        /// Testa o resultado de sucesso no método de Login.
        /// Para isso, é criado um administrador no banco de dados, e então o login é realizado com os dados desse administrador.
        /// </summary>
        [TestMethod]
        public void TestandoLoginComSucesso()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            AdministradorService service = new(context);

            Administrador administrador = new()
            {
                Email = "teste@teste.com",
                Senha = "Teste123",
                Perfil = "Admin"
            };
            service.AdicionarAdministrador(administrador);

            LoginDTO loginDTO = new()
            {
                Email = "teste@teste.com",
                Senha = "Teste123",
            };

            // Act
            Administrador? administradorLogado = service.Login(loginDTO);

            // Assert
            Assert.IsNotNull(administradorLogado);
        }

        /// <summary>
        /// Testa o resultado de falha no método de Login.
        /// Para isso, é criado um administrador no banco de dados, e então o login é realizado com dados diferentes dos desse administrador.
        /// </summary>

        [TestMethod]
        public void TestandoLoginSemSucesso()
        {
            // Arrange
            using MinimalsAPIContexto context = CriarContextoTeste();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            AdministradorService service = new(context);

            Administrador administrador = new()
            {
                Email = "teste@teste.com",
                Senha = "Teste123",
                Perfil = "Admin"
            };
            service.AdicionarAdministrador(administrador);

            LoginDTO loginDTO = new()
            {
                Email = "teste@teste.com",
                Senha = "SenhaErrada",
            };

            // Act
            Administrador? administradorLogado = service.Login(loginDTO);

            // Assert
            Assert.IsNull(administradorLogado);
        }
    }
}
