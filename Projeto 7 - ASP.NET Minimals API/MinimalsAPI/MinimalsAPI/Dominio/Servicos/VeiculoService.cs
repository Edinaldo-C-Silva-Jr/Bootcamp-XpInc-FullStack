using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPI.Dominio.Servicos
{
    /// <summary>
    /// Implementação da classe de Service que contém os métodos relacionados a veículo.
    /// </summary>
    public class VeiculoService : IVeiculoService
    {
        /// <summary>
        /// Recebe o contexto do banco de dados por DI.
        /// </summary>
        private readonly MinimalsAPIContexto _context;

        /// <summary>
        /// Construtor primário que realiza a injeção de dependência.
        /// </summary>
        /// <param name="context">O contexto do banco de dados a ser usado nos</param>
        public VeiculoService(MinimalsAPIContexto context)
        {
            _context = context;
        }

        public List<Veiculo> RetornarTodos(int pagina = 1, string? nome = null, string? marca = null)
        {
            if (pagina < 1)
            {
                return [];
            }

            // Cria uma query do banco de dados para pesquisar por veículos.
            IQueryable<Veiculo> query = _context.Veiculos.AsQueryable();

            // Adiciona condições na query com base nos parâmetros recebidos.
            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(v => v.Nome.Contains(nome, StringComparison.CurrentCultureIgnoreCase));
            }
            if (!string.IsNullOrEmpty(marca))
            {
                query = query.Where(v => v.Marca.Contains(marca, StringComparison.CurrentCultureIgnoreCase));
            }

            int itensPorPagina = 10;
            
            // Altera a query para pegar apenas os registros na página solicitada. 
            query = query.Skip((pagina - 1) * itensPorPagina).Take(itensPorPagina);

            return query.ToList();
        }

        public Veiculo? RetornaPorId(int id)
        {
            return _context.Veiculos.Where(v => v.Id == id).FirstOrDefault();
        }

        public void IncluirVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }

        public void DeletarVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
        }
    }
}
