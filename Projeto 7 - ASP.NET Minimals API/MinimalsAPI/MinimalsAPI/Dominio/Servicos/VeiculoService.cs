using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPI.Dominio.Servicos
{
    public class VeiculoService : IVeiculoService
    {
        /// <summary>
        /// Recebe o contexto do banco de dados por DI.
        /// </summary>
        private readonly VeiculosContexto _context;

        public VeiculoService(VeiculosContexto context)
        {
            _context = context;
        }

        public List<Veiculo> RetornarTodos(int pagina = 1, string? nome = null, string? marca = null)
        {
            if (pagina < 1)
            {
                return [];
            }

            IQueryable<Veiculo> query = _context.Veiculos.AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(v => v.Nome.Contains(nome, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrEmpty(marca))
            {
                query = query.Where(v => v.Marca.Contains(marca, StringComparison.CurrentCultureIgnoreCase));
            }

            int itensPorPagina = 10;

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
