import { useState } from "react";
import { Header } from "../../components/Header";
import background from "../../assets/Github-Background.png";
import { ItemList } from "../../components/ItemList";
import "./styles.css";

function App() {
    const [user, setUser] = useState(""); // Guarda o nome do usuário digitado no Input.
    const [currentUser, setCurrentUser] = useState(null); // Guarda o usuário retornado pela API do Github.
    const [repos, setRepos] = useState(null); // Guarda os repositórios do usuário.

    // Busca os dados da API do Github.
    const handleGetData = async () => {
        const userData = await fetch(`https://api.github.com/users/${user}`); // Busca o usuário no Github.
        const newUser = await userData.json();

        if (newUser.name) {
            // Se o usuário existir...
            const { avatar_url, name, bio, login } = newUser;
            setCurrentUser({ avatar_url, name, bio, login }); // ...salva os dados do usuário no estado.

            const reposData = await fetch(`https://api.github.com/users/${user}/repos`); // ...e busca os repositórios do usuário.
            const newRepos = await reposData.json();

            if (newRepos.length) {
                // Se houver repositórios, salva os dados deles no estado.
                setRepos(newRepos);
            }
        } else {
            // Se não existir usuário, limpa os estados.
            setCurrentUser(null);
            setRepos(null);
        }
    };

    return (
        <div className="App">
            <Header />
            <div className="conteudo">
                <img
                    src={background}
                    className="background"
                    alt="background of the application."
                />
                <main className="info">
                    <section>
                        <input
                            name="usuario"
                            value={user}
                            onChange={(event) => setUser(event.target.value)}
                            placeholder="@username"
                        />
                        <button onClick={handleGetData}>Buscar</button> 
                    </section>
                    {currentUser?.name ? ( // Exibe a seção somente se o usuário existir.
                        <section className="perfil">
                            <img
                                src={currentUser.avatar_url}
                                className="profile-image"
                                alt="Profile's image."
                            />
                            <div>
                                <h3>{currentUser.name}</h3>
                                <span>@{currentUser.login}</span>
                                <p>{currentUser.bio}</p>
                            </div>
                        </section>
                    ) : null}
                    {repos?.length ? ( // Exibe a seção somente se o usuário tiver repositórios.
                        <section>
                            <h4 className="repositorio">Repositórios</h4>
                            {repos.map((repo) => (
                                <ItemList
                                    title={repo.name}
                                    description={repo.description}
                                />
                            ))}
                        </section>
                    ) : null}
                </main>
            </div>
        </div>
    );
}

export default App;
