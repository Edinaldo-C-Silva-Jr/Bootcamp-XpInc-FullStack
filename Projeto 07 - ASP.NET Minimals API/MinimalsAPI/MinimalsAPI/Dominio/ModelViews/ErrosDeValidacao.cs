namespace MinimalsAPI.Dominio.ModelViews
{
    /// <summary>
    /// Modelo de visualização que será usado para erros de validação nos endpoints.
    /// </summary>
    public struct ErrosDeValidacao
    {
        /// <summary>
        /// Uma lista de mensagens que serão exibidas na tela.
        /// </summary>
        public List<string> Mensagem { get; set; }
    }
}
