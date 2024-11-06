## O Que é Styled Components

O Styled Components é uma biblioteca que possibilita escrever código CSS dentro do JavaScript. Com ele, é possível criar websites com mais agilidade e precisão.  
O styled components permite criar componentes com um estilo aplicado nele diretamente.

### Configurando o styled-components

Para instalar o styled components em um projeto, basta utilizar o comando `npm install styled-components`. Com a instalação, já é possível utilizá-lo na aplicação.

Para utilizar o styled components dentro de uma aplicação:
- Criar uma variável que recebe o componente
- Utilizar a função `styled` para criar um componente. Ela permite utilizar qualquer tag do HTML para criar um componente.
- Inserir o estilo dentro da tag utilizando ` `` `.
- É possível também passar propriedades para o componente.

#### IntelliSense no Styled Components

Normalmente, ao utilizar styled components, o IntelliSense não da sugestões de sintaxe CSS dentro de uma tag styled, por utilizar ` `` `.  
Para utilizar o IntelliSense com ele, existe uma extensão do VS Code chamada **VScode-Styled-Components**, do publicador **Styled Components**.

## Projeto: Clone da plataforma da DIO

Um projeto que implementa uma versão simplificada da plataforma da DIO, incluindo a página inicial, a página de login, e um feed principal para visualizar após o login.

- Criar o projeto utilizando `npx create-react-app`. Limpar os arquivos em excesso para ficar com um projeto base, deixando apenas os arquivos `index.js` `App.js` e `index.html`.
- Criar a estrutura de pastas com `pages` e `components`.
- Criar a pasta de `Button`, com os arquivos `index.js` e `styles.js`. 
    - Fazer a estilização do Button, através do styled components no arquivo `styles.js`.
    - Passar propriedades para o botão, através da sintaxe: `${}`, e definiar uma estilização alternativa utilizando a função `css` importada do styled components.
- Criar a pasta `Header`, com os arquivos `index.js` e `styles.js`.
    - Criar os componentes que compõem o Header: Header, Row, Column, Wrapper, BuscatInputContainer, Menu, MenuRight, UserPicture e Input.
    - Fazer a estilização de todos os componentes.
    - Montar o Header com todos os componentes.
- Criar a pasta `Home`, criando um arquivo `index.js`.
    - Inserir o Header na página
    - Montar a página com os componentes necessários.
- Criar uma pasta `styles` e criar um arquivo de estilo global `global.js`. O Styled Components trabalha de forma isolada com cada componente, o createGlobalStyles permite criar estilos globais para a aplicação.
    - Importar o estilo global no `index.js` principal.
- Criar a estilização da página Home, criando o arquivo `styles.js` na pasta `Home`
    - Criar os componentes da página Home com sua estilização.
    - Montar a página Home usando os componentes criados.
- Criar a pasta de `Input`, com os arquivos `index.js` e `styles.js`. 
    - Fazer a estilização do Input.
- Preparar a aplicação para ter mais de uma página através de rotas.
    - Instalar o pacote `react-router-dom` para definir as rotas.
    - Definir as rotas no arquivo `App.js` com o sguinte código:
    ```
    import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
    import { Home } from "./pages/Home";
    import { Login } from "./pages/Login";
    
    const App = () => {
        return (
            <Router>
                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/login" element={<Login />} />
                </Routes>
            </Router>
        );
    };

    export default App;
    ```
- Criar a tela de `Login`, que é bem parecida com a tela Home.
    - Inserir os Inputs na tela de login para criar o formulário de login.
    - Instalar o pacote `react-icons` para importar os ícones utilizados no formulário de login.
    - Inserir os ícones nos Inputs importando `react-icons/md` e utilizando os ícones dentro de tags.
- Criar um componente de `Card` para mostrar as informações dos posts no feed.
    - Criar a estilização dos componentes do Card.
    - Montar o card com os componentes dele.
- Criar um componente de `UserInfo` para mostrar as informações de progresso do usuário.
    - Criar a estilização dos componentes do UserInfo.
    - Montar o UserInfo com os componentes dele.
- Criar a tela de `Feed`, que será acessada pelo usuário após o login.
    - Inserir nela os Cards e os UserInfos na página.
    - Fazer a estilização da página.
    - Fazer a página de feed mostrar o usuário logado.
- Criar a navegação das páginas com os hooks do `react-router-dom`