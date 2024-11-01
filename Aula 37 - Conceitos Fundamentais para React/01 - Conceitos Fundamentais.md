### JSX

A sintaxe JSX é uma forma de criar elementos para utilizá-los como templates em aplicações React. Ela é bem similar ao código HTML, e fornece aos desenvolvedores uma forma simples e intuitiva de criar componentes.

No exemplo do projeto desenvolvido anteriormente, o bloco 
```
        <div className="App">
            <h1>Hello World!</h1>
        </div>
```
dentro do App.js é um código JSX, que é retornado dentro de uma função JavaScript.

O JSX possui um componente pai, que deve envolver todos os outros componentes. Somente um componente pode ser retornado pela função HTML, portanto deve haver uma tag principal que possui todas as outras tags dentro dela. Normalmente a tag pai é uma `<div>`.

É possível utilizar código JavaScript dentro das tags do JSX colocando o código dentro de chaves `{ }`.  
É possível também aninhar tags dentro desse código, criando uma interação do JavaScript com o HTML na aplicação. Por exemplo:
```
const App = () => {
    const array = [1,2,3,4,5,6,7,8,9]
    return (
        <div className="App">
            <h1>Hello World!</h1>
            {array.map(item => {
                return (
                    <p>
                        {item} * 5 = {item * 5}
                    </p>
                );
            })}
        </div>
    );
};

export default App;
```
Esse código faz os cálculos em JavaScript, depois renderiza na tela através do HTML.

### Componentes de Classe e Funcionais

Os componentes de classe são componentes que devem ser criados dentro de uma classe.  
A classe deve ser criado estendendo de Component, do React. Ela precisa definir os estados que a aplicação pode ter, e para renderizar o componente, ela deve definir um método `render`, onde o código do componente deve ser colocado e retornado.
```
import React, { Component } from "react";

class App extends Component {
    state = {
        usuarios: ["João", "José", "Maria"],
    };

    render() {
        const { usuarios } = this.state;
        return (
            <div className="App">
                <h1>Hello World!</h1>
                {usuarios.map((item) => (
                    <p>{item}</p>
                ))}
            </div>
        )
    }
}
```

Nos componentes funcionais, não é necessário usar uma classe. Eles definem o componente através de uma função, e trata o estado através de um hook `useState`.  
O `useState` é uma função que recebe o valor inicial do estado, que pode ser de qualquer tipo de dado. Ele retorna um array com dois parâmetros: o primeiro é o estado atual, e o segundo é uma função para mudar o valor do estado. O estado só pode ser alterado através dessa função, ele não pode ser acessado diretamente.  
Um componente funcional não precisa de um método `render`, pois ele é uma função e retorna um valor.

```
import React, { useState } from "react";

const App = () => {
    const [usuarios, serUsuarios] = useState(
        ["João", "José", "Maria"]
    );

    return (
        <div className="App">
            <h1>Hello World!</h1>
            {usuarios.map((item) => (
                <p>{item}</p>
            ))}
        </div>
    )
}
```

### Ciclo de Vida

Quando alguma alteração é feita em um estado de um componente, o componente é renderizado novamente na tela. A renderização acontece no componente que contém aquele estado.  

É possível fazer alterações na aplicação quando um componente entra em tela, através do hook `useEffect`.  
O `useEffect` é uma função que recebe dois parâmetros: O primeiro é uma função, e o segundo é um array de dependências.   
A função define qual função será executado quando o método for chamado.  
O array de dependências define quando o método será executado. Toda vez que um dos estados dentro do array de dependências é alterado, o método é executado.  
É possível também retornar uma função no `useEffect`, que é executada quando o componente é desmontado.