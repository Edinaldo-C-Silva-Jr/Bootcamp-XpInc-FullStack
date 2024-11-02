import { useState } from "react";
import { Header } from "../../components/Header";
import background from "../../assets/Github-Background.png";
import { ItemList } from "../../components/ItemList";
import "./styles.css";

function App() {
    const [user, setUser] = useState("");
    const [currentUser, setCurrentUser] = useState(null);
    const [repos, setRepos] = useState(null);

    const handleGetData = async () => {
        const userData = await fetch(`https://api.github.com/users/${user}`);
        const newUser = await userData.json();

        if (newUser.name) {
            const { avatar_url, name, bio, login } = newUser;
            setCurrentUser({ avatar_url, name, bio, login });

            const reposData = await fetch(`https://api.github.com/users/${user}/repos`);
            const newRepos = await reposData.json();

            if (newRepos.length) {
                setRepos(newRepos);
            }
        } else {
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
                    {currentUser?.name ? (
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
                    {repos?.length ? (
                        <section>
                        <h4 className="repositorio">Repositórios</h4>
                        {repos.map(repo => (
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
