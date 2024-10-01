using Microsoft.EntityFrameworkCore;
using MinimalsAPI.Dominio.Entidades;

namespace MinimalsAPI.Infraestrutura.DatabaseContext
{
    public class VeiculosContexto : DbContext
    {
        protected readonly IConfiguration _configuration;

        public VeiculosContexto(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MinimalsAPIDatabase"));
        }
    }
}
