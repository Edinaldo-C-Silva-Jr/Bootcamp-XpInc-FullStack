using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Dominio.ModelViews;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;

internal class Program
{
    private static void Main(string[] args)
    {
        #region App Builder
        var builder = WebApplication.CreateBuilder(args);

        // Adiciona os serviços à aplicação com lifetime Scoped.
        builder.Services.AddScoped<IAdministradorService, AdministradorService>();
        builder.Services.AddScoped<IVeiculoService, VeiculoService>();

        // Configura o contexto do banco de dados na aplicação.
        builder.Services.AddDbContext<VeiculosContexto>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("MinimalsAPIDatabase"));
        });

        // Configura o Swagger na aplicação.
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        #endregion

        // Mapeia a rota inicial do aplicativo através da model Home, que aponta para a documentação.
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

        // Rota para realizar o cadastro de um veículo.
        app.MapPost("/veiculos", ([FromBody] VeiculoDTO veiculoDTO, IVeiculoService veiculoService) =>
        {
            Veiculo veiculo = new()
            {
                Nome = veiculoDTO.Nome,
                Marca = veiculoDTO.Marca,
                Ano = veiculoDTO.Ano
            };

            veiculoService.IncluirVeiculo(veiculo);

            return Results.Created($"/veiculo/{veiculo.Id}", veiculo);
        });

        // Rota para retornar todos os veículos.
        app.MapGet("/veiculos", (IVeiculoService veiculoService, int pagina = 1) =>
        {
            List<Veiculo> veiculos = veiculoService.RetornarTodos(pagina);

            return Results.Ok(veiculos);
        });

        // Configura o aplicativo para usar o Swagger com a interface.
        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}