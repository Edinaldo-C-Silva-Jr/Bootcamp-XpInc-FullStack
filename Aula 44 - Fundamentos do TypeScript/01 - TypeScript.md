## O que é o TypeScript?

TypeScript é um superset de JavaScript, ou seja, um conjunto de ferramentas e formas eficientes de escrever código JavaScript, adicionando recursos que não existem de maneira nativa no JavaScript.

O TypeScrypt foi desenvolvido pela Microsoft em 2012, com o objetivo de adicionar recursos e ferramentas à linguagem JavaScript, como tipagem estática (tipos de variáveis sendo definidos explicitamente no código) e orientação a objetos.  
O TypeScript não age no produto final, ele age no ambiente de desenvolvimento, no momento de escrever o código.

### Por que usar o TypeScript?

O TypeScript traz diversos benefícios, com os principais sendo o potencial de detectar erros durante o desenvolvimento de projetos e a possibilidade de incluir inteligência na IDE. Com isso o ambiente de desenvolvimento fica mais ágil e seguro.

Com o TypeScript, é possível detectar erros no código durante o desenvolvimento, em vez de precisar esperar até o código estar executando no navegador para que o erro apareça. Ele também permite validar as variáveis através do tipo.

Além de ser uma linguagem fortemente tipada, ele também traz vários conceitos da orientação a objetos, como: classes, heranças, encapsulamento, interfaces, dentre outros.

### Conceitos Básicos de TypeScript

#### Tipagem Estática

O TypeScript permite definir o tipo de uma variável. A sintaxe utilizada é:

```
const nome: string = "João";
const idade: numer = 20;
const ativo: boolean = false;
```

A partir do momento que o tipo da variável é definido, ela será sempre daquele tipo. Com isso, ao tentar atribuir um valor de um tipo diferente a ela, a IDE já aponta um erro.  
O tipo também define as regras que se aplicam a algumas variáveis, como por exemplo, comparações só podem ser feitas com tipos válidos.

#### Inferência de Tipo

O TypeScript permite inferir o tipo da variável com base no valor atribuídos a ela.  
A partir do momento que uma variável tem seu tipo inferido, ela sempre será daquele mesmo tipo.

#### Interface

As interfaces permitem definir um padrão de dados para um certo tipo de objeto. Sempre que um objeto desse tipo for criado, ele deve seguir o padrão estabelecido.

```
interface IUsuario {
    nome: string;
    idade: number;
    ativo: boolean;
}

const usuario: IUsuario = {
    nome: "João",
    idade: 20,
    ativo: true
}
```

Caso o objeto não siga o padrão estabelecido pela interface, a IDE aponta um erro.  
A IDE também informa os atributos necessários ao passar o mouse sobre o nome da interface.

#### Type

Um Type permite definir um padrão para um certo tipo de objeto. Ele é bem parecido com uma interface, mas possui algumas diferenças com base no uso.

#### Enum

Os enumeradores representam um grupo de constantes. Com eles é possível definir um grupo de valores com um nome descritivo para referenciar cada um deles.

```
enum CARGO {
    DESENVOLVEDOR = "desenvolvedor";
}

const usuario = {
    nome: "João";
    cargo: CARGO.DESENVOLVEDOR;
}
```
