using Microsoft.EntityFrameworkCore;
using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Infraestrutura.DatabaseContext
{
    /// <summary>
    /// Classe de contexto do banco de dados para a aplicação.
    /// </summary>
    public class MinimalsAPIContexto : DbContext
    {
        /// <summary>
        /// Variável que recebe por DI as configurações do projeto.
        /// </summary>
        protected readonly IConfiguration _configuration;

        /// <summary>
        /// Construtor primário que realiza a injeção de dependência.
        /// </summary>
        /// <param name="configuration">Uma instância de configuração que será injetada no campo _configuration.</param>
        public MinimalsAPIContexto(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// DBSet que representa a entidade de administradores.
        /// </summary>
        public DbSet<Administrador> Administradores { get; set; } = default!;

        /// <summary>
        /// DBSet que representa a entidade de veículos.
        /// </summary>
        public DbSet<Veiculo> Veiculos { get; set; } = default!;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Cria um registro de Administrador padrão ao criar o banco de dados.
        //    modelBuilder.Entity<Administrador>().HasData(
        //        new Administrador
        //        {
        //            Id = 1,
        //            Email = "administrador@admin.com",
        //            Senha = "123456",
        //            Perfil = "Admin"
        //        });
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? stringConexao = _configuration.GetConnectionString("MinimalsAPIDatabase");
                if (!string.IsNullOrEmpty(stringConexao))
                {
                    optionsBuilder.UseSqlServer(stringConexao);
                }
            }
        }
    }
}
