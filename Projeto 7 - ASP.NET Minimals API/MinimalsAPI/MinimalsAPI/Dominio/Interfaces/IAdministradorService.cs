using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Dominio.Interfaces
{
    public interface IAdministradorService
    {
        public Administrador? Login(LoginDTO loginDTO);

        public void AdicionarAdministrador(Administrador administrador);

        public List<Administrador> RetornarTodos(int pagina);

        public Administrador? RetornaPorId(int id);
    }
}
