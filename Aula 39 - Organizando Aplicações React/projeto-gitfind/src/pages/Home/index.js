import { Header } from "../../components/Header";
import background from "../../assets/Github-Background.png";
import { ItemList } from "../../components/ItemList";
import "./styles.css";

function App() {
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
                        <input name="usuario" placeholder="@username" />
                        <button>Buscar</button>
                    </section>
                    <section className="perfil">
                        <img
                            src="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                            className="profile-image"
                            alt="Profile's image."
                        />
                        <div>
                            <h3>Nome do Usuário</h3>
                            <span>@nomedousuario</span>
                            <p>Descrição do Usuário.</p>
                        </div>
                    </section>
                    <hr />
                    <section>
                        <h3 className="repositorio">Repositórios</h3>
                        <ItemList title="Teste1" description="Descrição Teste"/>
                        <ItemList title="Teste2" description="Descrição Teste"/>
                        <ItemList title="Teste3" description="Descrição Teste"/>
                    </section>
                </main>
            </div>
        </div>
    );
}

export default App;
