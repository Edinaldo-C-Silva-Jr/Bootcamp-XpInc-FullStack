namespace MinimalsAPI.Dominio.ModelViews
{
    /// <summary>
    /// Modelo de visualização usado para visualizar o administrador depois de realizar o login.
    /// </summary>
    public struct AdministradorLogado
    {
        /// <summary>
        /// O e-mail do Administrador.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// O perfil do Administrador.
        /// </summary>
        public string Perfil { get; set; }

        /// <summary>
        /// O token gerado ao fazer o login.
        /// </summary>
        public string Token { get; set; }
    }
}
