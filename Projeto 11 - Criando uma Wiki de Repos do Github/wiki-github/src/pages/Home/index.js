import gitLogo from "../../assets/github-logo.png";
import { Container } from "./styles";
import Input from "../../components/Input";
import Button from "../../components/Button";
import ItemRepo from "../../components/ItemRepo";
import { useState } from "react";
import { api } from "../../services/api";

const App = () => {
    const [currentRepo, setCurrentRepo] = useState(""); // Armazena o nome do repositório recebido pelo Input.
    const [repos, setRepos] = useState([]); // Armazena os repositórios na lista de repositórios da página.

    // Busca pelo repositório usando a API do Github.
    const handleSearchRepos = async () => {
        try {
            const { data } = await api.get(`repos/${currentRepo}`); // Utiliza a instância do axios para fazer uma requisição na API.

            // Se o repositório tiver um id válido...
            if (data.id) {
                const repoJaAdicionado = repos.find(
                    // ...verifica se ele já existe na lista de repositórios.
                    (repo) => repo.id === data.id
                );

                // Se elenão existir na lista...
                if (!repoJaAdicionado) {
                    setRepos((prev) => [...prev, data]); // ...adiciona o repositório.
                }
                setCurrentRepo("");
            }
        } catch (error) {
            alert("Repositório não encontrado!");
        }
    };

    // Remove um repositório da lista.
    const handleRemoveRepo = (id) => {
        setRepos(repos.filter((repo) => repo.id !== id)); // Filtra a lista, retornando somente os repositórios que não contém o ID do repositório a ser removido.
    };

    return (
        <Container className="App">
            <img src={gitLogo} width={72} height={72} alt="logo"></img>
            <Input
                value={currentRepo}
                onChange={(e) => setCurrentRepo(e.target.value)}
            />
            <Button onClick={handleSearchRepos} />
            {repos.map((repo) => (
                <ItemRepo repo={repo} handleRemoveRepo={handleRemoveRepo} />
            ))}
        </Container>
    );
};

export default App;
