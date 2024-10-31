namespace MinimalsAPI.Dominio.ModelViews
{
    /// <summary>
    /// Modelo de visualização usado para visualizar os administradores nos métodos GET.
    /// </summary>
    public struct AdministradorModelView
    {
        /// <summary>
        /// O identificador único do Administrador.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O e-mail do Administrador.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// O perfil do Administrador.
        /// </summary>
        public string Perfil { get; set; }
    }
}
