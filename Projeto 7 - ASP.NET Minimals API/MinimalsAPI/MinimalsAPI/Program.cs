using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MinimalsAPI.Dominio.DTOs;
using MinimalsAPI.Dominio.Entidades;
using MinimalsAPI.Dominio.Enums;
using MinimalsAPI.Dominio.Interfaces;
using MinimalsAPI.Dominio.ModelViews;
using MinimalsAPI.Dominio.Servicos;
using MinimalsAPI.Infraestrutura.DatabaseContext;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        // Pega o valor da key do appsettings.json.
        string key = builder.Configuration.GetSection("Jwt").ToString() ?? "12345678";

        // Adiciona o serviço de autenticação na aplicação, utilizando o JWT Bearer.
        builder.Services.AddAuthentication(option =>
        {
            option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(option =>
        {
            option.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateLifetime = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
            };
        });
        builder.Services.AddAuthorization();

        // Configura o Swagger na aplicação.
        // Adiciona as configurações de token JWT no Swagger.
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Insira o token JWT aqui"
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
        });

        var app = builder.Build();
        #endregion

        // Mapeia a rota inicial através da model Home, que aponta para a documentação.
        app.MapGet("/", () => Results.Json(new Home()))
            .WithTags("Home");

        #region Administradores
        // Função para gerar o token JWT.
        string GerarTokenJWT(Administrador administrador)
        {
            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims =
            [
                new Claim("Email", administrador.Email),
                new Claim("Perfil", administrador.Perfil),
                new Claim(ClaimTypes.Role, administrador.Perfil)
            ];

            SecurityToken token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // Função que faz as validações dos dados de um administradorDTO.
        ErrosDeValidacao ValidaAdministradorDTO(AdministradorDTO administradorDTO)
        {
            ErrosDeValidacao validacao = new()
            {
                Mensagem = []
            };

            if (string.IsNullOrEmpty(administradorDTO.Email))
            {
                validacao.Mensagem.Add("O e-mail não pode ser vazio.");
            }

            if (administradorDTO.Senha.Length < 8)
            {
                validacao.Mensagem.Add("A senha deve ter pelo menos 8 caracteres.");
            }

            if (administradorDTO.PerfilDoAdmin != Perfil.Admin && administradorDTO.PerfilDoAdmin != Perfil.Editor)
            {
                validacao.Mensagem.Add("O perfil deve ser Admin (0) ou Editor (1).");
            }

            return validacao;
        }

        // Rota para realizar o cadastro de um administrador.
        app.MapPost("/administradores", ([FromBody] AdministradorDTO administradorDTO, IAdministradorService administradorService) =>
        {
            ErrosDeValidacao validacao = ValidaAdministradorDTO(administradorDTO);
            if (validacao.Mensagem.Count > 0)
            {
                return Results.BadRequest(validacao);
            }

            Administrador administrador = new()
            {
                Email = administradorDTO.Email,
                Senha = administradorDTO.Senha,
                Perfil = administradorDTO.PerfilDoAdmin.ToString() ?? Perfil.Editor.ToString()
            };

            administradorService.AdicionarAdministrador(administrador);

            AdministradorModelView admin = new()
            {
                Id = administrador.Id,
                Email = administrador.Email,
                Perfil = administrador.Perfil
            };

            return Results.Created($"/administradores/{administrador.Id}", admin);
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
            .WithTags("Administradores");

        // Rota para retornar todos os administradores.
        app.MapGet("/administradores", (IAdministradorService administradorService, int pagina = 1) =>
        {
            List<AdministradorModelView> admins = [];
            List<Administrador> administradores = administradorService.RetornarTodos(pagina);

            foreach (Administrador admin in administradores)
            {
                admins.Add(new AdministradorModelView
                {
                    Id = admin.Id,
                    Email = admin.Email,
                    Perfil = admin.Perfil
                });
            }

            return Results.Ok(admins);
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
            .WithTags("Administradores");

        // Rota para retornar um administrador através do ID.
        app.MapGet("/administradores/{id}", ([FromRoute] int id, IAdministradorService administradorService) =>
        {
            Administrador? administrador = administradorService.RetornaPorId(id);

            if (administrador is null)
            {
                return Results.NotFound();
            }
            else
            {
                AdministradorModelView admin = new()
                {
                    Id = administrador.Id,
                    Email = administrador.Email,
                    Perfil = administrador.Perfil
                };

                return Results.Ok(admin);
            }
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
            .WithTags("Administradores");

        // Rota para realizar o login.
        app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
        {
            Administrador? administrador = administradorService.Login(loginDTO);
            if (administrador is not null)
            {
                string token = GerarTokenJWT(administrador);

                AdministradorLogado adminLogado = new()
                {
                    Email = administrador.Email,
                    Perfil = administrador.Perfil,
                    Token = token
                };

                return Results.Ok(adminLogado);
            }
            else
            {
                return Results.Unauthorized();
            }
        })
            .WithTags("Administradores");
        #endregion

        #region Veiculos
        // Função que faz as validações dos dados de um veiculoDTO.
        ErrosDeValidacao ValidaVeiculoDTO(VeiculoDTO veiculoDTO)
        {
            ErrosDeValidacao validacao = new()
            {
                Mensagem = []
            };

            if (string.IsNullOrEmpty(veiculoDTO.Nome))
            {
                validacao.Mensagem.Add("O nome não pode ser vazio.");
            }

            if (string.IsNullOrEmpty(veiculoDTO.Marca))
            {
                validacao.Mensagem.Add("A marca não pode ser vazia.");
            }

            if (veiculoDTO.Ano < 1886)
            {
                validacao.Mensagem.Add("O ano deve ser igual ou superior a 1886, o ano de invenção do primeiro carro.");
            }

            return validacao;
        }

        // Rota para realizar o cadastro de um veículo através de um DTO.
        app.MapPost("/veiculos", ([FromBody] VeiculoDTO veiculoDTO, IVeiculoService veiculoService) =>
        {
            ErrosDeValidacao validacao = ValidaVeiculoDTO(veiculoDTO);
            if (validacao.Mensagem.Count > 0)
            {
                return Results.BadRequest(validacao);
            }

            Veiculo veiculo = new()
            {
                Nome = veiculoDTO.Nome,
                Marca = veiculoDTO.Marca,
                Ano = veiculoDTO.Ano
            };

            veiculoService.IncluirVeiculo(veiculo);

            return Results.Created($"/veiculo/{veiculo.Id}", veiculo);
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
            .WithTags("Veiculos");

        // Rota para retornar todos os veículos.
        app.MapGet("/veiculos", (IVeiculoService veiculoService, int pagina = 1) =>
        {
            List<Veiculo> veiculos = veiculoService.RetornarTodos(pagina);

            return Results.Ok(veiculos);
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
            .WithTags("Veiculos");

        // Rota para retornar um veículo através do ID.
        app.MapGet("/veiculos/{id}", ([FromRoute] int id, IVeiculoService veiculoService) =>
        {
            Veiculo? veiculo = veiculoService.RetornaPorId(id);

            if (veiculo is null)
            {
                return Results.NotFound();
            }
            else
            {
                return Results.Ok(veiculo);
            }
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
            .WithTags("Veiculos");

        // Rota para alterar um veículo através do ID e de um veiculoDTO.
        app.MapPut("/veiculos/{id}", ([FromRoute] int id, [FromBody] VeiculoDTO veiculoDTO, IVeiculoService veiculoService) =>
        {
            ErrosDeValidacao validacao = ValidaVeiculoDTO(veiculoDTO);
            if (validacao.Mensagem.Count > 0)
            {
                return Results.BadRequest(validacao);
            }

            Veiculo? veiculo = veiculoService.RetornaPorId(id);

            if (veiculo is null)
            {
                return Results.NotFound();
            }
            else
            {
                veiculo.Nome = veiculoDTO.Nome;
                veiculo.Marca = veiculoDTO.Marca;
                veiculo.Ano = veiculoDTO.Ano;

                veiculoService.AtualizarVeiculo(veiculo);

                return Results.Ok(veiculo);
            }
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
            .WithTags("Veiculos");

        // Rota para deletar um veículo através do ID.
        app.MapDelete("/veiculos/{id}", ([FromRoute] int id, IVeiculoService veiculoService) =>
        {
            Veiculo? veiculo = veiculoService.RetornaPorId(id);

            if (veiculo is null)
            {
                return Results.NotFound();
            }
            else
            {
                veiculoService.DeletarVeiculo(veiculo);

                return Results.NoContent();
            }
        })
            .RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
            .WithTags("Veiculos");
        #endregion

        // Configura o aplicativo para usar o Swagger com a interface.
        app.UseSwagger();
        app.UseSwaggerUI();

        // Configura a aplicação para usar a autenticação.
        app.UseAuthentication();
        app.UseAuthorization();

        app.Run();
    }
}