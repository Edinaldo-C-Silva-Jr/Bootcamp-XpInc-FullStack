import { Header } from "../../components/Header";
import background from "../../assets/Github-Background.png";
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
                </main>
            </div>
        </div>
    );
}

export default App;
