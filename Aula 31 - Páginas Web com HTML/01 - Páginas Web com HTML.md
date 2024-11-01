## Como Funciona a Web

A Web é construída por 3 partes, que são necessárias para desenvolver páginas e sites:
- **HTML**: O HTML é a planta básica do site, que define a sua estrutura, dando orientações sobre o que são cada um dos componentes e elementos da página e onde eles se encontram.
- **CSS**: O CSS é o que dá forma ao site. Ele define as propriedades visual dos componentes da página, definindo as prorpiedades de estilo, de tamanho, cor, alinhamento, dentre outras propriedades visuais e de organização.
- **JavaScript**: O Javascript define as ações no site. Ele permite criar interações entre os usuários e os componentes do site, definindo as suas funções para que o site possa funcionar de fato.

Essas 3 "linguagens" são as que o navegador entende. Quaisquer páginas desenvolvidas em outras linguagens devem ser convertidas para HTML, CSS e JavaScript para poderem ser utilizadas em sites na Web.

### O que é HTML

O HTML é uma sigla que significa **HyperText Markup Language**, ou **Linguagem de Marcação de Hipertexto**.
O HTML é o componente básico da Web, permitindo inserir o conteúdo e estabelecer a estrutura básica do site. Ele serve para dar significado e organização às informações de uma página da Web.

Para criar um documento HTML, é necessário usar a extensão `.html` ou `.htm`. Com isso, o navegador faz a leitura do arquivo e renderiza o conteúdo para que o usuário possa visualizá-lo. Esses arquivos podem ser visualizados em qualquer navegador.  
Cada navegador interpreta a linguagem de uma maneira específica, por isso é importante testar os sites em mais de um navegador.

Normalmente um site é composto por diversas páginas HTML, sendo cada uma para cada página do site.  
As páginas consistem em uma série de tags, que podem ser considerados os blocos de construção das páginas. As tags são a maneira que o HTML faz a marcação dos conteúdos, criando a hierarquia e estrutura da página, dividindo o conteúdo em seções, parágrafos, cabeçalhos, dentre outros componentes.

## Trabalhando com HTML

Ao utilizar o Visual Studio Code, é possível utilizar a extensão nativa *Emmet Abbreviation* para montar a estrutura básica de um documento HTML.  
Para isso, basta digitar `Html:5` e selecionar a opção que aparece. Com isso, a estrutura a seguir é criada no editor:
```
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Primeira Pagina HTML</title>
    </head>
    <body>

    </body>
</html>
```
Essa estrutura é utilizada como base para a criação de páginas HTML.

### Tags

Cada uma das estruturas dentro dos símbolos `< >` são as tags, que definem os componentes do HTML. A tag é aberta utilizando `<[nome]>`, e é fechada utilizando `</[nome]>`. No meio da tag pode ser inserido o conteúdo dela, como por exemplo: `<p>Este é o conteúdo da tag p.<\p>`. Uma tag que não possui conteúdo pode ser aberta e fechada em um único comando utilizando `<[nome] />`.  
As tags possuem uma hierarquia, definida pela estrutura, onde algumas tags podem ser colocadas dentro de outras para se tornarem um componente interno da tag principal.

#### Tags da Estrutura Básica do HTML

- `<!DOCTYPE html>`: Essa tag é utilizada como um padrão para que o navegador consiga identificar que a página está usando o HTML 5.
- `<html lang="en">`: Inicia a página HTML. A linha `lang="en"` define o idioma utilizado pela página.
- `<head>`: Define o cabeçalho da página HTML. O cabeçalho fica invisível para o usuário.
- `<title>`: Define to título da página, que fica visível no navegador na aba em que a página foi aberta.
- `<body>`: O corpo da página, que contém todo o conteúdo que será mostrado para o usuário.

#### Tags de Conteúdo

Essas tags são utilizadas para adicionar conteúdo na página.
- `<h1>`: Tag de texto com ênfase. O texto aparece maior e fica mais distante do restante do corpo de texto. Utilizada para criar títulos e subtítulos no conteúdo. Essa tag pode ir desde o `h1` até o `h6`, onde quanto menor o número, maior a ênfase. Então `h1` seria o título principal, e os números maiores são subtítulos.
- `<p>`: Tag de parágrafo de texto. Ela permite inserir texto na página.
- `<a href=[site]>`: Tag que permite inserir um link na página, que leva a uma outra página. O atributo `href` é o que define para onde o link envia o usuário.
- `<hr>`: Adiciona uma divisão na página. Essa tag não precisa ser fechada.
- `<br>`: Adiciona uma quebra de linha. Essa tag não precisa ser fechada.
- `<ol>`: Define uma lista ordenada. Essa lista ordena os itens com um número.
- `<ul>`: Define uma lista não ordenada. Essa lista exibe todos os itens com um ponto.
- `<li>`: Define um item de uma lista.
- `<form>`: Define um formulário na página.
- `<input>`: Define os campos de entrada de dados em um formulário.
- `<textarea>`: Define uma área para o usuário digitar um texto.
- `<button>`: Define um botão na página.
- `<img>`: Permite inserir uma imagem na página. Essa tag tem um atributo `src` que recebe o link de fonte da imagem.

#### Tags de Organização

Essas tags são utilizada para organizar o código da página, permitindo criar seções e divisões para agrupar componentes relevantes.
- `<div>`: Tag que define uma divisão no conteúdo. Ela é utilizada para criar um bloco de conteúdo dentro do código para que 
- `<header>`: Define um cabeçalho na página, que fica visível para o usuário, diferente do `head`
- `<section>`: Define uma seção dentro do site.
- `<article>`: Define um artigo dentro do site.
- `<footer>`: Define um rodapé na página.
- `<nav>`: Define uma área de navegação, normalmente utilizada para criar menus.
- `<table>`: Define uma tabela na página.

#### Meta Tags

Essas tags são definidas dentro da tag `head` da página, e não ficam visíveis para o usuário. Elas são tags que descrevem o conteúdo do site para os buscadores. Nelas podem ser inseridas palavras-chave que facilitam encontrar a página ao buscar por ela.  
As meta tags são sempre abertas como `<meta>`, e elas possuem algumas propriedades que permitem definir algumas informações, como por exemplo:
- `<meta name="keywords" content="sites, web, html">`: Informa as palavras-chave que definem o conteúdo do site, o que ele quer passar para o usuário.
- `<meta name="description" content="Meta Tags - O que são e como utilizá-las">`: A descrição do site. Essa é a descrição que fica visível em um buscador de conteúdo (Como Google ou Bing), que aparece abaixo do título da página nos resultados.
- `<meta http-equiv="content-language" content="pt-BR">`: Informa o idioma utilizado pela página.
- `<meta http-equiv="content-type" content="text/html;charset=iso-8859-1">`: Indica qual o tipo de conteúdo da página e qual charset é utilizado.
- `<meta name="author" content="Edinaldo Silva">`: Indica quem é o autor da página.
- `<meta http-equiv="refresh" content="5;url=http://www.novapagina.com">`: Define um redirecionamento para uma outra página. O número no início é o tempo até que o refresh seja feito, e a url é a nova página que será carregada.

### Listas

As listas são muito utilizadas para listar itens dentro do site, além de também serem usadas para criar menus de navegação.

Existem 3 tipos principais de listas em HTML:
- Lista ordenada
- Lista Desordenada
- Lista por Definição

As listas ordenadas identificam os itens com uma série de caracteres ordenados, do menor para o maior. Por padrão, esses caracteres são números.  
As listas ordenadas possuem algumas propriedades que permitem alterar sua funcionalidade:
- `start`: Define em qual posição a lista começa
- `type`: O tipo de caractere usado para a ordenação, podendo ser `1` `A` `a` `I` e `i`.

As listas desordenadas utilizam apenas um caractere para marcar os itens da lista. Por padrão, esse marcador é um ponto, mas é possível customizá-lo.

É possível também colocar uma lista dentro da outra, abrindo uma nova lista dentro de uma tag `<li></li>` de uma lista existente.

A lista por definição é uma lista que possui título e conteúdo, utilizando diferentes níveis de hierarquia.  
Ela é definida através de 3 tags:
- `<dl>`: Define uma lista por definição.
- `<dt>`: Define o título de um item da lista.
- `<dd>`: Define o conteúdo de um item da lista.

### Tabelas

As tabelas do HTML são listas de dados em duas dimensões: compostas por linhas e colunas. Elas são muito utilizadas para apresentar dados de forma organizada.

As tabelas são definidas pela tag `<table>`. Ela pode aceitar diversas propriedades, como por exemplo `border`, que define a espessura da borda da tabela.

O HTML 5 trouxe algumas convenções para definir cada uma das partes da tabela, sendo elas `<thead>`, `<tbody>` e `<tfooter>`.

A tabela possui diversas tags para definir suas linhas e células:
- `<tr>`: Define uma linha na tabela.
- `<th>`: Define o título de uma coluna na tabela. Essa tag deve ser colocada dentro de uma linha.
- `<td>`: Define o conteúdo de uma coluna na tabela. Essa tag deve ser colocada dentro de uma linha. Essa tag tem uma propriedade `colspan`, que define quantas colunas serão usadas nessa célula.

### Formulários

Um formulário em HTML é um campo ou um conjunto de campos de preenchimento de dados ou de ações que permite que o usuário insira dados ou interaja com a página de alguma maneira.  
Esses campos podem ser textos, caixas de seleção, botões, radio buttons ou checkboxes utilizando tags do HTML.

Um formulário é definindo pela tag `<form>`, junto com as tags dos componentes que existem dentro dele. Podem ser usadas diversas tags dentro de um formulário.

A tag `<form>` possui algumas propriedades importantes, dentre elas: `action` define o que será feito quando o usuário clicar no botão de enviar, incluindo o local aonde os dados serão enviados, e `method` define qual será o método de envio das informações, sendo que `get` coloca as informações na URL da página, e `post` envia as informações no corpo da requisição HTTP.

Alguns componentes possuem uma propriedade `id`, que é usado para identificar esse componente dentro do código, tanto no HTML como em outros códigos que possam acessar o componente. Esse id deve ser único na página toda.

A tag `<label>` é vinculada a um componente existente na página, recebendo seu id. Ela exibe um texto na página, e ao clicar nela, ela muda o foco para o componente vinculado a ela.

### HTML Semântico

O HTML semântico é uma forma de deixar o site com as informações bem explicadas e compreensíveis para o computador. Isso pode ajudar o entendimento de leitores de acessibilidade e de mecanismos de busca.  
Ele também deixa o código mais limpo e compreensível, tanto na organização como na facilidade de reconhecer uma tag com um olhar rápido.

O HTML Semântico usa tags autodescritivas, que facilitam o entendimento de a que parte do site aquela tag se refere. Em vez de utilizar tags `<div>` para todas as seções da página, as tags usadas são tags como `<header>`, `<nav>`, `<main>`, `<figure>`, `<section>`,`<footer>`, dentre outroas.

![HTML Semantico](Semantic-HTML.png)

### Documentação

É possível ver todas as tags disponíveis no HTML, além de suas propriedades e como utilizá-las, através da sua documentação, disponível no site `https://www.w3schools.com/html/`