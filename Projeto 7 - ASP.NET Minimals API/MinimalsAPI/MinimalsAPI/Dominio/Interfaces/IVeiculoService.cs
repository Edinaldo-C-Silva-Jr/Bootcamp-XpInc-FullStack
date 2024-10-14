using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Dominio.Interfaces
{
    public interface IVeiculoService
    {
        public List<Veiculo> RetornarTodos(int pagina = 1, string? nome = null, string? marca = null);

        public Veiculo? RetornaPorId(int id);

        public void IncluirVeiculo(Veiculo veiculo);

        public void AtualizarVeiculo(Veiculo veiculo);

        public void DeletarVeiculo(Veiculo veiculo);
    }
}
