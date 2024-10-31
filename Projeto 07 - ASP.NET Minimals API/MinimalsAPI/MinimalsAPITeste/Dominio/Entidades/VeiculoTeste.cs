using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPITeste.Dominio.Entidades
{
    /// <summary>
    /// Classe para testes de unidade com a classe Veiculo.
    /// </summary>
    [TestClass]
    public class VeiculoTeste
    {
        /// <summary>
        /// Testa os métodos Get e Set das propriedades do Veiculo.
        /// </summary>
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            Veiculo veiculo = new();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "Carro";
            veiculo.Marca= "Marca de Carro";
            veiculo.Ano = 2010;

            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Carro", veiculo.Nome);
            Assert.AreEqual("Marca de Carro", veiculo.Marca);
            Assert.AreEqual(2010, veiculo.Ano);
        }
    }
}
