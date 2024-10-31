using MinimalsAPI.Dominio.Enums;

namespace MinimalsAPI.Dominio.DTOs
{
    /// <summary>
    /// Uma classe para fazer transferência de dados para administradores.
    /// </summary>
    public class AdministradorDTO
    {
        /// <summary>
        /// O e-mail do administrador.
        /// </summary>
        public string Email { get; set; } = default!;

        /// <summary>
        /// A senha do administrador.
        /// </summary>
        public string Senha { get; set; } = default!;

        /// <summary>
        /// O perfil do administrador.
        /// </summary>
        public Perfil? PerfilDoAdmin { get; set; } = default!;
    }
}
