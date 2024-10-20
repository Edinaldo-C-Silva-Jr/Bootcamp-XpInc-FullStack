using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using MinimalsAPI;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPITeste.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace MinimalsAPITeste.Helpers
{
    /// <summary>
    /// Classe usada para iniciar a aplicação para realizar os testes.
    /// </summary>
    public class Setup
    {
        public const string PORT = "5001";
        public static TestContext testContext = default!;
        public static WebApplicationFactory<StartUp> http = default!;
        public static HttpClient client = default!;

        /// <summary>
        /// Inicia o serviço da aplicação.
        /// </summary>
        /// <param name="contextTest">O contexto de teste para utilizar na aplicação.</param>
        public static void ClassInit(TestContext contextTest)
        {
            testContext = contextTest;
            http = new WebApplicationFactory<StartUp>();

            http = http.WithWebHostBuilder(builder =>
            {
                builder.UseSetting("https_port", PORT).UseEnvironment("Testing");
                builder.ConfigureServices(services =>
                {
                    services.AddScoped<IAdministradorService, AdministradorServicoMock>();
                });
            });

            client = http.CreateClient();
        }

        /// <summary>
        /// Libera os recursos utilizado na aplicação.
        /// </summary>
        public static void ClassCleanup()
        {
            http.Dispose();
        }
    }
}
