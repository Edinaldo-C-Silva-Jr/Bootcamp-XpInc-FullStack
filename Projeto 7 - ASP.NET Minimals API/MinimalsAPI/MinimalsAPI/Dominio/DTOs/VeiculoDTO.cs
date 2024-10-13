namespace MinimalsAPI.Dominio.DTOs
{
    /// <summary>
    /// Uma classe para fazer transferência de dados para veículos.
    /// </summary>
    public class VeiculoDTO
    {
        /// <summary>
        /// Nome do veículo.
        /// </summary>
        public string Nome { get; set; } = default!;

        /// <summary>
        /// Marca do veículo.
        /// </summary>
        public string Marca { get; set; } = default!;

        /// <summary>
        /// Ano de lançamento do veículo.
        /// </summary>
        public int Ano { get; set; } = default!;
    }
}
