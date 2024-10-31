namespace MinimalsAPI.Dominio.ModelViews
{
    /// <summary>
    /// Modelo de visualização que será usado no início da aplicação.
    /// </summary>
    public struct Home
    {
        /// <summary>
        /// Uma mensagem para ser exibida na tela.
        /// </summary>
        public string Mensagem { get => "Bem-vindo à API de Veículos - Minimals API"; }

        /// <summary>
        /// Mostra o link para a documentação.
        /// </summary>
        public string Documentacao { get => "/swagger"; }
    }
}
