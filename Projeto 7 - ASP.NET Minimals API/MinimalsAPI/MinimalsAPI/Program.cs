using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Dominio.ModelViews;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Adiciona o AdministratorService � aplica��o com lifetime Scoped.
        builder.Services.AddScoped<IAdministradorService, AdministradorService>();

        // Configura o contexto do banco de dados na aplica��o.
        builder.Services.AddDbContext<VeiculosContexto>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("MinimalsAPIDatabase"));
        });

        // Configura o Swagger na aplica��o.
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configura o aplicativo para usar o Swagger com a interface.
        app.UseSwagger();
        app.UseSwaggerUI();

        // Mapeia a rota inicial do aplicativo atrav�s da model Home, que aponta para a documenta��o.
        app.MapGet("/", () => Results.Json(new Home()));

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