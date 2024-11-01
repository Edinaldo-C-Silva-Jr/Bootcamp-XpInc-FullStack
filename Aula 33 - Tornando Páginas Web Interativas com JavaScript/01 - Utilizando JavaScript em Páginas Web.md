## O que é JavaScript

JavaScript é uma linguagem de programação criada por Brandan Eich a pedido da empresa Netscape, por volta de 1995. O JavaScript inicialmente era chamado de LiveScript.  
A empresa SUN Microsystems se interessou pela linguagem e se juntou ao desenvolvimento dela.

Embora possua "Java" no nome, o JavaScript é uma linguagem completamente diferente do Java. A mudança de nome ocorreu por causa da influência da SUN, criadora da linguagem de programação Java.

A ideia da web é funcionar igualmente para todos. Para manter um padrão, em 1996 a Netscape enviou o JavaScript à ECMA International, uma associação fundada em 1961 para padronização de sistemas de informação. Já que o nome JavaScript pertencia à SUN, a linguagem foi registrada com um novo nome: ECMAScript. Porém, o nome JavaScript era tão famoso que continua sendo usado até hoje.

O JavaScript é uma linguagem de programação de alto nível para ser executada em navegadores e manipular comportamentos de páginas web. Com is scripts é possível incluir elementos dinâmicos em uma página estática, como mapas, formulários, operações numéricas, animações, infográficos interativos e mais.

O HTML é responsável por montar a estrutura da página Web, o CSS faz a estilização da página, já o JavaScript é o que faz a página funcionar.

### Operações Básicas

Os operadores aritméticos são utilizados para a realização de cálculos simples.

- `+` - Soma
- `-` - Subtração
- `*` - Multiplicação
- `/` - Divisão
- `%` - Módulo
- `++` - Incremento
- `--` Decremento

### Condicionais

As estruturas condicionais executam tomadas de decisões, utilizando expressões que retornam verdadeiro ou falso para executar blocos específicos de código.  
No JavaScript, existem 4 estruturas condicionais básicas, sendo elas **if**, **else**, **switch** e **ternário**.

#### Operadores Lógicos

São os operadores de comparação utilizados dentro dos condicionais:
- `&&` - Operador **AND**: Faz uma avaliação de duas condições, e retorna verdadeiro caso ambas sejam verdadeiras.
- `||` - Operador **OR**: Faz uma avaliação de duas condições, e retorna falso caso ambas sejam falsas.
- `==` - Operador **Igual Duplo**. Executa uma comparação de valor sem considerar o tipo. Por exemplo: `1 == '1'` retorna verdadeiro, pois o valor em ambos é 1.
- `===` - Operador **Igual Triplo**. Executa uma comparação de valor e de tipo, retornando verdadeiro somente se o valor e o tipo forem o mesmo. Por exemplo `1 == '1'` retorna falso, pois embora o valor seja 1, os tipos são diferentes (int e string).
- `!=` - Operador **Diferente Duplo**. Compara dois valores e retorna verdadeiro se eles forem diferentes. Assim como o igual duplo, ele não considera o tipo.
- `!==` - Operador **Diferente Triplo**. Compara dois valores e retorna verdadeiro se eles forem diferentes. Assim como o igual triplo, ele considera o tipo.
- `>` - Operador **Maior**. Verifica se o primeiro valor é maior que o segundo.
- `<` - Operador **Menor**. Verifica se o primeiro valor é menor que o segundo.

### Tipos de Variáveis

As variáveis são nomes simbólicos para valores usados na aplicação. Os nomes identificadores das variáveis, em JavaScript, devem começar com uma letra ou underline `_`, com demais caracteres podendo ser números.  
O JavaScript é case-sensitive, portanto diferencia variáveis com letras maiúsculas e minúsculas.

Há 3 maneiras de declarar variáveis em JavaScript:
- **var** - Declara uma variável, que pode ter sei valor alterado. Uma variávei declarada com var tem escopo de função, podendo ser acessada em qualquer lugar da função na qual ela foi declarada. Uma var pode ser redeclarada dentro do mesmo escopo.
- **let** - Declara uma variável, que pode ter sei valor alterado. Uma variávei declarada com let tem escopo de bloco, podendo ser acessada apenas dentro do bloco (delimitado por `{ }`) no qual ela foi declarada. Uma let não pode ser redeclarada dentro do mesmo escopo.
- **const** - Declara uma constante, que é uma variável que não pode ter seu valor alterado.

### Laços de Repetição

OS laços, ou loops, permitem a execução de um emsmo bloco de código mais de uma vez, com base em uma condição.  
Existem 4 tipos de laços de repetição no JavaScript: 

- **while**: Recebe uma condição e executa o laço enquanto a condição continuar sendo verdadeira.
- **for**: Utiliza uma variável de contador e uma condição envolvendo o contador. Incrementa o contador automaticamente a cada execução, e continua executando até que a condição seja falsa.
- **foreach**: Esse laço é uma função utilizada em um array. Ele pega cada elemento do array e executa um bloco de código com esse elemento.
- **map**: Esse laço é uma função utilizada em um array. Ele pega cada elemento do array, executa um bloco de código com esse elemento, e depois retorna um novo array com os novos elementos.

### Functions

Uma função é um bloco de código que pode ser chamado por um código externo (ou interno) a ela. A função é composta por uma sequência de instruções chamada de corpo da função. Ela pode receber valores através de parâmetros, e retornar um valor ao fim de sua execução.

```
function Soma (numero1, numero2) {
    return numero1 + numero2;
}
```

#### Arrow Functions

A versão do ECMA Script 2015 trouxe uma nova forma mais sucinta de trabalhar com funções, chamada Arrow Functions. Ela utiliza uma sintaxe que lembra uma flecha: `() => {}`.
```
const soma = (numero1, numero2) => {
    return numero1 + numero2;
}
```

Uma Arrow Function não possui um nome, mas pode ser armazenada dentro de uma variável.

As Arrow Functions são feitas para escrever funções pequenas de forma sucinta, portanto elas são melhor utilizadas em funções pequenas, com poucas instruções.  
Elas também possuem um return implícito, portanto é possível declará-las apenas passando o bloco de código, que nesse caso deve ser obrigatoriamente uma única instrução.
```
const soma = (numero1, numero2) => numero1 + numero2;
```

### Array

Um array é uma lista de objetos. Eles são objetos que contém múltiplos valores armazenados em uma lista. Um array pode ser armazenaod em uma variável para ser tratado de forma similar a outros valores, mas cada um dos seus itens pode ser acessado individualmente.

Um array pode ser criado com qualquer tipo de variável, incluindo objetos criados a partir de alguma classe. Os arrays em JavaScript podem receber valores de tipos diferentes.

O JavaScript ES6 (De 2015) adicionou muitas novas funcionalidades para a linguagem. Algumas delas ajudam a manipular arrays, como por exemplo:

- **filter**: O filter passa por todos os itens to array, retornando um novo array com os valores dele, similar ao map. Porém, o filter recebe uma condição, e retorna apenas os objetos que satisfazem a condição.
- **find**: Passa pelos itens de um array e retorna um único item, com base em uma condição. Ele retorna apenas o primeiro item que satisfaz a condição.
- **findIndex**: Passa pelos itens de um array e retorna um único item, com base em uma condição. Ele retorna o índice do primeiro item que satisfaz a condição.
- **reduce**: Utilizado para reduzir um array a um único valor, executando a arrow function passada para cada elemento. A arrow function deve utilizar uma variável acumuladora que será retornada ao final da execução.
- **some**: Aplica uma condição aos elementos do array, e retorna true caso algum elemento satisfaça a condição.
- **every**: Aplica uma condição aos elementos do array, e retorna true somente se todos os elementos satisfaçam a condição.

### Console do Navegador

Ao apertar o F12 e abrir as ferramentas de desenvolvedor do navegador da web, é possível acessar o console. Dentro dele, é possível executar comandos JavaScript.