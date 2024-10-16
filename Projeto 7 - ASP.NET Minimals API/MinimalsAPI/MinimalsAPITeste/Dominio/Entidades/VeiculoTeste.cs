using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPITeste.Dominio.Entidades
{
    [TestClass]
    public class VeiculoTeste
    {
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
