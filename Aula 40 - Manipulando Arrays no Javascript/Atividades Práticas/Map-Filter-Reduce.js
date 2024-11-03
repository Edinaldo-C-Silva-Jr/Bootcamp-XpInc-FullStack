/*
Atividade 01 - Map

Pratique a sintaxe de multiplicação de números.
Uma vez utilizando o parâmetro this de um objeto criado por você, e depois sem ele.
*/

// Sem this
const numerosMap = [1, 2, 3, 4, 5];
console.log(
    `Array multiplicado por 2: ${numerosMap.map((numero) => numero * 2)}`
);
console.log(`Array original inalterado: ${numerosMap}`);
console.log("------------------");

// Com this
const multiplicador3 = { value: 3 };
const multiplicador4 = { value: 4 };
const multiplicador5 = { value: 5 };

const numerosMapThis = [1, 2, 3, 4, 5];

mapComThis(numerosMapThis, multiplicador3);
mapComThis(numerosMapThis, multiplicador4);
mapComThis(numerosMapThis, multiplicador5);
console.log(`Array original inalterado: ${numerosMapThis}`);
console.log("------------------");

function mapComThis(numeros, thisValue) {
    console.log(
        `Array multiplicado com This: ${numeros.map(function (numero) {
            return numero * this.value;
        }, thisValue)}`
    );
}

/*
Atividade 02 - Filter

Filtre e retorne todos os números pares de um array.
*/

const numerosFilter = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

console.log(
    `Números filtrados por pares: ${numerosFilter.filter(
        (numero) => numero % 2 === 0
    )}`
);
console.log(`Array original inalterado: ${numerosFilter}`);
console.log("------------------");

/*
Atividade 03 - Reduce

1. Some todos os números de um array.
2. Crie uma função que recebe uma lista de preços e um número representando o saldo disponível.
Calcule qual será o saldo final após subtrair todos os preços da lista enviada.
*/

// Somar Números
const numerosReduce = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

console.log(`Array original: ${numerosReduce}`);
console.log(
    `Valor do array somado com reduce: ${numerosReduce.reduce(
        (total, numero) => total + numero,
        0
    )}`
);
console.log("------------------");

// Lista de Preços
const precos = [5, 15, 25, 35];
const saldo = 100;

console.log(`Saldo inicial: ${saldo}. Lisa de preços: ${precos}`);
console.log(
    `Saldo após subtrair o preço: ${precos.reduce(
        (total, numero) => total - numero,
        saldo
    )}`
);
console.log("------------------");
