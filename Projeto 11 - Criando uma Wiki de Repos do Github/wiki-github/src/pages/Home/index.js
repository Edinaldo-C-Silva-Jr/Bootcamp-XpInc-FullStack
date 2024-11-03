import gitLogo from "../../assets/github-logo.png";
import { Container } from "./styles";
import Input from "../../components/Input";
import Button from "../../components/Button";
import ItemRepo from "../../components/ItemRepo";
import { useState } from "react";
import { api } from "../../services/api";

const App = () => {
    const [currentRepo, setCurrentRepo] = useState("");
    const [repos, setRepos] = useState([]);

    const handleSearchRepos = async () => {
        try {
            const { data } = await api.get(`repos/${currentRepo}`);

            if (data.id) {
                const repoJaAdicionado = repos.find((repo) => repo.id === data.id);
    
                if (!repoJaAdicionado) {
                    setRepos((prev) => [...prev, data]);
                }
                setCurrentRepo("");
            }
        } catch (error) {
            alert("Repositório não encontrado!");
        }        
    };

    const handleRemoveRepo = (id) => {
        console.log("Removendo registro", id);
        setRepos(repos.filter((repo) => repo.id !== id));
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
