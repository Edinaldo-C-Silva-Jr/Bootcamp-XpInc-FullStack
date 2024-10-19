using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using MinimalsAPI;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPITeste.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace MinimalsAPITeste.Helpers
{
    public class Setup
    {
        public const string PORT = "5001";
        public static TestContext testContext = default!;
        public static WebApplicationFactory<StartUp> http = default!;
        public static HttpClient client = default!;

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

        public static void ClassCleanup()
        {
            http.Dispose();
        }
    }
}
