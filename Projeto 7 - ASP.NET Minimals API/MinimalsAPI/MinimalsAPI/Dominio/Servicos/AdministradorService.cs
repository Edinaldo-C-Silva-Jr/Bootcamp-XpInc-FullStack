using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPI.Dominio.Servicos
{
    /// <summary>
    /// Implementação da classe de Service que contém os métodos relacionados a administrador.
    /// </summary>
    public class AdministradorService : IAdministradorService
    {
        /// <summary>
        /// Recebe o contexto do banco de dados por DI.
        /// </summary>
        private readonly MinimalsAPIContexto _context;

        /// <summary>
        /// Construtor primário que realiza a injeção de dependência.
        /// </summary>
        /// <param name="context">O contexto do banco de dados a ser usado nos</param>
        public AdministradorService(MinimalsAPIContexto context) 
        {
            _context = context;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            // Retorna o primeiro administrador cujo e-mail e senha coincidem com os enviados no login.
            return _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        }

        public void AdicionarAdministrador(Administrador administrador)
        {
            _context.Administradores.Add(administrador);
            _context.SaveChanges();
        }

        public List<Administrador> RetornarTodos(int pagina)
        {
            if (pagina < 1)
            {
                return [];
            }

            // Cria uma query do banco de dados para pesquisar por administradores.
            IQueryable<Administrador> query = _context.Administradores.AsQueryable();

            int itensPorPagina = 10;

            // Altera a query para pegar apenas os registros na página solicitada. 
            query = query.Skip((pagina - 1) * itensPorPagina).Take(itensPorPagina);

            return query.ToList();
        }

        public Administrador? RetornaPorId(int id)
        {
            return _context.Administradores.Where(v => v.Id == id).FirstOrDefault();
        }
    }
}
