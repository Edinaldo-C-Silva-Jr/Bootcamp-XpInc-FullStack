namespace MinimalsAPI.Dominio.DTOs
{
    /// <summary>
    /// Uma classe para fazer transferência de dados de login.
    /// </summary>
    public class LoginDTO
    {
        /// <summary>
        /// O e-mail usado para realizar o login.
        /// </summary>
        public string Email { get; set; } = default!;

        /// <summary>
        /// A senha usada para realizar o login.
        /// </summary>
        public string Senha { get; set; } = default!;
    }
}
