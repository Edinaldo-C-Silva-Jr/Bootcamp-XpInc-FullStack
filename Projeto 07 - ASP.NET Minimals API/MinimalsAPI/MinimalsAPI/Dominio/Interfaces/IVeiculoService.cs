using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Dominio.Interfaces
{
    /// <summary>
    /// Interface que define os métodos para a classe Service dos veículos.
    /// </summary>
    public interface IVeiculoService
    {
        /// <summary>
        /// Recebe uma instância de veículo e insere no banco de dados.
        /// </summary>
        /// <param name="veiculo">O veículo a ser inserido no banco.</param>
        public void AdicionarVeiculo(Veiculo veiculo);

        /// <summary>
        /// Retorna um veículo pelo Id, se existir.
        /// </summary>
        /// <param name="id">O Id od veículo para retornar.</param>
        /// <returns>O veículo solicitado, que pode ser nulo.</returns>
        public Veiculo? RetornaPorId(int id);

        /// <summary>
        /// Retorna todos os veículos cadastrados, com base no valor da página.
        /// Opcionalmente, filtra os registros pelo nome e marca dos veículos.
        /// </summary>
        /// <param name="pagina">O número da página a ser retornado.</param>
        /// <param name="nome">O nome do veículo para filtrar os resultados.</param>
        /// <param name="marca">A marca do veículo para filtrar os resultados.</param>
        /// <returns>Uma lista com todos os veículos na página solicitada.</returns>
        public List<Veiculo> RetornarTodos(int pagina = 1, string? nome = null, string? marca = null);
        

        /// <summary>
        /// Recebe uma instância de veículo para atualizá-lo no banco de dados.
        /// </summary>
        /// <param name="veiculo">O veículo a ser atualizado no banco.</param>
        public void AtualizarVeiculo(Veiculo veiculo);

        /// <summary>
        /// Recebe uma instância de veículo e remove do banco de dados.
        /// </summary>
        /// <param name="veiculo">O veículo a ser removido do banco.</param>
        public void DeletarVeiculo(Veiculo veiculo);
    }
}
