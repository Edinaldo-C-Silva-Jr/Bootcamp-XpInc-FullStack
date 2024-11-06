## React Hook Forms

React Hook Forms é uma biblioteca de gerenciamento e validação de formulários para aplicações React.  
Para instalá-lo, basta utilizar `npm install react-hook-form`.

### Usar o React Hook Forms

Após instalar e importar na aplicação, ele fornece o hook `useForm`, que retorna vários valores, dentre eles:
- `register`: Método que permite registrar um Input ou um elemento e aplicar regras de validação.
- `handleSubmit`: Função que recebe os dados do formulário se eles passarem da validação.
- `watch`: Método que verifica os Inputs especificados e retorna os seus valores. 
- `control`: Um objeto que contém métodos para registrar componentes no React Hook Form.
- `formState`: Um objeto que contém informações sobre o estado do formulário. Ele ajuda a acompanhar a interação do usuário com o formulário. Há vários estados que podem ser retornados por ele.

É preciso também definir uma função para tratar os dados do formulário ao usar o botão Submit. Por exemplo: `const onSubmit = (data) => console.log(data);`

#### Adicionar um Input no formulário

O Input pode ser inserido no formulário colocando um componente de `Controller` dentro dele.  
Esse componente recebe as seguintes propriedades:
- `name`: Nome do input.
- `control`: O objeto de controle usado para registrar os componentes no form.
- `rules`: As regras de validação que serão aplicadas nesse formulário.
- `render`: Uma função que retorna um componente React e permite inserir eventos e valores no componente.

### Fazer Validação nos Inputs do Form

O React Hook Form tem suporte para validação do form através de outras bibliotecas, como o Yup.  
Para utilizá-lo, é preciso instalar os seguintes pacotes: `npm install @hookform/resolvers yup`

Depois de instalar, importar as dependências na página: 
```
import { yupResolver } from "@hookform/resolvers/yup";
import * as yup from "yup";
```

Então, preparar um schema de validação, que será usado para validar os campos. O schema pode ser colocado fora do código da página.
```
const schema = yup.object({
    email: yup.string().email('E-mail inválido.').required(),
    password: yup.string().min(6, 'Senha deve ter pelo menos 6 caracteres.').required(),
});
```

Por fim, o schema deve ser passado para o form no hook `useForm`.  
Ele recebe dois parâmetros:
- `resolver`: O resolver da validação. Ele deve ser passado como uma função, junto com o schema. No caso do yup, o código é: `resolver: yupResolver(schema)`
- `mode`: O modo que a validação será aplicada. Pode ser `onBlur`, `onChange`, `onSubmit`, `onTouched` ou `all`.

### Trabalhar com Requisições com Axios

O Axios é uma biblioteca de React que permite fazer requisições para acessar endpoints de uma API.  
Para utilizá-lo, primeiro é necessário instalar o pacote: `npm install axios`.

#### Criando uma API Falsa com JSON Server

É possível criar uma API falsa para testes utilizando o pacote JSON Server, instalado com o comando `npm install json-server`.

Após instalar o JSON Server, criar um arquivo JSON para ser usado como banco de dados dessa API falsa.
```
{
    "users": [
        { "id": 1, "name": "João", "email": "joao@email.com", "senha": 123456 },
        { "id": 2, "name": "Maria", "email": "maria@email.com", "senha": 654321 }
    ]
}
```
Depois definir nos scripts do arquivo `package.json` um script para rodar esse servidor com a API: `"api": "json-server --watch db.json -p 8001"`.

#### Utilizar a API com o Axios

Depois de definir o servidor da API, criar um arquivo `api`, dentro de uma pasta `services` para definir uma instância do Axios com a URL base para acessar a API.

Essa instância pode então ser utilizada para fazer requisições na API.