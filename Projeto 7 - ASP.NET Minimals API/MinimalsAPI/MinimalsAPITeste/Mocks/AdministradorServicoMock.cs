using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Interfaces;

namespace MinimalsAPITeste.Mocks
{
    public class AdministradorServicoMock : IAdministradorService
    {
        private static List<Administrador> administradores =
            [
                new Administrador{
                    Id = 1,
                    Email = "administrador@teste.com",
                    Senha = "adm123456",
                    Perfil = "Adm"
                },
                new Administrador{
                    Id = 2,
                    Email = "editor@teste.com",
                    Senha = "ed123456",
                    Perfil = "Editor"
                }
            ];

        public void AdicionarAdministrador(Administrador administrador)
        {
            administrador.Id = administradores.Count + 1;
            administradores.Add(administrador);
        }

        public Administrador? RetornaPorId(int id)
        {
            return administradores.Find(a => a.Id == id);
        }

        public List<Administrador> RetornarTodos(int pagina)
        {
            return administradores;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            return administradores.Find(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
        }
    }
}
