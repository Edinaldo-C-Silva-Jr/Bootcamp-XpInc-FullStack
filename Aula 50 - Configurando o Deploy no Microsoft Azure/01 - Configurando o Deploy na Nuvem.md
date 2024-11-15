## Configurar o Deploy na Nuvem

### Diferenças entre IaaS, PaaS e DbaaS

O modelo de serviço Infrastructure as a Service (IaaS) permite ao cliente gerenciar a infraestrutura que está disponibilizada na nuvem. O provedor de nuvem disponibiliza os servidores, mas o cliente tem o controle e a responsabilidade sobre suas configurações.

O modelo de Platform as a Service (PaaS) fornece uma plataforma com as ferramentas disponíveis para desenvolvimento, com os detalhes de infraestrutura sendo de responsabilidade completa do provedor de nuvem.

O modelo de Database as a Service (DbaaS) fornece um serviço de banco de dados pronto para ser usado, através do qual não há necessidade de gerenciar quaisquer aspectos de configuração ou manutenção do banco de dados.

### Serviços para o Deploy

Para realizar o deploy na nuvem, é necessária a contratação de alguns serviços:
- Um serviço DbaaS para hospedar o banco de dados utilizado na aplicação
- Um serviço de PaaS para hospedar a API que fará a integração com esse banco de dados
- Um serviço de PaaS para hospedar o front end responsável por consumir essa API e oferecer o serviço aos usuários

### Fazer o Deploy da API e banco de dados com Visual Studio

- Abrir o projeto da API no Visual Studio.
- Clicar com o botão direito e escolher a opção **Publicar**.
- Selecionar o Target como o **Azure**.
- Selecionar o tipo de serviço do Azure, como um servidor Azure Linux.
- Informar o usuário da conta Azure que será usado para a publicação.
- Preencher as informações necessárias dos recursos da Azure e criar o recurso da aplicação.

Após publicar a aplicação, o Visual Studio identifica as dependências do serviço hospedado (no caso da API, será um banco de dados).  
Essas dependências também devem ser configuradas para que o serviço funcione corretamente.

Após finalizar a publicação, o Azure disponibiliza a URL que pode ser utilizada para acessar a API.

### Fazer o Deploy da aplicação MVC com Visual Studio

- Abrir o projeto da aplicação MVC no Visual Studio.
- Clicar com o botão direito e escolher a opção **Publicar**.
- Selecionar o Target como o **Azure**.
- Selecionar o tipo de serviço do Azure, como um servidor Azure Linux.
- Informar o usuário da conta Azure que será usado para a publicação, possivelmente a mesma conta utilizada no deploy da API.
- Preencher as informações necessárias dos recursos da Azure e criar o recurso da aplicação.

Após finalizar a publicação, o Azure disponibiliza a URL que pode ser utilizada para acessar a aplicação MVC.

## Automação CI/CD

Para realizar essa automação, o código fonte deve estar no Github. Será usada a ferramenta Github Actions.

Dentor do Azure, existe uma ferramenta conhecida como "Central de Implantação", que permite realizar o deploy contínuo.  
Ao entrar nessa ferramenta, é necessário definir a origem do código fonte (como o Github), e depois preencher as informações necessárias, como conta, repositório, branch, stack e versão.

Isso cria no Github uma pasta `.github/workflows`, que contém as configurações de deploy realizadas através da ferramenta.