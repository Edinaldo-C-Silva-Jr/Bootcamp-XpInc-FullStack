// Operadores Aritméticos
const valor1 = 10;
const valor2 = 20;

console.log("Soma:", valor1 + valor2);
console.log("Subtração:", valor1 - valor2);
console.log("Multiplicação:", valor1 * valor2);
console.log("Divisão:", valor1 / valor2);

// If - Else
const idade = 25;

if (idade >= 18) {
    console.log("Maior de idade.");
} else {
    console.log("Menor de idade.")
}

// Switch
const opcao = 1;

switch(opcao){
    case 1:
        console.log("Opcão 1 selecionada.");
        break;
    case 2:
        console.log("Opcão 2 selecionada.");
        break;
    case 3:
        console.log("Opcão 3 selecionada.");
        break;
    case 4:
        console.log("Opcão 4 selecionada.");
        break;
}

// Ternário
const nota = 9;

nota > 5 ? console.log("Aprovado") : console.log("Reprovado");

// For
for (let i = 0; i < 10; i++) {
    console.log("For:", i);
}

// While
let i = 0;
while(i < 10) {
    console.log("While:", i);
    i++;
}

// Foreach
let foreachIs = [1,2,3,4,5,6,7,8,9,10];
foreachIs.forEach(value => {
    console.log("Foreach:",value);
});

// Map
let mapIs = [1,2,3,4,5,6,7,8,9,10];
mapIs = mapIs.map(value => {
    return value;
});
console.log("Map:", mapIs);

// Arrow Function
const somar = (numero1, numero2) => {
    return numero1 + numero2;
}

const subtrair = (numero1, numero2) => numero1 - numero2;

const resultadoSoma = somar(10, 5);
console.log("Soma:", resultadoSoma);
const resultadoSubtracao = subtrair(10, 5);
console.log("Subtração:", resultadoSubtracao);

// Array
const objetos = [1, 'batata', true, {nome: "José", idade: 18}];

console.log(objetos[0]);
console.log(objetos[1]);
console.log(objetos[2]);
console.log(objetos[3]);

// Operações com Arrays
const alunos = [
    {
        nome: "João",
        idade: 23
    },
    {
        nome: "José",
        idade: 18
    },
    {
        nome: "Maria",
        idade: 21
    },
    {
        nome: "Márcia",
        idade: 16
    }
];
console.table(alunos);

// Filter
const alunosMaioresDe18 = alunos.filter(aluno => aluno.idade > 18);
console.table(alunosMaioresDe18);

// Find
const alunoJoao = alunos.find(aluno => aluno.nome === "João");
console.log("Aluno João:", alunoJoao);

// FindIndex
const indexJose = alunos.findIndex(aluno => aluno.nome === "José");
console.log("Índice do José:", indexJose);

// Reduce
const idades = alunos.reduce((soma, aluno) => {
    return soma + aluno.idade;
}, 0);
console.log("Idade total:",idades);

// Some
const menorQue15 = alunos.some(aluno => aluno.idade < 15);
console.log("Há alunos menores que 15:", menorQue15);
const menorQue18 = alunos.some(aluno => aluno.idade < 18);
console.log("Há alunos menores que 18:", menorQue18);

// Every
const menoresQue18 = alunos.every(aluno => aluno.idade < 18);
console.log("Todos os alunos são menores que 18:", menoresQue18);
const menoresQue25 = alunos.every(aluno => aluno.idade < 25);
console.log("Todos os alunos são menores que 25:", menoresQue25);