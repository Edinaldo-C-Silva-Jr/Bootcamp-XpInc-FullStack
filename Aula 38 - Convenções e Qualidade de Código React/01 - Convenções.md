## Code Style

Há algumas ferramentas que ajudam na organização e na qualidade do código.

### Eslint

O ESLint é uma ferramenta de análise de código que, junto com a extensão do mesmo nome disponível no VS Code, permite identificar erros quanto a regras ou padrões de escrita definidos pelo usuário.  
Com ele é possível, por exemplo, definir que toda linha deve terminar com ponto e vírgula, ou que o último elemento do array sempre tem vírgula.

#### Configurar o ESLint

Para configurar o ESLint, primeiro é necessário instalá-lo, utilizando o comando `npm install eslint`, e depois usar o comando `npx eslint --init` no terminal. Com isso, a ferramenta faz algumas perguntas para o usuário definir as configurações.  
Essas perguntas são sobre o tipo de tecnologia usada e qual o propósito do ESLint.

Isso gera um arquivo de configuração do ESLint chamado `.eslintrc.json`, com as seguintes configurações:
```
{
    "env": {
        "browser": true,
        "es2021": true
    },
    "extends": [
        "plugin:react/recommended",
        "airbnb"
    ],
    "parserOptions": {
        "ecmaFeatures": {
            "jsx": true
        },
        "ecmaVersion": "latest",
        "sourceType": "module"
    },
    "plugins": [
        "react"
    ],
    "rules": {
        "react/react-in-jsx-scope": "off"
    }
  }
```

### Prettier

O Prettier é um formatador de código que tem como objetivo ajudar desenvolvedores a escrever aplicações mais fáceis de entender e mais uniformizadas.  
Ele permite definir regras para formatar o código de uma maneira específica.

Ele difere do ESLint pois o ESLint lida com a sintaxe do código e consertando erros, o Prettier foca mais na formatação do código.

Para instalar o Prettier, é necessário primeiro ter o ESLint instalado, pois eles trabalham em conjunto. Então, utilizar o comando é `npm install prettier eslint-config-prettier eslint-plugin-prettier` para instalar as dependências necessárias.

Depois, é preciso fazer algumas configurações no arquivo de configuração do ESLint, adicionando na área `extends` o seguinte código:

```
"eslint:recommended",
"plugin:react/recommended",
"plugin:prettier/recommended",
```

Depois é necessário também criar o arquivo de configuração para o Prettier, chamado `.prettierrc`, e adicionar as configurações desejadas, como por exemplo:
```
{
    "semi": true,
    "tabWidth": 4,
    "printWidth": 100,
    "singleQuote": true,
    "trailingComma": "none",
    "jsxBracketSameLine": true
}
```

### Editor Config

O Editor Config é um plugin que obriga o editor de código a seguir os padrões macro essenciais de formatação configurados pelo usuário. Isso ajuda a estabelecer um estilo de código entre diferentes editores, independente da tecnologia utilizada.

Para configurá-lo, basta criar um arquivo com o nome `.editorconfig`. A linha `root=true` indica que as configurações servirão para todos os arquivos.
```
root=true
end_of_line = lf
insert_final_newline = true
indent_size = 
```