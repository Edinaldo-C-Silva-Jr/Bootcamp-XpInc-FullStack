using MinimalsAPI.Dominio.DTOs;
using MinimalsAPITeste.Helpers;
using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Net;
using MinimalsAPI.Dominio.ModelViews;

namespace MinimalsAPITeste.Request
{
    [TestClass]
    public class AdministradorRequestTeste
    {
        [ClassInitialize]
        public static void ClassInit(TestContext contextTest)
        {
            Setup.ClassInit(contextTest);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Setup.ClassCleanup();
        }

        [TestMethod]
        public async Task TestarRotaDeLogin()
        {
            // Arrange
            LoginDTO loginDTO = new()
            {
                Email = "administrador@teste.com",
                Senha = "adm123456"
            };

            StringContent content = new(JsonSerializer.Serialize(loginDTO), Encoding.UTF8, "Application/json");

            // Act
            HttpResponseMessage response = await Setup.client.PostAsync("/login", content);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            string result = await response.Content.ReadAsStringAsync();
            AdministradorLogado administradorLogado = JsonSerializer.Deserialize<AdministradorLogado>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Assert.IsNotNull(administradorLogado);
            Assert.AreEqual("administrador@teste.com", administradorLogado.Email);
            Assert.IsNotNull("Admin", administradorLogado.Perfil);

            Console.WriteLine(administradorLogado.Token);
        }
    }
}
