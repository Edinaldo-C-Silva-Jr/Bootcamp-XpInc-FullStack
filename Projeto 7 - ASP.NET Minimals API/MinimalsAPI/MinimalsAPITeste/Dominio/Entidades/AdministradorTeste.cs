using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPITeste.Dominio.Entidades
{
    /// <summary>
    /// Classe para testes de unidade com a classe Administrador.
    /// </summary>
    [TestClass]
    public class AdministradorTeste
    {
        /// <summary>
        /// Testa os métodos Get e Set das propriedades do Administrador.
        /// </summary>
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            Administrador administrador = new();

            // Act
            administrador.Id = 1;
            administrador.Email = "admin@teste.com";
            administrador.Senha = "12345678";
            administrador.Perfil = "Admin";

            // Assert
            Assert.AreEqual(1, administrador.Id);
            Assert.AreEqual("admin@teste.com", administrador.Email);
            Assert.AreEqual("12345678", administrador.Senha);
            Assert.AreEqual("Admin", administrador.Perfil);
        }
    }
}
