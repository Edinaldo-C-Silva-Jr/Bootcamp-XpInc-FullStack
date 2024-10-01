using Microsoft.EntityFrameworkCore;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Infraestrutura.DatabaseContext;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<VeiculosContexto>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("MinimalsAPIDatabase"));
        });

        var app = builder.Build();

        // Rota padrão do aplicativo.
        app.MapGet("/", () => "Hello World!");

        // Rota para realizar o login.
        app.MapPost("/login", (LoginDTO loginDTO) =>
        {
            if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
            {
                return Results.Ok("Login realizado com sucesso.");
            }
            else
            {
                return Results.Unauthorized();
                ;
            }
        });

        app.Run();
    }
}