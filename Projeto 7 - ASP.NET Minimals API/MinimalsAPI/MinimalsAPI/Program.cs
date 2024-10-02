using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<IAdministradorService, AdministradorService>();

        // Configura o contexto do banco de dados na aplicação.
        builder.Services.AddDbContext<VeiculosContexto>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("MinimalsAPIDatabase"));
        });

        var app = builder.Build();

        // Rota padrão do aplicativo.
        app.MapGet("/", () => "Hello World!");

        // Rota para realizar o login.
        app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
        {
            if (administradorService.Login(loginDTO) is not null)
            {
                return Results.Ok("Login realizado com sucesso.");
            }
            else
            {
                return Results.Unauthorized();
            }
        });

        app.Run();
    }
}