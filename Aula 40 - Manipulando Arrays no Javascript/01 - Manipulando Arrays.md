## Funções de Manipulação de Array

### Map

O método **Map** é um método que faz uma operação em um array, resultando em um segundo array com os valores transformados pela operação.  
Ele pode ser visto de forma similar a conjuntos matemáticos, onde um conjunto A tem uma função aplicada a ele, se tornando um conjunto B com os novos valores dos elementos.

O método Map cria um novo array com os resultados, e não modifica o array original.  
Ela realiza as operações em ordem, começando pelo primeiro elemento do array e indo até o último.

O método Map pode ser utilizado pela sintaxe a seguir: `nomeDoArray.map(callbackFunction, thisValue)`
- `nomeDoArray`: O nome do array no qual a função será aplicada.
- `callbackFunction`: `function(item, index, array)` A função que será aplicada a cada elemento do array. Ela possui 3 parâmetros:
    - `item`: O elemento atual sobre o qual a função será aplicada.
    - `index`: O índice do elemento atual.
    - `array`: O array do elemento atual.
- `thisValue`: Um valor passado para a função para ser usado como o `this`. Com ele, é possível passar um objeto para a função que contenha valores diferentes dependendo do contexto.

Exemplo de Map:
```
const numeros = [1,2,3];
numeros.map(item => item * 2);
// Retorno: [2,4,6]
```

O `map` é bem parecido com o método `forEach`, a diferença sendo que o map retorna um novo array com os valores alterados.

### Filter

O método **Filter** utiliza um filtro para retorna apenas os valores do array que correspondem à condição do filtro.

Assim como o Map, o Filter retorna um novo array com os valores que correspondem ao filtro, e não altera o array original.

A sintaxe dele é bem próxima do método Map: `nomeDoArray.filter(callbackFunction, thisValue)`

Exemplo de filter:
```
const frutas = ['maçã fuji', 'maçã verde', 'laranja', 'abacaxi'];
frutas.filter(item => item.includes('maçã'));
// retorno: ['maçã fuji', 'maçã verde'];
```

### Reduce

O método **Reduce** é um método que executa uma função em todos os elementos do array e retorna um único valor. Ele basicamente reduz um array a um único valor.

O método reduce funciona utilizando uma variável acumuladora, que armazena o valor de retorno conforme o array é processado pela função.

A sintaxe dele é parecida com os métodos map e filter, mas difere em algumas coisas: `nomeDoArray.reduce(callbackFunction, initialValue)`
- `nomeDoArray`: O nome do array no qual a função será aplicada.
- `callbackFunction`: `function(accumulator, item, index, array)` A função que será aplicada a cada elemento do array. Ela possui 4 parâmetros:
    - `accumulator`: O valor de retorno do método, que acumula o valor de todas as chamadas da função callback.
    - `item`: O elemento atual sobre o qual a função será aplicada.
    - `index`: O índice do elemento atual.
    - `array`: O array do elemento atual.
- `initialValue`: Um valor inicial sobre o qual o retorno será processado. Esse parâmetro é opcional, possibilitando alterar o resultado final. Caso ele não seja passado

Exemplo de reduce:
```
const valores = [1,2,3,4,5,6,7,8,9];
valores.reduce(((total, item) => total + item), 0);
// retorno: 45;
// O retorno é a soma de todos os valores.
```