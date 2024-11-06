## O que são Hooks

Até o React 16.7, só era possível acessar algumas funcionalidades, como o ciclo de vida, através de classes. Mesmo após a adição dos Componentes Funcionais, que permitem criar componentes em funções, sem depender de uma classe, ainda haviam algumas funcionalidades do React que só ficavam disponíveis através de Componentes de Classe. Os componentes funcionais só podiam receber propriedades.

Assim, na versão 16.8 do React, fora criados os Hooks. OS hooks são funções que permitem usar vários recursos do React de forma simples através de funções, assim dando acesso ao restante das funcionalidades do React aos componentes funcionais.

### useState

O `useState` é um hook que permite lidar com estado dentro de um componente.  
O estado é uma propriedade que armazena o estado de algum comportamento dentro do componente. 

Por exemplo, um componente de Input pode ter um estado que guarda o texto que está escrito nele.

O `useState` recebe um parâmetro:
- `initialState`: O valor que o estado tem inicialmente, ao ser instanciado.

O `useState` retorna um array com dois valores:
- `state`: O valor do estado.
- `setState`: Uma função que permite alterar o valor do estado. O estado é imutável, então a única maneira de alterá-lo é através dessa função.

### useEffect

O `useEffect` é um hook que trabalha com o ciclo de vida de um componente.  
Cada componente tem o seu ciclo de vida, que marca os momentos antes, durante e após ele ser renderizado, e também o antes, durante e após ele ser desmontado.

O `useEffect` permite gerenciar o ciclo de vida de um componente, executando algum código quando ocorre uma mudança em alguma de suas dependências.

O `useEffect` recebe dois parâmetros:
- `effectCallback`: Uma função que executa algum código.
- `dependencies`: O array das dependências do `useEffect`. Essas dependências definem os componentes que fazem o `useEffect` executar novamente.  
Se o array estiver vazio, ele só executa uma vez. Se nenhum array for passado, ele executa em toda renderização.

O `useEffect` não tem retorno.

### useMemo

O `useMemo` é um hook que memoriza um cálculo ou valor. Isso evita que essa ação ou cálculo seja refeito toda vez que o componente for renderizado.

O `useMemo` recebe dois parâmetros:
- `memoCallback`: Uma função que executa algum código.
- `dependencies`: O array das dependências do `useMemo`. Essas dependências definem os componentes que fazem o `useMemo` executar novamente.

O `useMemo` retorna uma referência de valor.

### useCallback

O  `useCallback` é um hook que memoriza uma função. Ele é bem parecido com o `useMemo`.

O `useCallback` recebe dois parâmetros:
- `callbackFunction`: Uma função que executa algum código.
- `dependencies`: O array das dependências do `useCallback`. Essas dependências definem os componentes que fazem o `useCallback` executar novamente.

O `useCallback` retorna uma referência de função.