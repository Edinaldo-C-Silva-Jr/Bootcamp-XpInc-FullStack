# Minimals API

### Definição do Projeto

O projeto a ser desenvolvido é uma aplicação de cadastros de veículos.

> O usuário acessa a API para cadastro de veículos.  
> O servidor faz a autenticação do usuário.  
> Usuário loga com e-mail e senha.  
> A aplicação valida os dados do usuário e retorna um token JWT.  
> Com o token, o usuário faz uma requisição para ter acesso aos dados de veículo.

Métodos HTTP de login:
- **POST Login**: Faz o login do usuário.
- **POST CriarLogin**: Cria o login de usuário.

Métodos HTTP de veículos:
- **GET Veiculos**: Retorna uma lista paginada.
- **GET Veiculos/1**: Retorna um veículo.
- **POST Veiculos**: Cria um veículo.
- **PUT Veiculos/1**: Atualiza um veículo.
- **DELETE Veiculos/1**: Delete um veículo.

A aplicação tem 2 perfis de usuário:
- **Administrador**: Pode acessar todas as funções da aplicação.
- **Editor**: Não pode criar outros usuários. Não pode alterar ou deletar veículos.

### Criando o Projeto

O projeto deve utilizar uma versão do .NET igual ou superior ao .NET 6. Não pode ser feito em .NET 5 ou anterior.

Para criar o projeto, ele deve ser do tipo **ASP.NET Core Vazio** no Visual Studio.  
Ele pode também ser criado por linha de comando através do comando `dotnet new web -o [nome do projeto]`, porém nesse caso ele será criado sem uma solution.

Ao criar o projeto, ele vem com alguns arquivos de template:
- **launchSettings.json**: Define as portas nas quais a aplicação será iniciada.
- **appSettings.json**: Define as propriedades da aplicação.
- **[nome do projeto].csproj**: Define as properiedades do projeto.
- **Program.cs**: Cria um aplicativo e define uma rota para ela. Retorna um texto "Hello World".

Para rodar o projeto, é possível utilizar:
- `dotnet run`: Roda o projeto.
- `dotnet watch run`: Roda o projeto e recarrega se houver alguma alteração.
- **Clicar em run no Visual Studio**: Roda o projeto.

#### Criar a Rota de Login

Para criar uma nova rota, é possível ir no arquivo `Program.cs` e mapeá-la diretamente por lá.
Para isso é usado o comando `app.MapPost`, que recebe uma rota (`"/login"` neste exemplo) e uma função para executar na rota.

Porém, normalmente as aplicações são feitas de uma forma mais robusta e organizada, em vez de deixar o código todo no `Program.cs`.

### Criar a estrutura do Projeto

Para fazer a estrutura geral do projeto, são usadas algumas pastas:
- **Infraestrutura**: Contém os arquivos responsáveis pela configuração da estrutura do projeto, como a conexão com o banco de dados.
- **Domínio**: Contém os arquivos de regras de negócio e dados do projeto.

A pasta de domínio contém as pastas de Serviços, Entidades e DTOs.

Após a criação das pastas, é necessário fazer as configurações para a aplicação:
- Criar a classe `Administrador`, para definir os dados do administrador que serão salvos no banco de dados.
- Criar a classe `DatabaseContext`, herdando de `DBContext` e definindo os `DBSets` da aplicação.
- Definir a string de conexão no arquivo `appsettings.json`.
- Configurar a string de conexão no `Program.cs` na `DatabaseContext`.
- Configurar e rodar a migration para criar a tabela no banco de dados.

A **Migration** pode ser criada pelo console do gerenciador de pacotes, ou pelo console do computador (mas requer a instalação do EntityFramework no computador).  
A Migration pode ser criada pelo comando `add-migration [Nome da Migration]` no gerenciador de pacotes, e depois executada através do comando `update-database`.  
No caso do console do computador, o comando é `dotnet ef migrations add [Nome da Migration]`, e o comando de execução é `dotnet ef databse update`.

#### Criar um Seed para o Login

Uma seed é uma configuração inicial do banco de dados para cadastrar dados iniciais, que podem ser utilizados no programa sem a necessidade de cadastrar dados.

Para criar uma seed, é necessário ir na classe do `DBContext` (Neste caso `VeiculoContext`) e fazer um override do método `OnModelCreating`. Após criar o método, o `modelBuilder` pode ser usado para criar dados no banco de dados.

Após alterar essa configuração, é necessário criar uma nova Migration para aplicar as mudanças no banco de dados.

#### Criar a Função de Login

Para criar a função de login, primeiro é necessário criar a classe de serviço. Isso é feito em duas etapas:
- Criar uma interface `IAdministradorService`, que será utilizada para fazer testes
- Criar uma classe `AdministradorService`, que implementa a interface e implementa o método de Login

Com ambas as classes criadas, é possível chamar o método de Login diretamente do `AdministratorService`.

#### Criar o Modelo de Veículos

- Criar uma classe `Veiculo` para ser o modelo da tabela no banco de dados.
- Adicionar a nova classe de veiculo no contexto.
- Fazer a migration para atualizar o banco de dados.
- Criar a interface `IVeiculoService` e a classe `VeiculoService`.

#### Configurar o Swagger no Projeto

- Baixar o pacote `Swashbuckle.AspNetCore` no projeto.
- Adicionar, no Program.cs, os comandos `builder.Services.AddEndpointsApiExplorer` e `builder.Services.AddSwaggerGen()`.
- Depois de dar o build do aplicativo, adicionar os comandos `app.UseSwagger()` e `app.UseSwaggerUI`.

#### Configurar a Home

- Criar uma pasta `ModelViews`, que possui os modelos de visualização para retornar os dados da API.
- Criar uma struct chamada `Home`, que possui propriedades para serem exibidas na tela ao iniciar a aplicação (mensagem e link para a documentação).
- Adicionar, no `Program.cs`, o mapeamento da rota inicial na struct Home: `app.MapGet("/", () => Results.Json(new Home()));`

#### Configurar as Rotas para Veiculos

- Criar uma classe DTO para veículos.
- Mapear as rotas no arquivo `Program.cs`.

- Mapear uma rota POST para o método `IncluirVeiculo`.
- Mapear uma rota GET para o método `RetornarTodos`.
- Mapear uma rota GET para o método `RetornarPorId`.
- Mapear uma rota PUT para o método `AtualizarVeiculo`.
- Mapear uma rota DELETE para o método `DeletarVeiculo`.

- Adicionar tags nas rotas usando o método `WithTags([NomeDaCategoria])` no final do mapeamento, que separa as rotas por categoria no Swagger.

#### Fazer validações nos Endpoints de Veiculo

- Criar uma struct de erros de validação que contém uma lista de mensagens.
- Criar uma função dentro do `Program.cs` para fazer as validações em um `veiculoDTO` recebido.
- Utilizar a função para fazer as validações dentro de cada EndPoint.

#### Criar os Endpoints para Administradores

- Criar um DTO para receber os dados de administrador: email, senha e perfil.
- Criar um Enum para o Perfil do administrador.
- Criar os métodos de adicionar administrador, retornar todos e retornar por id no `AdministradorService`.
- Mapear as rotas no `Program.cs`.
- Mapear a rota POST para o método `AdicionarAdministrador`".
- Mapear a rota GET para o método `RetornarTodos`".
- Mapear a rota GET para o método `RetornarPorID`".
- Criar um MovelView para exibir o administrador sem exibir a senha.

#### Configurar o token JWT para o login

- Baixar o pacote `Microsoft.AspNetCore.Authentication.JwtBearer`.
- Configurar o JWT no `appsettings.json`, dando o nome de uma chave, que é a chave usada para criptografar o token.
- Configurar o serviço do **Authentication** e do **Authorization** no `Program.cs`, depois configurar o aplicativo para usá-los.

##### Configurar as rotas para precisarem de autenticação

- Ao final do mapeamento de uma rota, adicionar o comando `RequireAuthorization()`.
- Criar um método para gerar o token JWT.
- Criar um ModelView para administrador logado que recebe o token ao fazer o login corretamente.
- Utilizar o ModelView para retornar o token na rota de login.

#### Configurar o Swagger Pra Receber o Token

- Configurar o token JWT no Swagger, utilizando `options.AddSecurityDefinition` e `options.AddSecurityRequirements`.
- Adicionar `ValidateIssuer` e `ValidateAudience` como false no `AddAuthentication`.
- Ao fazer login na API, pegar o token e inserir na aba de "Authorization".

#### Criar Autorização de perfis

- Adicionar uma nova **Claim** com `ClaimType` para Roles.
- Adicionar, no comando `RequireAuthorization()`, uma nova `AuthorizateAttribute { Roles = [nome do perfil]}`.

### Criar o Projeto de teste

- Criar um novo projeto com o template do MSTest, utilizando a mesma solução do projeto da API.
- Adicionar uma referência no projeto de teste ao projeto original.
- Adicionar uma estrutura de pastas similar à do projeto original, para organizar as classes de teste de forma similar às classes originais.

#### Criar casos de teste

- Criar casos de teste para as classes da pasta `Entidade`. Testar os getters e setters das classes.
- Criar uma classe de teste para `AdministrdorService` e `VeiculoService`. Testar os métodos que fazem conexão com o banco de dados, utilizando um contexto de teste.
- Refatorar o código do `Program.cs`, criando uma classe `StartUp.cs`.
- A classe `StartUp.cs` é uma classe com um formato padrão usado para iniciar uma aplicação no ASP.NET.
- Criar uma classe `Setup` para subir a aplicação para testes.
- Criar um mock de `AdministradorService` para salvar os dados na memória ao realizar os testes.
- Criar testes de request para a rota de login.