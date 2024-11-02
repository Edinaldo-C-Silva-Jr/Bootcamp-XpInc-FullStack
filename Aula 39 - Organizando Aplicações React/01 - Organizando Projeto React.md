## Criando o Projeto

O primeiro passo é criar o projeto React, usando o comando `npx create-react-app [nome do projeto]` no terminal, dentro da pasta desejada.  
Com isso é criada toda a estrutura do projeto:

- `node-modules`: a pasta que contém as dependÇencias do projeto.
- `public`: A pasta onde o React faz as manipulações.
- `src`: A pasta que contém os arquivos do projeto.
- `.gitignore`: Arquivo gitignore para projetos em React.

### Criando a Estrutura de Pastas e Arquivos

#### Simplificando o Projeto

Primeiro retirar os arquivos extras do projeto para deixar somente a estrutura básica dele:

- Remover todos os arquivos da pasta `public`, deixando apenas o `index.html`.
- Remover os comentários e imports do arquivo `index.html`. Ele deve ficar assim:

```
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="theme-color" content="#000000" />
    <meta
      name="description"
      content="Web site created using create-react-app"
    />
    <title>Git Find</title>
  </head>
  <body>
    <noscript>You need to enable JavaScript to run this app.</noscript>
    <div id="root"></div>
  </body>
</html>
```

- Remover os arquivos da pasta `src`, deixando apenas o `App.js` e o `index.js`
- Remover os imports e comentários do `index.js`, deixando ele assim:

```
import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
```

- Remover os imports e o header existente no `App.js`, deixando ele assim:

```
function App() {
  return (
    <div className="App">

    </div>
  );
}

export default App;
```

#### Criando as Pastas

- Criar uma pasta `pages`, onde ficarão as páginas do aplicativo.
- Criar uma pasta `Home` dentro da pasta `pages`. Colocar o arquivo `App.js` dentro dela, renomenado para `index.js`.
Com isso é possível deixar todos os arquivos relacionados a cada página dentro de sua própria pasta.  
O arquivo com nome `index.js` já é identificado como o arquivo principal da pasta, portanto ele não precisa ser referenciado no import.
- Criar uma pasta `components`.
- Criar 3 pastas dentro dela: `Header`, `Input` e `Button`.

## Projeto Git Find

Uma aplicação que permite pesquisar por um usuário do Github, e retorna o perfil do usuário, junto com os repositórios públicos do usuário.  
A aplicação utiliza a API do Github para retornar esses dados.

### Desenvolver o Projeto

- Criar um arquivo `styles.css` dentro da pasta `src`, que será a estilização global da aplicação.  
Importá-lo no `index.js` da pasta `src`.
- Criar um arquivo `index.js` dentro da pasta `Header`, para criar o componente do header da aplicação.  
É possível criar um componente template utilizando o comando `rfc` (React Functional Component) dentro de um arquivo JavaScript. 
- Criar também um arquivo `styles.css` dentro da pasta `Header`, contendo todos os valores de estilização para o header da aplicação.
- Para utilizar uma fonte no projeto, é necessário ir até o site Google Fonts, escolher a fonte e pegar o código de embed dela. Depois colar no `<head>` do arquivo `index.html`.
- Criar uma pasta `assets`, onde serão colocadas as imagens utilizadas no projeto.
- Inserir a imagem dentro de uma seção na página Home, e fazer a estilização dela.
- Criar outra seção dentro da página Home, onde ficarão o Input e o Botão usados para pesquisa. Fazer a estilização de ambos.
- Criar uma outra seção para o perfil do usuário que será buscado. Ela terá uma imagem, um título e um parágrafo.
- Criar mais outra seção na página Home para incluir os itens da lista de repositórios. Para isso, criar um componente `ItemList` que representará cada um dos repositórios na lista.

### Fazendo as Requisições para Buscar os dados do Projeto

Os dados de um usuário do Github podem ser acessados através da API do Github, no link: `https://api.github.com/users/[nome do usuário]`.

Os dados de todos os repositórios de um usuários podem ser acessados pela mesma API do Github ao acessar o link `https://api.github.com/users/[nome do usuário]/repos`.

Para acessar esses dados dentro da aplicação:
- Criar um estado para armazenar: 
  1. O valor digitado para pesquisa.
  2. O usuário retornado pelo Github.
  3. OS repositórios do usuário retornado.
- Criar uma função para pegar os dados da API do Github, fazendo um `fetch` na URL da API, passando o valor digitado do nome do usuário.
- Depois de retornar o usuário, fazer um fetch também dos repositórios.
- Fazer uma validação dentro do JSX para só mostrar as seções do site quando tiver dados para mostrar. Fazer a mesma validação para os repositórios.
- Inserir os dados retornados do fetch nos componentes da página para serem exibidos.