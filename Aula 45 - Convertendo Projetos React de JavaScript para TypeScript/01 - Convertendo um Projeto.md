## Converter um Projeto de JavaScript para TypeScript

Primeiro, é necessário instalar alguns pacotes:
`npm install typescript @types/node @types/react @types/react-dom @types/jest -D`

Como o TypeScript é uma linguagem que trabalha em cima do JavaScript, ele só é utilizado em ambiente de desenvolvimento. Após o código ser desenvolvido, ele é convertido em JavaScript para ir para ambiente de produção.

Após instalar o TypeScript, é necessário iniciá-lo no projeto, através do comando `npx tsc --init`. Isso executa todas as condifurações necessárias, criando o arquivo `tsconfig.json`.

A documentação do TypeScript pode ser acessada em `typescriptlang.org/docs/`.

### Mudar a Extensão dos Arquivos

Para utilizar o TypeScript, é preciso renomear os arquivos, mudando a extensão `.js`, do JavaScript, para `.ts`, do TypeScript. Os arquivos `.jsx` também devem ser alterados para `tsx`.

O Styled Components possui uma biblioteca própria para a tipagem com TypeScript, para adicioná-la, o comando é `npm install @types/styled-components -D`.

Após mudar a extensão dos arquivos, provavelmente aparecerão alguns erros de tipo. Basta consertar os erros, tipando os elementos de forma correta, para converter o projeto.

### Tipar os Componentes

Criar um arquivo `types.ts` dentro de cada componente.  
Criar uma interface do tipo do componente, definindo o tipo de cada um dos parâmetros passados para o componente. Por exemplo:

```
// Componente
export const Button = (title, variant, onClick) = {
    return <button title={title} variant={variant} onClick={onClick} />
}

// Interface
export interface IButton {
    title: string;
    variant: string;
    onClick: () => void;
}

// Componente Implementando a Interface
export const Button = ({title, variant, onClick}: IButton) = {
    return <button title={title} variant={variant} onClick={onClick} />
}

```

Para adicionar um tipo a um componente do Styled Components, ele deve ser passado ao declarar o tipo de tag HTML do componente:

```
// Componente do Styled Components
export const ButtonContainer = styled.button`
    // CSS
`

// Interface
export interface IButtonStyled {
    variant: string;
}

// Componente do Styled Components Implementando a Interface
export const ButtonContainer = styled.button<IButtonStyled>`
    // CSS
`
```

Para saber o tipo de um elemento, é possível passar o mouse sobre ele dentro de um arquivo TypeScript, e o tipo será mostrado. Com isso, é possível copiá-lo para definir em uma interface.  
Isso é útil para, por exemplo, descobrir o tipo de elementos HTML.

### Tipar Arquivos da pasta assets

Ao importar arquivos de assets, como imagens, o TypeScript não reconhece o arquivo como um módulo.

Para reconhecer o arquivo, deve ser criado um tipo global: Criar uma pasta `@types`, onde serão colocados os arquivos de tipagem global.  
No caso de imagens PNG, o arquivo pode ser:

```
image.d.ts:

declare module "*.png";
```
