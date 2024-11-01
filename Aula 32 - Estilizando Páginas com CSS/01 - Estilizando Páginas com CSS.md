## O que é o CSS

CSS é uma sigla que significa Cascasing Style Sheet. Ele é usado para estilizar elementos em páginas web.  
O CSS separa o conteúdo do site de sua representação visual, permitindo decorar a página de maneira mais flexível. Ele permite alterar a cor do texto, cor de fundo, fonte, espaçamento, criar tabelas, mudar o layout da página, ajustar imagens, e muitas outras utilidades.

O CSS é uma folha de estilo em cascata. Quanto o navegador interpreta um arquivo CSS, ele lê o arquivo de cima para baixo, em ordem. Com isso, é possível sobrescrever estilos anteriores com outros localizados mais abaixo no arquivo.

A sintaxe do CSS é baseada em alguns elementos:
- Seletor: Define o que será selecionado na página para editar. Pode-se utilizar um asterisco `*` para afetar toda a página.
- Estilo: Os valores passados dentor de chaves `{ }` depois do seletor, que são aplicados aos componentes da página selecionados.

### Seletores

Seletores são usados para direcionar os elementos HTML da página que serão estilizados em um bloco. Há uma grande variedade de seletores CSS disponíveis, permitindo refinar a seleção de elementos que serão estilizados.

Os seletores podem ser:
- **Tipo**: Seletores de tipo selecionam uma tag HTML. Ao selecionar a tag HTML para estilização, o estilo é aplicado em todas as instâncias daquela tag que existem dentro de uma página.
- **Classe**: Seletores de classe selecionam uma classe. As classes são identificadas por um ponto antes do nome, e o estilo é aplicado para todas as instâncias daquela classe dentro da página.
- **ID**: Os seletores de ID selecionam um componente por seu identificador único. Com isso o estilo aplicado apenas àquele componente.
- **Seletores de Atributos**: Os seletores de atributos recebem um componente com o seu atributo, e aplicam o estilo apenas aos componentes que possuem aquele atributo especificamente.

### Box Models

Em uma página Wevm cada elemento é representado como uma caixa retangular (box). O mecanismo de renderização tem como objetivo determinar o tamanho, posição e propriedades desses boxes.

No CSS, cada um dos boxes de um componente é descrito usando um box model padrão. Este podemo descreve o conteúdo do espaço ocupado por um elemento. Cada box possui 4 edges: Margin Edge, Border Edge, Padding Edge e Content Edge.  
O Padding é um espaçamento que existe dentro da borda da caixa, enquanto que o Margin é um espaçamento que fica fora da borda da caixa. O Content é o conteúdo do componente.

![BoxModels](CSS-BoxModels.png)

### FlexBox

O Flexbox foi projetado como um modelo de layout unidimensional, e como um método capaz de organizar os elementos em uma interface, além de possuir capacidades de alinhamento.  
Quando se diz que o flexbox é unidimensional, há ênfase no fato de ele lidar com o layout em uma dimensão de cada vez: ou uma linha, ou uma coluna.

Ao utilizar o flexbox, todas as operações realizadas se relacionam a dois eixos: O eixo principal e o eixo transversal. O eixo principal é definido através da propriedade `flex-direction` e o eixo transversal é perpendicular a ele.  
A `flex-direction` define o eixo que tem a estilização principal. Se for definida como `row`, a orientação é em linha, e em `column`, a oriendação é em coluna.

Para utilizar a FlexBox, é necessário criar uma seção ou divisão, e então definir em suas propriedades no CSS: `display: flex`. Com isso, essa divisão terá o estilo de FlexBox habilitado.  
Após definir o estilo na divisão principal, em cada componente dentro dela, também é necessário definir `display: flex`, para que a formatação se aplique a cada um deles. Com isso, é possível estilizar o alinhamento dos componentes utilizando propriedades como `align-items`, `justify-content`, `margin` e `padding`.

### Pseudo-Classes e Elementos

Uma pseudo-classe em CSS é uma palavra-chave adiconada a um seletor para especificar um estado específico do elemento selecionado. Por exemplo, `:hover` é uma pseudo-classe usada para estilizar um botão quando o usuário passar o cursor sobre ele.

### Media Queries

Media Queries são a utilização de Media Types com expressões envolvendo características de uma mídia (dispositivo) para definir formatações para cada dispositivo. Os navegadores lêem essas expressões e, caso o dispositivo em questão se encaixe nas requisições, o CSS será aplicado.

Os media types definem para qual tipo de media o código CSS é direcionado. O HTML pode ser lido e interpretado por qualquer dispositivo, mas cada dispositivo o exibe de uma maneira, devido a fatores como a dimensão da tela. Um site não tem a mesma aparência em um computador e em um celular.

Para utilizar uma Media Query, basta colocar `@media` e uma condição. Com isso, o estilo dentro do bloco só será utilizado quando a mídia atual se enquadrar nessa condição.
```
body {
    background-color: #0000FF
}

@media (max-width: 450px) {
    body {
        background-color: #00FF00
    }
}
```

Nesse exemplo, a cor de fundo muda dependendo do tamanho máximo da tela.

## Trabalhando com CSS

O CSS pode ser definido dentro de uma tag `<style>`, inserida na `<head>` da página HTML. Porém, normalmente ele é definido em um arquivo separado, para facilitar a organização do projeto.

Dentro da tag `<style>`, cada componente pode ser definido, passando as propriedades de estilo que se deseja aplicar a eles, como por exemplo:
```
body {
    margin: 0;
    padding: 0;
    background-color: #8559A1;
    color: #F1F991
}
```
Esse bloco retira a margem do conteúdo do body da página, e define uma cor para o fundo e para a fonte usada na página.

Para utilizar uma classe em um componente, basta adicionar a classe como um atributo do componente:
```
<input type="text" id="nome" class="inputs"></input>
```

