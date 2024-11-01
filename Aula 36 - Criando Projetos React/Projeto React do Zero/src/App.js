import React, { useState, useEffect } from "react";

const App = () => {
    // Define os estados da aplicação e os métodos set deles.
    const [usuario, setUsuario] = useState("");
    const [usuarios, setUsuarios] = useState(["João", "José", "Maria"]);
    const [count, setCount] = useState(0);

    // Função para adicionar um usuário.
    const handleAddUser = () => {
        setUsuarios([...usuarios, usuario]); // Adiciona o usuário na lista.
        setUsuario(""); // Limpa o valor do usuário atual.
    }

    useEffect(()=>{
        setCount(usuarios.length);
    },[usuarios])

    return (
        <div className="App">
            <h1>Usuários</h1>
            <h3>Total de usuários: {count}</h3>
            <div>
                <input 
                    value={usuario} // Define o estado de usuário como o valor do input.
                    onChange={(event) => setUsuario(event.target.value)} // Quando o texto do input for alterado, altera o estado de usuário.
                />
                <button onClick={handleAddUser}>Adicionar</button>
            </div>
            <hr />
            {usuarios.map((item) => ( // Para cada item dentro de usuários...
                <p>{item}</p> // Coloque-o dentro de uma tag de parágrafo.
            ))}
        </div>
    )
}

export default App;