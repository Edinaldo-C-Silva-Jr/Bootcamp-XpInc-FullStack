using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Dominio.Interfaces
{
    public interface IVeiculoService
    {
        List<Veiculo> RetornarTodos(int pagina = 1, string? nome = null, string? marca = null);

        Veiculo? RetornaPorId(int id);

        void IncluirVeiculo(Veiculo veiculo);

        void AtualizarVeiculo(Veiculo veiculo);

        void DeletarVeiculo(Veiculo veiculo);
    }
}
