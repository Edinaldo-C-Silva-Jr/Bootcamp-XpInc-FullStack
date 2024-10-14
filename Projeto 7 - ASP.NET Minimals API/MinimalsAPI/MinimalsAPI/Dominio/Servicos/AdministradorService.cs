using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Infraestrutura.DatabaseContext;

namespace MinimalsAPI.Dominio.Servicos
{
    public class AdministradorService : IAdministradorService
    {
        /// <summary>
        /// Recebe o contexto do banco de dados por DI.
        /// </summary>
        private readonly VeiculosContexto _context;

        public AdministradorService(VeiculosContexto context) 
        {
            _context = context;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
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

            IQueryable<Administrador> query = _context.Administradores.AsQueryable();

            int itensPorPagina = 10;

            query = query.Skip((pagina - 1) * itensPorPagina).Take(itensPorPagina);

            return query.ToList();
        }

        public Administrador? RetornaPorId(int id)
        {
            return _context.Administradores.Where(v => v.Id == id).FirstOrDefault();
        }
    }
}
