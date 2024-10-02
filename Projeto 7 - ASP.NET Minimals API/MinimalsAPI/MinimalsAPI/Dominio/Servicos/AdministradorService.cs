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
    }
}
