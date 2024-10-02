using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Dominio.Interfaces
{
    public interface IAdministradorService
    {
        public Administrador? Login(LoginDTO loginDTO);
    }
}
