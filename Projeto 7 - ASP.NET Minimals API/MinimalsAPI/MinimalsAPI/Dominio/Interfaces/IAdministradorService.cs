using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Dominio.Interfaces
{
    /// <summary>
    /// Interface que define os métodos para a classe Service dos administradores.
    /// </summary>
    public interface IAdministradorService
    {
        /// <summary>
        /// Recebe os dados de login e realiza o login caso eles sejam válidos.
        /// </summary>
        /// <param name="loginDTO">Os dados utilizados para realizar o login.</param>
        /// <returns>Um administrador, caso os dados sejam válidos.</returns>
        public Administrador? Login(LoginDTO loginDTO);

        /// <summary>
        /// Recebe uma instância de administrador e insere no banco de dados.
        /// </summary>
        /// <param name="administrador">O administrador a ser inserido no banco.</param>
        public void AdicionarAdministrador(Administrador administrador);

        /// <summary>
        /// Retorna todos os administradores cadastrados, com base no valor da página.
        /// </summary>
        /// <param name="pagina">O número da página a ser retornado.</param>
        /// <returns>Uma lista com todos os administradores na página solicitada.</returns>
        public List<Administrador> RetornarTodos(int pagina);

        /// <summary>
        /// Retorna um administrador pelo Id, se existir.
        /// </summary>
        /// <param name="id">O Id od administrador para retornar.</param>
        /// <returns>O administrador solicitado, que pode ser nulo.</returns>
        public Administrador? RetornaPorId(int id);
    }
}
